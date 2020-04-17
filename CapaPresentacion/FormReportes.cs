using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }
        public int Ciclo { get; set; }
        private void FormReportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.MostrarReportesTutorias' table. You can move, or remove it, as needed.
            this.MostrarReportesTutoriasTableAdapter.Fill(this.DataSet1.MostrarReportesTutorias,Ciclo);

            this.reportViewer1.RefreshReport();
        }
    }
}
