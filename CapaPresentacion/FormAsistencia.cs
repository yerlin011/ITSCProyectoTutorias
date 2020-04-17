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
    public partial class FormAsistencia : Form
    {
        CN_Asistencia objetoCN = new CN_Asistencia();
        public string IdAsistencia = null;
        public bool Editar = false;
        public string Operacion = "Insertar";

        public FormAsistencia()
        {
            InitializeComponent();
        }

        private void FormAsistencia_Load(object sender, EventArgs e)
        {
            Matriculas();
            Tutorias();
            //Nombres();
            //Apellidos();
            //Materias();
            //Dias();
            //Horarios();
            //Maestros();
            ListarAsistencia();



        }
        private void ListarAsistencia()
        {
            CN_Asistencia objeto = new CN_Asistencia();
            dataGridViewAsistencia.DataSource = objeto.MostrarAsist();
            this.dataGridViewAsistencia.Columns["Id_Asistencia"].Visible = false;
            this.dataGridViewAsistencia.Columns["CodEstudiante"].Visible = false;


        }
        private void Matriculas()
        {
            CN_Asistencia objeto = new CN_Asistencia();
            FormMantAsistencia frm = new FormMantAsistencia();

            frm.cmbMatricula.DataSource = objeto.MostrarMatri();
            frm.cmbMatricula.DisplayMember = "Matricula_Estudiante";
            frm.cmbMatricula.ValueMember = "Id_Estudiante";

        }
        private void Tutorias()
        {
            CN_Asistencia objeto = new CN_Asistencia();
            FormMantAsistencia frm = new FormMantAsistencia();

            frm.cmbCodigoTutoria.DataSource = objeto.MostrarCodTut();
            //frm.cmbCodigoTutoria.DisplayMember = "CodTutorias";
            frm.cmbCodigoTutoria.ValueMember = "Id_Tutoria";


        }
        //private void Nombres()
        //{
        //    CN_Asistencia objeto = new CN_Asistencia();
        //    FormMantAsistencia frm = new FormMantAsistencia();

        //    frm.cmbCodigoTutoria.DataSource = objeto.MostrarNomb();
        //    frm.cmbCodigoTutoria.DisplayMember = "Nombre_Estudiante";
        //    frm.cmbCodigoTutoria.ValueMember = "Id_Estudiante";

        //}
        //private void Apellidos()
        //{
        //    CN_Asistencia objeto = new CN_Asistencia();
        //    FormMantAsistencia frm = new FormMantAsistencia();

        //    frm.cmbApellido.DataSource = objeto.MostrarApelli();
        //    frm.cmbMatricula.DisplayMember = "Apellido_Estudiante";
        //    frm.cmbMatricula.ValueMember = "Id_Estudiante";

        //}
        //private void Materias()
        //{
        //    CN_Asistencia objeto = new CN_Asistencia();
        //    FormMantAsistencia frm = new FormMantAsistencia();

        //    frm.cmbAsignatura.DataSource = objeto.MostrarMate();
        //    frm.cmbAsignatura.DisplayMember = "Nombre_Materia";
        //    frm.cmbAsignatura.ValueMember = "Id_Materia";

        //}
        //private void Dias()
        //{
        //    CN_Asistencia objeto = new CN_Asistencia();
        //    FormMantAsistencia frm = new FormMantAsistencia();

        //    frm.cmbDias.DataSource = objeto.MostrarDias();
        //    frm.cmbDias.DisplayMember = "Nombre_Dias";
        //    frm.cmbDias.ValueMember = "Id_Dias";

        //}
        //private void Horarios()
        //{
        //    CN_Asistencia objeto = new CN_Asistencia();
        //    FormMantAsistencia frm = new FormMantAsistencia();


        //    frm.cmbHorario.DataSource = objeto.MostrarHora();
        //    frm.cmbHorario.DisplayMember = "Nombre_Horario";
        //    frm.cmbHorario.ValueMember = "Id_Horario";

        //}
        //private void Maestros()
        //{

        //    CN_Asistencia objeto = new CN_Asistencia();
        //    FormMantAsistencia frm = new FormMantAsistencia();

        //    frm.cmbMaestro.DataSource = objeto.MostrarMaest();
        //    frm.cmbMaestro.DisplayMember = "Nombre_Maestro";
        //    frm.cmbMaestro.ValueMember = "Id_Maestro";
        //}


      
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //    //EDITAR
            //    //Editar = true;

            if (dataGridViewAsistencia.SelectedRows.Count > 0)
            {
                FormMantAsistencia frm = new FormMantAsistencia();
                frm.Operacion = "Editar";
                frm.MostrarMatriculas();
                frm.MostrarCodigoTutorias();

                frm.idAsistencia = dataGridViewAsistencia.CurrentRow.Cells["Id_Asistencia"].Value.ToString();

                frm.cmbMatricula.Text = dataGridViewAsistencia.CurrentRow.Cells["Matricula"].Value.ToString();
                frm.cmbCodigoTutoria.Text = dataGridViewAsistencia.CurrentRow.Cells["CodTutorias"].Value.ToString();
                frm.txtFecha.Text = dataGridViewAsistencia.CurrentRow.Cells["Fecha"].Value.ToString();
                frm.ShowDialog();
                ListarAsistencia();



            }

            else
                MessageBox.Show("seleccione una fila por favor");


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAsistencia.SelectedRows.Count > 0)
            {
                IdAsistencia = dataGridViewAsistencia.CurrentRow.Cells["Id_Asistencia"].Value.ToString();
                objetoCN.EliminarAsistencia(IdAsistencia);
                MessageBox.Show("Se ha eliminado correctamente");
                ListarAsistencia();



            }

            else
                MessageBox.Show("seleccione una fila por favor");

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarAsis();
        }
        private void BuscarAsis()
        {
            CN_Asistencia objetoBusqueda = new CN_Asistencia();
            dataGridViewAsistencia.DataSource = objetoBusqueda.BuscarAsistencia(txtBuscar.Text);


        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormGenerarReporteFecha frm = new FormGenerarReporteFecha();
            frm.ShowDialog();
        }

        private void btnNuevo2_Click(object sender, EventArgs e)
        {
            FormMantAsistencia frm = new FormMantAsistencia();
            frm.Operacion = "Insertar";
            frm.MostrarMatriculas();
            frm.MostrarCodigoTutorias();
            frm.ShowDialog();
            ListarAsistencia();
        }
    }
}
