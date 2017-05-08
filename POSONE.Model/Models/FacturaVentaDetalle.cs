using System;
using System.Collections.Generic;

namespace POSONE.Model.Models
{
    public partial class FacturaVentaDetalle
    {
        public int FacturaDetalleId { get; set; }
        public string Factura { get; set; }
        public string ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public string IsvTipo { get; set; }
        public decimal IsvPorcentaje { get; set; }
        public decimal? Isv { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public decimal TotalProducto { get; set; }
    }
}
