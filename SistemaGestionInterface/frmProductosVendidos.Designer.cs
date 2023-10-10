namespace SistemaGestionInterface
{
    partial class frmProductosVendidos
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
            dgProductosVendidos = new DataGridView();
            txtId = new TextBox();
            txtStock = new TextBox();
            txtIdProducto = new TextBox();
            txtIdVenta = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).BeginInit();
            SuspendLayout();
            // 
            // dgProductosVendidos
            // 
            dgProductosVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductosVendidos.Location = new Point(361, 71);
            dgProductosVendidos.Name = "dgProductosVendidos";
            dgProductosVendidos.RowTemplate.Height = 25;
            dgProductosVendidos.Size = new Size(521, 332);
            dgProductosVendidos.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(87, 125);
            txtId.Name = "txtId";
            txtId.Size = new Size(161, 23);
            txtId.TabIndex = 1;
            txtId.Enter += txtId_Enter;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(87, 178);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(161, 23);
            txtStock.TabIndex = 2;
            txtStock.Enter += txtStock_Enter;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(87, 226);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(161, 23);
            txtIdProducto.TabIndex = 3;
            txtIdProducto.Enter += txtIdProducto_Enter;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(87, 277);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(161, 23);
            txtIdVenta.TabIndex = 4;
            txtIdVenta.Enter += txtIdVenta_Enter;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(26, 330);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(81, 33);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Crear";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(125, 330);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 33);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(225, 330);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(84, 33);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmProductosVendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtIdVenta);
            Controls.Add(txtIdProducto);
            Controls.Add(txtStock);
            Controls.Add(txtId);
            Controls.Add(dgProductosVendidos);
            Name = "frmProductosVendidos";
            Text = "frmProductosVendidos";
            Load += frmProductosVendidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProductosVendidos;
        private TextBox txtId;
        private TextBox txtStock;
        private TextBox txtIdProducto;
        private TextBox txtIdVenta;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}