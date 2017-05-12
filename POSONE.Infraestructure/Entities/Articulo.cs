using System;
using System.Collections.Generic;

namespace POSONE.Model.Entities
{
    public partial class Articulo
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

        public virtual Categoria Categoria { get; set; }
        public virtual Isv Isv { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Tipo Tipo { get; set; }
        public virtual UnidadMedida Um { get; set; }
    }
}
