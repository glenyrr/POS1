namespace POSONE.Application.DTOs
{
    public class ArticuloDTO
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionLarga { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string Um { get; set; }
        public string Isv { get; set; }
        public decimal PorcenjateIsv {get;set;}
        public bool IncluyeImpuesto { get; set; }
        public decimal CostoPromedio { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Activo { get; set; }

    }
}