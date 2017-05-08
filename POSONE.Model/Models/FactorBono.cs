using System;
using System.Collections.Generic;

namespace POSONE.Model.Models
{
    public partial class FactorBono
    {
        public int BonoId { get; set; }
        public string Bono { get; set; }
        public decimal? FactorConversion { get; set; }
        public decimal? MontoRetirable { get; set; }
    }
}
