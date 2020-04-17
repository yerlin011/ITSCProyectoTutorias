using CapaNegocio;
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
    public partial class FormFiltrarReportes : Form
    {
        public FormFiltrarReportes()
        {
            InitializeComponent();
        }
        CN_Tutorias objetoCN = new CN_Tutorias();
        public string IdTutoria = null;
        public bool Editar = false;
        public string Operacion = "Insertar";

        private void FormFiltrarReportes_Load(object sender, EventArgs e)
        {
            Ciclos();
        }
        public void Ciclos()
        {

            CN_Tutorias objeto = new CN_Tutorias();

            cmbCiclo.DataSource = objeto.MostrarCic();
            cmbCiclo.DisplayMember = "Periodo";
            cmbCiclo.ValueMember = "Id_Ciclo";
        }

        private void btnGenerarReportes_Click(object sender, EventArgs e)
        {
            FormReportes frm = new FormReportes();
            frm.Ciclo = Convert.ToInt32(cmbCiclo.SelectedValue.ToString());
            frm.ShowDialog();
        }
    }
}
