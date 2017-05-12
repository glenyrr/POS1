namespace POSONE.Application.DTOs
{
    public class ArticuloDTO
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionLarga { get; set; }
        public int Marca { get; set; }
        public int Categoria { get; set; }
        public int Tipo { get; set; }
        public int Um { get; set; }
        public int Isv { get; set; }
        public decimal PorcenjateIsv {get;set;}
        public bool IncluyeImpuesto { get; set; }
        public decimal CostoPromedio { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Activo { get; set; }

    }
}