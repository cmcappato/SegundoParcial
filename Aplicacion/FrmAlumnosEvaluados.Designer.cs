namespace Aplicacion
{
    partial class FrmAlumnosEvaluados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAlumnosEvaluados = new System.Windows.Forms.GroupBox();
            this.lstAlumnosEvaluados = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssProximoRecreo = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbAlumnosEvaluados.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAlumnosEvaluados
            // 
            this.gbAlumnosEvaluados.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbAlumnosEvaluados.Controls.Add(this.lstAlumnosEvaluados);
            this.gbAlumnosEvaluados.Location = new System.Drawing.Point(12, 12);
            this.gbAlumnosEvaluados.Name = "gbAlumnosEvaluados";
            this.gbAlumnosEvaluados.Size = new System.Drawing.Size(345, 228);
            this.gbAlumnosEvaluados.TabIndex = 5;
            this.gbAlumnosEvaluados.TabStop = false;
            this.gbAlumnosEvaluados.Text = "Evaluados";
            // 
            // lstAlumnosEvaluados
            // 
            this.lstAlumnosEvaluados.BackColor = System.Drawing.Color.White;
            this.lstAlumnosEvaluados.Enabled = false;
            this.lstAlumnosEvaluados.FormattingEnabled = true;
            this.lstAlumnosEvaluados.Location = new System.Drawing.Point(6, 19);
            this.lstAlumnosEvaluados.Name = "lstAlumnosEvaluados";
            this.lstAlumnosEvaluados.Size = new System.Drawing.Size(330, 199);
            this.lstAlumnosEvaluados.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssProximoRecreo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(367, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssProximoRecreo
            // 
            this.tssProximoRecreo.BackColor = System.Drawing.SystemColors.Control;
            this.tssProximoRecreo.Name = "tssProximoRecreo";
            this.tssProximoRecreo.Size = new System.Drawing.Size(102, 17);
            this.tssProximoRecreo.Text = "tssProximoRecreo";
            // 
            // FrmAlumnosEvaluados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(367, 276);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbAlumnosEvaluados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAlumnosEvaluados";
            this.Text = "Alumnos Evaluados";
            this.Load += new System.EventHandler(this.FrmAlumnosEvaluados_Load);
            this.gbAlumnosEvaluados.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.GroupBox gbAlumnosEvaluados;
        private System.Windows.Forms.ListBox lstAlumnosEvaluados;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssProximoRecreo;
    }
}

