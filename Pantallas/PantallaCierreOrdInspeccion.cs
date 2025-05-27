using PPAI_DSI_sismo.Entidades;
using PPAI_DSI_sismo.Gestores;
using PPAI_DSI_sismo.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_sismo.Pantallas
{
    public partial class PantallaCierreOrdInspeccion : Form
    {
        public PantallaCierreOrdInspeccion()
        {
            InitializeComponent();
        }


        private void PantallaCierreOrdInspeccion_Load(object sender, EventArgs e)
        {
            

            var gestor = new GestorCierreOrdInspeccion();
            gestor.iniciarCU();



            cmbOrdenes.DisplayMember = "DescripcionCompleta";
            cmbOrdenes.ValueMember = "numeroOrden";

            cmbOrdenes.DataSource = gestor.ordenarPorFechaFinalizacion();




            cmbMotivos.DisplayMember = "Descripcion";
            cmbMotivos.DataSource = gestor.obtenerMotivosFueraDeServicio();


            dtMotivos = new DataTable();
            dtMotivos.Columns.Add("Motivo", typeof(string));
            dtMotivos.Columns.Add("Comentario", typeof(string));

            dgvMotivos.DataSource = dtMotivos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMotivos.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un motivo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComentarioCierre.Text))
            {
                MessageBox.Show("Por favor ingrese un comentario.");
                return;
            }

            var motivoSeleccionado = (MotivoTipo)cmbMotivos.SelectedItem;

            dtMotivos.Rows.Add(motivoSeleccionado.descripcion, txtComentarioCierre.Text.Trim());

            cmbMotivos.SelectedIndex = -1;
            txtComentarioCierre.Clear();
            cmbMotivos.Focus();
        }

        private void buttonCerrarOrden_Click(object sender, EventArgs e)
        {
            opCerrarOrdInspeccion();
        }
        private DataTable dtMotivos { get; set; } = new DataTable();


        private void opCerrarOrdInspeccion()
        {
            var confirmacion = MessageBox.Show("Está seguro de que desea cerrar esta orden?", "Confirmacion", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                if (cmbOrdenes.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una orden a cerrar");
                    return;
                }


                var ordenSeleccionada = (OrdenDeInspeccion)cmbOrdenes.SelectedItem;

                List<MotivoFueraServicio> listaMotivos = new List<MotivoFueraServicio>();

                foreach (DataRow row in dtMotivos.Rows)
                {
                    var motivo = new MotivoFueraServicio
                    {
                        TipoMotivo = new MotivoTipo { descripcion = row["Motivo"].ToString() },
                        comentario = row["Comentario"].ToString()
                    };

                    listaMotivos.Add(motivo);
                }

                if (listaMotivos.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos un motivo");
                    return;
                }
                string observacion = txtObservacion.Text.Trim();
                DateTime fecha = DateTime.Now;

                GestorCierreOrdInspeccion gestor = new GestorCierreOrdInspeccion();

                List<Estado> estadosSistema = new List<Estado>
{
    new Estado { ambito = "OrdenInspeccion", nombreEstado = "Cerrada" },
    new Estado { ambito = "OrdenInspeccion", nombreEstado = "En Proceso" }
};

                Estado estadoCerrado = gestor.buscarEstadoCerrado(estadosSistema);


                ordenSeleccionada.cerrarOI(observacion, listaMotivos, estadoCerrado, fecha);



                string mensaje = $"Orden cerrada. Mail enviado.\n" +
                 $"Número: {ordenSeleccionada.numeroOrden}\n" +
                 $"Fecha y hora de cierre: {ordenSeleccionada.fechaHoraCierre}\n" +
                 $"Observaciones: {ordenSeleccionada.observaciones}\n" +
                 $"Motivos:\n";

                foreach (var motivo in listaMotivos)
                {
                    mensaje += $"- {motivo.TipoMotivo.descripcion}: {motivo.comentario}\n";
                }

                MessageBox.Show(mensaje, "Orden cerrada");


                this.Close();
            }
        }
        private void btnVerMails_Click(object sender, EventArgs e)
        {
            string todosLosMails = string.Join("\n\n", InterfazMail.mailsEnviados);
            MessageBox.Show(todosLosMails, "Mails enviados");
        }


    }
}
