using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CierreOrdenApp.Entidades;
using CierreOrdenApp.Servicios;


namespace CierreOrdenApp.Pantallas
{
    public partial class Form1 : Form
    {
        private List<OrdenInspeccion> listaOrdenesInspeccion = new();
        private List<MotivoTipo> listaMotivoFueraServicio = new();
        private OrdenInspeccion ordenInspeccionSelec;
        private string comentario;
        private System.Windows.Forms.Label lblSeleccionOrden;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblMotivos;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.WriteAllText("notificaciones_email.txt", string.Empty);
            File.WriteAllText("historial_cierres.txt", string.Empty);
            File.WriteAllText("publicaciones_CCRS.txt", string.Empty);
            var gestor = new GestorCierreOrdInspeccion();
            listaOrdenesInspeccion = gestor.buscarOrdenInspeccion(MockOrdenes());

            // ✅ Validación A1 - Si no hay órdenes pendientes
            if (listaOrdenesInspeccion.Count == 0)
            {
                MessageBox.Show("No hay órdenes de inspección realizadas para cerrar.", "Aviso");
                this.Close(); // O podés hacer: this.Enabled = false; para bloquear el uso
                return;
            }

            comboOrdenes.Items.Clear();
            comboOrdenes.Items.AddRange(listaOrdenesInspeccion.ToArray());
        }


        private void opCerrarOrdInspeccion(object sender, EventArgs e)
        {
            var gestor = new GestorCierreOrdInspeccion();

            ordenInspeccionSelec = gestor.tomarSelecOrdenInspeccion(listaOrdenesInspeccion, comboOrdenes.SelectedIndex);
            if (ordenInspeccionSelec == null)
            {
                MessageBox.Show("Seleccione una orden de inspección.");
                return;
            }

            var seleccionados = checkedListMotivos.CheckedItems.Cast<string>().ToList();
            if (seleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un motivo.");
                return;
            }



            listaMotivoFueraServicio = new List<MotivoTipo>();

            foreach (string motivo in seleccionados)
            {
                string comentarioIndividual = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Ingrese un comentario para el motivo: {motivo}",
                    "Comentario requerido",
                    ""
                );

                if (string.IsNullOrWhiteSpace(comentarioIndividual))
                {
                    MessageBox.Show($"Debe ingresar un comentario para el motivo '{motivo}'", "Comentario vacío");
                    return;
                }

                listaMotivoFueraServicio.Add(new MotivoTipo
                {
                    Descripcion = motivo,
                    Comentario = comentarioIndividual
                });
            }

            if (string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Debe ingresar una observación general antes de cerrar la orden.", "Observación requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComentario.Focus();
                return;
            }


            bool confirmacion = gestor.tomarConfirmacionCierreOrden(
                MessageBox.Show("¿Confirmar cierre de orden?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes
            );

            if (!confirmacion) return;


            gestor.CerrarOrden(
                ordenInspeccionSelec,
                listaMotivoFueraServicio,
                comentario,
                "Facundo Rueda" // Podrías reemplazar esto por `Sesion.UsuarioActual.Nombre`
            );

            gestor.enviarNotificacionPorMailEmpleados(
                ordenInspeccionSelec.EstacionSismologica.Sismografo,
                listaMotivoFueraServicio,
                "Facundo Rueda"
            );

            MessageBox.Show("Orden cerrada exitosamente.");
            // ✅ Eliminar orden cerrada del combo y refrescar la UI
     
            listaOrdenesInspeccion.Remove(ordenInspeccionSelec);

            comboOrdenes.Items.Clear();
            comboOrdenes.Items.AddRange(listaOrdenesInspeccion.ToArray());
            comboOrdenes.SelectedIndex = -1;


            // Limpiar campos
            checkedListMotivos.ClearSelected();
            txtComentario.Clear();

        }

        private void btnVerMails_Click(object sender, EventArgs e)
        {
            string ruta = "notificaciones_email.txt";

            if (!File.Exists(ruta))
            {
                MessageBox.Show("No hay notificaciones registradas.");
                return;
            }

            string contenido = File.ReadAllText(ruta);
            MessageBox.Show(contenido, "Notificaciones enviadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 💡 Simulación de órdenes para pruebas
        private List<OrdenInspeccion> MockOrdenes()
        {
            return new List<OrdenInspeccion>
    {
        new OrdenInspeccion
        {
            Id = "001",
            FechaHoraFinalizacion = new DateTime(2024, 4, 2),
            EstaCerrada = false,
            EstacionSismologica = new EstacionSismologica
            {
                Nombre = "ES-Salta",
                Sismografo = new Sismografo { IdentificadorSismografo = "S-1002" }
            },
            Responsable = new Empleado { Nombre = "Facundo Rueda", Mail = "facundo@ri.com" }
        },
        new OrdenInspeccion
        {
            Id = "002",
            FechaHoraFinalizacion = new DateTime(2024, 4, 5),
            EstaCerrada = false,
            EstacionSismologica = new EstacionSismologica
            {
                Nombre = "ES-Mendoza",
                Sismografo = new Sismografo { IdentificadorSismografo = "S-1003" }
            },
            Responsable = new Empleado { Nombre = "Facundo Rueda", Mail = "facundo@ri.com" }
        },
        new OrdenInspeccion
        {
            Id = "003",
            FechaHoraFinalizacion = new DateTime(2024, 4, 7),
            EstaCerrada = false,
            EstacionSismologica = new EstacionSismologica
            {
                Nombre = "ES-San Juan",
                Sismografo = new Sismografo { IdentificadorSismografo = "S-1004" }
            },
            Responsable = new Empleado { Nombre = "Facundo Rueda", Mail = "facundo@ri.com" }
        },
        new OrdenInspeccion
        {
            Id = "004",
            FechaHoraFinalizacion = new DateTime(2024, 4, 10),
            EstaCerrada = false,
            EstacionSismologica = new EstacionSismologica
            {
                Nombre = "ES-Jujuy",
                Sismografo = new Sismografo { IdentificadorSismografo = "S-1005" }
            },
            Responsable = new Empleado { Nombre = "Facundo Rueda", Mail = "facundo@ri.com" }
        },
        new OrdenInspeccion
        {
            Id = "005",
            FechaHoraFinalizacion = new DateTime(2024, 4, 12),
            EstaCerrada = false,
            EstacionSismologica = new EstacionSismologica
            {
                Nombre = "ES-Tucumán",
                Sismografo = new Sismografo { IdentificadorSismografo = "S-1006" }
            },
            Responsable = new Empleado { Nombre = "Facundo Rueda", Mail = "facundo@ri.com" }
        }

    };
        }

    }
}


