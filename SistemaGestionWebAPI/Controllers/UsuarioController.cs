using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "TraerUsuario")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBussiness.GetUsuarios()
            .ToArray();
        }

        [HttpPost(Name = "CrearUsuario")]
        public void Crear([FromBody] Usuario usu)
        {
            UsuarioBussiness.CrearUsuario(usu);
        }

        [HttpPut(Name = "ModificarUsuario")]
        public void Actualizar([FromBody] Usuario usu)
        {
            UsuarioBussiness.ModificarUsuario(usu);
        }

        [HttpDelete(Name = "EliminarUsuario")]
        public void Eliminar([FromBody] Usuario usu)
        {
            UsuarioBussiness.EliminarUsuario(usu);
        }
        [HttpDelete(Name = "TraerNombre")]
        public void GetNombre([FromBody] int idUsuario)
        {
            UsuarioBussiness.TraerNombre(idUsuario);
        }

        [HttpDelete(Name = "InicioSesion")]
        public void validaLogin([FromBody] string nombre, string contraseña)
        {
            UsuarioBussiness.InicioSesion(nombre, contraseña);
        }
    }
}
