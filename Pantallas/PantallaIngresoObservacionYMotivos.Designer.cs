namespace PPAI_DSI_sismo.Pantallas
{
    partial class PantallaIngresoObservacionYMotivos
    {
        private System.ComponentModel.IContainer components = null;

        // Todos los botones declarados correctamente acá
        private System.Windows.Forms.Button btnVerMails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblObservacion = new Label();
            txtObservacion = new TextBox();
            lblMotivo = new Label();
            cmbMotivos = new ComboBox();
            lblComentario = new Label();
            txtComentario = new TextBox();
            btnAgregarMotivo = new Button();
            dgvMotivos = new DataGridView();
            btncerrarOI = new Button();
            btnVerMails = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMotivos).BeginInit();
            SuspendLayout();
            // 
            // lblObservacion
            // 
            lblObservacion.AutoSize = true;
            lblObservacion.Location = new Point(30, 20);
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(87, 15);
            lblObservacion.TabIndex = 0;
            lblObservacion.Text = "Observaciones:";
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(30, 40);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(500, 60);
            txtObservacion.TabIndex = 1;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(30, 120);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(48, 15);
            lblMotivo.TabIndex = 2;
            lblMotivo.Text = "Motivo:";
            // 
            // cmbMotivos
            // 
            cmbMotivos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMotivos.Location = new Point(90, 117);
            cmbMotivos.Name = "cmbMotivos";
            cmbMotivos.Size = new Size(180, 23);
            cmbMotivos.TabIndex = 3;
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Location = new Point(290, 120);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(73, 15);
            lblComentario.TabIndex = 4;
            lblComentario.Text = "Comentario:";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(360, 117);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(170, 23);
            txtComentario.TabIndex = 5;
            // 
            // btnAgregarMotivo
            // 
            btnAgregarMotivo.Location = new Point(390, 150);
            btnAgregarMotivo.Name = "btnAgregarMotivo";
            btnAgregarMotivo.Size = new Size(140, 25);
            btnAgregarMotivo.TabIndex = 6;
            btnAgregarMotivo.Text = "Agregar motivo";
            btnAgregarMotivo.Click += btnAgregarMotivo_Click;
            // 
            // dgvMotivos
            // 
            dgvMotivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMotivos.Location = new Point(30, 190);
            dgvMotivos.Name = "dgvMotivos";
            dgvMotivos.Size = new Size(500, 150);
            dgvMotivos.TabIndex = 7;
            // 
            // btncerrarOI
            // 
            btncerrarOI.Location = new Point(400, 360);
            btncerrarOI.Name = "btncerrarOI";
            btncerrarOI.Size = new Size(130, 30);
            btncerrarOI.TabIndex = 8;
            btncerrarOI.Text = "Cerrar orden";
            btncerrarOI.Click += btnCerrarOrden_Click;
            // 
            // btnVerMails
            // 
            btnVerMails.Location = new Point(30, 360);
            btnVerMails.Name = "btnVerMails";
            btnVerMails.Size = new Size(130, 30);
            btnVerMails.TabIndex = 9;
            btnVerMails.Text = "Ver mails enviados";
            btnVerMails.Click += btnVerMails_Click;
            // 
            // PantallaIngresoObservacionYMotivos
            // 
            ClientSize = new Size(742, 506);
            Controls.Add(lblObservacion);
            Controls.Add(txtObservacion);
            Controls.Add(lblMotivo);
            Controls.Add(cmbMotivos);
            Controls.Add(lblComentario);
            Controls.Add(txtComentario);
            Controls.Add(btnAgregarMotivo);
            Controls.Add(dgvMotivos);
            Controls.Add(btncerrarOI);
            Controls.Add(btnVerMails);
            Name = "PantallaIngresoObservacionYMotivos";
            Text = "Observación y motivos";
            Load += PantallaIngresoObservacionYMotivos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMotivos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Resto de componentes
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

