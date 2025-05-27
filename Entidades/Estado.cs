using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class Estado
    {
        public string ambito { get; set; }   
        public string nombreEstado { get; set; }

        public bool esAmbitoOI()
        {
            return ambito == "OrdenInspeccion";
        }

        public bool esCerrada()
        {
            return nombreEstado == "Cerrada";
        }
        public bool esAmbitoSismografo()
        {
            return this.ambito == "Sismografo";
        }

        public bool esFueraDeServicio()
        {
            return this.nombreEstado == "Fuera de Servicio";
        }



    }

}
