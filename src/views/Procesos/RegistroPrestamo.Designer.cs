namespace Sistema_Prestamos.src.views.Procesos
{
    partial class RegistroPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLimpiar = new Button();
            txtCuotas = new TextBox();
            txtInteres = new TextBox();
            btnCalcular = new Button();
            btnSave = new Button();
            txtAgente = new TextBox();
            label4 = new Label();
            dataGridViewPrestamo = new DataGridView();
            cuotas = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            pago = new DataGridViewTextBoxColumn();
            capital = new DataGridViewTextBoxColumn();
            interes = new DataGridViewTextBoxColumn();
            lbBalance = new Label();
            lbCapital = new Label();
            lbInteres = new Label();
            label16 = new Label();
            txtFiador = new TextBox();
            label15 = new Label();
            txtGarantia = new TextBox();
            label13 = new Label();
            label10 = new Label();
            txtDireccion = new TextBox();
            label11 = new Label();
            txtTelefono = new TextBox();
            label12 = new Label();
            txtCedula = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtCobrador = new TextBox();
            label9 = new Label();
            txtZona = new TextBox();
            cbCliente = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            cbFormato = new ComboBox();
            label3 = new Label();
            cbPrestamo = new ComboBox();
            dtFechaFrom = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            txtMonto = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(667, 183);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 41);
            btnLimpiar.TabIndex = 130;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtCuotas
            // 
            txtCuotas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCuotas.Location = new Point(282, 192);
            txtCuotas.Name = "txtCuotas";
            txtCuotas.Size = new Size(146, 29);
            txtCuotas.TabIndex = 129;
            // 
            // txtInteres
            // 
            txtInteres.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInteres.Location = new Point(150, 192);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(122, 29);
            txtInteres.TabIndex = 128;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(799, 182);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(97, 41);
            btnCalcular.TabIndex = 127;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(930, 182);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 41);
            btnSave.TabIndex = 126;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAgente
            // 
            txtAgente.BackColor = SystemColors.ButtonHighlight;
            txtAgente.Location = new Point(667, 83);
            txtAgente.Name = "txtAgente";
            txtAgente.ReadOnly = true;
            txtAgente.Size = new Size(180, 23);
            txtAgente.TabIndex = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 179);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 124;
            label4.Text = "Formato de pago";
            // 
            // dataGridViewPrestamo
            // 
            dataGridViewPrestamo.AllowUserToAddRows = false;
            dataGridViewPrestamo.AllowUserToDeleteRows = false;
            dataGridViewPrestamo.AllowUserToResizeColumns = false;
            dataGridViewPrestamo.AllowUserToResizeRows = false;
            dataGridViewPrestamo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPrestamo.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewPrestamo.BorderStyle = BorderStyle.None;
            dataGridViewPrestamo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrestamo.Columns.AddRange(new DataGridViewColumn[] { cuotas, fecha, monto, pago, capital, interes });
            dataGridViewPrestamo.Location = new Point(3, 221);
            dataGridViewPrestamo.MultiSelect = false;
            dataGridViewPrestamo.Name = "dataGridViewPrestamo";
            dataGridViewPrestamo.ReadOnly = true;
            dataGridViewPrestamo.Size = new Size(1034, 310);
            dataGridViewPrestamo.TabIndex = 123;
            dataGridViewPrestamo.TabStop = false;
            // 
            // cuotas
            // 
            cuotas.HeaderText = "No. Cuotas";
            cuotas.Name = "cuotas";
            cuotas.ReadOnly = true;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            monto.ReadOnly = true;
            // 
            // pago
            // 
            pago.HeaderText = "Pago Cta.";
            pago.Name = "pago";
            pago.ReadOnly = true;
            // 
            // capital
            // 
            capital.HeaderText = "Capital";
            capital.Name = "capital";
            capital.ReadOnly = true;
            // 
            // interes
            // 
            interes.HeaderText = "Interes";
            interes.Name = "interes";
            interes.ReadOnly = true;
            // 
            // lbBalance
            // 
            lbBalance.AutoSize = true;
            lbBalance.Location = new Point(332, 543);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(57, 15);
            lbBalance.TabIndex = 122;
            lbBalance.Text = "Bal. Total:";
            // 
            // lbCapital
            // 
            lbCapital.AutoSize = true;
            lbCapital.Location = new Point(12, 543);
            lbCapital.Name = "lbCapital";
            lbCapital.Size = new Size(69, 15);
            lbCapital.TabIndex = 121;
            lbCapital.Text = "Tot. Capital:";
            lbCapital.UseWaitCursor = true;
            // 
            // lbInteres
            // 
            lbInteres.AutoSize = true;
            lbInteres.Location = new Point(165, 543);
            lbInteres.Name = "lbInteres";
            lbInteres.Size = new Size(67, 15);
            lbInteres.TabIndex = 120;
            lbInteres.Text = "Tot. Interes:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(457, 122);
            label16.Name = "label16";
            label16.Size = new Size(40, 15);
            label16.TabIndex = 119;
            label16.Text = "Fiador";
            // 
            // txtFiador
            // 
            txtFiador.Location = new Point(457, 140);
            txtFiador.Name = "txtFiador";
            txtFiador.Size = new Size(180, 23);
            txtFiador.TabIndex = 118;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 65);
            label15.Name = "label15";
            label15.Size = new Size(51, 15);
            label15.TabIndex = 117;
            label15.Text = "Garantia";
            // 
            // txtGarantia
            // 
            txtGarantia.Location = new Point(12, 83);
            txtGarantia.Name = "txtGarantia";
            txtGarantia.Size = new Size(211, 23);
            txtGarantia.TabIndex = 116;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(667, 65);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 115;
            label13.Text = "Agente";
            label13.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(667, 12);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 114;
            label10.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = SystemColors.ButtonHighlight;
            txtDireccion.Location = new Point(667, 30);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(180, 23);
            txtDireccion.TabIndex = 113;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(457, 12);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 112;
            label11.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.ButtonHighlight;
            txtTelefono.Location = new Point(457, 30);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(180, 23);
            txtTelefono.TabIndex = 111;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(248, 12);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 110;
            label12.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = SystemColors.ButtonHighlight;
            txtCedula.Location = new Point(248, 30);
            txtCedula.Name = "txtCedula";
            txtCedula.ReadOnly = true;
            txtCedula.Size = new Size(180, 23);
            txtCedula.TabIndex = 109;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 10);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 108;
            label7.Text = "Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 65);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 107;
            label8.Text = "Zona";
            // 
            // txtCobrador
            // 
            txtCobrador.BackColor = SystemColors.ButtonHighlight;
            txtCobrador.Location = new Point(457, 83);
            txtCobrador.Name = "txtCobrador";
            txtCobrador.ReadOnly = true;
            txtCobrador.Size = new Size(180, 23);
            txtCobrador.TabIndex = 106;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(457, 65);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 105;
            label9.Text = "Corbador";
            // 
            // txtZona
            // 
            txtZona.BackColor = SystemColors.ButtonHighlight;
            txtZona.Location = new Point(248, 83);
            txtZona.Name = "txtZona";
            txtZona.ReadOnly = true;
            txtZona.Size = new Size(180, 23);
            txtZona.TabIndex = 104;
            // 
            // cbCliente
            // 
            cbCliente.AllowDrop = true;
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.Location = new Point(12, 30);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(211, 23);
            cbCliente.TabIndex = 103;
            cbCliente.SelectedIndexChanged += cbCliente_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 120);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 102;
            label6.Text = "Tipo Prestamo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 120);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 101;
            label5.Text = "Fecha";
            // 
            // cbFormato
            // 
            cbFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFormato.FormattingEnabled = true;
            cbFormato.Items.AddRange(new object[] { "Mensual", "Quincenal", "Semanal" });
            cbFormato.Location = new Point(457, 197);
            cbFormato.Name = "cbFormato";
            cbFormato.Size = new Size(180, 23);
            cbFormato.TabIndex = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 174);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 99;
            label3.Text = "Cuotas";
            // 
            // cbPrestamo
            // 
            cbPrestamo.AllowDrop = true;
            cbPrestamo.FormattingEnabled = true;
            cbPrestamo.Items.AddRange(new object[] { "Interes Fijo", "Saldo Insoluto Variado" });
            cbPrestamo.Location = new Point(282, 140);
            cbPrestamo.Name = "cbPrestamo";
            cbPrestamo.Size = new Size(146, 23);
            cbPrestamo.Sorted = true;
            cbPrestamo.TabIndex = 98;
            // 
            // dtFechaFrom
            // 
            dtFechaFrom.Location = new Point(12, 140);
            dtFechaFrom.Name = "dtFechaFrom";
            dtFechaFrom.Size = new Size(233, 23);
            dtFechaFrom.TabIndex = 97;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 174);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 96;
            label2.Text = "Interes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 174);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 95;
            label1.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMonto.Location = new Point(12, 192);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(122, 29);
            txtMonto.TabIndex = 94;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewPrestamo);
            panel1.Location = new Point(2, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 561);
            panel1.TabIndex = 131;
            // 
            // RegistroPrestamo
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1058, 569);
            Controls.Add(btnLimpiar);
            Controls.Add(txtCuotas);
            Controls.Add(txtInteres);
            Controls.Add(btnCalcular);
            Controls.Add(btnSave);
            Controls.Add(txtAgente);
            Controls.Add(label4);
            Controls.Add(lbBalance);
            Controls.Add(lbCapital);
            Controls.Add(lbInteres);
            Controls.Add(label16);
            Controls.Add(txtFiador);
            Controls.Add(label15);
            Controls.Add(txtGarantia);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(txtDireccion);
            Controls.Add(label11);
            Controls.Add(txtTelefono);
            Controls.Add(label12);
            Controls.Add(txtCedula);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtCobrador);
            Controls.Add(label9);
            Controls.Add(txtZona);
            Controls.Add(cbCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbFormato);
            Controls.Add(label3);
            Controls.Add(cbPrestamo);
            Controls.Add(dtFechaFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMonto);
            Controls.Add(panel1);
            Name = "RegistroPrestamo";
            Text = "Registro de Prestamos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamo).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private TextBox txtCuotas;
        private TextBox txtInteres;
        private Button btnCalcular;
        private Button btnSave;
        private TextBox txtAgente;
        private Label label4;
        private DataGridView dataGridViewPrestamo;
        private DataGridViewTextBoxColumn cuotas;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn pago;
        private DataGridViewTextBoxColumn capital;
        private DataGridViewTextBoxColumn interes;
        private Label lbBalance;
        private Label lbCapital;
        private Label lbInteres;
        private Label label16;
        private TextBox txtFiador;
        private Label label15;
        private TextBox txtGarantia;
        private Label label13;
        private Label label10;
        private TextBox txtDireccion;
        private Label label11;
        private TextBox txtTelefono;
        private Label label12;
        private TextBox txtCedula;
        private Label label7;
        private Label label8;
        private TextBox txtCobrador;
        private Label label9;
        private TextBox txtZona;
        private ComboBox cbCliente;
        private Label label6;
        private Label label5;
        private ComboBox cbFormato;
        private Label label3;
        private ComboBox cbPrestamo;
        private DateTimePicker dtFechaFrom;
        private Label label2;
        private Label label1;
        private TextBox txtMonto;
        private Panel panel1;
    }
}