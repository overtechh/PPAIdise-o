namespace PPAI_DSI_sismo.Pantallas
{
    partial class PantallaSeleccionOrdenInspeccion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.cmbOrdenes = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOrdenes
            // 
            this.cmbOrdenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenes.FormattingEnabled = true;
            this.cmbOrdenes.Location = new System.Drawing.Point(30, 40);
            this.cmbOrdenes.Name = "cmbOrdenes";
            this.cmbOrdenes.Size = new System.Drawing.Size(400, 21);
            this.cmbOrdenes.TabIndex = 0;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(330, 80);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 30);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente →";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar orden a inspeccionar:";
            // 
            // PantallaSeleccionOrdenInspeccion
            // 
            this.ClientSize = new System.Drawing.Size(460, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.cmbOrdenes);
            this.Name = "PantallaSeleccionOrdenInspeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar orden";
            this.Load += new System.EventHandler(this.PantallaSeleccionOrdenInspeccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrdenes;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label1;
    }
}

