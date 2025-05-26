using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class Empleado
    {
        public string apellido { get; set; } = string.Empty;
        public string mail { get; set; } = string.Empty;
        public string nombre { get; set; } = string.Empty;
        public int telefono { get; set; }
        public Rol rol { get; set; } = new Rol();
    }
}
