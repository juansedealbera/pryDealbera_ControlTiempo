namespace pryDealbera_ControlTiempo
{
    partial class frmAuditoria
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTiempoTrabajo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLugares = new System.Windows.Forms.Label();
            this.btnAuditar = new System.Windows.Forms.Button();
            this.panelTrabajo = new System.Windows.Forms.Panel();
            this.lstCoordenadas = new System.Windows.Forms.ListBox();
            this.timerTiempoTrabajo = new System.Windows.Forms.Timer(this.components);
            this.panelTrabajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo de Trabajo:";
            // 
            // lblTiempoTrabajo
            // 
            this.lblTiempoTrabajo.AutoSize = true;
            this.lblTiempoTrabajo.Location = new System.Drawing.Point(309, 369);
            this.lblTiempoTrabajo.Name = "lblTiempoTrabajo";
            this.lblTiempoTrabajo.Size = new System.Drawing.Size(10, 13);
            this.lblTiempoTrabajo.TabIndex = 1;
            this.lblTiempoTrabajo.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lugares:";
            // 
            // lblLugares
            // 
            this.lblLugares.AutoSize = true;
            this.lblLugares.Location = new System.Drawing.Point(309, 404);
            this.lblLugares.Name = "lblLugares";
            this.lblLugares.Size = new System.Drawing.Size(10, 13);
            this.lblLugares.TabIndex = 3;
            this.lblLugares.Text = "-";
            // 
            // btnAuditar
            // 
            this.btnAuditar.Location = new System.Drawing.Point(371, 385);
            this.btnAuditar.Name = "btnAuditar";
            this.btnAuditar.Size = new System.Drawing.Size(75, 23);
            this.btnAuditar.TabIndex = 4;
            this.btnAuditar.Text = "Auditar";
            this.btnAuditar.UseVisualStyleBackColor = true;
            this.btnAuditar.Click += new System.EventHandler(this.btnAuditar_Click);
            // 
            // panelTrabajo
            // 
            this.panelTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTrabajo.Controls.Add(this.lstCoordenadas);
            this.panelTrabajo.Location = new System.Drawing.Point(12, 12);
            this.panelTrabajo.Name = "panelTrabajo";
            this.panelTrabajo.Size = new System.Drawing.Size(776, 338);
            this.panelTrabajo.TabIndex = 5;
            this.panelTrabajo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTrabajo_Paint);
            // 
            // lstCoordenadas
            // 
            this.lstCoordenadas.FormattingEnabled = true;
            this.lstCoordenadas.Location = new System.Drawing.Point(15, 15);
            this.lstCoordenadas.Name = "lstCoordenadas";
            this.lstCoordenadas.Size = new System.Drawing.Size(741, 303);
            this.lstCoordenadas.TabIndex = 6;
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTrabajo);
            this.Controls.Add(this.btnAuditar);
            this.Controls.Add(this.lblLugares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTiempoTrabajo);
            this.Controls.Add(this.label1);
            this.Name = "frmAuditoria";
            this.Text = "frmAuditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            this.panelTrabajo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTiempoTrabajo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLugares;
        private System.Windows.Forms.Button btnAuditar;
        private System.Windows.Forms.Panel panelTrabajo;
        private System.Windows.Forms.ListBox lstCoordenadas;
        private System.Windows.Forms.Timer timerTiempoTrabajo;
    }
}