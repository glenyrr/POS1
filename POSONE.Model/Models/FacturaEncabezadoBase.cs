using System;
using System.Collections.Generic;

namespace POSONE.Model.Models
{
    public partial class FacturaEncabezadoBase
    {
        public string Factura { get; set; }
        public string TipoFactura { get; set; }
        public string Cliente { get; set; }
        public string RtnCliente { get; set; }
        public string Caja { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public decimal? Efectivo { get; set; }
        public decimal? Cambio { get; set; }
        public int? ClienteFrecuenteId { get; set; }
        public string DesCodigo { get; set; }
        public decimal? DescPorcentaje { get; set; }
        public decimal? Descuento { get; set; }
        public bool? EnCierre { get; set; }
    }
}
