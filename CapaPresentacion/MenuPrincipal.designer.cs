namespace CapaPresentacion
{
    partial class MenuPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMaterias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCarrerasPreferidas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.lblTituloEst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCarrerasPreferidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMaterias
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartMaterias.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartMaterias.Legends.Add(legend1);
            this.chartMaterias.Location = new System.Drawing.Point(40, 161);
            this.chartMaterias.Name = "chartMaterias";
            this.chartMaterias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMaterias.Series.Add(series1);
            this.chartMaterias.Size = new System.Drawing.Size(467, 237);
            this.chartMaterias.TabIndex = 2;
            this.chartMaterias.Text = "Materias";
            title1.BackColor = System.Drawing.Color.White;
            title1.BorderColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Cantidad de estudiantes por materias";
            this.chartMaterias.Titles.Add(title1);
            // 
            // chartCarrerasPreferidas
            // 
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chartCarrerasPreferidas.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.SystemColors.Control;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartCarrerasPreferidas.Legends.Add(legend2);
            this.chartCarrerasPreferidas.Location = new System.Drawing.Point(513, 161);
            this.chartCarrerasPreferidas.Name = "chartCarrerasPreferidas";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCarrerasPreferidas.Series.Add(series2);
            this.chartCarrerasPreferidas.Size = new System.Drawing.Size(410, 237);
            this.chartCarrerasPreferidas.TabIndex = 3;
            this.chartCarrerasPreferidas.Text = "chart1";
            title2.BackColor = System.Drawing.Color.White;
            title2.BorderColor = System.Drawing.Color.White;
            title2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            this.chartCarrerasPreferidas.Titles.Add(title2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(104, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 42);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.AutoSize = true;
            this.lblEstudiantes.BackColor = System.Drawing.Color.White;
            this.lblEstudiantes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiantes.Location = new System.Drawing.Point(163, 75);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(53, 21);
            this.lblEstudiantes.TabIndex = 6;
            this.lblEstudiantes.Text = "label1";
            // 
            // lblTituloEst
            // 
            this.lblTituloEst.AutoSize = true;
            this.lblTituloEst.BackColor = System.Drawing.Color.White;
            this.lblTituloEst.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEst.Location = new System.Drawing.Point(163, 54);
            this.lblTituloEst.Name = "lblTituloEst";
            this.lblTituloEst.Size = new System.Drawing.Size(143, 21);
            this.lblTituloEst.TabIndex = 7;
            this.lblTituloEst.Text = "Total Estudiantes ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Top 10 cantidad de estudiantes por carreras";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloEst);
            this.Controls.Add(this.lblEstudiantes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.chartCarrerasPreferidas);
            this.Controls.Add(this.chartMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCarrerasPreferidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMaterias;
     
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCarrerasPreferidas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.Label lblTituloEst;
        private System.Windows.Forms.Label label1;
    }
}