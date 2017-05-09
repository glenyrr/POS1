using System;
using System.Collections.Generic;

namespace POSONE.Model.Entities
{
    public partial class TipoArticulo
    {
        public TipoArticulo()
        {
            Articulo = new HashSet<Articulo>();
        }

        public int TipoArticuloId { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Articulo> Articulo { get; set; }
    }
}
