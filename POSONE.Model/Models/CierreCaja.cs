using System;
using System.Collections.Generic;

namespace POSONE.Model.Models
{
    public partial class CierreCaja
    {
        public int CierreCajaId { get; set; }
        public DateTime? Fecha { get; set; }
        public string Comentario { get; set; }
        public string UsuarioId { get; set; }
        public decimal? Debe { get; set; }
        public decimal? Haber { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? FechaCierre { get; set; }
    }
}
