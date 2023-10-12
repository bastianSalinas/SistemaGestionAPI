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
    public partial class frmVentas : Form
    {
        int idVenta = 0;
        bool editar = false;
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            List<Venta> ventas = VentaBussiness.GetVentas();
            dgVentas.AutoGenerateColumns = true;
            dgVentas.DataSource = ventas;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtComentarios.Text != "" && txtIdUsuario.Text != "")
            {
                if (editar == false)
                {
                    Venta venta = new Venta();
                    venta.Comentarios = txtComentarios.Text;
                    venta.IdUsuario = Convert.ToInt16(txtIdUsuario.Text);
                    MessageBox.Show(VentaBussiness.CrearVenta(venta));

                    txtComentarios.Text = "";
                    txtIdUsuario.Text = "";

                    List<Venta> ventas = VentaBussiness.GetVentas();
                    dgVentas.DataSource = null;
                    dgVentas.DataSource = ventas;
                }
                if (editar == true)
                {
                    Venta venta = new Venta();
                    venta.Id = idVenta;
                    venta.Comentarios = txtComentarios.Text;
                    venta.IdUsuario = Convert.ToInt16(txtIdUsuario.Text);
                    MessageBox.Show(VentaBussiness.ModificarVenta(venta));

                    txtComentarios.Text = "";
                    txtIdUsuario.Text = "";

                    List<Venta> ventas = VentaBussiness.GetVentas();
                    dgVentas.DataSource = null;
                    dgVentas.DataSource = ventas;
                }
            }
            else
            {
                MessageBox.Show("Para guardar se deben completar todos los campos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgVentas.SelectedRows.Count > 0)
            {
                Venta venta = new Venta();
                venta.Id = Convert.ToInt16(dgVentas.CurrentRow.Cells["Id"].Value.ToString());
                MessageBox.Show(VentaBussiness.EliminarVenta(venta));

                List<Venta> ventas = VentaBussiness.GetVentas();
                dgVentas.DataSource = null;
                dgVentas.DataSource = ventas;
            }
            else
            {
                MessageBox.Show("Para eliminar se debe seleccionar una linea de la tabla");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgVentas.SelectedRows.Count > 0)
            {
                editar = true;
                txtComentarios.Text = dgVentas.CurrentRow.Cells["Comentarios"].Value.ToString();
                txtIdUsuario.Text = dgVentas.CurrentRow.Cells["IdUsuario"].Value.ToString();
                idVenta = Convert.ToInt16(dgVentas.CurrentRow.Cells["Id"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Para modificar selecciona una linea de la tabla");
            }

        }
    }
}
