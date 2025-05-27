using PPAI_DSI_sismo.Entidades;
using PPAI_DSI_sismo.Gestores;
using PPAI_DSI_sismo.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PPAI_DSI_sismo.Pantallas
{
    public partial class PantallaIngresoObservacionYMotivos : Form
    {
        private readonly OrdenDeInspeccion orden;
        private readonly DataTable dtMotivos = new DataTable();

        public PantallaIngresoObservacionYMotivos(OrdenDeInspeccion ordenSeleccionada)
        {
            InitializeComponent();
            orden = ordenSeleccionada;
            

        }

        private void PantallaIngresoObservacionYMotivos_Load(object sender, EventArgs e)
        {
            cmbMotivos.DisplayMember = "descripcion";
            cmbMotivos.DataSource = new GestorCierreOrdInspeccion().obtenerMotivosFueraDeServicio();

            dtMotivos.Columns.Add("Motivo", typeof(string));
            dtMotivos.Columns.Add("Comentario", typeof(string));
            dgvMotivos.DataSource = dtMotivos;
        }

        private void btnAgregarMotivo_Click(object sender, EventArgs e)
        {
            if (cmbMotivos.SelectedItem == null || string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Seleccione un motivo e ingrese un comentario.");
                return;
            }

            var motivo = (MotivoTipo)cmbMotivos.SelectedItem;
            dtMotivos.Rows.Add(motivo.descripcion, txtComentario.Text.Trim());

            cmbMotivos.SelectedIndex = -1;
            txtComentario.Clear();
        }
        private List<Empleado> listaEmpleados = new List<Empleado>
{
    new Empleado
    {
        nombre = "Carlos",
        apellido = "Gómez",
        mail = "carlos.gomez@empresa.com",
        rol = new Rol { nombre = "Responsable Reparacion" }
    },
    new Empleado
    {
        nombre = "Lucía",
        apellido = "Pérez",
        mail = "lucia.perez@empresa.com",
        rol = new Rol { nombre = "Responsable Reparacion" }
    },
    new Empleado
    {
        nombre = "Sofía",
        apellido = "Martínez",
        mail = "sofia.martinez@empresa.com",
        rol = new Rol { nombre = "Otro Rol" } // Este no debería recibir mail
    }
};


        private void btnCerrarOrden_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrWhiteSpace(txtObservacion.Text))
            {
                MessageBox.Show("Debe ingresar una observación.");
                return;
            }

            List<MotivoFueraServicio> listaMotivos = new List<MotivoFueraServicio>();

            foreach (DataRow row in dtMotivos.Rows)
            {
                listaMotivos.Add(new MotivoFueraServicio
                {
                    TipoMotivo = new MotivoTipo { descripcion = row["Motivo"].ToString() },
                    comentario = row["Comentario"].ToString()
                });
            }

            if (listaMotivos.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un motivo.");
                return;
            }

            string observacion = txtObservacion.Text.Trim();

            List<Estado> estadosSistema = new List<Estado>
    {
        new Estado { ambito = "OrdenInspeccion", nombreEstado = "Cerrada" },
        new Estado { ambito = "OrdenInspeccion", nombreEstado = "En Proceso" },
        new Estado { ambito = "OtraCosa", nombreEstado = "Activo" }
    };
            MessageBox.Show($"Estado ANTES del cierre: {orden.estadoActual?.nombreEstado ?? "Sin estado"}");

            GestorCierreOrdInspeccion gestor = new GestorCierreOrdInspeccion();
            gestor.cerrarOI(orden, observacion, listaMotivos, estadosSistema);

            string resumen = $"Orden cerrada:\nNro: {orden.numeroOrden}\n" +
                             $"Fecha/hora cierre: {orden.fechaHoraCierre}\n" +
                             $"Observación: {orden.observaciones}\n" +
                             $"Estado actual: {orden.estadoActual?.nombreEstado}\n" +
                             $"Motivos:\n";


            foreach (var m in listaMotivos)
            {
                resumen += $"- {m.TipoMotivo.descripcion}: {m.comentario}\n";
            }
            MessageBox.Show($"Estado REAL actual: {orden.estadoActual.nombreEstado}");


            MessageBox.Show(resumen, "Cierre exitoso");
            InterfazMail.notificarCierre(orden.sismografo, orden.fechaHoraCierre, listaMotivos, listaEmpleados);

        }
        private void btnVerMails_Click(object sender, EventArgs e)
        {
            string todosLosMails = string.Join("\n\n", InterfazMail.mailsEnviados);
            MessageBox.Show(todosLosMails, "Mails enviados");
        }







    }
}
