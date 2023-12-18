namespace Sistema_Prestamos.src.views.Mantenimientos
{
    partial class Cobradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobradores));
            cobradorControl = new TabControl();
            cobradorPage1 = new TabPage();
            dataGridViewCobrador = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            cobradorPage2 = new TabPage();
            pInputs = new Panel();
            cbDireccion = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            textLocalidad = new TextBox();
            cbZona = new ComboBox();
            textProvincia = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtCedula = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            lbAccion = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            cobradorControl.SuspendLayout();
            cobradorPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCobrador).BeginInit();
            cobradorPage2.SuspendLayout();
            pInputs.SuspendLayout();
            SuspendLayout();
            // 
            // cobradorControl
            // 
            cobradorControl.Controls.Add(cobradorPage1);
            cobradorControl.Controls.Add(cobradorPage2);
            cobradorControl.Location = new Point(0, 0);
            cobradorControl.Name = "cobradorControl";
            cobradorControl.SelectedIndex = 0;
            cobradorControl.Size = new Size(1061, 570);
            cobradorControl.TabIndex = 9;
            cobradorControl.TabStop = false;
            // 
            // cobradorPage1
            // 
            cobradorPage1.Controls.Add(dataGridViewCobrador);
            cobradorPage1.Controls.Add(label1);
            cobradorPage1.Controls.Add(label2);
            cobradorPage1.Controls.Add(label3);
            cobradorPage1.Controls.Add(label4);
            cobradorPage1.Controls.Add(btnAgregar);
            cobradorPage1.Controls.Add(txtBuscar);
            cobradorPage1.Controls.Add(btnEliminar);
            cobradorPage1.Controls.Add(btnEditar);
            cobradorPage1.Location = new Point(4, 24);
            cobradorPage1.Name = "cobradorPage1";
            cobradorPage1.Padding = new Padding(3);
            cobradorPage1.Size = new Size(1053, 542);
            cobradorPage1.TabIndex = 0;
            cobradorPage1.Text = " ";
            cobradorPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCobrador
            // 
            dataGridViewCobrador.AllowUserToAddRows = false;
            dataGridViewCobrador.AllowUserToDeleteRows = false;
            dataGridViewCobrador.AllowUserToResizeColumns = false;
            dataGridViewCobrador.AllowUserToResizeRows = false;
            dataGridViewCobrador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCobrador.BorderStyle = BorderStyle.None;
            dataGridViewCobrador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCobrador.Location = new Point(20, 240);
            dataGridViewCobrador.MultiSelect = false;
            dataGridViewCobrador.Name = "dataGridViewCobrador";
            dataGridViewCobrador.ReadOnly = true;
            dataGridViewCobrador.Size = new Size(881, 278);
            dataGridViewCobrador.TabIndex = 8;
            dataGridViewCobrador.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(479, 40);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Añadir Cobrador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(483, 175);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Buscar Registro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(962, 298);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Eliminar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(961, 229);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = " Editar";
            // 
            // btnAgregar
            // 
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(471, 58);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 67);
            btnAgregar.TabIndex = 0;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(378, 193);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(290, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(926, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(923, 240);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 37);
            btnEditar.TabIndex = 2;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // cobradorPage2
            // 
            cobradorPage2.Controls.Add(pInputs);
            cobradorPage2.Controls.Add(lbAccion);
            cobradorPage2.Controls.Add(btnCancel);
            cobradorPage2.Controls.Add(btnSave);
            cobradorPage2.Location = new Point(4, 24);
            cobradorPage2.Name = "cobradorPage2";
            cobradorPage2.Padding = new Padding(3);
            cobradorPage2.Size = new Size(1053, 542);
            cobradorPage2.TabIndex = 1;
            cobradorPage2.UseVisualStyleBackColor = true;
            // 
            // pInputs
            // 
            pInputs.Controls.Add(cbDireccion);
            pInputs.Controls.Add(label10);
            pInputs.Controls.Add(label11);
            pInputs.Controls.Add(textLocalidad);
            pInputs.Controls.Add(cbZona);
            pInputs.Controls.Add(textProvincia);
            pInputs.Controls.Add(label9);
            pInputs.Controls.Add(label8);
            pInputs.Controls.Add(label7);
            pInputs.Controls.Add(label6);
            pInputs.Controls.Add(label5);
            pInputs.Controls.Add(txtCedula);
            pInputs.Controls.Add(txtTelefono);
            pInputs.Controls.Add(txtNombre);
            pInputs.Location = new Point(235, 68);
            pInputs.Name = "pInputs";
            pInputs.Size = new Size(612, 312);
            pInputs.TabIndex = 15;
            // 
            // cbDireccion
            // 
            cbDireccion.FormattingEnabled = true;
            cbDireccion.Location = new Point(319, 169);
            cbDireccion.Name = "cbDireccion";
            cbDireccion.Size = new Size(270, 23);
            cbDireccion.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Location = new Point(319, 151);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 24;
            label10.Text = "Direccion";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 203);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 23;
            label11.Text = "Localidad";
            // 
            // textLocalidad
            // 
            textLocalidad.Location = new Point(21, 221);
            textLocalidad.Name = "textLocalidad";
            textLocalidad.Size = new Size(270, 23);
            textLocalidad.TabIndex = 22;
            // 
            // cbZona
            // 
            cbZona.FormattingEnabled = true;
            cbZona.Location = new Point(21, 169);
            cbZona.Name = "cbZona";
            cbZona.Size = new Size(270, 23);
            cbZona.TabIndex = 19;
            // 
            // textProvincia
            // 
            textProvincia.Location = new Point(319, 221);
            textProvincia.Name = "textProvincia";
            textProvincia.Size = new Size(270, 23);
            textProvincia.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(319, 203);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 15;
            label9.Text = "Provincia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Location = new Point(21, 151);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 13;
            label8.Text = "Zona";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 64);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 12;
            label7.Text = "Cedula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 14);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 11;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 14);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Nombre";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(21, 82);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(270, 23);
            txtCedula.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(319, 32);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(270, 23);
            txtTelefono.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(21, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(270, 23);
            txtNombre.TabIndex = 3;
            // 
            // lbAccion
            // 
            lbAccion.AutoSize = true;
            lbAccion.Location = new Point(486, 50);
            lbAccion.Name = "lbAccion";
            lbAccion.Size = new Size(102, 15);
            lbAccion.TabIndex = 14;
            lbAccion.Text = "Agregar Cobrador";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(610, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 31);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(355, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 31);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Cobradores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 568);
            Controls.Add(cobradorControl);
            Name = "Cobradores";
            Text = "Cobradores";
            cobradorControl.ResumeLayout(false);
            cobradorPage1.ResumeLayout(false);
            cobradorPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCobrador).EndInit();
            cobradorPage2.ResumeLayout(false);
            cobradorPage2.PerformLayout();
            pInputs.ResumeLayout(false);
            pInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl cobradorControl;
        private TabPage cobradorPage1;
        private DataGridView dataGridViewCobrador;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private Button btnEditar;
        private TabPage cobradorPage2;
        private Panel pInputs;
        private ComboBox cbZona;
        private TextBox textProvincia;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtCedula;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label lbAccion;
        private Button btnCancel;
        private Button btnSave;
        private Label label11;
        private TextBox textLocalidad;
        private ComboBox cbDireccion;
        private Label label10;
    }
}