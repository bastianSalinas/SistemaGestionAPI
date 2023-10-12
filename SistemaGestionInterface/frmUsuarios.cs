using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionInterface
{
    public partial class frmUsuarios : Form
    {
        int idUsuario = 0;
        bool editar = false;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuarioBussiness.GetUsuarios();
            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = usuarios;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != "" && txtApellido.Text != "" && txtNombreUsuario.Text != "" && txtContraseña.Text != "" && txtMail.Text !="")
            {
                if (editar == false)
                {
                    Usuario usuario = new Usuario();
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.NombreUsuario = txtNombreUsuario.Text;
                    usuario.Contraseña = txtContraseña.Text;
                    usuario.Mail = txtMail.Text;
                    MessageBox.Show(UsuarioBussiness.CrearUsuario(usuario));

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtNombreUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtMail.Text = "";

                    List<Usuario> usuarios = UsuarioBussiness.GetUsuarios();
                    dgUsuarios.DataSource = null;
                    dgUsuarios.DataSource = usuarios;

                }
                if (editar == true)
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = idUsuario;
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.NombreUsuario = txtNombreUsuario.Text;
                    usuario.Contraseña = txtContraseña.Text;
                    usuario.Mail = txtMail.Text;
                    MessageBox.Show(UsuarioBussiness.ModificarUsuario(usuario));

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtNombreUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtMail.Text = "";

                    List<Usuario> usuarios = UsuarioBussiness.GetUsuarios();
                    dgUsuarios.DataSource = null;
                    dgUsuarios.DataSource = usuarios;
                }
            }
            else
            {
                MessageBox.Show("Para guardar se deben completar todos los campos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count > 0)
            {
                Usuario usuario = new Usuario();
                usuario.Id = Convert.ToInt16(dgUsuarios.CurrentRow.Cells["Id"].Value.ToString());
                MessageBox.Show(UsuarioBussiness.EliminarUsuario(usuario));

                List<Usuario> usuarios = UsuarioBussiness.GetUsuarios();
                dgUsuarios.DataSource = null;
                dgUsuarios.DataSource = usuarios;
            }
            else
            {
                MessageBox.Show("Para eliminar se debe seleccionar una linea de la tabla");
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count > 0)
            {
                editar = true;
                txtNombre.Text = dgUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNombreUsuario.Text = dgUsuarios.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                txtContraseña.Text = dgUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtMail.Text = dgUsuarios.CurrentRow.Cells["Mail"].Value.ToString();
                idUsuario = Convert.ToInt16(dgUsuarios.CurrentRow.Cells["Id"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Para modificar selecciona una linea de la tabla");
            }
        }

        


    }
}