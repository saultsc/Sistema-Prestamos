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
    public partial class Cobradores : Form
    {
        private int accion;
        private CobradorService cobradorService;
        private ZonaService zonaService;
        private DireccionService direccionService;
        private int idSeleccionado;
        private readonly DbContextProvider _dbContextProvider;

        public Cobradores()
        {
            InitializeComponent();
            InitializeFormComponents();
            _dbContextProvider = new DbContextProvider();
            cobradorService = new CobradorService(_dbContextProvider.Context);
            zonaService = new ZonaService(_dbContextProvider.Context);
            direccionService = new DireccionService(_dbContextProvider.Context);

            LoadCobradorDataGrid();
            LoadZonasComboBox();
            LoadDireccionesComboBox();
            SaveInitialControlValues();
        }

        private void InitializeFormComponents()
        {
            cobradorControl.ItemSize = new System.Drawing.Size(1, 1);
            cobradorControl.SizeMode = TabSizeMode.Fixed;
        }

        private void LoadCobradorDataGrid()
        {
            dataGridViewCobrador.DataSource = cobradorService.GetAllCobradores().ToList();
        }

        private void LoadZonasComboBox()
        {
            var zonas = zonaService.GetAllZonas().ToList();
            cbZona.DisplayMember = "Nombre";
            cbZona.ValueMember = "Id";
            cbZona.DataSource = zonas;
            cbZona.SelectedIndex = -1;
        }

        private void LoadDireccionesComboBox()
        {
            var direcciones = direccionService.GetAllDirecciones().ToList();
            cbDireccion.DisplayMember = "Nombre";
            cbDireccion.ValueMember = "Id";
            cbDireccion.DataSource = direcciones;
            cbDireccion.SelectedIndex = -1;
        }

        private void SaveInitialControlValues()
        {
            foreach (Control control in pInputs.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Tag = textBox.Text;
                }
            }
            cbZona.Tag = cbZona.SelectedIndex;
            cbDireccion.Tag = cbDireccion.SelectedIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = 0;
            SetCobradorControl(1, "Agregar Cobrador");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCobrador.SelectedRows.Count > 0)
            {
                accion = 1;
                idSeleccionado = Convert.ToInt32(dataGridViewCobrador.SelectedRows[0].Cells["Id"].Value);
                SetCobradorControl(1, "Modificar Cobrador");

                Cobrador cobradorFind = cobradorService.GetCobrador(idSeleccionado);
                SetCobradorData(cobradorFind);
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
                SaveNewCobrador();
            }
            else
            {
                UpdateExistingCobrador();
            }
        }

        private void SaveNewCobrador()
        {
            if (!IsInputValid()) return;

            if (cobradorService.IsCedulaAlreadyExists(txtCedula.Text, idSeleccionado))
            {
                ShowErrorMessage("La cédula del cobrador ya está en uso. Por favor, elige otra.");
                return;
            }

            if (cbZona.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona una zona.");
                return;
            }

            if (cbDireccion.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona una dirección.");
                return;
            }

            cobradorService.AddCobrador(txtNombre.Text, txtCedula.Text, txtTelefono.Text, (Zona)cbZona.SelectedItem!, textProvincia.Text, textLocalidad.Text, (Direccion)cbDireccion.SelectedItem!);
            ResetCobradorInputs();
            LoadCobradorDataGrid();
            SetCobradorControl(0);
        }

        private void UpdateExistingCobrador()
        {
            if (!IsInputValid()) return;

            string nuevoNombre = txtNombre.Text.Trim();
            string nuevaCedula = txtCedula.Text.Trim();
            string nuevoTelefono = txtTelefono.Text.Trim();
            string nuevaProvincia = textProvincia.Text.Trim();
            string nuevaLocalidad = textLocalidad.Text.Trim();

            if (cbZona.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona una zona.");
                return;
            }

            if (cbDireccion.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona una dirección.");
                return;
            }

            // Obtén la cédula actual del cobrador que se está editando
            string cedulaActual = cobradorService.GetCobrador(idSeleccionado).Cedula;

            // Verifica si la nueva cédula ya está en uso por otro cobrador (excepto la cédula actual)
            if (cobradorService.IsCedulaAlreadyExists(nuevaCedula, idSeleccionado))
            {
                ShowErrorMessage("La cédula del cobrador ya está en uso. Por favor, elige otra.");
                return;
            }

            cobradorService.UpdateCobrador(idSeleccionado, nuevoNombre, nuevaCedula, nuevoTelefono, (Zona)cbZona.SelectedItem!, nuevaProvincia, nuevaLocalidad, (Direccion)cbDireccion.SelectedItem!);
            ResetCobradorInputs();
            LoadCobradorDataGrid();
            SetCobradorControl(0);
        }


        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCedula.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                ShowWarningMessage("Por favor, completa los campos obligatorios.");
                return false;
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCobrador.SelectedRows.Count > 0)
            {
                idSeleccionado = Convert.ToInt32(dataGridViewCobrador.SelectedRows[0].Cells["Id"].Value);
                DialogResult result = ShowConfirmationDialog("¿Estás seguro de que deseas eliminar este cobrador?");

                if (result == DialogResult.Yes)
                {
                    cobradorService.DeleteCobrador(idSeleccionado);
                    LoadCobradorDataGrid();
                }
            }
            else
            {
                ShowWarningMessage("Por favor, selecciona una fila antes de editar.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetCobradorInputs();
            SetCobradorControl(0);
        }

        private void ResetCobradorInputs()
        {
            foreach (Control control in pInputs.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = textBox.Tag!.ToString();
                }
            }
            cbZona.SelectedIndex = (int)cbZona.Tag!;
            cbDireccion.SelectedIndex = (int)cbDireccion.Tag!;
        }

        private void SetCobradorControl(int index, string action = "")
        {
            cobradorControl.SelectedIndex = index;
            lbAccion.Text = action;
        }

        private void SetCobradorData(Cobrador cobrador)
        {
            txtNombre.Text = cobrador.Nombre;
            txtCedula.Text = cobrador.Cedula;
            txtTelefono.Text = cobrador.Telefono;
            textProvincia.Text = cobrador.Provincia;
            textLocalidad.Text = cobrador.Localidad;

            // Obtener la lista de zonas desde el servicio
            var zonas = zonaService.GetAllZonas().ToList();

            // Asignar la lista de zonas al ComboBox
            cbZona.DisplayMember = "Nombre";
            cbZona.ValueMember = "Id";
            cbZona.DataSource = zonas;

            // Seleccionar la zona del cobrador en el ComboBox
            cbZona.SelectedItem = zonas.Find(z => z.Nombre == cobrador.Zonas);

            // Obtener la lista de direcciones desde el servicio
            var direcciones = direccionService.GetAllDirecciones().ToList();

            // Asignar la lista de direcciones al ComboBox
            cbDireccion.DisplayMember = "Nombre";
            cbDireccion.ValueMember = "Id";
            cbDireccion.DataSource = direcciones;

            // Seleccionar la dirección del cobrador en el ComboBox
            cbDireccion.SelectedItem = direcciones.Find(d => d.Nombre == cobrador.Direcion);
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

                dataGridViewCobrador.DataSource = _dbContextProvider.Context.Cobrador
                    .Where(c =>
                        EF.Functions.Like(c.Id.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(c.Nombre, $"%{searchText}%") ||
                        EF.Functions.Like(c.Cedula, $"%{searchText}%") ||
                        EF.Functions.Like(c.Telefono, $"%{searchText}%") ||
                        EF.Functions.Like(c.Provincia, $"%{searchText}%") ||
                        EF.Functions.Like(c.Localidad, $"%{searchText}%") ||
                        EF.Functions.Like(c.Zonas, $"%{searchText}%") ||
                        EF.Functions.Like(c.Direcion, $"%{searchText}%") ||
                        EF.Functions.Like(c.CreatedAt.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(c.UpdatedAt.ToString(), $"%{searchText}%")
                    )
                    .Select(cobrador => new
                    {
                        cobrador.Id,
                        cobrador.Nombre,
                        cobrador.Cedula,
                        cobrador.Telefono,
                        cobrador.Zonas,
                        cobrador.Provincia,
                        cobrador.Localidad,
                        cobrador.Direcion,
                        cobrador.CreatedAt,
                        cobrador.UpdatedAt
                    }).ToList();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error al realizar la búsqueda: {ex.Message}");
            }
        }
    }
}
