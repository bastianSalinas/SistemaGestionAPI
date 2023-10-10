using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public static class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> GetProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }
        public static String CrearProductoVendido(ProductoVendido prodVendido)
        {
            try
            {
                ProductoVendidoData.CrearProductoVendido(prodVendido);
                return "Producto Vendido creado correctamente";
            }
            catch
            {
                return "Error al crear Producto Vendido";
            }
        }
        public static String EliminarProductoVendido(ProductoVendido prodVendido)
        {
            try
            {
                ProductoVendidoData.EliminarProductoVendido(prodVendido);
                return "Producto Vendido eliminado correctamente";
            }
            catch
            {
                return "Error al eliminar Producto Vendido";
            }
        }
        public static String ModificarProductoVendido(ProductoVendido prodVendido)
        {
            try
            {
                ProductoVendidoData.ModificarProductoVendido(prodVendido);
                return "Producto Vendido actualizado correctamente";
            }
            catch
            {
                return "Error al actualizar Producto Vendido";
            }
        }
    }
}
