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
                                // CREAR UN NUEVO OBJETO ALUMNO
                                alumnos = new Alumnos();
                                alumnos.Id = (int)lector["Id"];
                               // alumnos.Codigo = (int)lector["Codigo"];
                                alumnos.Apellidos = lector["Apellidos"].ToString();
                                alumnos.Nombres = lector["Nombres"].ToString();
                                alumnos.Direccion = lector["Direccion"].ToString();
                                alumnos.Email = lector["Email"].ToString();

                                // AGREGAR EL CLIENTE AL LISTADO
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
