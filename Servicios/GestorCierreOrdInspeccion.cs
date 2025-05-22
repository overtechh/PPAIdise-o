using CierreOrdenApp.Entidades;
using CierreOrdenApp.Notificaciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CierreOrdenApp.Servicios
{
    public class GestorCierreOrdInspeccion
    {
        public Empleado empleado;
        public List<OrdenInspeccion> listaOrdenInspeccion;
        public OrdenInspeccion ordenInspeccionSelec;
        public List<MotivoTipo> listaMotivoFueraServicio;
        public string comentario;
        public DateTime fechaHoraActual;

        public void opCerrarOrdInspeccion()
        {
            // Punto de entrada principal del caso de uso
        }

        public DateTime getFechaHoraActual()
        {
            return DateTime.Now;
        }

        public List<OrdenInspeccion> buscarOrdenInspeccion(List<OrdenInspeccion> todas)
        {
            return todas
                .Where(o => o.EsRealizada())
                .OrderByDescending(o => o.FechaFinalizacion)
                .ToList();
        }

        public Estado buscarEstadoCerrado(List<Estado> estados)
        {
            return estados.FirstOrDefault(e => e.esCerrada());
        }

        public Estado buscarEstadoFueraServicio(List<Estado> estados)
        {
            return estados.FirstOrDefault(e => e.esFueraDeServicio());
        }

        public List<MotivoTipo> ordenarMotivosFueraServicio(List<MotivoTipo> motivos)
        {
            return motivos.OrderBy(m => m.Descripcion).ToList();
        }

        public List<OrdenInspeccion> ordenarPorFechaFinalizacion(List<OrdenInspeccion> todas)
        {
            return todas
                .Where(o => o.EsRealizada())
                .OrderByDescending(o => o.FechaFinalizacion)
                .ToList();
        }

        public string tomarComentario(string comentario)
        {
            return comentario.Trim();
        }

        public bool tomarConfirmacionCierreOrden(bool confirmacion)
        {
            return confirmacion;
        }

        public List<MotivoTipo> tomarSelecMotivos(List<MotivoTipo> seleccionados)
        {
            return seleccionados;
        }

        public OrdenInspeccion tomarSelecOrdenInspeccion(List<OrdenInspeccion> lista, int index)
        {
            if (index >= 0 && index < lista.Count)
                return lista[index];
            return null;
        }

        public void enviarNotificacionPorMailEmpleados(Sismografo sismografo, List<MotivoTipo> motivos, string responsable)
        {
            string cuerpo = $"[NOTIFICACIÓN - ESTADO FUERA DE SERVICIO]\n" +
                            $"Sismógrafo: {sismografo.IdentificadorSismografo}\n" +
                            $"Estado: Fuera de Servicio\n" +
                            $"Fecha y hora: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n" +
                            $"Motivos y comentarios:\n  - {string.Join("\n  - ", motivos)}\n" +
                            $"Responsable: {responsable}\n";

            var reparadores = Empleado.EmpleadosSistema.Where(e => e.EsResponsableDeReparacion()).ToList();

            if (reparadores.Count == 0)
            {
                File.AppendAllText("notificaciones_email.txt", "⚠️ No hay empleados de reparación para notificar.\n------------------------\n");
                return;
            }

            foreach (var emp in reparadores)
            {
                var mail = $"Para: {emp.Mail}\n{cuerpo}------------------------\n";
                File.AppendAllText("notificaciones_email.txt", mail);
            }

            PantallaCCRS.Publicar(
                sismografo.IdentificadorSismografo,
                "Fuera de Servicio",
                DateTime.Now,
                motivos,
                responsable
            );
        }

        public void CerrarOrden(OrdenInspeccion orden, List<MotivoTipo> motivos, string comentario, string responsable)
        {
            orden.EstaCerrada = true;
            orden.FechaHoraCierre = DateTime.Now;

            orden.EstacionSismologica.Sismografo.ActualizarEstado(
                "Fuera de Servicio",
                motivos,
                responsable
            );
        }

        public void finCU()
        {
            // Finalización del caso de uso si lo necesitás
        }
    }
}


