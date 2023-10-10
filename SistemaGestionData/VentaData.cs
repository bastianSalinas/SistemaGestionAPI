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
    public static class VentaData
    {
        #region metodosVentas
        public static void CrearVenta(Venta venta)
        {
            string connectionString = AccesoDatos.Conexion();

            string query = "INSERT INTO Venta (Comentarios, IdUsuario)" +
                " VALUES(@Comentarios, @IdUsuario); ";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });

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

        public static Venta obtenerVenta(int idVenta)
        {
            var venta = new Venta();
            string connectionString = AccesoDatos.Conexion();

            string query = "SELECT Id, Comentarios, IdUsuario FROM Venta where Id =" + idVenta;

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
                                    venta.Id = Convert.ToInt32(dr["Id"]);
                                    venta.Comentarios = dr["Comentarios"].ToString();
                                    venta.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                }
                            }
                        }
                    }

                    // Opcional
                    conexion.Close();
                }
                return venta;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void ModificarVenta(Venta venta)
        {
            string connectionString = AccesoDatos.Conexion();
            string query = "UPDATE Venta " +
                "SET Comentarios = @Comentarios ,IdUsuario = @IdUsuario" +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });

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

        public static void EliminarVenta(Venta venta)
        {
            string connectionString = AccesoDatos.Conexion();
            string query = "DELETE FROM Venta " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });

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

        public static List<Venta> ListarVentas()
        {
            List<Venta> lista = new List<Venta>();

            string connectionString = AccesoDatos.Conexion();

            string query = "SELECT Id, Comentarios, IdUsuario FROM Venta";

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
                                    var venta = new Venta();
                                    venta.Id = Convert.ToInt32(dr["Id"]);
                                    venta.Comentarios = dr["Comentarios"].ToString();
                                    venta.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                    lista.Add(venta);
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
