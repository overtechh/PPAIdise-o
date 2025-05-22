using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace CierreOrdenApp.Entidades
{
    public class EstacionSismologica
    {
        public string CodigoEstacion { get; set; }
        public string DocumentoCertificacionAdq { get; set; }
        public DateTime FechaSolicitudCertificacion { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Nombre { get; set; }
        public string NroCertificacionAdquisicion { get; set; }

        public Sismografo Sismografo { get; set; }

        public string getNombre()
        {
            return Nombre;
        }

        public bool sismografoFueraDeServicio()
        {
            return Sismografo != null && Sismografo.EsFueraDeServicio();
        }
    }
}
