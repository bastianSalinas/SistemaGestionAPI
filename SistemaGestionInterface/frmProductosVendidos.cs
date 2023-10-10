using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionInterface
{
    public partial class frmProductosVendidos : Form
    {
        public frmProductosVendidos()
        {
            InitializeComponent();
            #region inicioPlaceholder
            txtId.Text = "Ingrese Id Producto Vendido";
            txtId.ForeColor = SystemColors.GrayText;
            txtStock.Text = "Ingrese Stock";
            txtStock.ForeColor = SystemColors.GrayText;
            txtIdProducto.Text = "Ingrese Id Producto";
            txtIdProducto.ForeColor = SystemColors.GrayText;
            txtIdVenta.Text = "Ingrese Id Venta";
            txtIdVenta.ForeColor = SystemColors.GrayText;
            #endregion
        }

        private void frmProductosVendidos_Load(object sender, EventArgs e)
        {
            List<ProductoVendido> prodVendido = ProductoVendidoBussiness.GetProductosVendidos();
            dgProductosVendidos.AutoGenerateColumns = true;
            dgProductosVendidos.DataSource = prodVendido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProductoVendido prodVendido = new ProductoVendido();
            prodVendido.Stock = Convert.ToInt16(txtStock.Text);
            prodVendido.IdProducto = Convert.ToInt16(txtIdProducto.Text);
            prodVendido.IdVenta = Convert.ToInt16(txtIdVenta.Text);
            MessageBox.Show(ProductoVendidoBussiness.CrearProductoVendido(prodVendido));

            List<ProductoVendido> prodVendidos = ProductoVendidoBussiness.GetProductosVendidos();
            dgProductosVendidos.DataSource = null;
            dgProductosVendidos.DataSource = prodVendidos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoVendido prodVendido = new ProductoVendido();
            prodVendido.Id = Convert.ToInt16(txtId.Text);
            MessageBox.Show(ProductoVendidoBussiness.EliminarProductoVendido(prodVendido));

            List<ProductoVendido> prodVendidos = ProductoVendidoBussiness.GetProductosVendidos();
            dgProductosVendidos.DataSource = null;
            dgProductosVendidos.DataSource = prodVendidos;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ProductoVendido prodVendido = new ProductoVendido();
            prodVendido.Id = Convert.ToInt16(txtId.Text);
            prodVendido.Stock = Convert.ToInt16(txtStock.Text);
            prodVendido.IdProducto = Convert.ToInt16(txtIdProducto.Text);
            prodVendido.IdVenta = Convert.ToInt16(txtIdVenta.Text);
            MessageBox.Show(ProductoVendidoBussiness.ModificarProductoVendido(prodVendido));

            List<ProductoVendido> prodVendidos = ProductoVendidoBussiness.GetProductosVendidos();
            dgProductosVendidos.DataSource = null;
            dgProductosVendidos.DataSource = prodVendidos;
        }
        #region placeholderTextbox

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "Ingrese Id Producto Vendido") ;
            {
                txtIdProducto.Text = "";
                txtIdProducto.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtStock_Enter(object sender, EventArgs e)
        {
            if (txtStock.Text == "Ingrese Stock") ;
            {
                txtStock.Text = "";
                txtStock.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtIdProducto_Enter(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == "Ingrese Id Producto") ;
            {
                txtIdProducto.Text = "";
                txtIdProducto.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtIdVenta_Enter(object sender, EventArgs e)
        {
            if (txtIdVenta.Text == "Ingrese Id Venta") ;
            {
                txtIdVenta.Text = "";
                txtIdVenta.ForeColor = SystemColors.WindowText;
            }
        }
        #endregion
    }
}
