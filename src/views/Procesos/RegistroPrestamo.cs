using Microsoft.EntityFrameworkCore;
using Sistema_Prestamos.src.data.sqlserver;
using Sistema_Prestamos.src.data.sqlserver.model;
using Sistema_Prestamos.src.services;
using Sistema_Prestamos.src.views.Mantenimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sistema_Prestamos.src.views.Procesos
{
    public partial class RegistroPrestamo : Form
    {
        private readonly DbContextProvider _dbContextProvider;

        public RegistroPrestamo()
        {
            InitializeComponent();
            _dbContextProvider = new DbContextProvider();
            LoadClientesComboBox();
            txtInteres.TextChanged += txtInteres_TextChanged!;
            txtMonto.KeyPress += txtMonto_KeyPress!;
            txtInteres.KeyPress += txtInteres_KeyPress!;
            txtCuotas.KeyPress += txtCuotas_KeyPress!;
            cbPrestamo.SelectedIndex = 0;
            cbFormato.SelectedIndex = 0;

        }

        private void LoadClientesComboBox()
        {
            // Obtener una lista única de clientes
            var clientes = _dbContextProvider.Context.Cliente.ToList();

            // Agregar un elemento adicional al principio de la lista
            clientes.Insert(0, new Cliente { Id = 0, Nombre = "Selecciona un Cliente" });

            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "Id";
            cbCliente.DataSource = clientes;
            cbCliente.SelectedIndex = 0; // Seleccionar el elemento adicional por defecto
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex > 0)
            {
                // Obtener el cliente seleccionado del ComboBox
                Cliente cliente = (Cliente)cbCliente.SelectedItem!;

                // Asignar valores a los TextBox
                txtAgente.Text = cliente.Agente?.ToString() ?? string.Empty;
                txtCedula.Text = cliente.Cedula?.ToString() ?? string.Empty;
                txtCobrador.Text = cliente.Cobrador?.ToString() ?? string.Empty;
                txtDireccion.Text = cliente.Direcion ?? string.Empty;
                txtTelefono.Text = cliente.Telefono?.ToString() ?? string.Empty;
                txtZona.Text = cliente.Zonas ?? string.Empty;
            }
            else
            {
                // Limpiar los TextBox si no se ha seleccionado un cliente
                txtAgente.Text = string.Empty;
                txtCedula.Text = string.Empty;
                txtCobrador.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtZona.Text = string.Empty;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Prestamo(cbFormato.Text, cbPrestamo.SelectedIndex, 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un cliente antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si no hay cliente seleccionado
            }

            Prestamo(cbFormato.Text, cbPrestamo.SelectedIndex, 2);
        }


        private void txtInteres_TextChanged(object sender, EventArgs e)
        {
            // Desvincular el evento TextChanged temporalmente
            txtInteres.TextChanged -= txtInteres_TextChanged!;

            // Obtener la posición actual del cursor
            int cursorPosition = txtInteres.SelectionStart;

            // Eliminar el símbolo '%' actual si existe
            txtInteres.Text = txtInteres.Text.TrimEnd('%');

            // Añadir '%' al final si no termina con '%'
            if (!txtInteres.Text.EndsWith("%"))
            {
                txtInteres.Text = txtInteres.Text + "%";
            }

            // Eliminar '%' si es el único carácter presente
            if (txtInteres.Text.Length == 1 && txtInteres.Text == "%")
            {
                txtInteres.Text = "";
            }

            // Restaurar la posición del cursor
            txtInteres.SelectionStart = cursorPosition;

            // Volver a vincular el evento TextChanged
            txtInteres.TextChanged += txtInteres_TextChanged!;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o un punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignorar la tecla presionada si no es un número o un punto decimal
            }

            // Asegurarse de que solo haya un punto decimal
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox)!.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignorar la tecla presionada si no es un número o un punto decimal
            }

            // Asegurarse de que solo haya un punto decimal
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox)!.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignorar la tecla presionada si no es un número o un punto decimal
            }

        }

        private void Prestamo(string formato, int tipoPrestamo, int accion)
        {
            dataGridViewPrestamo.Rows.Clear();
            List<string> errores = new List<string>();

            bool montoSuccess = TryConvertFields(out double monto, "Monto", errores);
            bool interesSuccess = TryConvertFields(out double interes, "Tasa de Interés", errores);
            bool cuotasSuccess = TryConvertFields(out int cuotas, "Cuotas", errores);

            if (!montoSuccess || !interesSuccess || !cuotasSuccess)
            {
                MostrarAviso(errores);
                return;
            }

            if (tipoPrestamo == 0)
            {
                interesFijo(monto, interes, cuotas, accion);
            }
            else
            {
                insolutoVariado(monto, interes, cuotas, accion);
            }
        }


        private bool TryConvertFields<T>(out T result, string fieldName, List<string> errores)
        {
            string input = null!;

            switch (fieldName)
            {
                case "Monto":
                    input = txtMonto.Text;
                    break;
                case "Tasa de Interés":
                    input = txtInteres.Text.TrimEnd('%');
                    break;
                case "Cuotas":
                    input = txtCuotas.Text;
                    break;
                // Agregar más campos según sea necesario

                default:
                    // Agregar lógica adicional para otros campos
                    break;
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                errores.Add(fieldName);
                result = default(T)!;
                return false;
            }

            return TryParse(fieldName, input, out result);
        }

        private bool TryParse<T>(string fieldName, string input, out T result)
        {
            try
            {
                result = (T)Convert.ChangeType(input, typeof(T));
                return true;
            }
            catch
            {
                result = default(T)!;
                return false;
            }
        }


        private void MostrarAviso(List<string> errores)
        {
            if (errores.Count > 0)
            {
                string mensaje = "Campos vacios: " + string.Join(", ", errores);
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void interesFijo(double monto, double tasaInteres, int cuotas, int accion)
        {
            DateTime ffecha = Convert.ToDateTime(dtFechaFrom.Value.ToString());
            DateTime fechaActual = ffecha;  // Inicializa fechaActual con el valor inicial
            double interes = monto * (tasaInteres / 100);
            double capital = monto / cuotas;
            double tInteres = 0;

            for (int i = 1; i <= cuotas; i++)
            {
                switch (cbFormato.SelectedItem!.ToString())
                {
                    case "Mensual":
                        fechaActual = fechaActual.AddMonths(1);
                        break;
                    case "Quincenal":
                        fechaActual = fechaActual.AddDays(15);
                        break;
                    case "Semanal":
                        fechaActual = fechaActual.AddDays(7);
                        break;
                    default:
                        break;
                }

                tInteres += interes;
                double totalCuota = interes + capital;
                dataGridViewPrestamo.Rows.Add(i.ToString(), fechaActual.ToShortDateString(), monto.ToString(".00"), totalCuota.ToString(".00"), capital.ToString(".00"), interes.ToString(".00"));
                monto -= capital;
            }

            lbCapital.Text = $"Tot. Capital: {double.Parse(txtMonto.Text):N2}$";
            lbInteres.Text = $"Tot. Interes: {tInteres:N2}$";
            lbBalance.Text = $"Balance Tot.: {(double.Parse(txtMonto.Text) + tInteres).ToString(".00")}$";

            if (accion == 2)
            {
                save((double.Parse(txtMonto.Text) + tInteres));
            }
        }

        private void insolutoVariado(double monto, double tasaInteres, int cuotas, int accion)
        {
            double tInteres = 0;
            DateTime ffecha = Convert.ToDateTime(dtFechaFrom.Value.ToString());
            DateTime fechaActual = ffecha;  // Inicializa fechaActual con el valor inicial
            double capital = monto / cuotas;

            for (int i = 1; i <= cuotas; i++)
            {
                switch (cbFormato.SelectedItem!.ToString())
                {
                    case "Mensual":
                        fechaActual = fechaActual.AddMonths(1);
                        break;
                    case "Quincenal":
                        fechaActual = fechaActual.AddDays(15);
                        break;
                    case "Semanal":
                        fechaActual = fechaActual.AddDays(7);
                        break;
                    default:
                        break;
                }


                double interes = monto * (tasaInteres / 100);
                double totalCuota = capital + interes;
                tInteres += interes;
                dataGridViewPrestamo.Rows.Add(i.ToString(), fechaActual.ToShortDateString(), monto.ToString(".00"), totalCuota.ToString(".00"), capital.ToString(".00"), interes.ToString(".00"));
                monto -= capital; // Actualizar el balance después de realizar el pago
            }

            // Asumiendo que lbCapital y tInteres son de tipo Label y monto es una variable numérica
            lbCapital.Text = $"Tot. Capital: {double.Parse(txtMonto.Text):N2}$";
            lbInteres.Text = $"Tot. Interes: {tInteres:N2}$";
            lbBalance.Text = $"Balance Tot.: {(double.Parse(txtMonto.Text) + tInteres).ToString(".00")}$";

            if (accion == 2)
            {
                save((double.Parse(txtMonto.Text) + tInteres));
            }

        }

        private void save(double balance)
        {
            // Obtener los valores necesarios del formulario
            string nombreCliente = cbCliente.SelectedIndex > 0 ? cbCliente.Text : null!;

            // Crear una nueva instancia de la entidad Prestamo
            Prestamo nuevoPrestamo = new Prestamo
            {
                IdCliente = cbCliente.SelectedIndex,
                NombreClient = nombreCliente,
                MontoPre = double.Parse(txtMonto.Text),
                InteresPre = double.Parse(txtInteres.Text.TrimEnd('%')),
                CuotasPre = int.Parse(txtCuotas.Text),
                GarantiaPre = txtGarantia.Text,
                FiadorPre = txtFiador.Text,
                FechaPre = dtFechaFrom.Value,
                TipoPre = cbPrestamo.SelectedItem?.ToString()!,
                CuotasPagadaPre = 0,
                BalancePre = balance,
                DiaPre = cbFormato.SelectedItem!.ToString()!,
                DiasCuotaPre = txtCuotas.Text.TrimEnd('%'),
                EstadoPre = "Activo",
                CreatedAt = DateTime.Now,
                UpdatedAt = null
            };

            Cliente cliente = _dbContextProvider.Context.Cliente.FirstOrDefault(c => c.Id == nuevoPrestamo.IdCliente)!;

            cliente.Balance += nuevoPrestamo.MontoPre;

            // Agregar el nuevo préstamo al contexto y guardar los cambios
            _dbContextProvider.Context.Prestamo.Add(nuevoPrestamo);
            _dbContextProvider.Context.SaveChanges();

            // Mostrar un mensaje de éxito o realizar otras acciones necesarias
            MessageBox.Show("Préstamo guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
