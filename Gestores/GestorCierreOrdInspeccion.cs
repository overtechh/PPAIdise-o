using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PPAI_DSI_sismo.Entidades;
using PPAI_DSI_sismo.Pantallas;

namespace PPAI_DSI_sismo.Gestores
{
    public class GestorCierreOrdInspeccion
    {
        // === SESIÓN ===
        private Sesion sesionActual = new Sesion();
        private List<Empleado> empleados = new List<Empleado>
        {
            new Empleado { nombre = "Carlos", apellido = "Gómez", mail = "carlos.gomez@empresa.com", rol = new Rol { nombre = "Responsable Reparacion" } },
            new Empleado { nombre = "Lucía", apellido = "Pérez", mail = "lucia.perez@empresa.com", rol = new Rol { nombre = "Responsable Reparacion" } },
            new Empleado { nombre = "Sofía", apellido = "Martínez", mail = "sofia.martinez@empresa.com", rol = new Rol { nombre = "Otro Rol" } }
        };

        public void iniciarCU()
        {
            var usuarioActual = new Usuario
            {
                nombreUsuario = "Usuario",
                contraseña = "1234",
                Empleado = new Empleado
                {
                    nombre = "Responsable 1",
                    apellido = "Apellido",
                    mail = "mail@ejemplo.com",
                    telefono = 12345678,
                    rol = new Rol { nombre = "Inspector", descripcionRol = "Rol de prueba" }
                }
            };

            sesionActual = new Sesion
            {
                fechaHoraInicio = DateTime.Now,
                usuario = usuarioActual
            };
        }

        public Usuario getUsuario() => sesionActual.usuario;

        // === ORDENES ===
        private OrdenDeInspeccion ordenSeleccionada;

        public List<OrdenDeInspeccion> buscarOrdInspeccionRI()
        {
            var empleado = getUsuario().getEmpleado();

            return new List<OrdenDeInspeccion>
            {
                new OrdenDeInspeccion { numeroOrden = 1, fechaHoraFinalizacion = new DateTime(2025, 5, 8), Responsable = empleado, EstacionSismologica = new EstacionSismologica { nombre = "Ushuaia", Sismografo = new Sismografo { nroSerie = 242 } } },
                new OrdenDeInspeccion { numeroOrden = 2, fechaHoraFinalizacion = new DateTime(2025, 5, 9), Responsable = new Empleado(), EstacionSismologica = new EstacionSismologica { nombre = "Paso Flores", Sismografo = new Sismografo { nroSerie = 254 } } },
                new OrdenDeInspeccion { numeroOrden = 3, fechaHoraFinalizacion = new DateTime(2025, 5, 10), Responsable = empleado, EstacionSismologica = new EstacionSismologica { nombre = "San Lorenzo", Sismografo = new Sismografo { nroSerie = 332 } } },
                new OrdenDeInspeccion { numeroOrden = 4, fechaHoraFinalizacion = new DateTime(2025, 5, 11), Responsable = empleado, EstacionSismologica = new EstacionSismologica { nombre = "Humahuaca", Sismografo = new Sismografo { nroSerie = 410 } } }
            };
        }

        public List<OrdenDeInspeccion> ordenarPorFechaFinalizacion()
        {
            var emp = getUsuario().getEmpleado();
            return buscarOrdInspeccionRI()
                .Where(o => o.esDeEmpleado(emp) && o.esRealizada())
                .OrderByDescending(o => o.fechaHoraFinalizacion)
                .ToList();
        }

        public void tomarSelecOrdenInspeccion(OrdenDeInspeccion orden)
        {
            ordenSeleccionada = orden;
            solicitarSelecMotivosFueraServicio();
        }

        public void solicitarSelecOrdenInspeccion()
        {
            var pantalla = new PantallaSeleccionOrdenInspeccion(this);
            pantalla.ShowDialog();
        }

        // === MOTIVOS ===
        private List<MotivoFueraServicio> motivosSeleccionados = new();
        private bool yaMostroPantallaMotivos = false;

        public List<MotivoTipo> obtenerMotivosFueraDeServicio() => MotivoTipo.obtenerTodos();

        public void tomarSelecMotivos(MotivoTipo motivo) { }

        public void solicitarIngresoComentario(MotivoTipo motivo)
        {
            Console.WriteLine($"Esperando comentario para el motivo: {motivo.descripcion}");
        }

        public void tomarComentario(MotivoTipo motivo, string comentario)
        {
            motivosSeleccionados.Add(new MotivoFueraServicio
            {
                TipoMotivo = motivo,
                comentario = comentario
            });
        }

        public List<MotivoFueraServicio> obtenerMotivosSeleccionados() => motivosSeleccionados;

        public void solicitarSelecMotivosFueraServicio()
        {
            if (yaMostroPantallaMotivos) return;
            yaMostroPantallaMotivos = true;
            new PantallaCierreOrdInspeccion(this).ShowDialog();
        }

        // === OBSERVACIÓN ===
        private string observacion;
        public Func<string> obtenerObservacionDesdePantalla;

        public void setObservacion(string obs) => observacion = obs;

        public void solicitarIngresoObservacion()
        {
            if (obtenerObservacionDesdePantalla != null)
                tomarObservacion(obtenerObservacionDesdePantalla());
        }

        public void tomarObservacion(string obs) => setObservacion(obs);

        // === CIERRE ===
        private readonly List<Estado> estadosSistema = new()
        {
            new Estado { ambito = "OrdenInspeccion", nombreEstado = "Cerrada" },
            new Estado { ambito = "OrdenInspeccion", nombreEstado = "En Proceso" }
        };

        public void solicitarConfirmacionCierreOrden()
        {
            if (MessageBox.Show("¿Está seguro de que desea cerrar esta orden?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                tomarConfirmacionCierreOrden();
        }

        public void tomarConfirmacionCierreOrden()
        {
            cerrarOI(ordenSeleccionada, observacion, motivosSeleccionados, estadosSistema);

            var pantallaCCRS = new PantallaCCRS();
            pantallaCCRS.publicar();

            yaMostroPantallaMotivos = false;

            enviarNotificacionPorMailEmpleados(
                ordenSeleccionada.sismografo,
                getFechaHoraActual(),
                motivosSeleccionados,
                empleados
            );

            mostrarMailsEnviados(); // Agregamos esto para que se muestren directamente
            finCU(); // Mostramos mensaje de fin
        }


        public void cerrarOI(OrdenDeInspeccion orden, string observacion, List<MotivoFueraServicio> motivos, List<Estado> estados)
        {
            var estadoCerrado = buscarEstadoCerrado(estados);
            if (estadoCerrado == null)
            {
                MessageBox.Show("No se encontró un estado 'Cerrado' válido.");
                return;
            }

            orden.cerrarOI(observacion, motivos, estadoCerrado, getFechaHoraActual());
        }

        // === ESTADOS ===
        public Estado buscarEstadoFueraDeServicio(List<Estado> estados)
        {
            return estados.FirstOrDefault(e => e.esAmbitoSismografo() && e.esFueraDeServicio());
        }

        public Estado buscarEstadoCerrado(List<Estado> estados)
        {
            var estadoCerrado = estados.FirstOrDefault(e => e.esAmbitoOI() && e.esCerrada());
            MessageBox.Show($"Estado encontrado: {estadoCerrado?.nombreEstado ?? "NINGUNO"}");
            return estadoCerrado;
        }

        // === UTILITARIOS ===
        public DateTime getFechaHoraActual() => DateTime.Now;

        public void finCU()
        {
            MessageBox.Show("Fin del caso de uso.", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // === FUNCIONES EXTRA ===
        public void registrarSismografoFueraDeServicio(Sismografo sismografo, Estado estado, List<MotivoFueraServicio> motivos, Empleado responsable)
        {
            sismografo.sismografoFueraDeServicio(estado, motivos, getFechaHoraActual(), responsable);
        }

        public void enviarNotificacionPorMailEmpleados(Sismografo sismografo, DateTime fecha, List<MotivoFueraServicio> motivos, List<Empleado> empleados)
        {
            InterfazMail.notificarCierre(sismografo, fecha, motivos, empleados);
        }

        public void mostrarMailsEnviados()
        {
            string todosLosMails = string.Join("\n\n", InterfazMail.mailsEnviados);
            MessageBox.Show(todosLosMails, "Mails enviados");
        }
    }
}




