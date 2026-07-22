using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetalleReq
    {
        public int IDDetalle { get; set; }
        public int IDRequerimiento { get; set; }
        public int IDInsumo { get; set; }
        public decimal Cantidad { get; set; }

        public string NombreInsumo { get; set; } 
    }
}
