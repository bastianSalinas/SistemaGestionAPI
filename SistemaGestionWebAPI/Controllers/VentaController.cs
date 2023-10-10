using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVentas")]
        public IEnumerable<Venta> Get()
        {
            return VentaBussiness.GetVentas()
            .ToArray();
        }

        [HttpPost(Name = "CrearVentas")]
        public void Crear([FromBody] Venta ven)
        {
            VentaBussiness.CrearVenta(ven);
        }

        [HttpPut(Name = "ModificarVentas")]
        public void Actualizar([FromBody] Venta ven)
        {
            VentaBussiness.ModificarVenta(ven);
        }

        [HttpDelete(Name = "EliminarVentas")]
        public void Eliminar([FromBody] Venta ven)
        {
            VentaBussiness.EliminarVenta(ven);
        }
    }
}
