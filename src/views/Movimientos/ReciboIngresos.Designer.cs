namespace Sistema_Prestamos.src.views.Procesos
{
    partial class ReciboIngresos
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
            btnSave = new Button();
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
            label15 = new Label();
            label10 = new Label();
            txtInteres = new TextBox();
            label11 = new Label();
            txtCapital = new TextBox();
            label12 = new Label();
            txtBalance = new TextBox();
            label7 = new Label();
            cbPrestamo = new ComboBox();
            cbPagoTipo = new ComboBox();
            txtMonto = new TextBox();
            label1 = new Label();
            label6 = new Label();
            txtTipoPrestamo = new TextBox();
            label2 = new Label();
            txtPagos = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamo).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(370, 175);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 41);
            btnLimpiar.TabIndex = 93;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(248, 175);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 41);
            btnSave.TabIndex = 89;
            btnSave.Text = "Pagar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            dataGridViewPrestamo.Location = new Point(12, 230);
            dataGridViewPrestamo.MultiSelect = false;
            dataGridViewPrestamo.Name = "dataGridViewPrestamo";
            dataGridViewPrestamo.ReadOnly = true;
            dataGridViewPrestamo.Size = new Size(1034, 310);
            dataGridViewPrestamo.TabIndex = 86;
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
            lbBalance.TabIndex = 85;
            lbBalance.Text = "Bal. Total:";
            // 
            // lbCapital
            // 
            lbCapital.AutoSize = true;
            lbCapital.Location = new Point(12, 543);
            lbCapital.Name = "lbCapital";
            lbCapital.Size = new Size(69, 15);
            lbCapital.TabIndex = 84;
            lbCapital.Text = "Tot. Capital:";
            lbCapital.UseWaitCursor = true;
            // 
            // lbInteres
            // 
            lbInteres.AutoSize = true;
            lbInteres.Location = new Point(165, 543);
            lbInteres.Name = "lbInteres";
            lbInteres.Size = new Size(67, 15);
            lbInteres.TabIndex = 83;
            lbInteres.Text = "Tot. Interes:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 57);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 80;
            label15.Text = "F. Pago";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(667, 12);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 77;
            label10.Text = "Interes";
            // 
            // txtInteres
            // 
            txtInteres.BackColor = SystemColors.ButtonHighlight;
            txtInteres.Enabled = false;
            txtInteres.Location = new Point(667, 30);
            txtInteres.Name = "txtInteres";
            txtInteres.ReadOnly = true;
            txtInteres.Size = new Size(180, 23);
            txtInteres.TabIndex = 76;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(457, 12);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 75;
            label11.Text = "Capital";
            // 
            // txtCapital
            // 
            txtCapital.BackColor = SystemColors.ButtonHighlight;
            txtCapital.Enabled = false;
            txtCapital.Location = new Point(457, 30);
            txtCapital.Name = "txtCapital";
            txtCapital.ReadOnly = true;
            txtCapital.Size = new Size(180, 23);
            txtCapital.TabIndex = 74;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(248, 12);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 73;
            label12.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.BackColor = SystemColors.ButtonHighlight;
            txtBalance.Enabled = false;
            txtBalance.Location = new Point(248, 30);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(180, 23);
            txtBalance.TabIndex = 72;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 10);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 71;
            label7.Text = "Restamo";
            // 
            // cbPrestamo
            // 
            cbPrestamo.AllowDrop = true;
            cbPrestamo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrestamo.Location = new Point(12, 30);
            cbPrestamo.Name = "cbPrestamo";
            cbPrestamo.Size = new Size(211, 23);
            cbPrestamo.TabIndex = 66;
            cbPrestamo.SelectedIndexChanged += cbPrestamo_SelectedIndexChanged;
            // 
            // cbPagoTipo
            // 
            cbPagoTipo.AllowDrop = true;
            cbPagoTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPagoTipo.FormattingEnabled = true;
            cbPagoTipo.Items.AddRange(new object[] { "Efectivo" });
            cbPagoTipo.Location = new Point(12, 75);
            cbPagoTipo.Name = "cbPagoTipo";
            cbPagoTipo.Size = new Size(211, 23);
            cbPagoTipo.Sorted = true;
            cbPagoTipo.TabIndex = 61;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMonto.Location = new Point(12, 187);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(122, 29);
            txtMonto.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 169);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 58;
            label1.Text = "Monto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 57);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 65;
            label6.Text = "Tipo Prestamo";
            // 
            // txtTipoPrestamo
            // 
            txtTipoPrestamo.BackColor = SystemColors.ButtonHighlight;
            txtTipoPrestamo.Enabled = false;
            txtTipoPrestamo.Location = new Point(248, 75);
            txtTipoPrestamo.Name = "txtTipoPrestamo";
            txtTipoPrestamo.ReadOnly = true;
            txtTipoPrestamo.Size = new Size(180, 23);
            txtTipoPrestamo.TabIndex = 94;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 57);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 96;
            label2.Text = "Cuotas Pagadas";
            // 
            // txtPagos
            // 
            txtPagos.BackColor = SystemColors.ButtonHighlight;
            txtPagos.Enabled = false;
            txtPagos.Location = new Point(457, 75);
            txtPagos.Name = "txtPagos";
            txtPagos.ReadOnly = true;
            txtPagos.Size = new Size(180, 23);
            txtPagos.TabIndex = 95;
            // 
            // panel1
            // 
            panel1.Location = new Point(1, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 561);
            panel1.TabIndex = 132;
            // 
            // ReciboIngresos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 569);
            Controls.Add(label2);
            Controls.Add(txtPagos);
            Controls.Add(txtTipoPrestamo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSave);
            Controls.Add(dataGridViewPrestamo);
            Controls.Add(lbBalance);
            Controls.Add(lbCapital);
            Controls.Add(lbInteres);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(txtInteres);
            Controls.Add(label11);
            Controls.Add(txtCapital);
            Controls.Add(label12);
            Controls.Add(txtBalance);
            Controls.Add(label7);
            Controls.Add(cbPrestamo);
            Controls.Add(label6);
            Controls.Add(cbPagoTipo);
            Controls.Add(label1);
            Controls.Add(txtMonto);
            Controls.Add(panel1);
            Name = "ReciboIngresos";
            Text = "Recibo Ingresos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnSave;
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
        private Label label15;
        private Label label10;
        private TextBox txtInteres;
        private Label label11;
        private TextBox txtCapital;
        private Label label12;
        private TextBox txtBalance;
        private Label label7;
        private ComboBox cbPrestamo;
        private ComboBox cbPagoTipo;
        private TextBox txtMonto;
        private Label label1;
        private Label label6;
        private TextBox txtTipoPrestamo;
        private Label label2;
        private TextBox txtPagos;
        private Panel panel1;
    }
}