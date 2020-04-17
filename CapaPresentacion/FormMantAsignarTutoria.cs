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

    public partial class FormMantAsignarTutoria : Form
    {
        CN_AsignarTutorias objetoCN = new CN_AsignarTutorias();
        public string IdAsignarTutorias = null;
        public bool Editar = false;
        public string Operacion = "";
        public FormMantAsignarTutoria()
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
        private void FormMantAsignarTutoria_Load(object sender, EventArgs e)
        {


        }

        public void MostrarMatriculas()
        {
            CN_AsignarTutorias objeto = new CN_AsignarTutorias();

            cmbMatricula.DataSource = objeto.MostrarMatri();
            cmbMatricula.DisplayMember = "Matricula_Estudiante";
            cmbMatricula.ValueMember = "Id_Estudiante";

        }
        public void MostrarMaterias()
        {
            CN_AsignarTutorias objeto = new CN_AsignarTutorias();
            FormMantAsignarTutoria frm = new FormMantAsignarTutoria();

            cmbMateria.DataSource = objeto.MostrarMater();
            cmbMateria.DisplayMember = "Nombre_Materia";
            cmbMateria.ValueMember = "Id_Materia";

        }
        public void MostrarCiclos()
        {
            CN_AsignarTutorias objeto = new CN_AsignarTutorias();



            cmbCiclo.DataSource = objeto.MostrarCic();
            cmbCiclo.DisplayMember = "Periodo";
            cmbCiclo.ValueMember = "Id_Ciclo";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Operacion == "Insertar")
            {
                try
                {
                    objetoCN.InsertarAsig(cmbMatricula.SelectedValue.ToString(), cmbMateria.SelectedValue.ToString(), cmbCiclo.SelectedValue.ToString());
                    MessageBox.Show("Estudiante  Registrado Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    objetoCN.EditarAsig(cmbMatricula.SelectedValue.ToString(), cmbMateria.SelectedValue.ToString(), cmbCiclo.SelectedValue.ToString(), IdAsignarTutorias);
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
    }
    }