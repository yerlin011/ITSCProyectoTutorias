namespace CapaPresentacion
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCiclo = new System.Windows.Forms.Button();
            this.btnAsignarTutorias = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnMaestro = new System.Windows.Forms.Button();
            this.btnEst = new System.Windows.Forms.Button();
            this.btnTutoria = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCiclo);
            this.panel1.Controls.Add(this.btnAsignarTutorias);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.btnMaestro);
            this.panel1.Controls.Add(this.btnEst);
            this.panel1.Controls.Add(this.btnTutoria);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 690);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnCiclo
            // 
            this.btnCiclo.FlatAppearance.BorderSize = 0;
            this.btnCiclo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiclo.ForeColor = System.Drawing.Color.DimGray;
            this.btnCiclo.Image = global::CapaPresentacion.Properties.Resources.calendario;
            this.btnCiclo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCiclo.Location = new System.Drawing.Point(3, 464);
            this.btnCiclo.Name = "btnCiclo";
            this.btnCiclo.Size = new System.Drawing.Size(197, 55);
            this.btnCiclo.TabIndex = 14;
            this.btnCiclo.Text = "Ciclos";
            this.btnCiclo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCiclo.UseVisualStyleBackColor = true;
            this.btnCiclo.Click += new System.EventHandler(this.btnCiclo_Click);
            // 
            // btnAsignarTutorias
            // 
            this.btnAsignarTutorias.FlatAppearance.BorderSize = 0;
            this.btnAsignarTutorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAsignarTutorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarTutorias.ForeColor = System.Drawing.Color.DimGray;
            this.btnAsignarTutorias.Image = global::CapaPresentacion.Properties.Resources.grupo;
            this.btnAsignarTutorias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarTutorias.Location = new System.Drawing.Point(3, 323);
            this.btnAsignarTutorias.Name = "btnAsignarTutorias";
            this.btnAsignarTutorias.Size = new System.Drawing.Size(197, 55);
            this.btnAsignarTutorias.TabIndex = 13;
            this.btnAsignarTutorias.Text = "Asignar tutorias";
            this.btnAsignarTutorias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignarTutorias.UseVisualStyleBackColor = true;
            this.btnAsignarTutorias.Click += new System.EventHandler(this.btnAsignarTutorias_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.ForeColor = System.Drawing.Color.DimGray;
            this.btnAsistencia.Image = global::CapaPresentacion.Properties.Resources.agregar_documentos;
            this.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsistencia.Location = new System.Drawing.Point(3, 368);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(197, 55);
            this.btnAsistencia.TabIndex = 11;
            this.btnAsistencia.Text = "Asistencia\r\n";
            this.btnAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.DimGray;
            this.btnUsuarios.Image = global::CapaPresentacion.Properties.Resources.grupo;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 508);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(197, 55);
            this.btnUsuarios.TabIndex = 10;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.icono_cliente;
            this.pictureBox2.Location = new System.Drawing.Point(14, 580);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(97, 589);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 21);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.DimGray;
            this.lblApellido.Location = new System.Drawing.Point(95, 610);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 21);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCargo.Location = new System.Drawing.Point(95, 631);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(56, 21);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "Cargo";
            // 
            // btnMaestro
            // 
            this.btnMaestro.FlatAppearance.BorderSize = 0;
            this.btnMaestro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMaestro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaestro.ForeColor = System.Drawing.Color.DimGray;
            this.btnMaestro.Image = global::CapaPresentacion.Properties.Resources.usuario;
            this.btnMaestro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaestro.Location = new System.Drawing.Point(3, 416);
            this.btnMaestro.Name = "btnMaestro";
            this.btnMaestro.Size = new System.Drawing.Size(197, 55);
            this.btnMaestro.TabIndex = 4;
            this.btnMaestro.Text = "Añadir Maestro";
            this.btnMaestro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMaestro.UseVisualStyleBackColor = true;
            this.btnMaestro.Click += new System.EventHandler(this.btnMaestro_Click);
            // 
            // btnEst
            // 
            this.btnEst.FlatAppearance.BorderSize = 0;
            this.btnEst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEst.ForeColor = System.Drawing.Color.DimGray;
            this.btnEst.Image = ((System.Drawing.Image)(resources.GetObject("btnEst.Image")));
            this.btnEst.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEst.Location = new System.Drawing.Point(3, 274);
            this.btnEst.Name = "btnEst";
            this.btnEst.Size = new System.Drawing.Size(197, 55);
            this.btnEst.TabIndex = 3;
            this.btnEst.Text = "Añadir Estudiante";
            this.btnEst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEst.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEst.UseVisualStyleBackColor = true;
            this.btnEst.Click += new System.EventHandler(this.btnEst_Click);
            // 
            // btnTutoria
            // 
            this.btnTutoria.FlatAppearance.BorderSize = 0;
            this.btnTutoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnTutoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutoria.ForeColor = System.Drawing.Color.DimGray;
            this.btnTutoria.Image = global::CapaPresentacion.Properties.Resources.grupo;
            this.btnTutoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTutoria.Location = new System.Drawing.Point(3, 223);
            this.btnTutoria.Name = "btnTutoria";
            this.btnTutoria.Size = new System.Drawing.Size(197, 55);
            this.btnTutoria.TabIndex = 2;
            this.btnTutoria.Text = "Crear Tutoría";
            this.btnTutoria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTutoria.UseVisualStyleBackColor = true;
            this.btnTutoria.Click += new System.EventHandler(this.btnTutoria_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.DimGray;
            this.btnMenu.Image = global::CapaPresentacion.Properties.Resources.analisis;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.Location = new System.Drawing.Point(3, 172);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(197, 55);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Estadisticas";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.ed;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkRed;
            this.panelLeft.Location = new System.Drawing.Point(197, 172);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(14, 58);
            this.panelLeft.TabIndex = 1;
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.White;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contenedor.Location = new System.Drawing.Point(200, 37);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(960, 653);
            this.Contenedor.TabIndex = 2;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            this.Contenedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Contenedor_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 37);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::CapaPresentacion.Properties.Resources.cuadrado_comprimido;
            this.button4.Location = new System.Drawing.Point(822, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 35);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::CapaPresentacion.Properties.Resources.maximize__2_;
            this.button3.Location = new System.Drawing.Point(869, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 35);
            this.button3.TabIndex = 4;
            this.button3.Tag = "";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(6, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 30);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Log Out";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(293, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(369, 23);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "SISTEMA DE REGISTRO DE TUTORIAS";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::CapaPresentacion.Properties.Resources.minimize__1_;
            this.button2.Location = new System.Drawing.Point(785, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 35);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::CapaPresentacion.Properties.Resources.interruptor__1_;
            this.button1.Location = new System.Drawing.Point(916, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1160, 690);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnTutoria;
        private System.Windows.Forms.Button btnEst;
        private System.Windows.Forms.Button btnMaestro;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAsignarTutorias;
        private System.Windows.Forms.Button btnCiclo;
    }
}