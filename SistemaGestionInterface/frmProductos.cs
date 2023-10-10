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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();

            #region inicioPlaceholder
            txtIdProducto.Text = "Ingrese Id Producto";
            txtIdProducto.ForeColor = SystemColors.GrayText;
            txtDescripcion.Text = "Ingrese Descripcion";
            txtDescripcion.ForeColor = SystemColors.GrayText;
            txtIdUsuario.Text = "Ingrese Id Usuario";
            txtIdUsuario.ForeColor = SystemColors.GrayText;
            #endregion
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            List<Producto> productos = ProductoBussiness.GetProductos();
            dgProductos.AutoGenerateColumns = true;
            dgProductos.DataSource = productos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Descripciones = txtDescripcion.Text;
            prod.Costo = txtCosto.Value;
            prod.PrecioVenta = txtPrecioVenta.Value;
            prod.Stock = txtStock.Value;
            prod.IdUsuario = Convert.ToInt16(txtIdUsuario.Text);
            MessageBox.Show(ProductoBussiness.CrearProducto(prod));

            List<Producto> productos = ProductoBussiness.GetProductos();
            dgProductos.DataSource = null;
            dgProductos.DataSource = productos;
            txtDescripcion.Text = "Ingrese Descripcion";
            txtDescripcion.ForeColor = SystemColors.GrayText;
            txtIdUsuario.Text = "Ingrese Id Usuario";
            txtIdUsuario.ForeColor = SystemColors.GrayText;
            txtCosto.Value = 0;
            txtPrecioVenta.Value = 0;
            txtStock.Value = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Id = Convert.ToInt16(txtIdProducto.Text);
            MessageBox.Show(ProductoBussiness.EliminarProducto(prod));

            List<Producto> productos = ProductoBussiness.GetProductos();
            dgProductos.DataSource = null;
            dgProductos.DataSource = productos;
            txtIdProducto.Text = "Ingrese Id Producto";
            txtIdProducto.ForeColor = SystemColors.GrayText;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Id = Convert.ToInt16(txtIdProducto.Text);
            prod.Descripciones = txtDescripcion.Text;
            prod.Costo = txtCosto.Value;
            prod.PrecioVenta = txtPrecioVenta.Value;
            prod.Stock = txtStock.Value;
            prod.IdUsuario = Convert.ToInt16(txtIdUsuario.Text);
            MessageBox.Show(ProductoBussiness.ModificarProducto(prod));

            List<Producto> productos = ProductoBussiness.GetProductos();
            dgProductos.DataSource = null;
            dgProductos.DataSource = productos;
            txtIdProducto.Text = "Ingrese Id Producto";
            txtIdProducto.ForeColor = SystemColors.GrayText;
            txtCosto.Value = 0;
            txtPrecioVenta.Value = 0;
            txtStock.Value = 0;
            txtDescripcion.Text = "Ingrese Descripcion";
            txtDescripcion.ForeColor = SystemColors.GrayText;
            txtIdUsuario.Text = "Ingrese Id Usuario";
            txtIdUsuario.ForeColor = SystemColors.GrayText;
        }

        #region placeholderTextbox

        private void txtIdProducto_Enter(object sender, EventArgs e)
        {
            if (txtIdProducto.Text == "Ingrese Id Producto") ;
            {
                txtIdProducto.Text = "";
                txtIdProducto.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtIdProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                txtIdProducto.Text = "Ingrese Id Venta";
                txtIdProducto.ForeColor = SystemColors.GrayText;
            }
        }
        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Ingrese Descripcion")
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.Text = "Ingrese Descripcion";
                txtDescripcion.ForeColor = SystemColors.GrayText;
            }
        }
        private void txtIdUsuario_Enter(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "Ingrese Id Usuario")
            {
                txtIdUsuario.Text = "";
                txtIdUsuario.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtIdUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                txtIdUsuario.Text = "Ingrese Id Usuario";
                txtIdUsuario.ForeColor = SystemColors.GrayText;
            }
        }

        #endregion
    }
}
