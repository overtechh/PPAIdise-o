using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class Rol
    {
        public string descripcionRol { get; set; }
        public string nombre { get; set; }

        public bool esRReparacion()
        {
            return nombre == "Responsable Reparacion";
        }
    }
}

