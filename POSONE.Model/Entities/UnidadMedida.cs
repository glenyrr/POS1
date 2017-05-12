using System;
using System.Collections.Generic;

namespace POSONE.Model.Entities
{
    public partial class UnidadMedida
    {
        public UnidadMedida()
        {
            Articulo = new HashSet<Articulo>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Articulo> Articulo { get; set; }
    }
}
