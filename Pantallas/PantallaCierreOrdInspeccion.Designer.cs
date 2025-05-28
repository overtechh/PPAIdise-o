namespace PPAI_DSI_sismo.Pantallas
{
    partial class PantallaCierreOrdInspeccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbOrdenes = new ComboBox();
            txtObservacion = new TextBox();
            label2 = new Label();
            lblMotivo = new Label();
            cmbMotivos = new ComboBox();
            txtComentarioCierre = new TextBox();
            button1 = new Button();
            dgvMotivos = new DataGridView();
            Motivo = new DataGridViewTextBoxColumn();
            Comentario = new DataGridViewTextBoxColumn();
            buttoncerrarOI = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMotivos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(176, 18);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar orden a cerrar";
            // 
            // cmbOrdenes
            // 
            cmbOrdenes.FormattingEnabled = true;
            cmbOrdenes.Location = new Point(25, 58);
            cmbOrdenes.Name = "cmbOrdenes";
            cmbOrdenes.Size = new Size(582, 23);
            cmbOrdenes.TabIndex = 1;
            cmbOrdenes.Text = "Seleccione";
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(25, 138);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(582, 23);
            txtObservacion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 12F);
            label2.Location = new Point(25, 109);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 3;
            label2.Text = "Observación";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Berlin Sans FB", 12F);
            lblMotivo.Location = new Point(25, 192);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(115, 18);
            lblMotivo.TabIndex = 4;
            lblMotivo.Text = "Motivos de cierre";
            // 
            // cmbMotivos
            // 
            cmbMotivos.FormattingEnabled = true;
            cmbMotivos.Location = new Point(25, 222);
            cmbMotivos.Name = "cmbMotivos";
            cmbMotivos.Size = new Size(142, 23);
            cmbMotivos.TabIndex = 5;
            cmbMotivos.Text = "Seleccione un motivo";
            // 
            // txtComentarioCierre
            // 
            txtComentarioCierre.AccessibleDescription = "";
            txtComentarioCierre.Location = new Point(193, 222);
            txtComentarioCierre.Name = "txtComentarioCierre";
            txtComentarioCierre.Size = new Size(414, 23);
            txtComentarioCierre.TabIndex = 6;
            txtComentarioCierre.Text = "Comentario";
            // 
            // button1
            // 
            button1.Location = new Point(25, 263);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 7;
            button1.Text = "Agregar motivo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAgregarMotivo_Click;
            // 
            // dgvMotivos
            // 
            dgvMotivos.AllowUserToAddRows = false;
            dgvMotivos.AllowUserToDeleteRows = false;
            dgvMotivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMotivos.Columns.AddRange(new DataGridViewColumn[] { Motivo, Comentario });
            dgvMotivos.Location = new Point(25, 306);
            dgvMotivos.Name = "dgvMotivos";
            dgvMotivos.ReadOnly = true;
            dgvMotivos.Size = new Size(582, 150);
            dgvMotivos.TabIndex = 8;
            // 
            // Motivo
            // 
            Motivo.DataPropertyName = "Motivo";
            Motivo.HeaderText = "Motivo";
            Motivo.Name = "Motivo";
            Motivo.ReadOnly = true;
            Motivo.Width = 200;
            // 
            // Comentario
            // 
            Comentario.DataPropertyName = "Comentario";
            Comentario.HeaderText = "Comentario";
            Comentario.Name = "Comentario";
            Comentario.ReadOnly = true;
            Comentario.Width = 400;
            // 
            // buttoncerrarOI
            // 
            buttoncerrarOI.Location = new Point(499, 480);
            buttoncerrarOI.Name = "buttoncerrarOI";
            buttoncerrarOI.Size = new Size(108, 23);
            buttoncerrarOI.TabIndex = 9;
            buttoncerrarOI.Text = "Cerrar Orden";
            buttoncerrarOI.UseVisualStyleBackColor = true;
            buttoncerrarOI.Click += btnCerrarOrden_Click;
            // 
            // PantallaCierreOrdInspeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 498);
            Controls.Add(buttoncerrarOI);
            Controls.Add(dgvMotivos);
            Controls.Add(button1);
            Controls.Add(txtComentarioCierre);
            Controls.Add(cmbMotivos);
            Controls.Add(lblMotivo);
            Controls.Add(label2);
            Controls.Add(txtObservacion);
            Controls.Add(cmbOrdenes);
            Controls.Add(label1);
            Name = "PantallaCierreOrdInspeccion";
            Text = "Cerrar orden de inspección";
            Load += PantallaCierreOrdInspeccion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMotivos).EndInit();
            ResumeLayout(false);
            PerformLayout();
            // 
            // 
            // btnVerMails
            //
            this.btnVerMails = new System.Windows.Forms.Button();
            this.btnVerMails.Location = new System.Drawing.Point(20, 480); // Ajustá posición según tu layout
            this.btnVerMails.Name = "btnVerMails";
            this.btnVerMails.Size = new System.Drawing.Size(150, 30);
            this.btnVerMails.TabIndex = 8;
            this.btnVerMails.Text = "Ver mails enviados";
            this.btnVerMails.UseVisualStyleBackColor = true;
            this.btnVerMails.Click += new System.EventHandler(this.btnVerMails_Click);

            // Agregar al formulario
            this.Controls.Add(this.btnVerMails);




        }

        #endregion

        private Label label1;
        private ComboBox cmbOrdenes;
        private TextBox txtObservacion;
        private Label label2;
        private Label lblMotivo;
        private ComboBox cmbMotivos;
        private TextBox txtComentarioCierre;
        private Button button1;
        private DataGridView dgvMotivos;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewTextBoxColumn Comentario;
        private Button buttoncerrarOI;
        private System.Windows.Forms.Button btnVerMails;


    }
}