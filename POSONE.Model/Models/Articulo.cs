using System;
using System.Collections.Generic;

namespace POSONE.Model.Models
{
    public partial class Articulo
    {
        public string ArticuloId { get; set; }
        public decimal Cantidad { get; set; }
        public string Categoria { get; set; }
        public decimal Costo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal? Precio1 { get; set; }
        public string TipoArticulo { get; set; }
        public string IsvTipo { get; set; }
        public int? Isvincluido { get; set; }
        public decimal? CantidadMayoreo { get; set; }
        public bool? Descontinuado { get; set; }
    }
}
