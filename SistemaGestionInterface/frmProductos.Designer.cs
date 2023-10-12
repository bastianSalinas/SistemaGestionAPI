namespace SistemaGestionInterface
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            dgProductos = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            txtCosto = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            txtDescripcion = new TextBox();
            txtIdUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // dgProductos
            // 
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(22, 36);
            dgProductos.Name = "dgProductos";
            dgProductos.RowTemplate.Height = 25;
            dgProductos.Size = new Size(637, 323);
            dgProductos.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(736, 346);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(177, 38);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(146, 369);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(147, 38);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(22, 369);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(118, 38);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(736, 132);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(177, 23);
            txtCosto.TabIndex = 10;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(736, 190);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(177, 23);
            txtPrecioVenta.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(736, 249);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(177, 23);
            txtStock.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(736, 77);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(177, 23);
            txtDescripcion.TabIndex = 13;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(736, 306);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(177, 23);
            txtIdUsuario.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(736, 59);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 15;
            label1.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(736, 114);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 16;
            label2.Text = "Costo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(736, 172);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 17;
            label3.Text = "Precio Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(736, 231);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 18;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Location = new Point(736, 288);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 19;
            label5.Text = "Id Usuario";
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(975, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtDescripcion);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dgProductos);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProductos;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;
        private TextBox txtCosto;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
        private TextBox txtDescripcion;
        private TextBox txtIdUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}