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
            agenteControl = new TabControl();
            agentePage1 = new TabPage();
            dataGridViewAgente = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            agentePage2 = new TabPage();
            pInputs = new Panel();
            cbZona = new ComboBox();
            textProvicia = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtCedula = new TextBox();
            txttelefono = new TextBox();
            txtNombre = new TextBox();
            lbAccion = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            agenteControl.SuspendLayout();
            agentePage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgente).BeginInit();
            agentePage2.SuspendLayout();
            pInputs.SuspendLayout();
            SuspendLayout();
            // 
            // agenteControl
            // 
            agenteControl.Controls.Add(agentePage1);
            agenteControl.Controls.Add(agentePage2);
            agenteControl.Location = new Point(2, 2);
            agenteControl.Name = "agenteControl";
            agenteControl.SelectedIndex = 0;
            agenteControl.Size = new Size(1061, 570);
            agenteControl.TabIndex = 8;
            agenteControl.TabStop = false;
            // 
            // agentePage1
            // 
            agentePage1.Controls.Add(dataGridViewAgente);
            agentePage1.Controls.Add(label1);
            agentePage1.Controls.Add(label2);
            agentePage1.Controls.Add(label3);
            agentePage1.Controls.Add(label4);
            agentePage1.Controls.Add(btnAgregar);
            agentePage1.Controls.Add(txtBuscar);
            agentePage1.Controls.Add(btnEliminar);
            agentePage1.Controls.Add(btnEditar);
            agentePage1.Location = new Point(4, 24);
            agentePage1.Name = "agentePage1";
            agentePage1.Padding = new Padding(3);
            agentePage1.Size = new Size(1053, 542);
            agentePage1.TabIndex = 0;
            agentePage1.Text = " ";
            agentePage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAgente
            // 
            dataGridViewAgente.AllowUserToAddRows = false;
            dataGridViewAgente.AllowUserToDeleteRows = false;
            dataGridViewAgente.AllowUserToResizeColumns = false;
            dataGridViewAgente.AllowUserToResizeRows = false;
            dataGridViewAgente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAgente.BorderStyle = BorderStyle.None;
            dataGridViewAgente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgente.Location = new Point(20, 240);
            dataGridViewAgente.MultiSelect = false;
            dataGridViewAgente.Name = "dataGridViewAgente";
            dataGridViewAgente.ReadOnly = true;
            dataGridViewAgente.Size = new Size(881, 278);
            dataGridViewAgente.TabIndex = 8;
            dataGridViewAgente.TabStop = false;
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
            btnAgregar.Click += btnAgregar_Click;
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
            // agentePage2
            // 
            agentePage2.Controls.Add(pInputs);
            agentePage2.Controls.Add(lbAccion);
            agentePage2.Controls.Add(btnCancel);
            agentePage2.Controls.Add(btnSave);
            agentePage2.Location = new Point(4, 24);
            agentePage2.Name = "agentePage2";
            agentePage2.Padding = new Padding(3);
            agentePage2.Size = new Size(1053, 542);
            agentePage2.TabIndex = 1;
            agentePage2.UseVisualStyleBackColor = true;
            // 
            // pInputs
            // 
            pInputs.Controls.Add(cbZona);
            pInputs.Controls.Add(textProvicia);
            pInputs.Controls.Add(label9);
            pInputs.Controls.Add(label8);
            pInputs.Controls.Add(label7);
            pInputs.Controls.Add(label6);
            pInputs.Controls.Add(label5);
            pInputs.Controls.Add(txtCedula);
            pInputs.Controls.Add(txttelefono);
            pInputs.Controls.Add(txtNombre);
            pInputs.Location = new Point(228, 123);
            pInputs.Name = "pInputs";
            pInputs.Size = new Size(612, 211);
            pInputs.TabIndex = 15;
            // 
            // cbZona
            // 
            cbZona.FormattingEnabled = true;
            cbZona.Location = new Point(21, 159);
            cbZona.Name = "cbZona";
            cbZona.Size = new Size(270, 23);
            cbZona.TabIndex = 19;
            // 
            // textProvicia
            // 
            textProvicia.Location = new Point(319, 159);
            textProvicia.Name = "textProvicia";
            textProvicia.Size = new Size(270, 23);
            textProvicia.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(319, 141);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 15;
            label9.Text = "Provincia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Location = new Point(21, 141);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 13;
            label8.Text = "Zona";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 77);
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
            txtCedula.Location = new Point(21, 95);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(270, 23);
            txtCedula.TabIndex = 6;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(319, 32);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(270, 23);
            txttelefono.TabIndex = 4;
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
            lbAccion.Location = new Point(468, 39);
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
            // Agentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 568);
            Controls.Add(agenteControl);
            Name = "Agentes";
            Text = "Agentes";
            agenteControl.ResumeLayout(false);
            agentePage1.ResumeLayout(false);
            agentePage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgente).EndInit();
            agentePage2.ResumeLayout(false);
            agentePage2.PerformLayout();
            pInputs.ResumeLayout(false);
            pInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl agenteControl;
        private TabPage agentePage1;
        private DataGridView dataGridViewAgente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private Button btnEditar;
        private TabPage agentePage2;
        private Panel pInputs;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtCedula;
        private TextBox txttelefono;
        private TextBox txtNombre;
        private Label lbAccion;
        private Button btnCancel;
        private Button btnSave;
        private TextBox textProvicia;
        private Label label9;
        private ComboBox cbZona;
    }
}