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
    public partial class Usuarios : Form
    {
        private int accion;
        private UserService userService;
        private int idSeleccionado;
        private readonly DbContextProvider _dbContextProvider;

        // Constructor de la clase Usuarios
        public Usuarios()
        {
            InitializeComponent();
            InitializeFormComponents();
            _dbContextProvider = new DbContextProvider();
            userService = new UserService(_dbContextProvider.Context);
            LoadUserDataGrid();
            SaveInitialControlValues();
        }

        // Inicializa los componentes comunes del formulario
        private void InitializeFormComponents()
        {
            userControl.ItemSize = new System.Drawing.Size(1, 1);
            userControl.SizeMode = TabSizeMode.Fixed;
            cbAcces.SelectedIndex = 0;
        }

        // Guarda los valores iniciales de los controles del formulario para el restablecimiento posterior
        private void SaveInitialControlValues()
        {
            foreach (Control control in pInputs.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.Tag = control.Text;
                }
            }
        }

        // Carga los datos de los usuarios en el DataGridView
        private void LoadUserDataGrid()
        {
            dataGridViewUsuarios.DataSource = userService.GetAllUser();
        }

        // Maneja el evento de hacer clic en el botón para agregar un usuario
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = 0;
            SetUserControl(1, "Agregar Usuario");
        }

        // Maneja el evento de hacer clic en el botón para editar un usuario
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                accion = 1;
                idSeleccionado = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["Id"].Value);
                SetUserControl(1, "Modificar Usuario");

                Usuario userFind = userService.GetUser(idSeleccionado);
                SetUserData(userFind);
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
                SaveNewUser();
            }
            else
            {
                UpdateExistingUser();
            }
        }

        // Guarda un nuevo usuario en la base de datos
        private void SaveNewUser()
        {
            if (!IsInputValid()) return;

            if (_dbContextProvider.Context.Usuarios.Any(u => u.Email == txtCorreo.Text))
            {
                ShowErrorMessage("El correo electrónico ya está en uso. Por favor, elige otro.");
                return;
            }

            userService.AddUser(txtNombre.Text, txtCorreo.Text, txtPassword.Text, cbAcces.Text);
            ResetInputs();
            LoadUserDataGrid();
            SetUserControl(0);
        }

        // Actualiza la información de un usuario existente en la base de datos
        private void UpdateExistingUser()
        {
            if (!IsInputValid()) return;

            userService.UpdateUser(idSeleccionado, txtNombre.Text, txtCorreo.Text, txtPassword.Text, cbAcces.Text);
            ResetInputs();
            LoadUserDataGrid();
            SetUserControl(0);
        }

        // Verifica si la entrada del usuario es válida
        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowWarningMessage("Por favor, completa todos los campos de texto.");
                return false;
            }

            if (!Regular_Exp.IsValidEmail(txtCorreo.Text))
            {
                ShowErrorMessage("Por favor, ingresa un correo electrónico válido.");
                return false;
            }

            return true;
        }

        // Maneja el evento de hacer clic en el botón para eliminar un usuario
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                idSeleccionado = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["Id"].Value);
                DialogResult result = ShowConfirmationDialog("¿Estás seguro de que deseas eliminar este usuario?");

                if (result == DialogResult.Yes)
                {
                    userService.DeleteUser(idSeleccionado);
                    LoadUserDataGrid();
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
            ResetInputs();
            SetUserControl(0);
        }

        // Restablece los valores de los controles a sus estados iniciales
        private void ResetInputs()
        {
            foreach (Control control in pInputs.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.Text = control.Tag!.ToString();
                }
            }
        }

        // Establece el control de usuario y la etiqueta de acción
        private void SetUserControl(int index, string action = "")
        {
            userControl.SelectedIndex = index;
            lbAccion.Text = action;
        }

        // Establece los datos del usuario en los controles de entrada
        private void SetUserData(Usuario user)
        {
            txtNombre.Text = user.Name;
            txtCorreo.Text = user.Email;
            txtPassword.Text = user.Password;
            cbAcces.Text = user.Level_acces;
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

                dataGridViewUsuarios.DataSource = _dbContextProvider.Context.Usuarios
                    .Where(u =>
                        EF.Functions.Like(u.Id.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(u.Name, $"%{searchText}%") ||
                        EF.Functions.Like(u.Email, $"%{searchText}%") ||
                        EF.Functions.Like(u.Level_acces, $"%{searchText}%")
                    )
                    .Select(user => new
                    {
                        user.Id,
                        user.Name,
                        user.Email,
                        user.Level_acces,
                        user.CreatedAt,
                        user.UpdatedAt
                    }).ToList();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error al realizar la búsqueda: {ex.Message}");
            }
        }
    }
}
