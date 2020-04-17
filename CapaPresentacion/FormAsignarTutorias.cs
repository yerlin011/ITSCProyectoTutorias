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
    public partial class FormAsignarTutorias : Form
    {
        CN_AsignarTutorias objetoCN = new CN_AsignarTutorias();
        public string IdAsignarTutorias = null;
        public bool Editar = false;
        public string Operacion = "Insertar";

        public FormAsignarTutorias()
        {
            InitializeComponent();
        }

       
            //
        private void FormAsignarTutorias_Load(object sender, EventArgs e)
        {
            Matriculas();
            Materias();
            Ciclos();
            MostrarAsigTutorias();

        }
        public void MostrarAsigTutorias()
        {
            CN_AsignarTutorias objeto = new CN_AsignarTutorias();
            dataGridViewAsignarTut.DataSource = objeto.MostrarAsigT();
            this.dataGridViewAsignarTut.Columns["Id_AsignarTutoria"].Visible = false;
        }

       
        private void Matriculas()
        {
            CN_AsignarTutorias objeto = new CN_AsignarTutorias();
            FormMantAsignarTutoria frm = new FormMantAsignarTutoria();

            frm.cmbMatricula.DataSource = objeto.MostrarMatri();
            frm.cmbMatricula.DisplayMember = "Matricula_Estudiante";
            frm.cmbMatricula.ValueMember = "Id_Estudiante";

        }
        private void Materias()
        {
            CN_AsignarTutorias objeto = new CN_AsignarTutorias();
            FormMantAsignarTutoria frm = new FormMantAsignarTutoria();

            frm.cmbMateria.DataSource = objeto.MostrarMater();
            frm.cmbMateria.DisplayMember = "Nombre_Materia";
            frm.cmbMateria.ValueMember = "Id_Materia";

        }
        private void Ciclos()
        {
            CN_AsignarTutorias objeto = new CN_AsignarTutorias();
            FormMantAsignarTutoria frm = new FormMantAsignarTutoria();



            frm.cmbCiclo.DataSource = objeto.MostrarCic();
            frm.cmbCiclo.DisplayMember = "Periodo";
            frm.cmbCiclo.ValueMember = "Id_Ciclo";

        }
      

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CN_AsignarTutorias objetoBusqueda = new CN_AsignarTutorias();
            dataGridViewAsignarTut.DataSource = objetoBusqueda.BuscarAsignaciones(txtBuscar.Text);

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            //    //EDITAR
            //    //Editar = true;

            if (dataGridViewAsignarTut.SelectedRows.Count > 0)
            {
                FormMantAsignarTutoria frm = new FormMantAsignarTutoria();
                frm.Operacion = "Editar";
                frm.MostrarMatriculas();
                frm.MostrarMaterias();
                frm.MostrarCiclos();



                frm.IdAsignarTutorias = dataGridViewAsignarTut.CurrentRow.Cells[0].Value.ToString();

                frm.cmbMatricula.Text = dataGridViewAsignarTut.CurrentRow.Cells[1].Value.ToString();
                frm.cmbMateria.Text = dataGridViewAsignarTut.CurrentRow.Cells[2].Value.ToString();
                frm.cmbCiclo.Text = dataGridViewAsignarTut.CurrentRow.Cells[3].Value.ToString();

                frm.ShowDialog();
                MostrarAsigTutorias();



            }

            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewAsignarTut.SelectedRows.Count > 0)
            {
                DialogResult resul = MessageBox.Show("Esta seguro que desea eliminar este registro?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resul == System.Windows.Forms.DialogResult.OK)
                {
                    IdAsignarTutorias = dataGridViewAsignarTut.CurrentRow.Cells["Id_AsignarTutoria"].Value.ToString();
                    objetoCN.EliminarAsig(IdAsignarTutorias);
                    MessageBox.Show("Eliminado Correctamente");
                    MostrarAsigTutorias();
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FormMantAsignarTutoria frm = new FormMantAsignarTutoria();
            frm.Operacion = "Insertar";
            frm.MostrarMatriculas();
            frm.MostrarMaterias();
            frm.MostrarCiclos();

            frm.ShowDialog();
            MostrarAsigTutorias();
        }
    }
}
