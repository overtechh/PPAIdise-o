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
            PantallaSeleccionOrdenInspeccion nuevoForm = new PantallaSeleccionOrdenInspeccion();
            nuevoForm.ShowDialog();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            habilitarPantalla();
        }
    }
}

