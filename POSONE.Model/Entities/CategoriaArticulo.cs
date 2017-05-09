using System;
using System.Collections.Generic;

namespace POSONE.Model.Entities
{
    public partial class CategoriaArticulo
    {
        public CategoriaArticulo()
        {
            Articulo = new HashSet<Articulo>();
        }

        public int CategoriaArticuloId { get; set; }
        public string Categoria { get; set; }

        public virtual ICollection<Articulo> Articulo { get; set; }
    }
}
