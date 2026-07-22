using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMesero
    {
        public int IdMesero { get; set; }
        public string NombreMesero { get; set; }
        public string DNIMesero { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool EstadoMesero { get; set; }
    }
}
