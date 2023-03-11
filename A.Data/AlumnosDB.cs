using A.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Data
{
    public class AlumnosDB
    {
        public List<Alumnos> Listar()
        {
            var listado = new List<Alumnos>();

            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Alumnos", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Alumnos alumnos;
                            while (lector.Read())
                            {
                                alumnos = new Alumnos()
                                {
                                    Id = int.Parse(lector["Id"].ToString()),
                                    //Codigo = lector["Codigo"].ToString(),
                                    Apellidos = lector["Apellidos"].ToString(),
                                    Nombres = lector["Nombres"].ToString(),
                                    Direccion = lector["Direccion"].ToString(),
                                    Email = lector["Email"].ToString()
                                };
                                listado.Add(alumnos);
                            }
                        }
                    }
                }
            }
            return listado;
        }
    }
}
