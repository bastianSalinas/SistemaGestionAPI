using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionInterface
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();

            #region inicioPlaceholder
                txtIdUsuario.Text = "Ingrese Id Usuario";
                txtIdUsuario.ForeColor = SystemColors.GrayText;
                txtNombre.Text = "Ingrese Nombre";
                txtNombre.ForeColor = SystemColors.GrayText;
                txtApellido.Text = "Ingrese Apellido";
                txtApellido.ForeColor = SystemColors.GrayText;
                txtNombreUsuario.Text = "Ingrese Nombre Usuario";
                txtNombreUsuario.ForeColor = SystemColors.GrayText;
                txtContraseña.Text = "Ingrese Contraseña";
                txtContraseña.ForeColor = SystemColors.GrayText;
                txtMail.Text = "Ingrese Mail";
                txtMail.ForeColor = SystemColors.GrayText;
            #endregion
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuarioBussiness.GetUsuarios();
            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = usuarios;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Mail = txtMail.Text;
            MessageBox.Show(UsuarioBussiness.CrearUsuario(usuario));

            List<Usuario> usuarios = UsuarioBussiness.GetUsuarios();
            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = usuarios;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt16(txtIdUsuario.Text);
            MessageBox.Show(UsuarioBussiness.EliminarUsuario(usuario));

            List<Usuario> usuarios = UsuarioBussiness.GetUsuarios();
            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = usuarios;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt16(txtIdUsuario.Text);
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.Mail = txtMail.Text;
            MessageBox.Show(UsuarioBussiness.ModificarUsuario(usuario));

            List<Usuario> usuarios = UsuarioBussiness.GetUsuarios();
            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = usuarios;
        }

        #region placeholderTextbox

        private void txtIdUsuario_Enter(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "Ingrese Id Usuario") ;
            {
                txtIdUsuario.Text = "";
                txtIdUsuario.ForeColor = SystemColors.WindowText; // Cambia el color del texto al color normal
            }
        }
        private void txtIdUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                txtIdUsuario.Text = "Ingrese Id Usuario";
                txtIdUsuario.ForeColor = SystemColors.GrayText; // Cambia el color del texto a gris
            }
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Ingrese Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = SystemColors.WindowText; // Cambia el color del texto al color normal
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Ingrese Nombre";
                txtNombre.ForeColor = SystemColors.GrayText; // Cambia el color del texto a gris
            }
        }
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Ingrese Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = SystemColors.WindowText; // Cambia el color del texto al color normal
            }
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.Text = "Ingrese Apellido";
                txtApellido.ForeColor = SystemColors.GrayText; // Cambia el color del texto a gris
            }
        }
        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "Ingrese Nombre Usuario")
            {
                txtNombreUsuario.Text = "";
                txtNombreUsuario.ForeColor = SystemColors.WindowText; // Cambia el color del texto al color normal
            }
        }
        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                txtNombreUsuario.Text = "Ingrese Nombre Usuario";
                txtNombreUsuario.ForeColor = SystemColors.GrayText; // Cambia el color del texto a gris
            }
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingrese Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = SystemColors.WindowText; // Cambia el color del texto al color normal
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.Text = "Ingrese Contraseña";
                txtContraseña.ForeColor = SystemColors.GrayText; // Cambia el color del texto a gris
            }
        }
        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Ingrese Mail")
            {
                txtMail.Text = "";
                txtMail.ForeColor = SystemColors.WindowText; // Cambia el color del texto al color normal
            }
        }
        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                txtMail.Text = "Ingrese Mail";
                txtMail.ForeColor = SystemColors.GrayText; // Cambia el color del texto a gris
            }
        }

        #endregion


    }
}