﻿using System;
using System.Collections.Generic;

namespace POSONE.Model.Entities
{
    public partial class Isv
    {
        public Isv()
        {
            Articulo = new HashSet<Articulo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal? IsvPorcentaje { get; set; }

        public virtual ICollection<Articulo> Articulo { get; set; }
    }
}
