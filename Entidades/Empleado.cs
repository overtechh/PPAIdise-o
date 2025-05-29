using System;
using System.Collections.Generic;
using System.Linq;

namespace PPAI_DSI_sismo.Entidades
{
    public class Empleado
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public Rol rol { get; set; }

        public bool esRReparacion()
        {
            return rol != null && rol.esRReparacion();
        }

        public string getMail()
        {
            return mail;
        }

        // Lista estática de empleados simulada como fuente de datos
        public static List<Empleado> obtenerTodos()
        {
            return new List<Empleado>
            {
                new Empleado
                {
                    nombre = "Carlos",
                    apellido = "Gómez",
                    mail = "carlos.gomez@empresa.com",
                    telefono = 123456789,
                    rol = new Rol { nombre = "Responsable Reparacion" }
                },
                new Empleado
                {
                    nombre = "Lucía",
                    apellido = "Pérez",
                    mail = "lucia.perez@empresa.com",
                    telefono = 987654321,
                    rol = new Rol { nombre = "Responsable Reparacion" }
                },
                new Empleado
                {
                    nombre = "Sofía",
                    apellido = "Martínez",
                    mail = "sofia.martinez@empresa.com",
                    telefono = 555555555,
                    rol = new Rol { nombre = "Otro Rol" }
                }
            };
        }

        // Utilizado por el gestor para filtrar los de reparación
        public static List<Empleado> obtenerResponsablesReparacion()
        {
            return obtenerTodos().Where(e => e.esRReparacion()).ToList();
        }
    }
}


