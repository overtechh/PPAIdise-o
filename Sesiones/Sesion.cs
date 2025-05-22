using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using CierreOrdenApp.Entidades;

namespace CierreOrdenApp.Sesiones
{
    public static class Sesion
    {
        public static DateTime FechaHoraInicio { get; set; } = DateTime.Now;
        public static DateTime? FechaHoraFin { get; set; }

        public static Usuario UsuarioActual { get; set; }

        public static Usuario getUsuario()
        {
            return UsuarioActual;
        }
    }
}
