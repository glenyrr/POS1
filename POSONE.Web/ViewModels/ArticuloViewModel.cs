using System.Collections.Generic;
using POSONE.Model.Entities;

namespace POSONE.Web.ViewModels
{
    public class ArticuloViewModel
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionLarga { get; set; }
        public int MarcaId { get; set; }
        public int CategoriaId { get; set; }
        public int TipoId { get; set; }
        public int Umid { get; set; }
        public int IsvId { get; set; }
        public bool IncluyeImpuesto { get; set; }
        public decimal CostoPromedio { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Activo { get; set; }

        public IEnumerable<Categoria> Categorias {get;set;}
        public IEnumerable<Tipo> Tipos {get;set;}

        public IEnumerable<Marca> Marcas {get;set;}
        public IEnumerable<Isv> Isvs {get;set;}

        public IEnumerable<UnidadMedida> UnidadesMedida {get;set;}




    }
}