using System;
using System.Collections.Generic;
using System.Linq;

namespace CierreOrdenApp.Entidades
{
    public class Sismografo
    {
        public DateTime FechaAdquisicion { get; set; }
        public string IdentificadorSismografo { get; set; }  // ✅ Ahora es editable
        public string NroSerie { get; set; }

        public List<Estado> HistorialEstados { get; set; } = new();

        public bool esDeEstacionSismologica()
        {
            // Por ahora devolvemos true como placeholder
            return true;
        }

        public string getIdentificadorSismografo()
        {
            return IdentificadorSismografo;
        }

        public bool EsFueraDeServicio()
        {
            return HistorialEstados.LastOrDefault()?.NombreEstado == "Fuera de Servicio";
        }

        public void ActualizarEstado(string tipo, List<MotivoTipo> motivos, string responsable)
        {
            var estado = new Estado
            {
                NombreEstado = tipo,
                Descripcion = string.Join(" | ", motivos.Select(m => m.ToString())),
                Responsable = responsable,
                FechaHora = DateTime.Now
            };

            HistorialEstados.Add(estado);
        }
    }
}


