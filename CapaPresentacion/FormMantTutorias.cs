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
    public partial class FormMantTutorias : Form
    {
        CN_Tutorias objetoCN = new CN_Tutorias();
        public string IdTutoria = null;
        public bool Editar = false;
        public string Operacion = "Insertar";

        public FormMantTutorias()
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

        private void FormMantCliente_Load(object sender, EventArgs e)
        {

        }
      

        public void Materias()
        {
            CN_Tutorias objeto = new CN_Tutorias();

            cmbMaterias.DataSource = objeto.MostrarMate();
            cmbMaterias.DisplayMember = "Nombre_Materia";
            cmbMaterias.ValueMember = "Id_Materia";

        }
        public void Dias()
        {
            CN_Tutorias objeto = new CN_Tutorias();

            cmbDias.DataSource = objeto.MostrarDias();
            cmbDias.DisplayMember = "Nombre_Dias";
            cmbDias.ValueMember = "Id_Dias";

        }
        public void Horarios()
        {
            CN_Tutorias objeto = new CN_Tutorias();

            cmbHorarios.DataSource = objeto.MostrarHora();
            cmbHorarios.DisplayMember = "Nombre_Horario";
            cmbHorarios.ValueMember = "Id_Horario";

        }
        public void Maestros()
        {

            CN_Tutorias objeto = new CN_Tutorias();

            cmbMaestros.DataSource = objeto.MostrarMaest();
            cmbMaestros.DisplayMember = "Nombre_Maestro";
            cmbMaestros.ValueMember = "Id_Maestro";
        }
        public void Ciclos()
        {

            CN_Tutorias objeto = new CN_Tutorias();

            cmbCiclo.DataSource = objeto.MostrarCic();
            cmbCiclo.DisplayMember = "Periodo";
            cmbCiclo.ValueMember = "Id_Ciclo";
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (this.maskedtxtPeriodo.Text == "    -")
            //{
            //    MessageBox.Show("Ingrese Periodo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.maskedtxtPeriodo.Select();
            //    return;
            //}
            //    ////INSERTAR
                if (Operacion == "Insertar")
                {
                try
                {
                    objetoCN.InsertarTut(cmbMaterias.SelectedValue.ToString(), cmbMaestros.SelectedValue.ToString(), cmbDias.SelectedValue.ToString(), cmbHorarios.SelectedValue.ToString(),cmbCiclo.SelectedValue.ToString());

                    MessageBox.Show("Tutoria Registrada Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    objetoCN.EditarTut(cmbMaterias.SelectedValue.ToString(), cmbMaestros.SelectedValue.ToString(), cmbDias.SelectedValue.ToString(), cmbHorarios.SelectedValue.ToString(),cmbCiclo.SelectedValue.ToString(), IdTutoria);
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

        private void cmbMaterias_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbHorarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbMaestros_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
