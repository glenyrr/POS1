using System;
using System.Collections.Generic;

namespace POSONE.Model.Entities
{
    public partial class FacturaVenta
    {
        public string Factura { get; set; }
        public string FacturaTipo { get; set; }
        public int? ClienteId { get; set; }
        public string Cliente { get; set; }
        public string RtnCliente { get; set; }
        public int CajaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string UsuarioId { get; set; }
        public decimal Recibido { get; set; }
        public decimal Cambio { get; set; }
        public string ClienteFrecuenteId { get; set; }
        public bool EnCierre { get; set; }
    }
}
