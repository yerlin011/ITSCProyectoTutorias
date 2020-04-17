namespace CapaPresentacion
{
    partial class FormEstudiantes
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditarF2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignarTutoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar_foto;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(414, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 37);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(40, 212);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(849, 330);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(344, 108);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(293, 21);
            this.txtBuscar.TabIndex = 26;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Buscar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnEditarF2
            // 
            this.btnEditarF2.BackColor = System.Drawing.Color.White;
            this.btnEditarF2.FlatAppearance.BorderSize = 0;
            this.btnEditarF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarF2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarF2.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.btnEditarF2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarF2.Location = new System.Drawing.Point(225, 169);
            this.btnEditarF2.Name = "btnEditarF2";
            this.btnEditarF2.Size = new System.Drawing.Size(100, 37);
            this.btnEditarF2.TabIndex = 28;
            this.btnEditarF2.Text = "Editar ";
            this.btnEditarF2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarF2.UseVisualStyleBackColor = false;
            this.btnEditarF2.Click += new System.EventHandler(this.btnEditarF2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CapaPresentacion.Properties.Resources.agregar_documentos1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(610, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 29;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(340, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "______________________________";
            // 
            // btnAsignarTutoria
            // 
            this.btnAsignarTutoria.BackColor = System.Drawing.Color.White;
            this.btnAsignarTutoria.FlatAppearance.BorderSize = 0;
            this.btnAsignarTutoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarTutoria.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarTutoria.Image = global::CapaPresentacion.Properties.Resources.usuario;
            this.btnAsignarTutoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarTutoria.Location = new System.Drawing.Point(739, 110);
            this.btnAsignarTutoria.Name = "btnAsignarTutoria";
            this.btnAsignarTutoria.Size = new System.Drawing.Size(150, 37);
            this.btnAsignarTutoria.TabIndex = 31;
            this.btnAsignarTutoria.Text = "Asignar tutoria";
            this.btnAsignarTutoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarTutoria.UseVisualStyleBackColor = false;
            this.btnAsignarTutoria.Click += new System.EventHandler(this.btnAsignarTutoria_Click);
            // 
            // FormEstudiantes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(960, 653);
            this.Controls.Add(this.btnAsignarTutoria);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditarF2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstudiantes";
            this.Text = "Registro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_FormClosed);
            this.Load += new System.EventHandler(this.Registro_Load_1);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Registro_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditarF2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignarTutoria;
    }
}