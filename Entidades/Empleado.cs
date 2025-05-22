using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace CierreOrdenApp.Entidades
{
    public class Empleado
    {
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Rol Rol { get; set; }

        public bool EsResponsableDeReparacion()
        {
            return Rol != null && Rol.EsRReparacion();
        }


        public string getMail()
        {
            return Mail;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Rol?.DescripcionRol}";
        }
        public static List<Empleado> EmpleadosSistema { get; } = new List<Empleado>
{
    new Empleado { Nombre = "Laura", Mail = "laura@ccrs.com", Rol = new Rol { DescripcionRol = "Reparacion" } },
    new Empleado { Nombre = "Mauro", Mail = "mauro@ccrs.com", Rol = new Rol { DescripcionRol = "Reparacion" } },
    new Empleado { Nombre = "Diego", Mail = "diego@ccrs.com", Rol = new Rol { DescripcionRol = "Logistica" } }
};

    }
}

