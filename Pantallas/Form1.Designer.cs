// Form1.Designer.cs
namespace CierreOrdenApp.Pantallas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox comboOrdenes;
        private System.Windows.Forms.CheckedListBox checkedListMotivos;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnCerrarOrden;
        private System.Windows.Forms.Button btnVerMails;
        


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboOrdenes = new System.Windows.Forms.ComboBox();
            this.checkedListMotivos = new System.Windows.Forms.CheckedListBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnCerrarOrden = new System.Windows.Forms.Button();
            this.btnVerMails = new System.Windows.Forms.Button();
            this.lblSeleccionOrden = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblMotivos = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblSeleccionOrden
            this.lblSeleccionOrden.Text = "Seleccione una orden de inspección:";
            this.lblSeleccionOrden.Location = new System.Drawing.Point(20, 5);
            this.lblSeleccionOrden.Size = new System.Drawing.Size(250, 15);

            // comboOrdenes
            this.comboOrdenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrdenes.FormattingEnabled = true;
            this.comboOrdenes.Location = new System.Drawing.Point(20, 20);
            this.comboOrdenes.Name = "comboOrdenes";
            this.comboOrdenes.Size = new System.Drawing.Size(300, 21);

            // lblObservacion
            this.lblObservacion.Text = "Observación:";
            this.lblObservacion.Location = new System.Drawing.Point(20, 45);
            this.lblObservacion.Size = new System.Drawing.Size(200, 15);

            // txtComentario
            this.txtComentario.Location = new System.Drawing.Point(20, 60);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(300, 20);

            // lblMotivos
            this.lblMotivos.Text = "Motivos de cierre:";
            this.lblMotivos.Location = new System.Drawing.Point(20, 85);
            this.lblMotivos.Size = new System.Drawing.Size(200, 15);

            // checkedListMotivos
            this.checkedListMotivos.FormattingEnabled = true;
            this.checkedListMotivos.Items.AddRange(new object[] {
        "Falla técnica",
        "Mantenimiento",
        "Sin energía",
        "Otro"});
            this.checkedListMotivos.Location = new System.Drawing.Point(20, 100);
            this.checkedListMotivos.Name = "checkedListMotivos";
            this.checkedListMotivos.Size = new System.Drawing.Size(300, 64);

            // btnCerrarOrden
            this.btnCerrarOrden.Location = new System.Drawing.Point(20, 180);
            this.btnCerrarOrden.Name = "btnCerrarOrden";
            this.btnCerrarOrden.Size = new System.Drawing.Size(300, 30);
            this.btnCerrarOrden.TabIndex = 0;
            this.btnCerrarOrden.Text = "Cerrar Orden";
            this.btnCerrarOrden.UseVisualStyleBackColor = true;
            this.btnCerrarOrden.Click += new System.EventHandler(this.opCerrarOrdInspeccion);

            // btnVerMails
            this.btnVerMails.Location = new System.Drawing.Point(20, 220);
            this.btnVerMails.Name = "btnVerMails";
            this.btnVerMails.Size = new System.Drawing.Size(300, 30);
            this.btnVerMails.TabIndex = 1;
            this.btnVerMails.Text = "Ver mails enviados";
            this.btnVerMails.UseVisualStyleBackColor = true;
            this.btnVerMails.Click += new System.EventHandler(this.btnVerMails_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(344, 271);
            this.Controls.Add(this.lblSeleccionOrden);
            this.Controls.Add(this.comboOrdenes);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.lblMotivos);
            this.Controls.Add(this.checkedListMotivos);
            this.Controls.Add(this.btnCerrarOrden);
            this.Controls.Add(this.btnVerMails);
            this.Name = "Form1";
            this.Text = "Pantalla de Cierre de Orden de Inspección";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion
    }
}




