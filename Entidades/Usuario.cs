using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CierreOrdenApp.Entidades
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }

        public Empleado Empleado { get; set; }

        public Usuario(Empleado empleado)
        {
            Empleado = empleado;
            NombreUsuario = empleado.Nombre; 
            Contrasenia = "1234"; 
        }

        public Empleado getEmpleado()
        {
            return Empleado;
        }
    }
}
