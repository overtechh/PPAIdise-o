using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CierreOrdenApp.Entidades
{
    public class Rol
    {
        public string DescripcionRol { get; set; }
        public string Nombre { get; set; }

        public bool EsRReparacion()
        {
            return DescripcionRol == "Reparacion";
        }


        public override string ToString()
        {
            return $"{Nombre} ({DescripcionRol})";
        }
    }
}
