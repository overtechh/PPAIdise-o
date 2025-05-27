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

        public List<CambioDeEstado> HistorialEstados { get; set; } = new List<CambioDeEstado>();

        public int getIdentificadorSismografo()
        {
            return nroSerie;
        }

        public void sismografoFueraDeServicio(Estado estadoFueraServicio, List<MotivoFueraServicio> motivos, DateTime fecha, Empleado responsable)
        {
            CambioDeEstado actual = HistorialEstados.Find(e => e.esActual());

            if (actual != null)
                actual.finalizar();

            CambioDeEstado nuevo = new CambioDeEstado
            {
                estado = estadoFueraServicio,
                fechaHoraInicio = fecha,
                responsable = responsable
            };

            nuevo.crearMotivosFueraServicio(motivos);

            HistorialEstados.Add(nuevo);
        }
    }
}
