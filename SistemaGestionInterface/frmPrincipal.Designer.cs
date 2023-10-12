namespace SistemaGestionInterface
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            panelIzquierdo = new Panel();
            btnUsuarios = new Button();
            btnVentas = new Button();
            btnProductosVendidos = new Button();
            btnProductos = new Button();
            panelSuperior = new Panel();
            pictureBox1 = new PictureBox();
            panelCuerpo = new Panel();
            panelIzquierdo.SuspendLayout();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.MediumAquamarine;
            panelIzquierdo.Controls.Add(btnUsuarios);
            panelIzquierdo.Controls.Add(btnVentas);
            panelIzquierdo.Controls.Add(btnProductosVendidos);
            panelIzquierdo.Controls.Add(btnProductos);
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(250, 561);
            panelIzquierdo.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 3;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.Transparent;
            btnUsuarios.Location = new Point(0, 267);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(250, 46);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 3;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.Transparent;
            btnVentas.Location = new Point(0, 215);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(250, 46);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductosVendidos
            // 
            btnProductosVendidos.FlatAppearance.BorderSize = 3;
            btnProductosVendidos.FlatStyle = FlatStyle.Flat;
            btnProductosVendidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductosVendidos.ForeColor = Color.Transparent;
            btnProductosVendidos.Location = new Point(0, 163);
            btnProductosVendidos.Name = "btnProductosVendidos";
            btnProductosVendidos.Size = new Size(250, 46);
            btnProductosVendidos.TabIndex = 1;
            btnProductosVendidos.Text = "Productos Vendidos";
            btnProductosVendidos.UseVisualStyleBackColor = true;
            btnProductosVendidos.Click += btnProductosVendidos_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 3;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.Transparent;
            btnProductos.Location = new Point(0, 111);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(250, 46);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // panelSuperior
            // 
            panelSuperior.BackgroundImage = (Image)resources.GetObject("panelSuperior.BackgroundImage");
            panelSuperior.BackgroundImageLayout = ImageLayout.None;
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(250, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1034, 81);
            panelSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 81);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelCuerpo
            // 
            panelCuerpo.BackgroundImage = (Image)resources.GetObject("panelCuerpo.BackgroundImage");
            panelCuerpo.BackgroundImageLayout = ImageLayout.Stretch;
            panelCuerpo.Dock = DockStyle.Fill;
            panelCuerpo.Location = new Point(250, 81);
            panelCuerpo.Name = "panelCuerpo";
            panelCuerpo.RightToLeft = RightToLeft.No;
            panelCuerpo.Size = new Size(1034, 480);
            panelCuerpo.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 561);
            Controls.Add(panelCuerpo);
            Controls.Add(panelSuperior);
            Controls.Add(panelIzquierdo);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            panelIzquierdo.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIzquierdo;
        private Panel panelSuperior;
        private Panel panelCuerpo;
        private Button btnUsuarios;
        private Button btnVentas;
        private Button btnProductosVendidos;
        private Button btnProductos;
        private PictureBox pictureBox1;
    }
}