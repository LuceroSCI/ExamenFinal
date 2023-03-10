using A.Entidades;
using A.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Negocio
{
    public class AlumnosBL
    {
        public static List<Alumnos> Listar()
        {
            var AlumnosBD = new AlumnosDB();
            return AlumnosBD.Listar();
        }
    }
}
