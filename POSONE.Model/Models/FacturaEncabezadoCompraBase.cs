using System;
using System.Collections.Generic;

namespace POSONE.Model.Models
{
    public partial class FacturaEncabezadoCompraBase
    {
        public string Factura { get; set; }
        public string TipoFactura { get; set; }
        public int? ProveedorId { get; set; }
        public string RtnProveedor { get; set; }
        public string Caja { get; set; }
        public DateTime? Fecha { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
    }
}
