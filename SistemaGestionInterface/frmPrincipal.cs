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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelCuerpo.Controls.Count > 0)
                this.panelCuerpo.Controls.RemoveAt(0);
            Form fh = (Form)Formhijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCuerpo.Controls.Add(fh);
            this.panelCuerpo.Tag = fh;
            fh.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmProductos());
        }

        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmProductosVendidos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmVentas());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmUsuarios());
        }
    }
}
