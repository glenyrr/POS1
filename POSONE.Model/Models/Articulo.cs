using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POSONE.Model.Models
{
    public partial class Articulo
    {
        [Display(Name = "Articulo Id")]
        public string ArticuloId { get; set; }
        public decimal Cantidad { get; set; }
        public string Categoria { get; set; }
        public decimal Costo { get; set; }
        public string Descripcion { get; set; }
       
        [Display(Name = "Precio Mayorista")]
        public decimal Precio { get; set; }
       
        [Display(Name = "Precio Detalle")] 
        public decimal? Precio1 { get; set; }

        [Display(Name = "Tipo")] 
        public string TipoArticulo { get; set; }
        [Display(Name = "Impuesto Tipo")] 
        public string IsvTipo { get; set; }
      
       [Display(Name = "Es Impuesto Incluido")] 
        public int? Isvincluido { get; set; }

         [Display(Name = "Cantidad Mayoreo")] 
        public decimal? CantidadMayoreo { get; set; }
        public bool? Descontinuado { get; set; }
    }
}
