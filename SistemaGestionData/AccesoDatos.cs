using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class AccesoDatos
    {
        public static string Conexion()
        {
            return @"Server=PCBASTIAN;DataBase=SistemaGestion; Trusted_Connection=True";
        }
    }
}
