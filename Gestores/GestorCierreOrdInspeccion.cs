using System;
using System.Collections.Generic;
using System.Linq;
using PPAI_DSI_sismo.Entidades;
using PPAI_DSI_sismo.Servicios;


namespace PPAI_DSI_sismo.Gestores
{
    public class GestorCierreOrdInspeccion
    {
        private Sesion sesionActual = new Sesion();

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

        public Usuario getUsuario()
        {
            return sesionActual.usuario;
        }

        public List<OrdenDeInspeccion> buscarOrdInspeccionRI()
        {
            var empleadoActual = getUsuario().getEmpleado();

            return new List<OrdenDeInspeccion>
            {
                new OrdenDeInspeccion
                {
                    numeroOrden = 1,
                    fechaHoraFinalizacion = new DateTime(2025, 5, 8),
                    Responsable = empleadoActual,
                    EstacionSismologica = new EstacionSismologica
                    {
                        nombre = "Ushuaia (Tierra del Fuego)",
                        Sismografo = new Sismografo { nroSerie = 242 }
                    }
                },
                new OrdenDeInspeccion
                {
                    numeroOrden = 2,
                    fechaHoraFinalizacion = new DateTime(2025, 5, 9),
                    Responsable = new Empleado { nombre = "Otro", apellido = "", mail = "", telefono = 0, rol = new Rol() },
                    EstacionSismologica = new EstacionSismologica
                    {
                        nombre = "Paso Flores (Rio Negro)",
                        Sismografo = new Sismografo { nroSerie = 254 }
                    }
                },
                new OrdenDeInspeccion
                {
                    numeroOrden = 3,
                    fechaHoraFinalizacion = new DateTime(2025, 5, 10),
                    Responsable = empleadoActual,
                    EstacionSismologica = new EstacionSismologica
                    {
                        nombre = "San Lorenzo (Salta)",
                        Sismografo = new Sismografo { nroSerie = 332 }
                    }
                },
                new OrdenDeInspeccion
                {
                    numeroOrden = 4,
                    fechaHoraFinalizacion = new DateTime(2025, 5, 11),
                    Responsable = empleadoActual,
                    EstacionSismologica = new EstacionSismologica
                    {
                        nombre = "Humahuaca (Jujuy)",
                        Sismografo = new Sismografo { nroSerie = 410 }
                    }
                }
            };
        }


        public List<OrdenDeInspeccion> ordenarPorFechaFinalizacion()
        {
            var empleadoActual = getUsuario().getEmpleado();
            var todas = buscarOrdInspeccionRI();

            return todas
                .Where(o => o.esDeEmpleado(empleadoActual) && o.esRealizada())
                .OrderByDescending(o => o.fechaHoraFinalizacion)
                .ToList();
        }


        public List<MotivoTipo> obtenerMotivosFueraDeServicio()
        {
            return MotivoTipo.obtenerTodos();
        }

        public DateTime getFechaHoraActual()
        {
            return DateTime.Now;
        }

        public Estado buscarEstadoFueraDeServicio(List<Estado> estados)
        {
            foreach (var estado in estados)
            {
                if (estado.esAmbitoSismografo() && estado.esFueraDeServicio())
                {
                    return estado;
                }
            }

            return null; // no se encontró un estado válido
        }


        public Estado buscarEstadoCerrado(List<Estado> estados)
        {
            foreach (var estado in estados)
            {
                if (estado.esAmbitoOI() && estado.esCerrada())
                {
                    return estado;
                }
            }

            return null; 
        }

        

        public void cerrarOI(OrdenDeInspeccion orden, string observacion, List<MotivoFueraServicio> motivos, List<Estado> estadosSistema)
        {
            Estado estadoCerrado = buscarEstadoCerrado(estadosSistema);

            if (estadoCerrado == null)
            {
                MessageBox.Show("No se encontró un estado 'Cerrado' válido.");
                return;
            }

            orden.cerrarOI(observacion, motivos, estadoCerrado, getFechaHoraActual());
        }

        public void registrarSismografoFueraDeServicio(Sismografo sismografo, Estado estadoFueraServicio, List<MotivoFueraServicio> motivos, Empleado responsable)
        {
            sismografo.sismografoFueraDeServicio(estadoFueraServicio, motivos, getFechaHoraActual(), responsable);
        }

        public void enviarNotificacionPorMailEmpleados(
    Sismografo sismografo,
    DateTime fecha,
    List<MotivoFueraServicio> motivos,
    List<Empleado> empleados)
        {
            InterfazMail.notificarCierre(sismografo, fecha, motivos, empleados);
        }








    }
}


