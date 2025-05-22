using System;
using System.Collections.Generic;
using System.Linq;

namespace CierreOrdenApp.Entidades
{
    public class CambioDeEstado
    {
        public DateTime FechaHoraFin { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public List<MotivoTipo> MotivoFueraDeServicio { get; set; } = new();

        public CambioDeEstado() { }

        public bool esActual()
        {
            return FechaHoraFin == DateTime.MinValue;
        }

        public void finalizar()
        {
            FechaHoraFin = DateTime.Now;
        }

        public void crearMotivoFueraDeServicio(List<string> descripciones)
        {
            foreach (var descripcion in descripciones)
            {
                MotivoTipo nuevoMotivo = new MotivoTipo(descripcion);
                MotivoFueraDeServicio.Add(nuevoMotivo);
            }
        }
    }
}

