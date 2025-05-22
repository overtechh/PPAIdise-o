using CierreOrdenApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CierreOrdenApp.Notificaciones
{
    public static class PantallaCCRS
    {
        public static void Publicar(string idSismografo, string estado, DateTime fechaHora, List<MotivoTipo> motivos, string responsable)
        {
            string mensaje = $"📢 Sismógrafo: {idSismografo}\n" +
                             $"Estado: {estado}\n" +
                             $"Fecha y hora: {fechaHora:dd/MM/yyyy HH:mm:ss}\n" +
                             $"Motivos:\n  - {string.Join("\n  - ", motivos)}\n" +
                             $"Responsable: {responsable}\n\n";

            File.AppendAllText("publicaciones_CCRS.txt", mensaje + "------------------------\n");
        }
    }
}

