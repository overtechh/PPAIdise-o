namespace PPAI_DSI_sismo.Pantallas
{
    partial class PantallaIngresoObservacionYMotivos
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
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.cmbMotivos = new System.Windows.Forms.ComboBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnAgregarMotivo = new System.Windows.Forms.Button();
            this.dgvMotivos = new System.Windows.Forms.DataGridView();
            this.btncerrarOI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(30, 20);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(108, 13);
            this.lblObservacion.TabIndex = 0;
            this.lblObservacion.Text = "Observaciones:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(30, 40);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(500, 60);
            this.txtObservacion.TabIndex = 1;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(30, 120);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(45, 13);
            this.lblMotivo.TabIndex = 2;
            this.lblMotivo.Text = "Motivo:";
            // 
            // cmbMotivos
            // 
            this.cmbMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivos.FormattingEnabled = true;
            this.cmbMotivos.Location = new System.Drawing.Point(90, 117);
            this.cmbMotivos.Name = "cmbMotivos";
            this.cmbMotivos.Size = new System.Drawing.Size(180, 21);
            this.cmbMotivos.TabIndex = 3;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(290, 120);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(66, 13);
            this.lblComentario.TabIndex = 4;
            this.lblComentario.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(360, 117);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(170, 20);
            this.txtComentario.TabIndex = 5;
            // 
            // btnAgregarMotivo
            // 
            this.btnAgregarMotivo.Location = new System.Drawing.Point(390, 150);
            this.btnAgregarMotivo.Name = "btnAgregarMotivo";
            this.btnAgregarMotivo.Size = new System.Drawing.Size(140, 25);
            this.btnAgregarMotivo.TabIndex = 6;
            this.btnAgregarMotivo.Text = "Agregar motivo";
            this.btnAgregarMotivo.UseVisualStyleBackColor = true;
            this.btnAgregarMotivo.Click += new System.EventHandler(this.btnAgregarMotivo_Click);
            // 
            // dgvMotivos
            // 
            this.dgvMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotivos.Location = new System.Drawing.Point(30, 190);
            this.dgvMotivos.Name = "dgvMotivos";
            this.dgvMotivos.Size = new System.Drawing.Size(500, 150);
            this.dgvMotivos.TabIndex = 7;
            // 
            // btnCerrarOrden
            // 
            this.btncerrarOI.Location = new System.Drawing.Point(400, 360);
            this.btncerrarOI.Name = "btnCerrarOrden";
            this.btncerrarOI.Size = new System.Drawing.Size(130, 30);
            this.btncerrarOI.TabIndex = 8;
            this.btncerrarOI.Text = "Cerrar orden";
            this.btncerrarOI.UseVisualStyleBackColor = true;
            this.btncerrarOI.Click += new System.EventHandler(this.btnCerrarOrden_Click);
            // 
            // PantallaIngresoObservacionYMotivos
            // 
            this.ClientSize = new System.Drawing.Size(564, 411);
            this.Controls.Add(this.btncerrarOI);
            this.Controls.Add(this.dgvMotivos);
            this.Controls.Add(this.btnAgregarMotivo);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.cmbMotivos);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblObservacion);
            this.Name = "PantallaIngresoObservacionYMotivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observación y motivos";
            this.Load += new System.EventHandler(this.PantallaIngresoObservacionYMotivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.ComboBox cmbMotivos;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnAgregarMotivo;
        private System.Windows.Forms.DataGridView dgvMotivos;
        private System.Windows.Forms.Button btncerrarOI;
    }
}

