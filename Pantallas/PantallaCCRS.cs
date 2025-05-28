using System;
using System.Windows.Forms;

namespace PPAI_DSI_sismo.Pantallas
{
    public partial class PantallaCCRS : Form
    {
        public PantallaCCRS()
        {
            InitializeComponent();
        }

        public void publicar()
        {
            MessageBox.Show("La orden fue publicada correctamente en el CCRS.", "Publicación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }
    }
}

