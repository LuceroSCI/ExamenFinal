using A.Data;
using A.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Negocio
{
    public static class CursosBL
    {
        public static List<Cursos> Listar()
        {
            var CursosBD = new CursosDB();
            return CursosBD.Listar();
        }
    }
}
