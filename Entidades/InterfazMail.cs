using PPAI_DSI_sismo.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PPAI_DSI_sismo.Servicios
{
    public static class InterfazMail
    {
        public static List<string> mailsEnviados = new List<string>();

        public static void notificarCierre(
            Sismografo sismografo,
            DateTime fecha,
            List<MotivoFueraServicio> motivos,
            List<Empleado> empleados)
        {
            foreach (var empleado in empleados)
            {
                if (empleado.esRReparacion())
                {
                    string mail = empleado.getMail();
                    string mensaje = $"Sismógrafo: {sismografo.getIdentificadorSismografo()}, Estado: Fuera de Servicio\n" +
                                     $"Fecha y hora: {fecha}\n" +
                                     "Motivos:\n" +
                                     string.Join("\n", motivos.Select(m => $"- {m.TipoMotivo.descripcion}: {m.comentario}"));

                    mailsEnviados.Add($"A {mail}:\n{mensaje}");
                }
            }
        }
    }
}

