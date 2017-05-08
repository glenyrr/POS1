using System;
using System.Collections.Generic;

namespace POSONE.Model.Models
{
    public partial class Correlativos
    {
        public int Id { get; set; }
        public string Caja { get; set; }
        public string Documento { get; set; }
        public string KeyId { get; set; }
        public string Prefijo { get; set; }
        public int? DigitosCorrelativo { get; set; }
        public int? NextCorrelativo { get; set; }
        public int? CorrelativoInicio { get; set; }
        public int? CorrelativoFinal { get; set; }
        public DateTime? FechaValido { get; set; }
    }
}
