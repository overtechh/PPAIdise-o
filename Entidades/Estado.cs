using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CierreOrdenApp.Entidades
{
    public class Estado
    {
        public string Ambito { get; set; }
        public string Descripcion { get; set; }
        public string NombreEstado { get; set; }
        public string Responsable { get; set; }         
        public DateTime FechaHora { get; set; }        

        public bool esRealizada() => NombreEstado == "Realizada";

        public bool esAmbitoOI() => Ambito == "OrdenInspeccion";

        public bool esCerrada() => NombreEstado == "Cerrada";

        public bool esAmbitoSismografo() => Ambito == "Sismografo";

        public bool esFueraDeServicio() => NombreEstado == "Fuera de Servicio";
    }

}

