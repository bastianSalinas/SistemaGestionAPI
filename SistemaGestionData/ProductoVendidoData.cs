using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class ProductoVendidoData
    {
        #region metodosProductosVendidos
        public static void CrearProductoVendido(ProductoVendido prodVendido)
        {
            string connectionString = AccesoDatos.Conexion();

            string query = "INSERT INTO ProductoVendido (Stock, IdProducto, IdVenta)" +
                " VALUES(@Stock, @IdProducto, @IdVenta); ";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = prodVendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = prodVendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = prodVendido.IdVenta });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public static ProductoVendido obtenerProductoVendido(int idProdVendido)
        {
            var prodVendido = new ProductoVendido();
            string connectionString = AccesoDatos.Conexion();

            string query = "SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido where Id =" + idProdVendido;

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    prodVendido.Id = Convert.ToInt32(dr["Id"]);
                                    prodVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                    prodVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    prodVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                }
                            }
                        }
                    }

                    // Opcional
                    conexion.Close();
                }
                return prodVendido;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void ModificarProductoVendido(ProductoVendido prodVendido)
        {
            string connectionString = AccesoDatos.Conexion();

            string query = "UPDATE ProductoVendido " +
                "SET Stock = @Stock ,IdProducto = @IdProducto, IdVenta = @IdVenta" +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = prodVendido.Id });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = prodVendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = prodVendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = prodVendido.IdVenta });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void EliminarProductoVendido(ProductoVendido prodVendido)
        {
            string connectionString = AccesoDatos.Conexion();

            string query = "DELETE FROM ProductoVendido " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = prodVendido.Id });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();

            string connectionString = AccesoDatos.Conexion();
            string query = "SELECT Id,Stock,IdProducto,IdVenta FROM ProductoVendido";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var prodVendido = new ProductoVendido();
                                    prodVendido.Id = Convert.ToInt32(dr["Id"]);
                                    prodVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                    prodVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    prodVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);

                                    lista.Add(prodVendido);
                                }
                            }
                        }
                    }

                    // Opcional
                    conexion.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}
