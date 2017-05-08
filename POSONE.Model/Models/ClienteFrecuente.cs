using System;
using System.Collections.Generic;

namespace POSONE.Model.Models
{
    public partial class ClienteFrecuente
    {
        public int ClienteFrecuenteId { get; set; }
        public string Cliente { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
