using System;
using System.Collections.Generic;

namespace POSONE.Model.Models
{
    public partial class TransaccionBono
    {
        public int TransaccionBonoId { get; set; }
        public string Factura { get; set; }
        public int? ClienteFrecuenteId { get; set; }
        public decimal? Bono { get; set; }
        public string TipoTransaccion { get; set; }
    }
}
