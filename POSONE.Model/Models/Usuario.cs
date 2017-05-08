using System;
using System.Collections.Generic;

namespace POSONE.Model.Models
{
    public partial class Usuario
    {
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Perfil { get; set; }
        public bool? Activo { get; set; }
        public string Clave { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
