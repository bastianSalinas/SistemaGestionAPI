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
        int idProductoVendido = 0;
        bool editar = false;
        public frmProductosVendidos()
        {
            InitializeComponent();
        }

        private void frmProductosVendidos_Load(object sender, EventArgs e)
        {
            List<ProductoVendido> prodVendido = ProductoVendidoBussiness.GetProductosVendidos();
            dgProductosVendidos.AutoGenerateColumns = true;
            dgProductosVendidos.DataSource = prodVendido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text != "" && txtIdVenta.Text != "" && txtStock.Text != "")
            {
                if (editar == false)
                {
                    ProductoVendido prodVendido = new ProductoVendido();
                    prodVendido.Stock = Convert.ToInt16(txtStock.Text);
                    prodVendido.IdProducto = Convert.ToInt16(txtIdProducto.Text);
                    prodVendido.IdVenta = Convert.ToInt16(txtIdVenta.Text);
                    MessageBox.Show(ProductoVendidoBussiness.CrearProductoVendido(prodVendido));

                    List<ProductoVendido> prodVendidos = ProductoVendidoBussiness.GetProductosVendidos();
                    dgProductosVendidos.DataSource = null;
                    dgProductosVendidos.DataSource = prodVendidos;

                    txtStock.Text = "";
                    txtIdProducto.Text = "";
                    txtIdVenta.Text = "";
                }
                if (editar == true)
                {
                    ProductoVendido prodVendido = new ProductoVendido();
                    prodVendido.Id = idProductoVendido;
                    prodVendido.Stock = Convert.ToInt16(txtStock.Text);
                    prodVendido.IdProducto = Convert.ToInt16(txtIdProducto.Text);
                    prodVendido.IdVenta = Convert.ToInt16(txtIdVenta.Text);
                    MessageBox.Show(ProductoVendidoBussiness.ModificarProductoVendido(prodVendido));
                    txtStock.Text = "";
                    txtIdProducto.Text = "";
                    txtIdVenta.Text = "";
                    List<ProductoVendido> prodVendidos = ProductoVendidoBussiness.GetProductosVendidos();
                    dgProductosVendidos.DataSource = null;
                    dgProductosVendidos.DataSource = prodVendidos;
                }
            }
            else
            {
                MessageBox.Show("Para guardar se deben completar todos los campos");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProductosVendidos.SelectedRows.Count > 0)
            {
                ProductoVendido prodVendido = new ProductoVendido();
                prodVendido.Id = Convert.ToInt16(dgProductosVendidos.CurrentRow.Cells["Id"].Value.ToString());
                MessageBox.Show(ProductoVendidoBussiness.EliminarProductoVendido(prodVendido));

                List<ProductoVendido> prodVendidos = ProductoVendidoBussiness.GetProductosVendidos();
                dgProductosVendidos.DataSource = null;
                dgProductosVendidos.DataSource = prodVendidos;
            }
            else
            {
                MessageBox.Show("Para eliminar se debe seleccionar una linea de la tabla");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgProductosVendidos.SelectedRows.Count > 0)
            {
                editar = true;
                txtStock.Text = dgProductosVendidos.CurrentRow.Cells["Stock"].Value.ToString();
                txtIdProducto.Text = dgProductosVendidos.CurrentRow.Cells["IdProducto"].Value.ToString();
                txtIdVenta.Text = dgProductosVendidos.CurrentRow.Cells["IdVenta"].Value.ToString();
                idProductoVendido = Convert.ToInt16(dgProductosVendidos.CurrentRow.Cells["Id"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Para modificar selecciona una linea de la tabla");
            }
        }

    }
}
