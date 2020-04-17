using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormCiclos : Form
    {
        CN_Ciclo objetoCN = new CN_Ciclo();
        public string idCiclo = null;
        public bool Editar = false;
        public string Operacion = "Insertar";

        public FormCiclos()
        {
            InitializeComponent();
        }

       
        private void FormCiclos_Load(object sender, EventArgs e)
        {
            MostrarCiclos();
        }
        private void MostrarCiclos()
        {
            CN_Ciclo objeto = new CN_Ciclo();
            dataGridViewCiclos.DataSource = objeto.MostrarCicl();
            this.dataGridViewCiclos.Columns["Id_Ciclo"].Visible = false;
        }

      
         private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CN_Ciclo objetobusqueda = new CN_Ciclo();
            dataGridViewCiclos.DataSource = objetobusqueda.BuscarCiclo(txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo2_Click(object sender, EventArgs e)
        {
            FormMantCiclos frm = new FormMantCiclos();
            frm.Operacion = "Insertar";
            frm.ShowDialog();
            MostrarCiclos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewCiclos.SelectedRows.Count > 0)
            {
                idCiclo = dataGridViewCiclos.CurrentRow.Cells["Id_Ciclo"].Value.ToString();
                objetoCN.EliminarCiclo(idCiclo);
                MessageBox.Show("Eliminado Correctamente");
                MostrarCiclos();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewCiclos.SelectedRows.Count > 0)
            {

                FormMantCiclos frm = new FormMantCiclos();


                //EDITAR
                //frm.Editar = true;
                frm.Operacion = "Editar";


                frm.idCiclos = dataGridViewCiclos.CurrentRow.Cells["Id_Ciclo"].Value.ToString();

                frm.FechaInicio.Text = dataGridViewCiclos.CurrentRow.Cells["Fecha_Inicio"].Value.ToString();
                frm.FechaTermino.Text = dataGridViewCiclos.CurrentRow.Cells["Fecha_Termino"].Value.ToString();
                frm.maskedTxtPeriodo.Text = dataGridViewCiclos.CurrentRow.Cells["Periodo"].Value.ToString();


                frm.ShowDialog();
                MostrarCiclos();

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}
