using CierreOrdenApp.Pantallas;
using System;
using System.Windows.Forms;

namespace CierreOrdenApp
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnCerrarOrden_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Oculta esta pantalla mientras la otra está abierta
        }
    }
}

