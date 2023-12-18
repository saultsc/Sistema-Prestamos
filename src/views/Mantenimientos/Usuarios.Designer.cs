namespace Sistema_Prestamos.src.views.Mantenimientos
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            userControl = new TabControl();
            userPage1 = new TabPage();
            dataGridViewUsuarios = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Acceso = new DataGridViewTextBoxColumn();
            Creacion = new DataGridViewTextBoxColumn();
            Actualizacion = new DataGridViewTextBoxColumn();
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtPassword = new TextBox();
            cbAcces = new ComboBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            lbAccion = new Label();
            pictureBox1 = new PictureBox();
            btnCancel = new Button();
            btnSave = new Button();
            userControl.SuspendLayout();
            userPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            userPage2.SuspendLayout();
            pInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userControl
            // 
            userControl.Controls.Add(userPage1);
            userControl.Controls.Add(userPage2);
            userControl.Location = new Point(0, 0);
            userControl.Name = "userControl";
            userControl.SelectedIndex = 0;
            userControl.Size = new Size(1061, 570);
            userControl.TabIndex = 7;
            userControl.TabStop = false;
            // 
            // userPage1
            // 
            userPage1.Controls.Add(dataGridViewUsuarios);
            userPage1.Controls.Add(label1);
            userPage1.Controls.Add(label2);
            userPage1.Controls.Add(label3);
            userPage1.Controls.Add(label4);
            userPage1.Controls.Add(btnAgregar);
            userPage1.Controls.Add(txtBuscar);
            userPage1.Controls.Add(btnEliminar);
            userPage1.Controls.Add(btnEditar);
            userPage1.Location = new Point(4, 24);
            userPage1.Name = "userPage1";
            userPage1.Padding = new Padding(3);
            userPage1.Size = new Size(1053, 542);
            userPage1.TabIndex = 0;
            userPage1.Text = " ";
            userPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.AllowUserToResizeColumns = false;
            dataGridViewUsuarios.AllowUserToResizeRows = false;
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Correo, Acceso, Creacion, Actualizacion });
            dataGridViewUsuarios.Location = new Point(20, 240);
            dataGridViewUsuarios.MultiSelect = false;
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.Size = new Size(881, 278);
            dataGridViewUsuarios.TabIndex = 8;
            dataGridViewUsuarios.TabStop = false;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Codigo";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Name";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Email";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Acceso
            // 
            Acceso.DataPropertyName = "Level_Acces";
            Acceso.HeaderText = "Acceso";
            Acceso.Name = "Acceso";
            Acceso.ReadOnly = true;
            // 
            // Creacion
            // 
            Creacion.DataPropertyName = "CreatedAt";
            Creacion.HeaderText = "Creacion";
            Creacion.Name = "Creacion";
            Creacion.ReadOnly = true;
            // 
            // Actualizacion
            // 
            Actualizacion.DataPropertyName = "UpdatedAt";
            Actualizacion.HeaderText = "Actualizacion";
            Actualizacion.Name = "Actualizacion";
            Actualizacion.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(472, 31);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Añadir Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(472, 175);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Buscar Registro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(956, 292);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Eliminar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(955, 223);
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
            // userPage2
            // 
            userPage2.Controls.Add(pInputs);
            userPage2.Controls.Add(lbAccion);
            userPage2.Controls.Add(pictureBox1);
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
            pInputs.Controls.Add(label8);
            pInputs.Controls.Add(label7);
            pInputs.Controls.Add(label6);
            pInputs.Controls.Add(label5);
            pInputs.Controls.Add(txtPassword);
            pInputs.Controls.Add(cbAcces);
            pInputs.Controls.Add(txtCorreo);
            pInputs.Controls.Add(txtNombre);
            pInputs.Location = new Point(606, 68);
            pInputs.Name = "pInputs";
            pInputs.Size = new Size(310, 258);
            pInputs.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 200);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 13;
            label8.Text = "Nivel Acceso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 138);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 12;
            label7.Text = "Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 78);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "Correo";
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
            // txtPassword
            // 
            txtPassword.Location = new Point(21, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 23);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // cbAcces
            // 
            cbAcces.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAcces.FormattingEnabled = true;
            cbAcces.Items.AddRange(new object[] { "Usuario", "Administrador" });
            cbAcces.Location = new Point(21, 218);
            cbAcces.Name = "cbAcces";
            cbAcces.Size = new Size(270, 23);
            cbAcces.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(21, 96);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(270, 23);
            txtCorreo.TabIndex = 4;
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
            lbAccion.Location = new Point(493, 40);
            lbAccion.Name = "lbAccion";
            lbAccion.Size = new Size(92, 15);
            lbAccion.TabIndex = 14;
            lbAccion.Text = "Agregar Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(199, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 251);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(792, 346);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 31);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(627, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 31);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 565);
            Controls.Add(userControl);
            Name = "Usuarios";
            Text = "Usuarios";
            userControl.ResumeLayout(false);
            userPage1.ResumeLayout(false);
            userPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            userPage2.ResumeLayout(false);
            userPage2.PerformLayout();
            pInputs.ResumeLayout(false);
            pInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl userControl;
        private TabPage userPage1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private Button btnEditar;
        private TabPage userPage2;
        private TextBox txtNombre;
        private ComboBox cbAcces;
        private TextBox txtCorreo;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private Button btnCancel;
        private Button btnSave;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lbAccion;
        private Panel pInputs;
        private DataGridView dataGridViewUsuarios;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Acceso;
        private DataGridViewTextBoxColumn Creacion;
        private DataGridViewTextBoxColumn Actualizacion;
    }
}