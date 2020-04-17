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
    public partial class BtnReportTutoria : Form
    {
        CN_Tutorias objetoCN = new CN_Tutorias();
        public string IdTutoria = null;
        public bool Editar = false;
        public string Operacion = "Insertar";
        public BtnReportTutoria()
        {
            InitializeComponent();
        }
        private void CrearTutoria_Load(object sender, EventArgs e)
        {
            Materias();
            Maestros();
            Dias();
            Horarios();
            ListarCiclos();
            MostrarTutorias();
        }
        private void MostrarTutorias()
        {
            CN_Tutorias objeto = new CN_Tutorias();
            dataGridView1.DataSource = objeto.MostrarTutori();
            this.dataGridView1.Columns["Id_Tutoria"].Visible = false;
        }

        private void Materias()
        {
            CN_Tutorias objeto = new CN_Tutorias();
            FormMantTutorias frm = new FormMantTutorias();

            frm.cmbMaterias.DataSource = objeto.MostrarMate();
            frm.cmbMaterias.DisplayMember = "Nombre_Materia";
            frm.cmbMaterias.ValueMember = "Id_Materia";

        }
        private void Dias()
        {
           CN_Tutorias objeto = new CN_Tutorias();
           FormMantTutorias frm = new FormMantTutorias();

           frm.cmbDias.DataSource = objeto.MostrarDias();
           frm.cmbDias.DisplayMember = "Nombre_Dias";
           frm.cmbDias.ValueMember = "Id_Dias";

        }
        private void Horarios()
        {
            CN_Tutorias objeto = new CN_Tutorias();
            FormMantTutorias frm = new FormMantTutorias();


            frm.cmbHorarios.DataSource = objeto.MostrarHora();
            frm.cmbHorarios.DisplayMember = "Nombre_Horario";
            frm.cmbHorarios.ValueMember = "Id_Horario";

        }
        private void Maestros()
        {

            CN_Tutorias objeto = new CN_Tutorias();
            FormMantTutorias frm = new FormMantTutorias();

            frm.cmbMaestros.DataSource = objeto.MostrarMaest();
            frm.cmbMaestros.DisplayMember = "Nombre_Maestro";
            frm.cmbMaestros.ValueMember = "Id_Maestro";
        }
        private void ListarCiclos()
        {

            CN_Tutorias objeto = new CN_Tutorias();
            FormMantTutorias frm = new FormMantTutorias();

            frm.cmbCiclo.DataSource = objeto.MostrarCic();
            frm.cmbCiclo.DisplayMember = "Periodo";
            frm.cmbCiclo.ValueMember = "Id_Ciclo";
        }



        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //////INSERTAR
            FormMantTutorias frm = new FormMantTutorias();
            frm.Operacion = "Insertar";
            frm.Materias();
            frm.Dias();
            frm.Horarios();
            frm.Maestros();
            frm.Ciclos();
            frm.ShowDialog();
            MostrarTutorias();
            //if (Operacion == "Insertar")
            //{
            //    try
            //    {
            //        objetoCN.InsertarTut(cmbMaterias.SelectedValue.ToString(), cmbMaestros.SelectedValue.ToString(), cmbDias.SelectedValue.ToString(), cmbHorarios.SelectedValue.ToString());
            //        MessageBox.Show("se inserto correctamente");
            //        MostrarTutorias();
            //        LimpiarForm();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("no se pudo insertar los datos por: " + ex);
            //    }
            //}
            //else if (Operacion == "Editar")
            //{

            //    try
            //    {
            //        objetoCN.EditarTut(cmbMaterias.SelectedValue.ToString(), cmbMaestros.SelectedValue.ToString(), cmbDias.SelectedValue.ToString(), cmbHorarios.SelectedValue.ToString(),  IdTutoria);
            //        MessageBox.Show("se edito correctamente");
            //        MostrarTutorias();
            //        LimpiarForm();
            //        //Editar = false;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("no se pudo editar los datos por: " + ex);
            //    }
            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //    //EDITAR
            //    //Editar = true;
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FormMantTutorias frm = new FormMantTutorias();
                frm.Operacion = "Editar";
                frm.Materias();
                frm.Dias();
                frm.Horarios();
                frm.Maestros();
                frm.Ciclos();


                frm.IdTutoria = dataGridView1.CurrentRow.Cells["Id_Tutoria"].Value.ToString();

                frm.cmbMaterias.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.cmbDias.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.cmbHorarios.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.cmbMaestros.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.cmbCiclo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();
                MostrarTutorias();



            }

            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void LimpiarForm()
        {
            FormMantTutorias frm = new FormMantTutorias();
            frm.cmbMaterias.Text = "------------";
            frm.cmbMaestros.Text = "------------";
            frm.cmbDias.Text     = "------------";
            frm.cmbHorarios.Text = "------------";

            //txtMatricula.Clear();
            //txtNombre.Clear();
            //txtApellido.Clear();
            //cbmCarrera.Text = "Carrera";
            //txtEstado.Clear();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult resul = MessageBox.Show("Esta seguro que desea eliminar este registro?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resul == System.Windows.Forms.DialogResult.OK)
                {
                   IdTutoria = dataGridView1.CurrentRow.Cells["Id_Tutoria"].Value.ToString();
                objetoCN.EliminarTut(IdTutoria);
                MessageBox.Show("Eliminado Correctamente");
                MostrarTutorias();
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CN_Tutorias objetoBusqueda = new CN_Tutorias();
            dataGridView1.DataSource = objetoBusqueda.BuscarTutor(txtBuscar.Text);
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormFiltrarReportes frm = new FormFiltrarReportes();
            frm.ShowDialog();
        }
    }
}
