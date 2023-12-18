namespace Sistema_Prestamos.src.views.Mantenimientos
{
    partial class Zonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zonas));
            zonaControl = new TabControl();
            zonaPage1 = new TabPage();
            dataGridViewZonas = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            zonaPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            pInputs = new Panel();
            label5 = new Label();
            txtNombre = new TextBox();
            lbAccion = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            zonaControl.SuspendLayout();
            zonaPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZonas).BeginInit();
            zonaPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pInputs.SuspendLayout();
            SuspendLayout();
            // 
            // zonaControl
            // 
            zonaControl.Controls.Add(zonaPage1);
            zonaControl.Controls.Add(zonaPage2);
            zonaControl.Location = new Point(-1, 2);
            zonaControl.Name = "zonaControl";
            zonaControl.SelectedIndex = 0;
            zonaControl.Size = new Size(1061, 570);
            zonaControl.TabIndex = 9;
            zonaControl.TabStop = false;
            // 
            // zonaPage1
            // 
            zonaPage1.Controls.Add(dataGridViewZonas);
            zonaPage1.Controls.Add(label1);
            zonaPage1.Controls.Add(label2);
            zonaPage1.Controls.Add(label3);
            zonaPage1.Controls.Add(label4);
            zonaPage1.Controls.Add(btnAgregar);
            zonaPage1.Controls.Add(txtBuscar);
            zonaPage1.Controls.Add(btnEliminar);
            zonaPage1.Controls.Add(btnEditar);
            zonaPage1.Location = new Point(4, 24);
            zonaPage1.Name = "zonaPage1";
            zonaPage1.Padding = new Padding(3);
            zonaPage1.Size = new Size(1053, 542);
            zonaPage1.TabIndex = 0;
            zonaPage1.Text = " ";
            zonaPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewZonas
            // 
            dataGridViewZonas.AllowUserToAddRows = false;
            dataGridViewZonas.AllowUserToDeleteRows = false;
            dataGridViewZonas.AllowUserToResizeColumns = false;
            dataGridViewZonas.AllowUserToResizeRows = false;
            dataGridViewZonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewZonas.BorderStyle = BorderStyle.None;
            dataGridViewZonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZonas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre });
            dataGridViewZonas.Location = new Point(9, 240);
            dataGridViewZonas.MultiSelect = false;
            dataGridViewZonas.Name = "dataGridViewZonas";
            dataGridViewZonas.ReadOnly = true;
            dataGridViewZonas.Size = new Size(881, 278);
            dataGridViewZonas.TabIndex = 8;
            dataGridViewZonas.TabStop = false;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Id";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 420;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(486, 33);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Añadir Zona";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(477, 178);
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
            btnAgregar.Location = new Point(464, 51);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 67);
            btnAgregar.TabIndex = 0;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(377, 193);
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
            // zonaPage2
            // 
            zonaPage2.Controls.Add(pictureBox1);
            zonaPage2.Controls.Add(pInputs);
            zonaPage2.Controls.Add(lbAccion);
            zonaPage2.Controls.Add(btnCancel);
            zonaPage2.Controls.Add(btnSave);
            zonaPage2.Location = new Point(4, 24);
            zonaPage2.Name = "zonaPage2";
            zonaPage2.Padding = new Padding(3);
            zonaPage2.Size = new Size(1053, 542);
            zonaPage2.TabIndex = 1;
            zonaPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(689, 580);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pInputs
            // 
            pInputs.Controls.Add(label5);
            pInputs.Controls.Add(txtNombre);
            pInputs.Location = new Point(720, 206);
            pInputs.Name = "pInputs";
            pInputs.Size = new Size(281, 54);
            pInputs.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 2);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(3, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(270, 23);
            txtNombre.TabIndex = 3;
            // 
            // lbAccion
            // 
            lbAccion.AutoSize = true;
            lbAccion.Location = new Point(819, 59);
            lbAccion.Name = "lbAccion";
            lbAccion.Size = new Size(79, 15);
            lbAccion.TabIndex = 14;
            lbAccion.Text = "Agregar Zona";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(916, 456);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 31);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(720, 456);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 31);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Zonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 572);
            Controls.Add(zonaControl);
            Name = "Zonas";
            Text = "Zonas";
            zonaControl.ResumeLayout(false);
            zonaPage1.ResumeLayout(false);
            zonaPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZonas).EndInit();
            zonaPage2.ResumeLayout(false);
            zonaPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pInputs.ResumeLayout(false);
            pInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl zonaControl;
        private TabPage zonaPage1;
        private DataGridView dataGridViewZonas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private Button btnEditar;
        private TabPage zonaPage2;
        private Panel pInputs;
        private Label label5;
        private TextBox txtNombre;
        private Label lbAccion;
        private Button btnCancel;
        private Button btnSave;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
    }
}