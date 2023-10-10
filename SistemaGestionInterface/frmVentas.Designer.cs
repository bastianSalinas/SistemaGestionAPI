namespace SistemaGestionInterface
{
    partial class frmVentas
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
            dgVentas = new DataGridView();
            txtIdVenta = new TextBox();
            txtComentarios = new TextBox();
            txtIdUsuario = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgVentas).BeginInit();
            SuspendLayout();
            // 
            // dgVentas
            // 
            dgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVentas.Location = new Point(490, 59);
            dgVentas.Name = "dgVentas";
            dgVentas.RowTemplate.Height = 25;
            dgVentas.Size = new Size(344, 302);
            dgVentas.TabIndex = 0;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(133, 128);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(173, 23);
            txtIdVenta.TabIndex = 1;
            txtIdVenta.Enter += txtIdVenta_Enter;
            txtIdVenta.Leave += txtIdVenta_Leave;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(133, 179);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(173, 23);
            txtComentarios.TabIndex = 2;
            txtComentarios.Enter += txtComentario_Enter;
            txtComentarios.Leave += txtComentario_Leave;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(133, 231);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(173, 23);
            txtIdUsuario.TabIndex = 3;
            txtIdUsuario.Enter += txtIdUsuario_Enter;
            txtIdUsuario.Leave += txtIdUsuario_Leave;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(90, 293);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 36);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(189, 293);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 36);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(277, 293);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 36);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(txtIdVenta);
            Controls.Add(dgVentas);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgVentas;
        private TextBox txtIdVenta;
        private TextBox txtComentarios;
        private TextBox txtIdUsuario;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}