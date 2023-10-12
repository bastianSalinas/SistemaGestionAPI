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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosVendidos));
            dgProductosVendidos = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            txtStock = new TextBox();
            txtIdProducto = new TextBox();
            txtIdVenta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).BeginInit();
            SuspendLayout();
            // 
            // dgProductosVendidos
            // 
            dgProductosVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductosVendidos.Location = new Point(12, 37);
            dgProductosVendidos.Name = "dgProductosVendidos";
            dgProductosVendidos.RowTemplate.Height = 25;
            dgProductosVendidos.Size = new Size(639, 325);
            dgProductosVendidos.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(714, 247);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(161, 33);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(155, 378);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 33);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(17, 378);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(132, 33);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(714, 92);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(161, 23);
            txtStock.TabIndex = 8;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(714, 151);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(161, 23);
            txtIdProducto.TabIndex = 9;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(714, 207);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(161, 23);
            txtIdVenta.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(714, 74);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 11;
            label1.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(714, 133);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 12;
            label2.Text = "Id Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(717, 189);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 13;
            label3.Text = "Id Venta";
            // 
            // frmProductosVendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(931, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdVenta);
            Controls.Add(txtIdProducto);
            Controls.Add(txtStock);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
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
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;
        private TextBox txtStock;
        private TextBox txtIdProducto;
        private TextBox txtIdVenta;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}