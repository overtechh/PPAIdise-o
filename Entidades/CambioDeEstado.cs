using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class CambioDeEstado
    {
        public DateTime fechaHoraFin { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public string motivoFueraDeServicio { get; set; } = string.Empty;
        public MotivoTipo motivoFueraDeServicioObj { get; set; } = new MotivoTipo();
        public Estado estado { get; set; }
        public Empleado responsable { get; set; }
        public List<MotivoFueraServicio> Motivos { get; set; } = new List<MotivoFueraServicio>();

        public bool esActual()
        {
            return fechaHoraFin == null;
        }

        public void finalizar()
        {
            fechaHoraFin = DateTime.Now;
        }

        public void crearMotivosFueraServicio(List<MotivoFueraServicio> motivos)
        {
            foreach (var motivo in motivos)
            {
                // Si necesitás crear una nueva instancia por cada motivo, podés hacer:
                var nuevoMotivo = new MotivoFueraServicio
                {
                    TipoMotivo = motivo.TipoMotivo,
                    comentario = motivo.comentario
                };

                Motivos.Add(nuevoMotivo);
            }
        }


    }



}
