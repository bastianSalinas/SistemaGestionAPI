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
            dgProductos = new DataGridView();
            txtIdProducto = new TextBox();
            txtDescripcion = new TextBox();
            txtIdUsuario = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            txtCosto = new NumericUpDown();
            txtPrecioVenta = new NumericUpDown();
            txtStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).BeginInit();
            SuspendLayout();
            // 
            // dgProductos
            // 
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(324, 59);
            dgProductos.Name = "dgProductos";
            dgProductos.RowTemplate.Height = 25;
            dgProductos.Size = new Size(639, 355);
            dgProductos.TabIndex = 0;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(67, 96);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(177, 23);
            txtIdProducto.TabIndex = 1;
            txtIdProducto.Enter += txtIdProducto_Enter;
            txtIdProducto.Leave += txtIdProducto_Leave;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(67, 139);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(177, 23);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.Enter += txtDescripcion_Enter;
            txtDescripcion.Leave += txtDescripcion_Leave;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(67, 327);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(177, 23);
            txtIdUsuario.TabIndex = 6;
            txtIdUsuario.Enter += txtIdUsuario_Enter;
            txtIdUsuario.Leave += txtIdUsuario_Leave;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(15, 376);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 38);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(112, 376);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 38);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(218, 376);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(83, 38);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(67, 188);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(177, 23);
            txtCosto.TabIndex = 10;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(67, 234);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(177, 23);
            txtPrecioVenta.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(67, 279);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(177, 23);
            txtStock.TabIndex = 12;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 450);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtDescripcion);
            Controls.Add(txtIdProducto);
            Controls.Add(dgProductos);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProductos;
        private TextBox txtIdProducto;
        private TextBox txtDescripcion;
        private TextBox txtIdUsuario;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;
        private NumericUpDown txtCosto;
        private NumericUpDown txtPrecioVenta;
        private NumericUpDown txtStock;
    }
}