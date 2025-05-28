using PPAI_DSI_sismo.Gestores;
using PPAI_DSI_sismo.Pantallas;

namespace PPAI_DSI_sismo
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        public void habilitarPantalla()
        {
            var gestor = new GestorCierreOrdInspeccion();
            PantallaSeleccionOrdenInspeccion nuevoForm = new PantallaSeleccionOrdenInspeccion(gestor);
            nuevoForm.ShowDialog();
        }


        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            habilitarPantalla();
        }
    }
}

