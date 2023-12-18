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
    public partial class Clientes : Form
    {
        private int accion;
        private ClienteService clienteService;
        private ZonaService zonaService;
        private AgenteService agenteService;
        private CobradorService cobradorService;
        private DireccionService direccionService;
        private int idSeleccionado;
        private readonly DbContextProvider _dbContextProvider;

        public Clientes()
        {
            InitializeComponent();
            InitializeFormComponents();
            _dbContextProvider = new DbContextProvider();
            clienteService = new ClienteService(_dbContextProvider.Context);
            zonaService = new ZonaService(_dbContextProvider.Context);
            agenteService = new AgenteService(_dbContextProvider.Context);
            cobradorService = new CobradorService(_dbContextProvider.Context);
            direccionService = new DireccionService(_dbContextProvider.Context);

            LoadClienteDataGrid();
            LoadZonasComboBox();
            LoadAgentesComboBox();
            LoadCobradoresComboBox();
            LoadDireccionesComboBox();
            SaveInitialControlValues();
        }

        private void InitializeFormComponents()
        {
            clienteControl.ItemSize = new System.Drawing.Size(1, 1);
            clienteControl.SizeMode = TabSizeMode.Fixed;
        }

        private void LoadClienteDataGrid()
        {
            dataGridViewCliente.DataSource = clienteService.AllDataGridClientes().ToList();
        }

        private void LoadZonasComboBox()
        {
            var zonas = zonaService.GetAllZonas().ToList();
            cbZona.DisplayMember = "Nombre";
            cbZona.ValueMember = "Id";
            cbZona.DataSource = zonas;
            cbZona.SelectedIndex = -1;
        }

        private void LoadAgentesComboBox()
        {
            var agentes = agenteService.GetAllAgentes().ToList();
            cbAgente.DisplayMember = "Nombre";
            cbAgente.ValueMember = "Id";
            cbAgente.DataSource = agentes;
            cbAgente.SelectedIndex = -1;
        }

        private void LoadCobradoresComboBox()
        {
            var cobradores = cobradorService.GetAllCobradores().ToList();
            cbCobrador.DisplayMember = "Nombre";
            cbCobrador.ValueMember = "Id";
            cbCobrador.DataSource = cobradores;
            cbCobrador.SelectedIndex = -1;
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
            cbAgente.Tag = cbAgente.SelectedIndex;
            cbCobrador.Tag = cbCobrador.SelectedIndex;
            cbDireccion.Tag = cbDireccion.SelectedIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = 0;
            SetClienteControl(1, "Agregar Cliente");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count > 0)
            {
                accion = 1;
                idSeleccionado = Convert.ToInt32(dataGridViewCliente.SelectedRows[0].Cells["Id"].Value);
                SetClienteControl(1, "Modificar Cliente");

                Cliente clienteFind = clienteService.GetCliente(idSeleccionado);
                SetClienteData(clienteFind);
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
                SaveNewCliente();
            }
            else
            {
                UpdateExistingCliente();
            }
        }

        private void SaveNewCliente()
        {
            if (!IsInputValid()) return;

            if (clienteService.IsCedulaAlreadyExists(txtCedula.Text, idSeleccionado))
            {
                ShowErrorMessage("La cédula del cliente ya está en uso. Por favor, elige otra.");
                return;
            }

            if (cbZona.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona una zona.");
                return;
            }

            if (cbAgente.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona un agente.");
                return;
            }

            if (cbCobrador.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona un cobrador.");
                return;
            }

            if (cbDireccion.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona una dirección.");
                return;
            }

            using (var dbContextTransaction = _dbContextProvider.Context.Database.BeginTransaction())
            {
                try
                {
                    clienteService.AddCliente(
                        txtNombre.Text,
                        txtCedula.Text,
                        txtTelefono.Text,
                        textRepresentante.Text,
                        (Zona)cbZona.SelectedItem!,
                        (Agente)cbAgente.SelectedItem!,
                        (Cobrador)cbCobrador.SelectedItem!,
                        txtProvincia.Text,
                        txtLocalidad.Text,
                        (Direccion)cbDireccion.SelectedItem!,
                        txtTrabajo.Text
                    );

                    dbContextTransaction.Commit();

                    ResetClienteInputs();
                    LoadClienteDataGrid();
                    SetClienteControl(0);
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    ShowErrorMessage($"Error al guardar el cliente: {ex.Message}");
                }
            }
        }



        private void UpdateExistingCliente()
        {
            if (!IsInputValid()) return;

            string nuevoNombre = txtNombre.Text.Trim();
            string nuevaCedula = txtCedula.Text.Trim();
            string nuevoTelefono = txtTelefono.Text.Trim();
            string nuevoRepresentante = textRepresentante.Text.Trim();
            string nuevaProvincia = txtProvincia.Text.Trim();
            string nuevaLocalidad = txtLocalidad.Text.Trim();
            string nuevoTrabajo = txtTrabajo.Text.Trim();
            double nuevoBalance = Convert.ToDouble(txtBalance.Text);

            if (cbZona.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona una zona.");
                return;
            }

            if (cbAgente.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona un agente.");
                return;
            }

            if (cbCobrador.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona un cobrador.");
                return;
            }

            if (cbDireccion.SelectedIndex == -1)
            {
                ShowErrorMessage("Por favor, selecciona una dirección.");
                return;
            }

            using (var dbContextTransaction = _dbContextProvider.Context.Database.BeginTransaction())
            {
                try
                {
                    // Obtén la cédula actual del cliente que se está editando
                    string cedulaActual = clienteService.GetCliente(idSeleccionado).Cedula;

                    // Verifica si la nueva cédula ya está en uso por otro cliente (excepto la cédula actual)
                    if (clienteService.IsCedulaAlreadyExists(nuevaCedula, idSeleccionado))
                    {
                        ShowErrorMessage("La cédula del cliente ya está en uso. Por favor, elige otra.");
                        return;
                    }

                    clienteService.UpdateCliente(
                        idSeleccionado,
                        nuevoNombre,
                        nuevaCedula,
                        nuevoTelefono,
                        nuevoRepresentante,
                        (Zona)cbZona.SelectedItem!,
                        (Agente)cbAgente.SelectedItem!,
                        (Cobrador)cbCobrador.SelectedItem!,
                        nuevaProvincia,
                        nuevaLocalidad,
                        (Direccion)cbDireccion.SelectedItem!,
                        nuevoTrabajo,
                        nuevoBalance
                    );

                    dbContextTransaction.Commit();

                    ResetClienteInputs();
                    LoadClienteDataGrid();
                    SetClienteControl(0);
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    ShowErrorMessage($"Error al actualizar el cliente: {ex.Message}");
                }
            }
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
            if (dataGridViewCliente.SelectedRows.Count > 0)
            {
                idSeleccionado = Convert.ToInt32(dataGridViewCliente.SelectedRows[0].Cells["Id"].Value);

                // Obtener el cliente seleccionado
                Cliente clienteSeleccionado = clienteService.GetCliente(idSeleccionado);

                // Verificar si el cliente tiene un balance pendiente
                if (clienteSeleccionado.Balance > 0)
                {
                    ShowWarningMessage("No puedes eliminar un cliente con balance pendiente.");
                    return; // No proceder con la eliminación
                }

                // Confirmar la eliminación
                DialogResult result = ShowConfirmationDialog("¿Estás seguro de que deseas eliminar este cliente?");

                if (result == DialogResult.Yes)
                {
                    // Eliminar el cliente
                    clienteService.DeleteCliente(idSeleccionado);
                    LoadClienteDataGrid();
                }
            }
            else
            {
                ShowWarningMessage("Por favor, selecciona una fila antes de eliminar.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetClienteInputs();
            SetClienteControl(0);
        }

        private void ResetClienteInputs()
        {
            foreach (Control control in pInputs.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = textBox.Tag!.ToString();
                }
            }
            cbZona.SelectedIndex = (int)cbZona.Tag!;
            cbAgente.SelectedIndex = (int)cbAgente.Tag!;
            cbCobrador.SelectedIndex = (int)cbCobrador.Tag!;
            cbDireccion.SelectedIndex = (int)cbDireccion.Tag!;
        }

        private void SetClienteControl(int index, string action = "")
        {
            clienteControl.SelectedIndex = index;
            lbAccion.Text = action;
        }

        private void SetClienteData(Cliente cliente)
        {
            txtNombre.Text = cliente.Nombre;
            txtCedula.Text = cliente.Cedula;
            txtTelefono.Text = cliente.Telefono;
            textRepresentante.Text = cliente.Representante;
            txtProvincia.Text = cliente.Provincia;
            txtLocalidad.Text = cliente.Localidad;
            txtTrabajo.Text = cliente.Trabajo;
            txtBalance.Text = cliente.Balance.ToString();

            // Obtener la lista de zonas desde el servicio
            var zonas = zonaService.GetAllZonas().ToList();

            // Asignar la lista de zonas al ComboBox
            cbZona.DisplayMember = "Nombre";
            cbZona.ValueMember = "Id";
            cbZona.DataSource = zonas;

            // Seleccionar la zona del cliente en el ComboBox
            cbZona.SelectedItem = zonas.Find(z => z.Nombre == cliente.Zonas);

            // Obtener la lista de agentes desde el servicio
            var agentes = agenteService.GetAllAgentes().ToList();

            // Asignar la lista de agentes al ComboBox
            cbAgente.DisplayMember = "Nombre";
            cbAgente.ValueMember = "Id";
            cbAgente.DataSource = agentes;

            // Seleccionar el agente del cliente en el ComboBox
            cbAgente.SelectedItem = agentes.Find(a => a.Nombre == cliente.Agente);

            // Obtener la lista de cobradores desde el servicio
            var cobradores = cobradorService.GetAllCobradores().ToList();

            // Asignar la lista de cobradores al ComboBox
            cbCobrador.DisplayMember = "Nombre";
            cbCobrador.ValueMember = "Id";
            cbCobrador.DataSource = cobradores;

            // Seleccionar el cobrador del cliente en el ComboBox
            cbCobrador.SelectedItem = cobradores.Find(c => c.Nombre == cliente.Cobrador);

            // Obtener la lista de direcciones desde el servicio
            var direcciones = direccionService.GetAllDirecciones().ToList();

            // Asignar la lista de direcciones al ComboBox
            cbDireccion.DisplayMember = "Nombre";
            cbDireccion.ValueMember = "Id";
            cbDireccion.DataSource = direcciones;

            // Seleccionar la dirección del cliente en el ComboBox
            cbDireccion.SelectedItem = direcciones.Find(d => d.Nombre == cliente.Direcion);
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

                dataGridViewCliente.DataSource = _dbContextProvider.Context.Cliente
                    .Where(c =>
                        EF.Functions.Like(c.Id.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(c.Nombre, $"%{searchText}%") ||
                        EF.Functions.Like(c.Cedula, $"%{searchText}%") ||
                        EF.Functions.Like(c.Telefono, $"%{searchText}%") ||
                        EF.Functions.Like(c.Representante, $"%{searchText}%") ||
                        EF.Functions.Like(c.Provincia, $"%{searchText}%") ||
                        EF.Functions.Like(c.Localidad, $"%{searchText}%") ||
                        EF.Functions.Like(c.Zonas, $"%{searchText}%") ||
                        EF.Functions.Like(c.Agente, $"%{searchText}%") ||
                        EF.Functions.Like(c.Cobrador, $"%{searchText}%") ||
                        EF.Functions.Like(c.Direcion, $"%{searchText}%") ||
                        EF.Functions.Like(c.Trabajo, $"%{searchText}%") ||
                        EF.Functions.Like(c.Balance.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(c.CreatedAt.ToString(), $"%{searchText}%") ||
                        EF.Functions.Like(c.UpdatedAt.ToString(), $"%{searchText}%")
                    )
                    .Select(cliente => new
                    {
                        cliente.Id,
                        cliente.Nombre,
                        cliente.Cedula,
                        cliente.Telefono,
                        cliente.Zonas,
                        cliente.Agente,
                        cliente.Cobrador,
                        cliente.Provincia,
                        cliente.Balance,
                        cliente.CreatedAt,
                        cliente.UpdatedAt
                    }).ToList();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error al realizar la búsqueda: {ex.Message}");
            }
        }
    }
}