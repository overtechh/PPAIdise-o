using PPAI_DSI_sismo.Entidades;
using PPAI_DSI_sismo.Gestores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PPAI_DSI_sismo.Pantallas
{
    public partial class PantallaCierreOrdInspeccion : Form
    {
        private readonly GestorCierreOrdInspeccion gestor;
        private DataTable dtMotivos = new DataTable();

        public PantallaCierreOrdInspeccion(GestorCierreOrdInspeccion gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        // === LOAD INICIAL ===
        private void PantallaCierreOrdInspeccion_Load(object sender, EventArgs e)
        {
            gestor.iniciarCU();

            cmbOrdenes.DisplayMember = "DescripcionCompleta";
            cmbOrdenes.ValueMember = "numeroOrden";
            cmbOrdenes.DataSource = gestor.ordenarPorFechaFinalizacion();

            cmbMotivos.DisplayMember = "descripcion";
            cmbMotivos.DataSource = gestor.obtenerMotivosFueraDeServicio();

            dtMotivos.Columns.Add("Motivo", typeof(string));
            dtMotivos.Columns.Add("Comentario", typeof(string));
            dgvMotivos.DataSource = dtMotivos;
        }

        // === ACCIONES ===
        private void btnAgregarMotivo_Click(object sender, EventArgs e)
        {
            if (cmbMotivos.SelectedItem == null || string.IsNullOrWhiteSpace(txtComentarioCierre.Text))
            {
                MessageBox.Show("Seleccione un motivo e ingrese un comentario.");
                return;
            }

            var motivoSeleccionado = (MotivoTipo)cmbMotivos.SelectedItem;

            gestor.tomarSelecMotivos(motivoSeleccionado);
            gestor.solicitarIngresoComentario(motivoSeleccionado);
            gestor.tomarComentario(motivoSeleccionado, txtComentarioCierre.Text.Trim());

            dtMotivos.Rows.Add(motivoSeleccionado.descripcion, txtComentarioCierre.Text.Trim());

            cmbMotivos.SelectedIndex = -1;
            txtComentarioCierre.Clear();
            cmbMotivos.Focus();
        }

        private void btnCerrarOrden_Click(object sender, EventArgs e)
        {
            if (cmbOrdenes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una orden a cerrar.");
                return;
            }

            var ordenSeleccionada = (OrdenDeInspeccion)cmbOrdenes.SelectedItem;
            gestor.tomarSelecOrdenInspeccion(ordenSeleccionada);

            if (string.IsNullOrWhiteSpace(txtObservacion.Text))
            {
                MessageBox.Show("Debe ingresar una observación.");
                return;
            }
            if (gestor.obtenerMotivosSeleccionados().Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un motivo con su comentario.");
                return;
            }


            gestor.obtenerObservacionDesdePantalla = () => txtObservacion.Text.Trim();
            gestor.solicitarIngresoObservacion();
            gestor.tomarObservacion(txtObservacion.Text.Trim());
            gestor.solicitarConfirmacionCierreOrden();

            // Limpiar pantalla y cerrar
            txtObservacion.Clear();
            dtMotivos.Rows.Clear();
            gestor.obtenerMotivosSeleccionados().Clear();

            actualizarComboOrdenes();
            this.Close();
        }

        private void btnVerMails_Click(object sender, EventArgs e)
        {
            gestor.mostrarMailsEnviados();
        }

        // === HELPER ===
        private void actualizarComboOrdenes()
        {
            var ordenesActualizadas = gestor.ordenarPorFechaFinalizacion();
            cmbOrdenes.DataSource = null;
            cmbOrdenes.DataSource = ordenesActualizadas;
            cmbOrdenes.DisplayMember = "DescripcionCompleta";
            cmbOrdenes.ValueMember = "numeroOrden";
        }
    }
}


