using System;
using System.Windows.Forms;
using PPAI_DSI_sismo.Entidades;
using PPAI_DSI_sismo.Gestores;

namespace PPAI_DSI_sismo.Pantallas
{
    public partial class PantallaSeleccionOrdenInspeccion : Form
    {
        private GestorCierreOrdInspeccion gestor;

        public PantallaSeleccionOrdenInspeccion(GestorCierreOrdInspeccion gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void PantallaSeleccionOrdenInspeccion_Load(object sender, EventArgs e)
        {
            gestor.iniciarCU();
            cmbOrdenes.DisplayMember = "DescripcionCompleta";
            cmbOrdenes.ValueMember = "numeroOrden";
            cmbOrdenes.DataSource = gestor.ordenarPorFechaFinalizacion();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (cmbOrdenes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una orden para continuar.");
                return;
            }

            var ordenSeleccionada = (OrdenDeInspeccion)cmbOrdenes.SelectedItem;
            gestor.tomarSelecOrdenInspeccion(ordenSeleccionada); // ← esta es la línea importante
            this.Close();
        }
    }

}