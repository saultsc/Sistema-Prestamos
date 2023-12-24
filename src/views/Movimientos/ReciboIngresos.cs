using Sistema_Prestamos.src.data.sqlserver.model;
using Sistema_Prestamos.src.data.sqlserver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Sistema_Prestamos.src.views.Mantenimientos;
using System.Security.Cryptography;

namespace Sistema_Prestamos.src.views.Procesos
{
    public partial class ReciboIngresos : Form
    {
        private readonly DbContextProvider _dbContextProvider;
        private double montoSeleccionado;
        private double interesSeleccionado;
        private string diaSeleccionado;
        private int cuotaSeleccionada;
        private DateTime fechaSeleccionada;
        Prestamo prestamo;

        public ReciboIngresos()
        {
            InitializeComponent();
            _dbContextProvider = new DbContextProvider();
            LoadPrestamosComboBox();
            cbPagoTipo.SelectedIndex = 0;
        }

        private void LoadPrestamosComboBox()
        {
            cbPrestamo.Items.Clear();

            // Obtener una lista de préstamos excluyendo los "Pagados" y "Anulados"
            var prestamos = _dbContextProvider.Context.Prestamo
                                .Where(p => p.EstadoPre != "Pagado" && p.EstadoPre != "Anulado")
                                .ToList();

            // Agregar un elemento adicional al principio de la lista
            prestamos.Insert(0, new Prestamo { Id = 0, NombreClient = "Seleccione un préstamo" });

            cbPrestamo.DisplayMember = "NombreClient"; // Corregir el nombre de la propiedad
            cbPrestamo.ValueMember = "Id";
            cbPrestamo.DataSource = prestamos;
            cbPrestamo.SelectedIndex = 0; // Seleccionar el elemento adicional por defecto
        }


        private void cbPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (cbPrestamo.SelectedIndex > 0)
            {
                // Obtener el cliente seleccionado del ComboBox
                dataGridViewPrestamo.Rows.Clear();
                prestamo = (Prestamo)cbPrestamo.SelectedItem!;

                // Asignar valores a las variables de clase
                montoSeleccionado = prestamo.MontoPre;
                interesSeleccionado = prestamo.InteresPre;
                diaSeleccionado = prestamo.DiaPre;
                cuotaSeleccionada = prestamo.CuotasPre;
                fechaSeleccionada = prestamo.FechaPre;

                // Asignar valores a los TextBox
                txtBalance.Text = prestamo.BalancePre.ToString() ?? string.Empty;
                txtInteres.Text = prestamo.InteresPre.ToString() + "%" ?? string.Empty;
                txtCapital.Text = (prestamo.MontoPre / prestamo.CuotasPre).ToString() ?? string.Empty;
                txtTipoPrestamo.Text = prestamo.TipoPre?.ToString() ?? string.Empty;
                txtPagos.Text = prestamo.CuotasPagadaPre.ToString() ?? string.Empty;
            }
            else
            {
                // Limpiar los TextBox si no se ha seleccionado un cliente
                txtBalance.Text = string.Empty;
                txtInteres.Text = string.Empty;
                txtCapital.Text = string.Empty;
                txtTipoPrestamo.Text = string.Empty;
                txtPagos.Text = string.Empty;
            }

            // Utilizar las variables de clase en otras partes de tu código según sea necesario
            if (txtTipoPrestamo.Text == "Interes Fijo")
            {
                interesFijo(montoSeleccionado, interesSeleccionado, cuotaSeleccionada, fechaSeleccionada, diaSeleccionado);
            }
            else
            {
                insolutoVariado(montoSeleccionado, interesSeleccionado, cuotaSeleccionada, fechaSeleccionada, diaSeleccionado);
            }
        }

        private void interesFijo(double monto, double tasaInteres, int cuotas, DateTime fecha, string dia)
        {
            dataGridViewPrestamo.Rows.Clear();
            DateTime ffecha = fecha;
            DateTime fechaActual = ffecha;  // Inicializa fechaActual con el valor inicial
            double interes = monto * (tasaInteres / 100);
            double capital = monto / cuotas;
            double tInteres = 0;
            double totalCuota;

            for (int i = 1; i <= cuotas; i++)
            {
                switch (dia)
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

                

                if (i > prestamo.CuotasPagadaPre)
                {
                    tInteres += interes;
                    totalCuota = interes + capital;
                    dataGridViewPrestamo.Rows.Add(i.ToString(), fechaActual.ToShortDateString(), monto.ToString(".00"), totalCuota.ToString(".00"), capital.ToString(".00"), interes.ToString(".00"));
                    monto -= capital;
                }
                else
                {
                    tInteres += interes;
                    totalCuota = interes + capital;
                    monto -= capital;
                }
            }

            lbCapital.Text = $"Tot. Capital: {montoSeleccionado:N2}$";  // Usa montoSeleccionado en lugar de txtMonto.Text
            lbInteres.Text = $"Tot. Interes: {tInteres:N2}$";
            lbBalance.Text = $"Balance Tot.: {(montoSeleccionado + tInteres).ToString(".00")}$";  // Usa montoSeleccionado en lugar de txtMonto.Text
        }



        private void insolutoVariado(double monto, double tasaInteres, int cuotas, DateTime fecha, string dia)
        {
            dataGridViewPrestamo.Rows.Clear();
            double tInteres = 0;
            DateTime ffecha = fecha;
            DateTime fechaActual = ffecha;  // Inicializa fechaActual con el valor inicial
            double capital = monto / cuotas;
            double interes;
            double totalCuota;

            for (int i = 1; i <= cuotas; i++)
            {
                switch (dia)
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

                if (i > prestamo.CuotasPagadaPre)
                {
                    interes = monto * (tasaInteres / 100);
                    totalCuota = capital + interes;
                    tInteres += interes;
                    dataGridViewPrestamo.Rows.Add(i.ToString(), fechaActual.ToShortDateString(), monto.ToString(".00"), totalCuota.ToString(".00"), capital.ToString(".00"), interes.ToString(".00"));
                    monto -= capital;
                }
                else
                {
                    interes = monto * (tasaInteres / 100);
                    totalCuota = capital + interes;
                    tInteres += interes;
                    monto -= capital;
                }
            }

            // Usa montoSeleccionado en lugar de txtMonto.Text
            lbCapital.Text = $"Tot. Capital: {montoSeleccionado:N2}$";
            lbInteres.Text = $"Tot. Interes: {tInteres:N2}$";
            lbBalance.Text = $"Balance Tot.: {(montoSeleccionado + tInteres).ToString(".00")}$";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un préstamo
            if (cbPrestamo.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un préstamo antes de realizar un pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el préstamo seleccionado
            prestamo = (Prestamo)cbPrestamo.SelectedItem!;

            var existingPrestamo = _dbContextProvider.Context.Prestamo.Find(prestamo.Id);
            double capital = prestamo.MontoPre / prestamo.CuotasPre;
            double pagocuota = 0;
            double interes;
            double newMonto = 0;
            double Monto = prestamo.MontoPre;

            if (double.TryParse(txtMonto.Text, out double montoIngresado))
            {
                for (int i = 1; i <= existingPrestamo!.CuotasPre; i++)
                {
                    if (existingPrestamo.TipoPre == "Interes Fijo")
                    {
                        pagocuota = capital + (existingPrestamo.MontoPre * (existingPrestamo.InteresPre / 100));
                    }
                    else
                    {
                        if (i > existingPrestamo.CuotasPagadaPre)
                        {
                            pagocuota = capital + Monto * (existingPrestamo.InteresPre / 100);
                            break;
                        }
                        else
                        {
                            Monto -= capital;
                        }
                    }
                }

                if (pagocuota != montoIngresado)
                {
                    // El monto ingresado no es igual al monto total del préstamo
                    MessageBox.Show("El monto ingresado tiene que ser igual a la cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    existingPrestamo!.BalancePre -= montoIngresado;
                    existingPrestamo!.CuotasPagadaPre++;
                    existingPrestamo.UpdatedAt = DateTime.Now;

                    if (existingPrestamo.CuotasPagadaPre == existingPrestamo.CuotasPre)
                    {
                        existingPrestamo.EstadoPre = "Pagado"; // Cambiar el estado a "Pagado"
                        LoadPrestamosComboBox();
                    }

                    Ingreso nuevoIngreso = new Ingreso
                    {
                        IdPrestamo = existingPrestamo.Id,
                        IdCliente = existingPrestamo.IdCliente,
                        ClienteNombre = existingPrestamo.NombreClient,
                        dinero = double.Parse(txtMonto.Text),
                        CreatedAt = DateTime.Now
                    };

                    Cliente cliente = _dbContextProvider.Context.Cliente.FirstOrDefault(c => c.Nombre == nuevoIngreso.ClienteNombre)!;

                    cliente.Balance -= montoIngresado;

                    _dbContextProvider.Context.Ingreso.Add(nuevoIngreso);

                    _dbContextProvider.Context.SaveChanges();

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("Pago registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar el objeto existingPrestamo después de guardar los cambios
                    existingPrestamo = _dbContextProvider.Context.Prestamo.AsNoTracking().FirstOrDefault(p => p.Id == prestamo.Id);

                    // Restablecer el estado del préstamo a No modificado para futuras operaciones
                    _dbContextProvider.Context.Entry(existingPrestamo).State = EntityState.Detached;

                    // Recargar el DataGridView con la información actualizada
                    cbPrestamo_SelectedIndexChanged(sender, e);

                    
                }
            }
            else
            {
                // Maneja el caso en el que el usuario ingresa un valor no válido en txtMonto.Text
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


    }
}
