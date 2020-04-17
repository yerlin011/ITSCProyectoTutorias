namespace CapaPresentacion
{
    partial class FormRecuperarContraseña
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
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtdni
            // 
            this.txtdni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdni.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.Location = new System.Drawing.Point(44, 39);
            this.txtdni.Multiline = true;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(236, 21);
            this.txtdni.TabIndex = 3;
            this.txtdni.Text = "Ingresar Usuario";
            this.txtdni.TextChanged += new System.EventHandler(this.txtdni_TextChanged);
            this.txtdni.Enter += new System.EventHandler(this.txtdni_Enter);
            this.txtdni.Leave += new System.EventHandler(this.txtdni_Leave);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.DarkGray;
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Location = new System.Drawing.Point(48, 81);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(457, 155);
            this.txtMensaje.TabIndex = 1;
            this.txtMensaje.TextChanged += new System.EventHandler(this.txtMensaje_TextChanged);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.FlatAppearance.BorderSize = 0;
            this.btnRecuperar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecuperar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Location = new System.Drawing.Point(423, 39);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(82, 28);
            this.btnRecuperar.TabIndex = 2;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(44, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "________________________";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkRed;
            this.panelLeft.Location = new System.Drawing.Point(423, 39);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(4, 28);
            this.panelLeft.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 10);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(1, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 10);
            this.panel2.TabIndex = 18;
            // 
            // FormRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 272);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecuperarContraseña";
            this.Load += new System.EventHandler(this.FormRecuperarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}