﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Entidades
{
    public class Notas
    {
        public int Id { get; set; }
        public int IdAulmno { get; set; }
        public int IdCurso { get; set; }
        public decimal Eva1 { get; set; }
        public decimal Parcial { get; set; }
        public decimal Eva2 { get; set; }
        public decimal Final { get; set; }
    }
}
