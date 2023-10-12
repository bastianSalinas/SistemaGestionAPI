namespace SistemaGestionInterface
{
    partial class frmUsuarios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            dgUsuarios = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtMail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgUsuarios
            // 
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Location = new Point(12, 35);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.Size = new Size(694, 319);
            dgUsuarios.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(779, 342);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(175, 39);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(183, 370);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(151, 39);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 370);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(148, 39);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(779, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(782, 128);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(173, 23);
            txtApellido.TabIndex = 12;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(779, 181);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(172, 23);
            txtNombreUsuario.TabIndex = 13;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(779, 226);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(172, 23);
            txtContraseña.TabIndex = 14;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(779, 279);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(175, 23);
            txtMail.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(779, 60);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(780, 110);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 17;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(779, 163);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 18;
            label3.Text = "Nombre Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(779, 208);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 19;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(782, 261);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 20;
            label5.Text = "Mail";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1021, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMail);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dgUsuarios);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgUsuarios;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private TextBox txtMail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}