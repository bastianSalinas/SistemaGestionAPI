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
        int idProducto = 0;
        bool editar = false;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            List<Producto> productos = ProductoBussiness.GetProductos();
            dgProductos.AutoGenerateColumns = true;
            dgProductos.DataSource = productos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtDescripcion.Text != "" && txtCosto.Text != "" && txtPrecioVenta.Text != "" && txtStock.Text !="" && txtIdUsuario.Text !="")
            {
                if (editar == false)
                {
                    Producto prod = new Producto();
                    prod.Descripciones = txtDescripcion.Text;
                    prod.Costo = Convert.ToDecimal(txtCosto.Text);
                    prod.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    prod.Stock = Convert.ToDecimal(txtStock.Text);
                    prod.IdUsuario = Convert.ToInt16(txtIdUsuario.Text);
                    MessageBox.Show(ProductoBussiness.CrearProducto(prod));

                    txtDescripcion.Text = "";
                    txtCosto.Text = "";
                    txtPrecioVenta.Text = "";
                    txtStock.Text = "";
                    txtIdUsuario.Text = "";

                    List<Producto> productos = ProductoBussiness.GetProductos();
                    dgProductos.DataSource = null;
                    dgProductos.DataSource = productos;
                }
                if (editar == true)
                {
                    Producto prod = new Producto();
                    prod.Id = idProducto;
                    prod.Descripciones = txtDescripcion.Text;
                    prod.Costo = Convert.ToDecimal(txtCosto.Text);
                    prod.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    prod.Stock = Convert.ToDecimal(txtStock.Text);
                    prod.IdUsuario = Convert.ToInt16(txtIdUsuario.Text);
                    MessageBox.Show(ProductoBussiness.ModificarProducto(prod));
                    txtDescripcion.Text = "";
                    txtCosto.Text = "";
                    txtPrecioVenta.Text = "";
                    txtStock.Text = "";
                    txtIdUsuario.Text = "";
                    List<Producto> productos = ProductoBussiness.GetProductos();
                    dgProductos.DataSource = null;
                    dgProductos.DataSource = productos;
                }
            }
            else
            {
                MessageBox.Show("Para guardar se deben completar todos los campos");
            }     
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            if (dgProductos.SelectedRows.Count > 0)
            {
                prod.Id = Convert.ToInt16(dgProductos.CurrentRow.Cells["Id"].Value.ToString());
                MessageBox.Show(ProductoBussiness.EliminarProducto(prod));
                List<Producto> productos = ProductoBussiness.GetProductos();
                dgProductos.DataSource = null;
                dgProductos.DataSource = productos;
            }
            else
            {
                MessageBox.Show("Para eliminar seleccione el producto de la tabla");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count > 0)
            {
                editar = true;
                txtDescripcion.Text = dgProductos.CurrentRow.Cells["Descripciones"].Value.ToString();
                txtCosto.Text = dgProductos.CurrentRow.Cells["Costo"].Value.ToString();
                txtPrecioVenta.Text = dgProductos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                txtStock.Text = dgProductos.CurrentRow.Cells["Stock"].Value.ToString();
                txtIdUsuario.Text = dgProductos.CurrentRow.Cells["IdUsuario"].Value.ToString();
                idProducto = Convert.ToInt16(dgProductos.CurrentRow.Cells["Id"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Para modificar selecciona una linea de la tabla");
            }
        }
    }
}
