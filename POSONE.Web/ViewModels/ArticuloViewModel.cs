using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using POSONE.Model.Entities;

namespace POSONE.Web.ViewModels
{
    public class ArticuloViewModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
        
        [Display(Name="Descripcion Larga")]
        public string DescripcionLarga { get; set; }
        
        [Required]
        [Display(Name="Marca Id")]
        public int MarcaId { get; set; }
        
        [Required]
          [Display(Name="Categoria Id")]
        public int CategoriaId { get; set; }
        
        [Required]
        [Display(Name="Tipo Id")]
        public int TipoId { get; set; }
        
        [Required]
        [Display(Name="Unidad Medida")]
        public int Umid { get; set; }

        [Required]
        [Display(Name="ISV")]
        public int IsvId { get; set; }
        
        [Required]
        [Display(Name="Incluye ISV en precio")]
        public bool IncluyeImpuesto { get; set; }
        
        [Required]
        [Display(Name="Costo Promedio")]
        public decimal CostoPromedio { get; set; }
        
        [Required]
        [Display(Name="Precio Venta")]
        public decimal PrecioVenta { get; set; }
        public bool Activo { get; set; }

        public IEnumerable<Categoria> Categorias {get;set;}
        public IEnumerable<Tipo> Tipos {get;set;}

        public IEnumerable<Marca> Marcas {get;set;}
        public IEnumerable<Isv> Isvs {get;set;}

        public IEnumerable<UnidadMedida> UnidadesMedida {get;set;}




    }
}