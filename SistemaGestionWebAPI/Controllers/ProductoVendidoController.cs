using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "TraerProductosVendidos")]
        public IEnumerable<ProductoVendido> Get()
        {
            return ProductoVendidoBussiness.GetProductosVendidos()
            .ToArray();
        }

        [HttpPost(Name = "CrearProductosVendidos")]
        public void Crear([FromBody] ProductoVendido prodVendido)
        {
            ProductoVendidoBussiness.CrearProductoVendido(prodVendido);
        }

        [HttpPut(Name = "ModificarProductosVendidos")]
        public void Actualizar([FromBody] ProductoVendido prodVendido)
        {
            ProductoVendidoBussiness.ModificarProductoVendido(prodVendido);
        }

        [HttpDelete(Name = "EliminarProductoVendidos")]
        public void Eliminar([FromBody] ProductoVendido prodVendido)
        {
            ProductoVendidoBussiness.EliminarProductoVendido(prodVendido);
        }
    }
}
