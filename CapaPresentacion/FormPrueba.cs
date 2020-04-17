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
    public partial class FormPrueba : Form
    {
        public FormPrueba()
        {
            InitializeComponent();
        }

        private void aSISTENCIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aSISTENCIABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_Registro_TutoriasDataSet);

        }

        private void FormPrueba_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_Registro_TutoriasDataSet.MostrarMatricula' table. You can move, or remove it, as needed.
            this.mostrarMatriculaTableAdapter.Fill(this.bD_Registro_TutoriasDataSet.MostrarMatricula);
            // TODO: This line of code loads data into the 'bD_Registro_TutoriasDataSet.MostrarAsistencia4' table. You can move, or remove it, as needed.
            this.mostrarAsistencia4TableAdapter.Fill(this.bD_Registro_TutoriasDataSet.MostrarAsistencia4);
            // TODO: This line of code loads data into the 'bD_Registro_TutoriasDataSet.MostrarTutorias' table. You can move, or remove it, as needed.
            //this.mostrarTutoriasTableAdapter.Fill(this.bD_Registro_TutoriasDataSet.MostrarTutorias);
            // TODO: This line of code loads data into the 'bD_Registro_TutoriasDataSet.MostrarAsistencia' table. You can move, or remove it, as needed.
            this.mostrarAsistenciaTableAdapter.Fill(this.bD_Registro_TutoriasDataSet.MostrarAsistencia);
            // TODO: This line of code loads data into the 'bD_Registro_TutoriasDataSet.ASISTENCIA' table. You can move, or remove it, as needed.
            this.aSISTENCIATableAdapter.Fill(this.bD_Registro_TutoriasDataSet.ASISTENCIA);

        }
    }
}
