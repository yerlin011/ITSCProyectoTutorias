using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormMantAsistencia : Form
    {
        CN_Asistencia objetoCN = new CN_Asistencia();
        public string idAsistencia = null;
        //private bool Editar = false;
        public string Operacion = "";

        public FormMantAsistencia()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MostrarMatriculas()
        {
            CN_Asistencia objeto = new CN_Asistencia();

            cmbMatricula.DataSource = objeto.MostrarMatri();
            cmbMatricula.DisplayMember = "Matricula_Estudiante";
            cmbMatricula.ValueMember = "Id_Estudiante";

        }
        public void MostrarCodigoTutorias()
        {
            CN_Asistencia objeto = new CN_Asistencia();

            cmbCodigoTutoria.DataSource = objeto.MostrarCodTut();
            //cmbCodigoTutoria.DisplayMember = "CodTutorias";
            cmbCodigoTutoria.ValueMember = "Id_Tutoria";

        }

        //public void MostrarNombres()
        //{
        //    CN_Asistencia objeto = new CN_Asistencia();

        //    cmbCodigoTutoria.DataSource = objeto.MostrarNomb();
        //    cmbCodigoTutoria.DisplayMember = "Nombre_Estudiante";
        //    cmbCodigoTutoria.ValueMember = "Id_Estudiante";
        //}

        // public void MostrarApellidos()
        //{
        //    CN_Asistencia objeto = new CN_Asistencia();

        //    cmbApellido.DataSource = objeto.MostrarApelli();
        //    cmbApellido.DisplayMember = "Apellido_Estudiante";
        //    cmbApellido.ValueMember = "Id_Estudiante";

        //}


        //public void Materias()
        //{
        //    CN_Asistencia objeto = new CN_Asistencia();

        //    cmbAsignatura.DataSource = objeto.MostrarMate();
        //    cmbAsignatura.DisplayMember = "Nombre_Materia";
        //    cmbAsignatura.ValueMember = "Id_Materia";

        //}
        //public void Dias()
        //{
        //    CN_Asistencia objeto = new CN_Asistencia();

        //    cmbDias.DataSource = objeto.MostrarDias();
        //    cmbDias.DisplayMember = "Nombre_Dias";
        //    cmbDias.ValueMember = "Id_Dias";

        //}
        //public void Horarios()
        //{
        //    CN_Asistencia objeto = new CN_Asistencia();

        //    cmbHorario.DataSource = objeto.MostrarHora();
        //    cmbHorario.DisplayMember = "Nombre_Horario";
        //    cmbHorario.ValueMember = "Id_Horario";

        //}
        //public void Maestros()
        //{

        //    CN_Asistencia objeto = new CN_Asistencia();

        //    cmbMaestro.DataSource = objeto.MostrarMaest();
        //    cmbMaestro.DisplayMember = "Nombre_Maestro";
        //    cmbMaestro.ValueMember = "Id_Maestro";
        //}


        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            
           
             ////INSERTAR
             if (Operacion == "Insertar")
            {
                try
                {
                    objetoCN.InsertarAsistencia(cmbMatricula.SelectedValue.ToString(), cmbCodigoTutoria.SelectedValue.ToString(),txtFecha.Text);

                    MessageBox.Show("Asistencia Registrada Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            else if (Operacion == "Editar")
            {

                try
                {
                    objetoCN.EditarAsistencia(cmbMatricula.SelectedValue.ToString(), cmbCodigoTutoria.SelectedValue.ToString(), txtFecha.Text, idAsistencia);
                    MessageBox.Show("Se edito correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    //Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void maskedtxtMatricula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormMantAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void cbmDias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxInterruptor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
