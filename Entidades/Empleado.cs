using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class Empleado
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public Rol rol { get; set; }

        public bool esRReparacion()
        {
            return rol.esRReparacion();
        }

        public string getMail()
        {
            return mail;
        }
        public bool esResponsableReparacion()
        {
            return rol != null && rol.nombre == "Responsable Reparacion";
        }

    }
}

