namespace Sistema_Prestamos.src.views.Mantenimientos
{
    partial class Direcciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Direcciones));
            direccionControl = new TabControl();
            direccionPage1 = new TabPage();
            dataGridViewDireccion = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            direccionPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            pInputs = new Panel();
            label5 = new Label();
            txtNombre = new TextBox();
            lbAccion = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            direccionControl.SuspendLayout();
            direccionPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDireccion).BeginInit();
            direccionPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pInputs.SuspendLayout();
            SuspendLayout();
            // 
            // direccionControl
            // 
            direccionControl.Controls.Add(direccionPage1);
            direccionControl.Controls.Add(direccionPage2);
            direccionControl.Location = new Point(1, 2);
            direccionControl.Name = "direccionControl";
            direccionControl.SelectedIndex = 0;
            direccionControl.Size = new Size(1061, 570);
            direccionControl.TabIndex = 10;
            direccionControl.TabStop = false;
            // 
            // direccionPage1
            // 
            direccionPage1.Controls.Add(dataGridViewDireccion);
            direccionPage1.Controls.Add(label1);
            direccionPage1.Controls.Add(label2);
            direccionPage1.Controls.Add(label3);
            direccionPage1.Controls.Add(label4);
            direccionPage1.Controls.Add(btnAgregar);
            direccionPage1.Controls.Add(txtBuscar);
            direccionPage1.Controls.Add(btnEliminar);
            direccionPage1.Controls.Add(btnEditar);
            direccionPage1.Location = new Point(4, 24);
            direccionPage1.Name = "direccionPage1";
            direccionPage1.Padding = new Padding(3);
            direccionPage1.Size = new Size(1053, 542);
            direccionPage1.TabIndex = 0;
            direccionPage1.Text = " ";
            direccionPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDireccion
            // 
            dataGridViewDireccion.AllowUserToAddRows = false;
            dataGridViewDireccion.AllowUserToDeleteRows = false;
            dataGridViewDireccion.AllowUserToResizeColumns = false;
            dataGridViewDireccion.AllowUserToResizeRows = false;
            dataGridViewDireccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDireccion.BorderStyle = BorderStyle.None;
            dataGridViewDireccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDireccion.Location = new Point(17, 240);
            dataGridViewDireccion.MultiSelect = false;
            dataGridViewDireccion.Name = "dataGridViewDireccion";
            dataGridViewDireccion.ReadOnly = true;
            dataGridViewDireccion.Size = new Size(881, 278);
            dataGridViewDireccion.TabIndex = 8;
            dataGridViewDireccion.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(478, 33);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Añadir Dirrecion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(480, 181);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Buscar Registro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(965, 301);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Eliminar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(964, 232);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = " Editar";
            // 
            // btnAgregar
            // 
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(469, 51);
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
            // direccionPage2
            // 
            direccionPage2.Controls.Add(pictureBox1);
            direccionPage2.Controls.Add(pInputs);
            direccionPage2.Controls.Add(lbAccion);
            direccionPage2.Controls.Add(btnCancel);
            direccionPage2.Controls.Add(btnSave);
            direccionPage2.Location = new Point(4, 24);
            direccionPage2.Name = "direccionPage2";
            direccionPage2.Padding = new Padding(3);
            direccionPage2.Size = new Size(1053, 542);
            direccionPage2.TabIndex = 1;
            direccionPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(689, 542);
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
            lbAccion.Location = new Point(796, 62);
            lbAccion.Name = "lbAccion";
            lbAccion.Size = new Size(100, 15);
            lbAccion.TabIndex = 14;
            lbAccion.Text = "Agregar Dirrecion";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(917, 456);
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
            // Direcciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 569);
            Controls.Add(direccionControl);
            Name = "Direcciones";
            Text = "Direcciones";
            direccionControl.ResumeLayout(false);
            direccionPage1.ResumeLayout(false);
            direccionPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDireccion).EndInit();
            direccionPage2.ResumeLayout(false);
            direccionPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pInputs.ResumeLayout(false);
            pInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl direccionControl;
        private TabPage direccionPage1;
        private DataGridView dataGridViewDireccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private Button btnEditar;
        private TabPage direccionPage2;
        private PictureBox pictureBox1;
        private Panel pInputs;
        private Label label5;
        private TextBox txtNombre;
        private Label lbAccion;
        private Button btnCancel;
        private Button btnSave;
    }
}