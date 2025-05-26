using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    internal class CambioDeEstado
    {
        public DateTime fechaHoraFin { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public string motivoFueraDeServicio { get; set; } = string.Empty;
        public MotivoTipo motivoFueraDeServicioObj { get; set; } = new MotivoTipo(); 
    }

}
