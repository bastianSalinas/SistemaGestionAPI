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

        [HttpGet("TraerNombre/{idUsuario}", Name = "TraerNombre")]
        public string GetNombre(int idUsuario)
        {
            string nombre = UsuarioBussiness.TraerNombre(idUsuario);
            return nombre;
        }

        [HttpGet("ValidaLogin", Name = "InicioSesion")]
        public bool ValidaLogin(string nombre, string contraseña)
        {
            bool validar = UsuarioBussiness.InicioSesion(nombre, contraseña);
            return validar;
        }

        [HttpGet("TraerUsuario", Name = "TraerUsuario")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBussiness.GetUsuarios()
            .ToArray();
        }
    }
}
