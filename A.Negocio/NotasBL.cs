using A.Entidades;
using A.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Negocio
{
    public class NotasBL
    {
        public static List<Notas> Listar()
        {
            var notasDB = new NotasDB();
            return notasDB.Listar();
        }

        public static bool Insertar(Notas notas)
        {
            var clienteDB = new NotasDB();
            return clienteDB.Insertar(notas) > 0;
        }
    }
}
