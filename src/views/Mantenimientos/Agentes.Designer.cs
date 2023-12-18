namespace Sistema_Prestamos.src.views.Mantenimientos
{
    partial class Agentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agentes));
            userControl = new TabControl();
            userPage1 = new TabPage();
            dataGridViewUsuarios = new DataGridView();
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
            cbAcces = new ComboBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtPassword = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            lbAccion = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            userControl.SuspendLayout();
            userPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            userPage2.SuspendLayout();
            pInputs.SuspendLayout();
            SuspendLayout();
            // 
            // userControl
            // 
            userControl.Controls.Add(userPage1);
            userControl.Controls.Add(userPage2);
            userControl.Location = new Point(2, 2);
            userControl.Name = "userControl";
            userControl.SelectedIndex = 0;
            userControl.Size = new Size(1061, 570);
            userControl.TabIndex = 8;
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
            dataGridViewUsuarios.Location = new Point(20, 240);
            dataGridViewUsuarios.MultiSelect = false;
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.Size = new Size(881, 278);
            dataGridViewUsuarios.TabIndex = 8;
            dataGridViewUsuarios.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(475, 34);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "Añadir Agente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(475, 178);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Buscar Registro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(959, 295);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Eliminar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(958, 226);
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
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(378, 193);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(290, 23);
            txtBuscar.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(926, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(923, 240);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 37);
            btnEditar.TabIndex = 2;
            btnEditar.UseVisualStyleBackColor = true;
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
            pInputs.Controls.Add(cbAcces);
            pInputs.Controls.Add(textBox2);
            pInputs.Controls.Add(label9);
            pInputs.Controls.Add(label8);
            pInputs.Controls.Add(label7);
            pInputs.Controls.Add(label6);
            pInputs.Controls.Add(label5);
            pInputs.Controls.Add(txtPassword);
            pInputs.Controls.Add(txtCorreo);
            pInputs.Controls.Add(txtNombre);
            pInputs.Location = new Point(210, 68);
            pInputs.Name = "pInputs";
            pInputs.Size = new Size(612, 314);
            pInputs.TabIndex = 15;
            // 
            // cbAcces
            // 
            cbAcces.FormattingEnabled = true;
            cbAcces.Location = new Point(21, 218);
            cbAcces.Name = "cbAcces";
            cbAcces.Size = new Size(270, 23);
            cbAcces.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 276);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 23);
            textBox2.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 258);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 15;
            label9.Text = "Provincia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Location = new Point(21, 200);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 13;
            label8.Text = "Codigo (Zona)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 138);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 12;
            label7.Text = "Cedula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 78);
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
            // txtPassword
            // 
            txtPassword.Location = new Point(21, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 23);
            txtPassword.TabIndex = 6;
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
            lbAccion.Location = new Point(445, 40);
            lbAccion.Name = "lbAccion";
            lbAccion.Size = new Size(90, 15);
            lbAccion.TabIndex = 14;
            lbAccion.Text = "Agregar Agente";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(610, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 31);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(355, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 31);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Agentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 568);
            Controls.Add(userControl);
            Name = "Agentes";
            Text = "Agentes";
            userControl.ResumeLayout(false);
            userPage1.ResumeLayout(false);
            userPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            userPage2.ResumeLayout(false);
            userPage2.PerformLayout();
            pInputs.ResumeLayout(false);
            pInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl userControl;
        private TabPage userPage1;
        private DataGridView dataGridViewUsuarios;
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
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtPassword;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label lbAccion;
        private Button btnCancel;
        private Button btnSave;
        private TextBox textBox2;
        private Label label9;
        private ComboBox cbAcces;
    }
}