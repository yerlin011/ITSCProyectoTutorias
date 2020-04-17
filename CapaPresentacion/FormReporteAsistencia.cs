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
    public partial class FormReporteAsistencia : Form
    {
        public FormReporteAsistencia()
        {
            InitializeComponent();
        }

        public DateTime Fecha { get; set; }
        
            
        

        private void FormReporteAsistencia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.MostrarReportesAsistencias' table. You can move, or remove it, as needed.
            this.MostrarReportesAsistenciasTableAdapter.Fill(this.DataSet1.MostrarReportesAsistencias,Fecha);

            this.reportViewer1.RefreshReport();
        }
    }
}
