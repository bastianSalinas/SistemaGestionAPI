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
            dgUsuarios = new DataGridView();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtMail = new TextBox();
            btnGuardar = new Button();
            txtIdUsuario = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgUsuarios
            // 
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Location = new Point(386, 63);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.Size = new Size(602, 360);
            dgUsuarios.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 138);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 23);
            txtNombre.TabIndex = 2;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(67, 188);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(175, 23);
            txtApellido.TabIndex = 3;
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(67, 234);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(175, 23);
            txtNombreUsuario.TabIndex = 4;
            txtNombreUsuario.Enter += txtNombreUsuario_Enter;
            txtNombreUsuario.Leave += txtNombreUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(67, 283);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(175, 23);
            txtContraseña.TabIndex = 5;
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(67, 326);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(175, 23);
            txtMail.TabIndex = 6;
            txtMail.Enter += txtMail_Enter;
            txtMail.Leave += txtMail_Leave;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(34, 384);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(84, 39);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(67, 92);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(175, 23);
            txtIdUsuario.TabIndex = 8;
            txtIdUsuario.Enter += txtIdUsuario_Enter;
            txtIdUsuario.Leave += txtIdUsuario_Leave;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(124, 384);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(72, 39);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(202, 384);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(69, 39);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdUsuario);
            Controls.Add(btnGuardar);
            Controls.Add(txtMail);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(dgUsuarios);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            Enter += txtNombreUsuario_Enter;
            Leave += txtNombreUsuario_Leave;
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgUsuarios;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private TextBox txtMail;
        private Button btnGuardar;
        private TextBox txtIdUsuario;
        private Button btnEliminar;
        private Button btnModificar;
    }
}