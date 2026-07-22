using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entInsumos
    {
        public int IdInsumo { get; set; }
        public string NombreInsumo { get; set; }
        public decimal Cantidad { get; set; }
        public bool EstadoInsumos { get; set; }
    }
}
