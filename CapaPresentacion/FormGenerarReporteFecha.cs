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
    public partial class FormGenerarReporteFecha : Form
    {
        public FormGenerarReporteFecha()
        {
            InitializeComponent();
        }

        private void btnGenerarReportes_Click(object sender, EventArgs e)
        {
            FormReporteAsistencia frm = new FormReporteAsistencia();
            frm.Fecha = Convert.ToDateTime(txtFecha.Text);
            frm.ShowDialog();

        }
    }
}
