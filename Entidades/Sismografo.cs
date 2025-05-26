using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class Sismografo
    {
        public DateTime fechaAdquisicion { get; set; }
        public int identificadorSismografo { get; set; }
        public int nroSerie { get; set; }

        public int getIdentificadorSismografo()
        {
            return nroSerie;
        }
    }
}
