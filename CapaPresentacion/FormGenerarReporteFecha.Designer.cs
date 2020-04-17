namespace CapaPresentacion
{
    partial class FormGenerarReporteFecha
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
            this.btnGenerarReportes = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnGenerarReportes
            // 
            this.btnGenerarReportes.Location = new System.Drawing.Point(134, 146);
            this.btnGenerarReportes.Name = "btnGenerarReportes";
            this.btnGenerarReportes.Size = new System.Drawing.Size(105, 32);
            this.btnGenerarReportes.TabIndex = 0;
            this.btnGenerarReportes.Text = "GenerarReportes";
            this.btnGenerarReportes.UseVisualStyleBackColor = true;
            this.btnGenerarReportes.Click += new System.EventHandler(this.btnGenerarReportes_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(91, 75);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 26);
            this.txtFecha.TabIndex = 1;
            // 
            // FormGenerarReporteFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 190);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnGenerarReportes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGenerarReporteFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGenerarReporteFecha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarReportes;
        private System.Windows.Forms.DateTimePicker txtFecha;
    }
}