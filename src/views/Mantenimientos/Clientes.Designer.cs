namespace Sistema_Prestamos.src.views.Mantenimientos
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            clienteControl = new TabControl();
            clientePage1 = new TabPage();
            dataGridViewCliente = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            userPage2 = new TabPage();
            pInputs = new Panel();
            label15 = new Label();
            txtBalance = new TextBox();
            txtTrabajo = new TextBox();
            label16 = new Label();
            cbCobrador = new ComboBox();
            label11 = new Label();
            cbDireccion = new ComboBox();
            label10 = new Label();
            cbAgente = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            txtLocalidad = new TextBox();
            label12 = new Label();
            textRepresentante = new TextBox();
            cbZona = new ComboBox();
            txtProvincia = new TextBox();
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
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            clienteControl.SuspendLayout();
            clientePage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            userPage2.SuspendLayout();
            pInputs.SuspendLayout();
            SuspendLayout();
            // 
            // clienteControl
            // 
            clienteControl.Controls.Add(clientePage1);
            clienteControl.Controls.Add(userPage2);
            clienteControl.Location = new Point(0, 0);
            clienteControl.Name = "clienteControl";
            clienteControl.SelectedIndex = 0;
            clienteControl.Size = new Size(1061, 570);
            clienteControl.TabIndex = 9;
            clienteControl.TabStop = false;
            // 
            // clientePage1
            // 
            clientePage1.Controls.Add(dataGridViewCliente);
            clientePage1.Controls.Add(label1);
            clientePage1.Controls.Add(label2);
            clientePage1.Controls.Add(label3);
            clientePage1.Controls.Add(label4);
            clientePage1.Controls.Add(btnAgregar);
            clientePage1.Controls.Add(txtBuscar);
            clientePage1.Controls.Add(btnEliminar);
            clientePage1.Controls.Add(btnEditar);
            clientePage1.Location = new Point(4, 24);
            clientePage1.Name = "clientePage1";
            clientePage1.Padding = new Padding(3);
            clientePage1.Size = new Size(1053, 542);
            clientePage1.TabIndex = 0;
            clientePage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.AllowUserToAddRows = false;
            dataGridViewCliente.AllowUserToDeleteRows = false;
            dataGridViewCliente.AllowUserToResizeColumns = false;
            dataGridViewCliente.AllowUserToResizeRows = false;
            dataGridViewCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCliente.BorderStyle = BorderStyle.None;
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Cedula });
            dataGridViewCliente.Location = new Point(6, 240);
            dataGridViewCliente.MultiSelect = false;
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.ReadOnly = true;
            dataGridViewCliente.Size = new Size(881, 278);
            dataGridViewCliente.TabIndex = 8;
            dataGridViewCliente.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(478, 31);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Añadir Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(478, 175);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Buscar Registro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(956, 294);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Eliminar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(961, 222);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = " Editar";
            // 
            // btnAgregar
            // 
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(463, 49);
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
            btnEliminar.Location = new Point(929, 312);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(926, 240);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 37);
            btnEditar.TabIndex = 2;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // userPage2
            // 
            userPage2.Controls.Add(pInputs);
            userPage2.Controls.Add(lbAccion);
            userPage2.Controls.Add(btnCancel);
            userPage2.Controls.Add(btnSave);
            userPage2.Location = new Point(4, 24);
            userPage2.Name = "userPage2";
            userPage2.Padding = new Padding(3);
            userPage2.Size = new Size(1053, 542);
            userPage2.TabIndex = 1;
            userPage2.UseVisualStyleBackColor = true;
            // 
            // pInputs
            // 
            pInputs.Controls.Add(label15);
            pInputs.Controls.Add(txtBalance);
            pInputs.Controls.Add(txtTrabajo);
            pInputs.Controls.Add(label16);
            pInputs.Controls.Add(cbCobrador);
            pInputs.Controls.Add(label11);
            pInputs.Controls.Add(cbDireccion);
            pInputs.Controls.Add(label10);
            pInputs.Controls.Add(cbAgente);
            pInputs.Controls.Add(label14);
            pInputs.Controls.Add(label13);
            pInputs.Controls.Add(txtLocalidad);
            pInputs.Controls.Add(label12);
            pInputs.Controls.Add(textRepresentante);
            pInputs.Controls.Add(cbZona);
            pInputs.Controls.Add(txtProvincia);
            pInputs.Controls.Add(label9);
            pInputs.Controls.Add(label8);
            pInputs.Controls.Add(label7);
            pInputs.Controls.Add(label6);
            pInputs.Controls.Add(label5);
            pInputs.Controls.Add(txtCedula);
            pInputs.Controls.Add(txtTelefono);
            pInputs.Controls.Add(txtNombre);
            pInputs.Location = new Point(74, 40);
            pInputs.Name = "pInputs";
            pInputs.Size = new Size(891, 352);
            pInputs.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(607, 322);
            label15.Name = "label15";
            label15.Size = new Size(107, 15);
            label15.TabIndex = 35;
            label15.Text = "Balance Pendiente:";
            // 
            // txtBalance
            // 
            txtBalance.Enabled = false;
            txtBalance.Location = new Point(720, 314);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(139, 23);
            txtBalance.TabIndex = 36;
            // 
            // txtTrabajo
            // 
            txtTrabajo.Location = new Point(21, 253);
            txtTrabajo.Name = "txtTrabajo";
            txtTrabajo.Size = new Size(270, 23);
            txtTrabajo.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(21, 235);
            label16.Name = "label16";
            label16.Size = new Size(45, 15);
            label16.TabIndex = 33;
            label16.Text = "Trabajo";
            // 
            // cbCobrador
            // 
            cbCobrador.FormattingEnabled = true;
            cbCobrador.Location = new Point(602, 139);
            cbCobrador.Name = "cbCobrador";
            cbCobrador.Size = new Size(270, 23);
            cbCobrador.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Location = new Point(602, 121);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 31;
            label11.Text = "Cobador";
            // 
            // cbDireccion
            // 
            cbDireccion.FormattingEnabled = true;
            cbDireccion.Location = new Point(602, 198);
            cbDireccion.Name = "cbDireccion";
            cbDireccion.Size = new Size(270, 23);
            cbDireccion.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Location = new Point(602, 180);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 29;
            label10.Text = "Dirrecion";
            // 
            // cbAgente
            // 
            cbAgente.FormattingEnabled = true;
            cbAgente.Location = new Point(310, 139);
            cbAgente.Name = "cbAgente";
            cbAgente.Size = new Size(270, 23);
            cbAgente.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.FlatStyle = FlatStyle.Popup;
            label14.Location = new Point(310, 121);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 24;
            label14.Text = "Agente";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(310, 180);
            label13.Name = "label13";
            label13.Size = new Size(58, 15);
            label13.TabIndex = 23;
            label13.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(310, 198);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(270, 23);
            txtLocalidad.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 67);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 21;
            label12.Text = "Representante";
            // 
            // textRepresentante
            // 
            textRepresentante.Location = new Point(21, 85);
            textRepresentante.Name = "textRepresentante";
            textRepresentante.Size = new Size(270, 23);
            textRepresentante.TabIndex = 20;
            // 
            // cbZona
            // 
            cbZona.FormattingEnabled = true;
            cbZona.Location = new Point(21, 139);
            cbZona.Name = "cbZona";
            cbZona.Size = new Size(270, 23);
            cbZona.TabIndex = 19;
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(21, 198);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(270, 23);
            txtProvincia.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 180);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 15;
            label9.Text = "Provincia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Location = new Point(21, 121);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 13;
            label8.Text = "Zona";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(602, 14);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 12;
            label7.Text = "Cedula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 14);
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
            txtCedula.Location = new Point(602, 32);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(270, 23);
            txtCedula.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(310, 32);
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
            lbAccion.Location = new Point(462, 22);
            lbAccion.Name = "lbAccion";
            lbAccion.Size = new Size(89, 15);
            lbAccion.TabIndex = 14;
            lbAccion.Text = "Agregar Cliente";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(615, 451);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 31);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(345, 451);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 31);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Codigo";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cedula
            // 
            Cedula.DataPropertyName = "Cedula";
            Cedula.HeaderText = "Cedula";
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 570);
            Controls.Add(clienteControl);
            Name = "Clientes";
            Text = "Clientes";
            clienteControl.ResumeLayout(false);
            clientePage1.ResumeLayout(false);
            clientePage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            userPage2.ResumeLayout(false);
            userPage2.PerformLayout();
            pInputs.ResumeLayout(false);
            pInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl clienteControl;
        private TabPage clientePage1;
        private DataGridView dataGridViewCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private Button btnEditar;
        private TabPage userPage2;
        private Panel pInputs;
        private TextBox txtProvincia;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtCedula;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label lbAccion;
        private Button btnCancel;
        private Button btnSave;
        private Label label13;
        private TextBox txtLocalidad;
        private Label label12;
        private TextBox textRepresentante;
        private ComboBox cbAgente;
        private Label label14;
        private ComboBox cbZona;
        private Label label8;
        private ComboBox cbDireccion;
        private Label label10;
        private TextBox txtBalance;
        private TextBox txtTrabajo;
        private ComboBox cbCobrador;
        private Label label11;
        private Label label15;
        private Label label16;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cedula;
    }
}