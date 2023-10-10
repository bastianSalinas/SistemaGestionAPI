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
        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBussiness.GetUsuarios()
            .ToArray();
        }

        [HttpPost(Name = "CrearUsuarios")]
        public void Crear([FromBody] Usuario usu)
        {
            UsuarioBussiness.CrearUsuario(usu);
        }

        [HttpPut(Name = "ModificarUsuarios")]
        public void Actualizar([FromBody] Usuario usu)
        {
            UsuarioBussiness.ModificarUsuario(usu);
        }

        [HttpDelete(Name = "EliminarUsuarios")]
        public void Eliminar([FromBody] Usuario usu)
        {
            UsuarioBussiness.EliminarUsuario(usu);
        }
    }
}
