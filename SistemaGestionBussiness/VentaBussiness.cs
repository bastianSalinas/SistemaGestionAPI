using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static List<Venta> GetVentas()
        {
            return VentaData.ListarVentas();
        }
        public static String CrearVenta(Venta venta)
        {
            try
            {
                VentaData.CrearVenta(venta);
                return "Venta creada correctamente";
            }
            catch
            {
                return "Error al crear Venta";
            }
        }
        public static String EliminarVenta(Venta venta)
        {
            try
            {
                VentaData.EliminarVenta(venta);
                return "Venta eliminada correctamente";
            }
            catch
            {
                return "Error al eliminar Venta";
            }
        }
        public static String ModificarVenta(Venta venta)
        {
            try
            {
                VentaData.ModificarVenta(venta);
                return "Venta actualizada correctamente";
            }
            catch
            {
                return "Error al actualizar Venta";
            }
        }
    }
}
