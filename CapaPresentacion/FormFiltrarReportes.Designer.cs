namespace CapaPresentacion
{
    partial class FormFiltrarReportes
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
            this.cmbCiclo = new System.Windows.Forms.ComboBox();
            this.Ciclo = new System.Windows.Forms.Label();
            this.btnGenerarReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCiclo
            // 
            this.cmbCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiclo.FormattingEnabled = true;
            this.cmbCiclo.Location = new System.Drawing.Point(124, 73);
            this.cmbCiclo.Name = "cmbCiclo";
            this.cmbCiclo.Size = new System.Drawing.Size(121, 24);
            this.cmbCiclo.TabIndex = 0;
            // 
            // Ciclo
            // 
            this.Ciclo.AutoSize = true;
            this.Ciclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ciclo.Location = new System.Drawing.Point(62, 76);
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.Size = new System.Drawing.Size(56, 16);
            this.Ciclo.TabIndex = 1;
            this.Ciclo.Text = "Periodo";
            // 
            // btnGenerarReportes
            // 
            this.btnGenerarReportes.Location = new System.Drawing.Point(124, 119);
            this.btnGenerarReportes.Name = "btnGenerarReportes";
            this.btnGenerarReportes.Size = new System.Drawing.Size(121, 35);
            this.btnGenerarReportes.TabIndex = 2;
            this.btnGenerarReportes.Text = "Generar Reportes";
            this.btnGenerarReportes.UseVisualStyleBackColor = true;
            this.btnGenerarReportes.Click += new System.EventHandler(this.btnGenerarReportes_Click);
            // 
            // FormFiltrarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 190);
            this.Controls.Add(this.btnGenerarReportes);
            this.Controls.Add(this.Ciclo);
            this.Controls.Add(this.cmbCiclo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFiltrarReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormFiltrarReportes";
            this.Load += new System.EventHandler(this.FormFiltrarReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbCiclo;
        private System.Windows.Forms.Label Ciclo;
        private System.Windows.Forms.Button btnGenerarReportes;
    }
}