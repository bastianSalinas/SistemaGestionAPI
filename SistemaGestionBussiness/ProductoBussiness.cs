using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static List<Producto> GetProductos()
        {
            return ProductoData.ListarProductos();
        }
        public static String CrearProducto(Producto producto)
        {
            try
            {
                ProductoData.CrearProducto(producto);
                return "Producto creado correctamente";
            }
            catch
            {
                return "Error al crear Producto";
            }
        }
        public static String EliminarProducto(Producto producto)
        {
            try
            {
                ProductoData.EliminarProducto(producto);
                return "Producto eliminado correctamente";
            }
            catch
            {
                return "Error al eliminar Producto";
            }
        }
        public static String ModificarProducto(Producto producto)
        {
            try
            {
                ProductoData.ModificarProducto(producto);
                return "Producto actualizado correctamente";
            }
            catch
            {
                return "Error al actualizar Producto";
            }
        }
    }
}

