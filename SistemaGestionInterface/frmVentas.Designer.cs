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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            dgVentas = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            txtComentarios = new TextBox();
            txtIdUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgVentas).BeginInit();
            SuspendLayout();
            // 
            // dgVentas
            // 
            dgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVentas.Location = new Point(43, 45);
            dgVentas.Name = "dgVentas";
            dgVentas.RowTemplate.Height = 25;
            dgVentas.Size = new Size(553, 302);
            dgVentas.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(678, 217);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(173, 36);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(181, 368);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 36);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(43, 368);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(132, 36);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(678, 101);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(173, 23);
            txtComentarios.TabIndex = 7;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(678, 158);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(173, 23);
            txtIdUsuario.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(678, 83);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 9;
            label1.Text = "Comentarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(681, 137);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 10;
            label2.Text = "Id Usuario";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(930, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
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
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;
        private TextBox txtComentarios;
        private TextBox txtIdUsuario;
        private Label label1;
        private Label label2;
    }
}