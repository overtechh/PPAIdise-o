using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class Usuario
    {
        public string contraseña { get; set; } = string.Empty;
        public string nombreUsuario { get; set; } = string.Empty;

        public Empleado Empleado { get; set; } = new Empleado();

        public Empleado getEmpleado()
        {
            return Empleado;
        }
    }
}
