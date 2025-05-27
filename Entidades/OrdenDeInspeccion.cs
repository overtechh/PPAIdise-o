using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class OrdenDeInspeccion
    {
        public Sismografo sismografo => EstacionSismologica?.Sismografo;

        public DateTime fechaHoraCierre { get; set; }
        public DateTime fechaHoraFinalizacion { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public int numeroOrden { get; set; }
        public string observaciones { get; set; }

        public EstacionSismologica EstacionSismologica { get; set; }

        // para mostrar en el comboBox
        public string DescripcionCompleta
        {
            get
            {
                return $"Orden {numeroOrden} - Finaliza {fechaHoraFinalizacion.ToShortDateString()} - Estación {EstacionSismologica?.nombre} - Sismógrafo {EstacionSismologica?.Sismografo?.nroSerie}";
            }
        }



        public string obtenerInfoOI()
        {
            string nombreEstacion = EstacionSismologica?.getNombre() ?? "Sin nombre";
            int nroSismografo = EstacionSismologica?.getSismografo()?.getIdentificadorSismografo() ?? -1;

            return $"Estación: {nombreEstacion} - Sismógrafo: {nroSismografo}";
        }

        public List<MotivoFueraServicio> MotivosCierre { get; set; } = new List<MotivoFueraServicio>();


        public Empleado Responsable { get; set; }

        public bool esDeEmpleado(Empleado empleado)
        {
            return Responsable != null && Responsable.Equals(empleado);
        }

        
        public bool esRealizada()
        {
            return true; 
        }
        public void cerrarOI(string observacion, List<MotivoFueraServicio> motivos, Estado estadoCerrado, DateTime fecha)
        {
            this.observaciones = observacion;
            this.MotivosCierre = motivos;
            this.fechaHoraCierre = fecha;
            this.estadoActual = estadoCerrado;
        }


        public Estado estadoActual { get; set; }



    }
}
