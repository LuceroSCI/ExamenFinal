using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Data
{
    public static class UtilDB
    {
        public static string CadenaConexion()
        {
            string cadenaConexion = @"Server = localhost; DataBase = Academia; User = sa; Password = 1234";

            return cadenaConexion;
        }
    }
}
