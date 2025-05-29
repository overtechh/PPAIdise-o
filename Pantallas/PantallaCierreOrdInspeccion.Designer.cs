namespace PPAI_DSI_sismo.Pantallas
{
    partial class PantallaCierreOrdInspeccion
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
            this.lblMotivo = new System.Windows.Forms.Label();
            this.cmbMotivos = new System.Windows.Forms.ComboBox();
            this.txtComentarioCierre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvMotivos = new System.Windows.Forms.DataGridView();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttoncerrarOI = new System.Windows.Forms.Button();
            this.btnVerMails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMotivo.Location = new System.Drawing.Point(25, 20);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(126, 19);
            this.lblMotivo.TabIndex = 0;
            this.lblMotivo.Text = "Motivos de cierre:";
            // 
            // cmbMotivos
            // 
            this.cmbMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivos.FormattingEnabled = true;
            this.cmbMotivos.Location = new System.Drawing.Point(25, 50);
            this.cmbMotivos.Name = "cmbMotivos";
            this.cmbMotivos.Size = new System.Drawing.Size(180, 23);
            this.cmbMotivos.TabIndex = 1;
            // 
            // txtComentarioCierre
            // 
            this.txtComentarioCierre.Location = new System.Drawing.Point(220, 50);
            this.txtComentarioCierre.Name = "txtComentarioCierre";
            this.txtComentarioCierre.Size = new System.Drawing.Size(387, 23);
            this.txtComentarioCierre.TabIndex = 2;
            this.txtComentarioCierre.PlaceholderText = "Comentario";
            // 
            // button1 (Agregar motivo)
            // 
            this.button1.Location = new System.Drawing.Point(25, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar motivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAgregarMotivo_Click);
            // 
            // dgvMotivos
            // 
            this.dgvMotivos.AllowUserToAddRows = false;
            this.dgvMotivos.AllowUserToDeleteRows = false;
            this.dgvMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Motivo,
            this.Comentario});
            this.dgvMotivos.Location = new System.Drawing.Point(25, 130);
            this.dgvMotivos.Name = "dgvMotivos";
            this.dgvMotivos.ReadOnly = true;
            this.dgvMotivos.Size = new System.Drawing.Size(582, 150);
            this.dgvMotivos.TabIndex = 4;
            // 
            // Motivo Column
            // 
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 200;
            // 
            // Comentario Column
            // 
            this.Comentario.DataPropertyName = "Comentario";
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Width = 360;
            // 
            // buttoncerrarOI
            // 
            this.buttoncerrarOI.Location = new System.Drawing.Point(499, 300);
            this.buttoncerrarOI.Name = "buttoncerrarOI";
            this.buttoncerrarOI.Size = new System.Drawing.Size(108, 30);
            this.buttoncerrarOI.TabIndex = 5;
            this.buttoncerrarOI.Text = "Cerrar Orden";
            this.buttoncerrarOI.UseVisualStyleBackColor = true;
            this.buttoncerrarOI.Click += new System.EventHandler(this.btnCerrarOrden_Click);
            // 
            // btnVerMails
            // 
            this.btnVerMails.Location = new System.Drawing.Point(25, 300);
            this.btnVerMails.Name = "btnVerMails";
            this.btnVerMails.Size = new System.Drawing.Size(130, 30);
            this.btnVerMails.TabIndex = 6;
            this.btnVerMails.Text = "Ver mails enviados";
            this.btnVerMails.UseVisualStyleBackColor = true;
            this.btnVerMails.Click += new System.EventHandler(this.btnVerMails_Click);
            // 
            // PantallaCierreOrdInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 351);
            this.Controls.Add(this.btnVerMails);
            this.Controls.Add(this.buttoncerrarOI);
            this.Controls.Add(this.dgvMotivos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtComentarioCierre);
            this.Controls.Add(this.cmbMotivos);
            this.Controls.Add(this.lblMotivo);
            this.Name = "PantallaCierreOrdInspeccion";
            this.Text = "Cerrar orden de inspección";
            this.Load += new System.EventHandler(this.PantallaCierreOrdInspeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.ComboBox cmbMotivos;
        private System.Windows.Forms.TextBox txtComentarioCierre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvMotivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.Button buttoncerrarOI;
        private System.Windows.Forms.Button btnVerMails;
    }
}

