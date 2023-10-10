using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> GetUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }

        public static String CrearUsuario(Usuario usuario)
        {
            try
            {
                UsuarioData.CrearUsuario(usuario);
                return "Usuario creado correctamente";
            }
            catch
            {
                return "Error al crear Usuario";
            }
           
        }
        public static String EliminarUsuario(Usuario usuario)
        {
            try
            {
                UsuarioData.EliminarUsuario(usuario);
                return "Usuario eliminado correctamente";
            }
            catch
            {
                return "Error al eliminar Usuario";
            }
        }
        public static String ModificarUsuario(Usuario usuario)
        {
            try
            {
                UsuarioData.ModificarUsuario(usuario);
                return "Usuario actualizado correctamente";
            }
            catch
            {
                return "Error al actualizar Usuario";
            }

        }
    }
}
