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
        public frmVentas()
        {
            InitializeComponent();

            #region inicioPlaceholder
            txtIdVenta.Text = "Ingrese Id Venta";
            txtIdVenta.ForeColor = SystemColors.GrayText;
            txtComentarios.Text = "Ingrese Comentario";
            txtComentarios.ForeColor = SystemColors.GrayText;
            txtIdUsuario.Text = "Ingrese Id Usuario";
            txtIdUsuario.ForeColor = SystemColors.GrayText;
            #endregion
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            List<Venta> ventas = VentaBussiness.GetVentas();
            dgVentas.AutoGenerateColumns = true;
            dgVentas.DataSource = ventas;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Comentarios = txtComentarios.Text;
            venta.IdUsuario = Convert.ToInt16(txtIdUsuario.Text);
            MessageBox.Show(VentaBussiness.CrearVenta(venta));

            List<Venta> ventas = VentaBussiness.GetVentas();
            dgVentas.DataSource = null;
            dgVentas.DataSource = ventas;

            txtComentarios.Text = "Ingrese Comentario";
            txtComentarios.ForeColor = SystemColors.GrayText;
            txtIdUsuario.Text = "Ingrese Id Usuario";
            txtIdUsuario.ForeColor = SystemColors.GrayText;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Id = Convert.ToInt16(txtIdVenta.Text);
            MessageBox.Show(VentaBussiness.EliminarVenta(venta));

            List<Venta> ventas = VentaBussiness.GetVentas();
            dgVentas.DataSource = null;
            dgVentas.DataSource = ventas;

            txtIdVenta.Text = "Ingrese Id Venta";
            txtIdVenta.ForeColor = SystemColors.GrayText;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Id = Convert.ToInt16(txtIdVenta.Text);
            venta.Comentarios = txtComentarios.Text;
            venta.IdUsuario = Convert.ToInt16(txtIdUsuario.Text);
            MessageBox.Show(VentaBussiness.ModificarVenta(venta));

            List<Venta> ventas = VentaBussiness.GetVentas();
            dgVentas.DataSource = null;
            dgVentas.DataSource = ventas;

            txtIdVenta.Text = "Ingrese Id Venta";
            txtIdVenta.ForeColor = SystemColors.GrayText;
            txtComentarios.Text = "Ingrese Comentario";
            txtComentarios.ForeColor = SystemColors.GrayText;
            txtIdUsuario.Text = "Ingrese Id Usuario";
            txtIdUsuario.ForeColor = SystemColors.GrayText;
        }

        #region placeholderTextbox

        private void txtIdVenta_Enter(object sender, EventArgs e)
        {
            if (txtIdVenta.Text == "Ingrese Id Venta") ;
            {
                txtIdVenta.Text = "";
                txtIdVenta.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtIdVenta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdVenta.Text))
            {
                txtIdVenta.Text = "Ingrese Id Venta";
                txtIdVenta.ForeColor = SystemColors.GrayText;
            }
        }
        private void txtComentario_Enter(object sender, EventArgs e)
        {
            if (txtComentarios.Text == "Ingrese Comentario")
            {
                txtComentarios.Text = "";
                txtComentarios.ForeColor = SystemColors.WindowText;
            }
        }
        private void txtComentario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComentarios.Text))
            {
                txtComentarios.Text = "Ingrese Comentario";
                txtComentarios.ForeColor = SystemColors.GrayText;
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
