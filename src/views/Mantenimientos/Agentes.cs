using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Sistema_Prestamos.src.config;
using Sistema_Prestamos.src.data.sqlserver;
using Sistema_Prestamos.src.data.sqlserver.model;
using Sistema_Prestamos.src.services;

namespace Sistema_Prestamos.src.views.Mantenimientos
{
    public partial class Agentes : Form
    {
        private int accion;
        private AgenteService agenteService;
        private ZonaService zonaService;
        private int idSeleccionado;
        private readonly DbContextProvider _dbContextProvider;

        public Agentes()
        {
            InitializeComponent();
            InitializeFormComponents();
            _dbContextProvider = new DbContextProvider();
            agenteService = new AgenteService(_dbContextProvider.Context);
            zonaService = new ZonaService(_dbContextProvider.Context);
            LoadAgenteDataGrid();
            LoadZonasComboBox();
            SaveInitialControlValues();
        }

        private void InitializeFormComponents()
        {
            agenteControl.ItemSize = new System.Drawing.Size(1, 1);
            agenteControl.SizeMode = TabSizeMode.Fixed;
        }

        private void LoadAgenteDataGrid()
        {
            dataGridViewAgente.DataSource = agenteService.GetAllAgentes().ToList();
        }

        private void LoadZonasComboBox()
        {
            var zonas = zonaService.GetAllZonas().ToList();
            cbZona.DisplayMember = "Nombre";
            cbZona.ValueMember = "Id";
            cbZona.DataSource = zonas;
            cbZona.SelectedIndex = -1;
        }

        private void SaveInitialControlValues()
        {
            foreach (Control control in pInputs.Controls)
            {
                if (control is TextBox)
                {
                    control.Tag = control.Text;
                }
            }
            cbZona.Tag = cbZona.SelectedIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = 0;
            SetAgenteControl(1, "Agregar Agente");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAgente.SelectedRows.Count > 0)
            {
                accion = 1;
                idSeleccionado = Convert.ToInt32(dataGridViewAgente.SelectedRows[0].Cells["Id"].Value);
                SetAgenteControl(1, "Modificar Agente");

                Agente agenteFind = agenteService.GetAgente(idSeleccionado);
                SetAgenteData(agenteFind);
            }
            else
            {
                ShowWarningMessage("Por favor, selecciona una fila antes de editar.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (accion == 0)
            {
                SaveNewAgente();
            }
            else
            {
                UpdateExistingAgente();
            }
        }

        private void SaveNewAgente()
        {
            if (!IsInputValid()) return;

            if (agenteService.IsCedulaAlreadyExists(txtCedula.Text, idSeleccionado))
            {
                ShowErrorMessage("La cédula del agente ya está en uso. Por favor, elige otra.");
                return;
            }

            if (cbZona.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona una zona.");
                return;
            }

            agenteService.AddAgente(txtNombre.Text, txttelefono.Text, txtCedula.Text, textProvicia.Text, cbZona.SelectedItem!);
            ResetAgenteInputs();
            LoadAgenteDataGrid();
            SetAgenteControl(0);
        }

        private void UpdateExistingAgente()
        {
            if (!IsInputValid()) return;

            string nuevoNombre = txtNombre.Text.Trim();
            string nuevaCedula = txtCedula.Text.Trim();
            string nuevoTelefono = txttelefono.Text.Trim();
            string nuevaProvincia = textProvicia.Text.Trim();

            if (cbZona.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona una zona.");
                return;
            }

            // Obtén la cédula actual del agente que se está editando
            string cedulaActual = agenteService.GetAgente(idSeleccionado).Cedula;

            // Verifica si la nueva cédula ya está en uso por otro agente (excepto la cédula actual)
            if (agenteService.IsCedulaAlreadyExists(nuevaCedula, idSeleccionado))
            {
                ShowErrorMessage("La cédula del agente ya está en uso. Por favor, elige otra.");
                return;
            }

            agenteService.UpdateAgente(idSeleccionado, nuevoNombre, nuevoTelefono, nuevaCedula, nuevaProvincia, cbZona.SelectedItem!);
            ResetAgenteInputs();
            LoadAgenteDataGrid();
            SetAgenteControl(0);
        }


        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                ShowWarningMessage("Por favor, completa los campos obligatorios.");
                return false;
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAgente.SelectedRows.Count > 0)
            {
                idSeleccionado = Convert.ToInt32(dataGridViewAgente.SelectedRows[0].Cells["Id"].Value);
                DialogResult result = ShowConfirmationDialog("¿Estás seguro de que deseas eliminar este agente?");

                if (result == DialogResult.Yes)
                {
                    agenteService.DeleteAgente(idSeleccionado);
                    LoadAgenteDataGrid();
                }
            }
            else
            {
                ShowWarningMessage("Por favor, selecciona una fila antes de editar.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetAgenteInputs();
            SetAgenteControl(0);
        }

        private void ResetAgenteInputs()
        {
            foreach (Control control in pInputs.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = control.Tag!.ToString();
                }
            }
            cbZona.SelectedIndex = (int)cbZona.Tag!;
        }

        private void SetAgenteControl(int index, string action = "")
        {
            agenteControl.SelectedIndex = index;
            lbAccion.Text = action;
        }

        private void SetAgenteData(Agente agente)
        {
            txtNombre.Text = agente.Nombre;
            txttelefono.Text = agente.Telefono;
            txtCedula.Text = agente.Cedula;
            textProvicia.Text = agente.Provincia;

            // Obtener la lista de zonas desde el servicio
            var zonas = zonaService.GetAllZonas().ToList();

            // Asignar la lista de zonas al ComboBox
            cbZona.DisplayMember = "Nombre";
            cbZona.ValueMember = "Id";
            cbZona.DataSource = zonas;

            // Seleccionar la zona del agente en el ComboBox
            cbZona.SelectedItem = zonas.Find(z => z.Nombre == agente.Zona);
        }





        private DialogResult ShowConfirmationDialog(string message)
        {
            return MessageBox.Show(message, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtBuscar.Text;

                dataGridViewAgente.DataSource = _dbContextProvider.Context.Agente
                    .Where(a =>
                        EF.Functions.Like(a.Id.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(a.Nombre, $"%{searchText}%") ||
                        EF.Functions.Like(a.Cedula, $"%{searchText}%") ||
                        EF.Functions.Like(a.Telefono, $"%{searchText}%") ||
                        EF.Functions.Like(a.Provincia, $"%{searchText}%") ||
                        EF.Functions.Like(a.CreatedAt.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(a.UpdatedAt.ToString(), $"%{searchText}%")
                    )
                    .Select(agente => new
                    {
                        agente.Id,
                        agente.Nombre,
                        agente.Cedula,
                        agente.Telefono,
                        agente.Provincia,
                        agente.CreatedAt,
                        agente.UpdatedAt
                    }).ToList();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error al realizar la búsqueda: {ex.Message}");
            }
        }
    }
}
