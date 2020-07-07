namespace Aplicacion
{
    partial class FrmInformacion
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssProximoAlumno = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstAlumnosSinEvaluar = new System.Windows.Forms.ListBox();
            this.gbAlumnosSinEvaluar = new System.Windows.Forms.GroupBox();
            this.gbAlumnoEnEvaluacion = new System.Windows.Forms.GroupBox();
            this.txtAlumnoEnEvaluacion = new System.Windows.Forms.TextBox();
            this.lblRecreo = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.gbAlumnosSinEvaluar.SuspendLayout();
            this.gbAlumnoEnEvaluacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssProximoAlumno});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(375, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // tssProximoAlumno
            // 
            this.tssProximoAlumno.Name = "tssProximoAlumno";
            this.tssProximoAlumno.Size = new System.Drawing.Size(109, 17);
            this.tssProximoAlumno.Text = "tssProximoAlumno";
            // 
            // lstAlumnosSinEvaluar
            // 
            this.lstAlumnosSinEvaluar.FormattingEnabled = true;
            this.lstAlumnosSinEvaluar.Location = new System.Drawing.Point(6, 28);
            this.lstAlumnosSinEvaluar.Name = "lstAlumnosSinEvaluar";
            this.lstAlumnosSinEvaluar.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstAlumnosSinEvaluar.Size = new System.Drawing.Size(338, 186);
            this.lstAlumnosSinEvaluar.TabIndex = 1;
            // 
            // gbAlumnosSinEvaluar
            // 
            this.gbAlumnosSinEvaluar.Controls.Add(this.lstAlumnosSinEvaluar);
            this.gbAlumnosSinEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbAlumnosSinEvaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlumnosSinEvaluar.Location = new System.Drawing.Point(12, 60);
            this.gbAlumnosSinEvaluar.Name = "gbAlumnosSinEvaluar";
            this.gbAlumnosSinEvaluar.Size = new System.Drawing.Size(350, 225);
            this.gbAlumnosSinEvaluar.TabIndex = 2;
            this.gbAlumnosSinEvaluar.TabStop = false;
            this.gbAlumnosSinEvaluar.Text = "Alumnos sin evaluar";
            // 
            // gbAlumnoEnEvaluacion
            // 
            this.gbAlumnoEnEvaluacion.Controls.Add(this.txtAlumnoEnEvaluacion);
            this.gbAlumnoEnEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbAlumnoEnEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlumnoEnEvaluacion.Location = new System.Drawing.Point(13, 352);
            this.gbAlumnoEnEvaluacion.Name = "gbAlumnoEnEvaluacion";
            this.gbAlumnoEnEvaluacion.Size = new System.Drawing.Size(350, 69);
            this.gbAlumnoEnEvaluacion.TabIndex = 3;
            this.gbAlumnoEnEvaluacion.TabStop = false;
            this.gbAlumnoEnEvaluacion.Text = "Alumno en evaluación";
            // 
            // txtAlumnoEnEvaluacion
            // 
            this.txtAlumnoEnEvaluacion.Enabled = false;
            this.txtAlumnoEnEvaluacion.Location = new System.Drawing.Point(5, 31);
            this.txtAlumnoEnEvaluacion.Name = "txtAlumnoEnEvaluacion";
            this.txtAlumnoEnEvaluacion.ReadOnly = true;
            this.txtAlumnoEnEvaluacion.Size = new System.Drawing.Size(337, 20);
            this.txtAlumnoEnEvaluacion.TabIndex = 6;
            // 
            // lblRecreo
            // 
            this.lblRecreo.AutoSize = true;
            this.lblRecreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecreo.Location = new System.Drawing.Point(14, 302);
            this.lblRecreo.Name = "lblRecreo";
            this.lblRecreo.Size = new System.Drawing.Size(50, 24);
            this.lblRecreo.TabIndex = 4;
            this.lblRecreo.Text = "label";
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(103, 12);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(167, 36);
            this.btnEvaluar.TabIndex = 5;
            this.btnEvaluar.Text = "Empezar Evaluacion";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // FrmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(375, 461);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.lblRecreo);
            this.Controls.Add(this.gbAlumnoEnEvaluacion);
            this.Controls.Add(this.gbAlumnosSinEvaluar);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInformacion";
            this.Text = "Alumnos por evaluar";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbAlumnosSinEvaluar.ResumeLayout(false);
            this.gbAlumnoEnEvaluacion.ResumeLayout(false);
            this.gbAlumnoEnEvaluacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssProximoAlumno;
        private System.Windows.Forms.ListBox lstAlumnosSinEvaluar;
        private System.Windows.Forms.GroupBox gbAlumnosSinEvaluar;
        private System.Windows.Forms.GroupBox gbAlumnoEnEvaluacion;
        private System.Windows.Forms.Label lblRecreo;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.TextBox txtAlumnoEnEvaluacion;
    }
}