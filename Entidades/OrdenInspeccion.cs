using System;
using CierreOrdenApp.Entidades;

namespace CierreOrdenApp.Entidades
{
    public class OrdenInspeccion
    {
        public string Id { get; set; }
        public DateTime FechaHoraFinalizacion { get; set; }    // consistencia con diagrama
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraCierre { get; set; }
        public string ObservacionesCierre { get; set; }
        public bool EstaCerrada { get; set; }

        public EstacionSismologica EstacionSismologica { get; set; }
        public Empleado Responsable { get; set; }

        // Relación 1 a 1 con Estado actual
        public Estado EstadoActual { get; set; }

        public bool EsDeEmpleado(Empleado empleado)
        {
            return Responsable?.Mail == empleado?.Mail;
        }

        public bool EsRealizada()
        {
            return !EstaCerrada;
        }

      //  public string ObtenerInfo()
       // {
       //     return $"#{NumeroOrden} - {FechaHoraFinalizacion:dd/MM/yyyy} - {EstacionSismologica.Nombre} - Sismógrafo {EstacionSismologica.Sismografo.IdentificadorSismografo}";
      //  }

        public bool SismografoFueraDeServicio()
        {
            return EstacionSismologica?.Sismografo?.EsFueraDeServicio() ?? false;
        }

        public string ObtenerInfo()
        {
            return $"#{Id} - {FechaHoraFinalizacion:dd/MM/yyyy} - {EstacionSismologica?.Nombre} - Sismógrafo {EstacionSismologica?.Sismografo?.IdentificadorSismografo}";
        }

        public override string ToString()
        {
            return ObtenerInfo();
        }



        // Método para cerrar la orden
        public void Cerrar(
            List<MotivoTipo> motivos,
            string comentario,
            string responsable)
        {
            EstaCerrada = true;
            FechaHoraCierre = DateTime.Now;
            ObservacionesCierre = comentario;

            // También actualizar el estado del sismógrafo
            EstacionSismologica.Sismografo?.ActualizarEstado(
                "Fuera de Servicio",
                motivos,
                responsable
            );
        }
        public DateTime FechaFinalizacion { get; set; }

    }
}




