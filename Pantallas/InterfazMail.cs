using PPAI_DSI_sismo.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PPAI_DSI_sismo.Pantallas
{
    public static class InterfazMail
    {
        public static List<string> mailsEnviados = new List<string>();

        public static void notificarCierre(Sismografo sismografo, DateTime fecha, List<MotivoFueraServicio> motivos, List<Empleado> empleados)
        {
            foreach (var e in empleados)
            {
                if (e.rol.nombre == "Responsable Reparacion")
                {
                    string cuerpo = $"Sismógrafo: {sismografo.nroSerie}\n" +
                                    $"Estado: Fuera de Servicio\n" +
                                    $"Fecha: {fecha}\n" +
                                    $"Motivos: {string.Join(", ", motivos.Select(m => m.TipoMotivo.descripcion + ": " + m.comentario))}";

                    string mail = $"Para: {e.mail}\nAsunto: Sismógrafo fuera de servicio\n{cuerpo}";
                    mailsEnviados.Add(mail); // Asegurate de que esto esté
                    MessageBox.Show("Se agregó mail: " + mail); // Verificás si se ejecuta

                }
            }
        }
    }

}

