using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProductos")]
        public IEnumerable<Producto> Get()
        {
            return ProductoBussiness.GetProductos()
            .ToArray();
        }

        [HttpPost(Name = "CrearProductos")]
        public void Crear([FromBody]Producto prod)
        {
            ProductoBussiness.CrearProducto(prod);
        }

        [HttpPut(Name = "ModificarProductos")]
        public void Actualizar([FromBody]Producto prod)
        {
            ProductoBussiness.ModificarProducto(prod);
        }

        [HttpDelete(Name = "EliminarProductos")]
        public void Eliminar([FromBody]Producto prod) 
        {
            ProductoBussiness.EliminarProducto(prod);
        }
    }
}
