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
    public partial class Zonas : Form
    {
        private int accion;
        private ZonaService zonaService;
        private int idSeleccionado;
        private readonly DbContextProvider _dbContextProvider;

        // Constructor de la clase Zonas
        public Zonas()
        {
            InitializeComponent();
            InitializeFormComponents();
            _dbContextProvider = new DbContextProvider();
            zonaService = new ZonaService(_dbContextProvider.Context);
            LoadZonaDataGrid();
            SaveInitialControlValues();
        }

        // Inicializa los componentes comunes del formulario
        private void InitializeFormComponents()
        {
            zonaControl.ItemSize = new System.Drawing.Size(1, 1);
            zonaControl.SizeMode = TabSizeMode.Fixed;
        }

        // Guarda los valores iniciales de los controles del formulario para el restablecimiento posterior
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

        // Carga los datos de las zonas en el DataGridView
        private void LoadZonaDataGrid()
        {
            dataGridViewZonas.DataSource = zonaService.GetAllZonas();
        }

        // Maneja el evento de hacer clic en el botón para agregar una zona
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = 0;
            SetZonaControl(1, "Agregar Zona");
        }

        // Maneja el evento de hacer clic en el botón para editar una zona
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewZonas.SelectedRows.Count > 0)
            {
                accion = 1;
                idSeleccionado = Convert.ToInt32(dataGridViewZonas.SelectedRows[0].Cells["Id"].Value);
                SetZonaControl(1, "Modificar Zona");

                Zona zonaFind = zonaService.GetZona(idSeleccionado);
                SetZonaData(zonaFind);
            }
            else
            {
                ShowWarningMessage("Por favor, selecciona una fila antes de editar.");
            }
        }

        // Maneja el evento de hacer clic en el botón para guardar los cambios
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (accion == 0)
            {
                SaveNewZona();
            }
            else
            {
                UpdateExistingZona();
            }
        }

        // Guarda una nueva zona en la base de datos
        private void SaveNewZona()
        {
            if (!IsInputValid()) return;

            if (_dbContextProvider.Context.Zona.Any(z => z.Nombre == txtNombre.Text))
            {
                ShowErrorMessage("El nombre de la zona ya está en uso. Por favor, elige otro.");
                return;
            }

            zonaService.AddZona(txtNombre.Text);
            ResetZonaInputs();
            LoadZonaDataGrid();
            SetZonaControl(0);
        }

        // Actualiza la información de una zona existente en la base de datos
        private void UpdateExistingZona()
        {
            if (!IsInputValid()) return;

            string nuevoNombre = txtNombre.Text.Trim();

            // Validar si el nuevo nombre ya existe en la base de datos
            if (zonaService.IsNombreAlreadyExists(nuevoNombre, idSeleccionado))
            {
                MessageBox.Show("El nombre de la zona ya existe. Por favor, elija otro.");
                return;
            }

            zonaService.UpdateZona(idSeleccionado, nuevoNombre);
            ResetZonaInputs();
            LoadZonaDataGrid();
            SetZonaControl(0);
        }

        // Verifica si la entrada del usuario es válida
        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                ShowWarningMessage("Por favor, completa el campo de texto.");
                return false;
            }

            // Puedes agregar más validaciones según tus requisitos.

            return true;
        }

        // Maneja el evento de hacer clic en el botón para eliminar una zona
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewZonas.SelectedRows.Count > 0)
            {
                idSeleccionado = Convert.ToInt32(dataGridViewZonas.SelectedRows[0].Cells["Id"].Value);
                DialogResult result = ShowConfirmationDialog("¿Estás seguro de que deseas eliminar esta zona?");

                if (result == DialogResult.Yes)
                {
                    zonaService.DeleteZona(idSeleccionado);
                    LoadZonaDataGrid();
                }
            }
            else
            {
                ShowWarningMessage("Por favor, selecciona una fila antes de editar.");
            }
        }

        // Maneja el evento de hacer clic en el botón para cancelar la operación actual
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetZonaInputs();
            SetZonaControl(0);
        }

        // Restablece los valores de los controles a sus estados iniciales
        private void ResetZonaInputs()
        {
            foreach (Control control in pInputs.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = control.Tag!.ToString();
                }
            }
        }

        // Establece el control de zona y la etiqueta de acción
        private void SetZonaControl(int index, string action = "")
        {
            zonaControl.SelectedIndex = index;
            lbAccion.Text = action;
        }

        // Establece los datos de la zona en los controles de entrada
        private void SetZonaData(Zona zona)
        {
            txtNombre.Text = zona.Nombre;
            // Puedes agregar más asignaciones según la estructura de tu entidad Zonas
        }

        // Muestra un cuadro de diálogo de confirmación con el mensaje proporcionado
        private DialogResult ShowConfirmationDialog(string message)
        {
            return MessageBox.Show(message, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        // Muestra un mensaje de error con el mensaje proporcionado
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Muestra un mensaje de advertencia con el mensaje proporcionado
        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Maneja el evento de cambio de texto en el cuadro de búsqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtBuscar.Text;

                dataGridViewZonas.DataSource = _dbContextProvider.Context.Zona
                    .Where(z =>
                        EF.Functions.Like(z.Id.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(z.Nombre, $"%{searchText}%") ||
                        EF.Functions.Like(z.CreatedAt.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(z.UpdatedAt.ToString(), $"%{searchText}%")
                    )
                    .Select(zona => new
                    {
                        zona.Id,
                        zona.Nombre,
                        zona.CreatedAt,
                        zona.UpdatedAt
                    }).ToList();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error al realizar la búsqueda: {ex.Message}");
            }
        }
    }
}
