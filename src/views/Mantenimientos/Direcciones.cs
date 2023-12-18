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
    public partial class Direcciones : Form
    {
        private int accion;
        private DireccionService direccionService;
        private int idSeleccionado;
        private readonly DbContextProvider _dbContextProvider;

        // Constructor de la clase DireccionesForm
        public Direcciones()
        {
            InitializeComponent();
            InitializeFormComponents();
            _dbContextProvider = new DbContextProvider();
            direccionService = new DireccionService(_dbContextProvider.Context);
            LoadDireccionDataGrid();
            SaveInitialControlValues();
        }

        private void InitializeFormComponents()
        {
            direccionControl.ItemSize = new System.Drawing.Size(1, 1);
            direccionControl.SizeMode = TabSizeMode.Fixed;
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
        }

        private void LoadDireccionDataGrid()
        {
            dataGridViewDireccion.DataSource = direccionService.GetAllDirecciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = 0;
            SetDireccionControl(1, "Agregar Dirección");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDireccion.SelectedRows.Count > 0)
            {
                accion = 1;
                idSeleccionado = Convert.ToInt32(dataGridViewDireccion.SelectedRows[0].Cells["Id"].Value);
                SetDireccionControl(1, "Modificar Dirección");

                Direccion direccionFind = direccionService.GetDireccion(idSeleccionado);
                SetDireccionData(direccionFind);
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
                SaveNewDireccion();
            }
            else
            {
                UpdateExistingDireccion();
            }
        }

        private void SaveNewDireccion()
        {
            if (!IsInputValid()) return;

            if (_dbContextProvider.Context.Direccion.Any(d => d.Nombre == txtNombre.Text))
            {
                ShowErrorMessage("El nombre de la dirección ya está en uso. Por favor, elige otro.");
                return;
            }

            direccionService.AddDireccion(txtNombre.Text);
            ResetDireccionInputs();
            LoadDireccionDataGrid();
            SetDireccionControl(0);
        }

        private void UpdateExistingDireccion()
        {
            if (!IsInputValid()) return;

            string nuevoNombre = txtNombre.Text.Trim();

            if (direccionService.IsNombreAlreadyExists(nuevoNombre, idSeleccionado))
            {
                MessageBox.Show("El nombre de la dirección ya existe. Por favor, elija otro.");
                return;
            }

            direccionService.UpdateDireccion(idSeleccionado, nuevoNombre);
            ResetDireccionInputs();
            LoadDireccionDataGrid();
            SetDireccionControl(0);
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                ShowWarningMessage("Por favor, completa el campo de texto.");
                return false;
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDireccion.SelectedRows.Count > 0)
            {
                idSeleccionado = Convert.ToInt32(dataGridViewDireccion.SelectedRows[0].Cells["Id"].Value);
                DialogResult result = ShowConfirmationDialog("¿Estás seguro de que deseas eliminar esta dirección?");

                if (result == DialogResult.Yes)
                {
                    direccionService.DeleteDireccion(idSeleccionado);
                    LoadDireccionDataGrid();
                }
            }
            else
            {
                ShowWarningMessage("Por favor, selecciona una fila antes de eliminar.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetDireccionInputs();
            SetDireccionControl(0);
        }

        private void ResetDireccionInputs()
        {
            foreach (Control control in pInputs.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = control.Tag!.ToString();
                }
            }
        }

        private void SetDireccionControl(int index, string action = "")
        {
            direccionControl.SelectedIndex = index;
            lbAccion.Text = action;
        }

        private void SetDireccionData(Direccion direccion)
        {
            txtNombre.Text = direccion.Nombre;
            // Puedes agregar más asignaciones según la estructura de tu entidad Direcciones
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

                dataGridViewDireccion.DataSource = _dbContextProvider.Context.Direccion
                    .Where(d =>
                        EF.Functions.Like(d.Id.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(d.Nombre, $"%{searchText}%") ||
                        EF.Functions.Like(d.CreatedAt.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(d.UpdatedAt.ToString(), $"%{searchText}%")
                    )
                    .Select(direccion => new
                    {
                        direccion.Id,
                        direccion.Nombre,
                        direccion.CreatedAt,
                        direccion.UpdatedAt
                    }).ToList();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error al realizar la búsqueda: {ex.Message}");
            }
        }
    }
}
