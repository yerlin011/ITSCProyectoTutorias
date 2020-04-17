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
    public partial class FormMantEstudiantes : Form
    {
        CN_Estudiantes objetoCN = new CN_Estudiantes();
        public string idEstudiante = null;
        public bool Editar = false;
        public string Operacion = "";

        public FormMantEstudiantes()
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
        public void MostrarCarreras()
        {

            CN_Estudiantes objeto = new CN_Estudiantes();
            cbmCarrera.DataSource = objeto.MostrarCarr();
            cbmCarrera.DisplayMember = "Nombre_Carrera";
            cbmCarrera.ValueMember = "Id_Carrera";
        }
        public void Materias()
        {
            //CN_Estudiantes objeto = new CN_Estudiantes();

            //cmbMateria.DataSource = objeto.MostrarMate();
            //cmbMateria.DisplayMember = "Nombre_Materia";
            //cmbMateria.ValueMember = "Id_Materia";

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.maskedtxtMatricula.Text == "    -")
            {
                MessageBox.Show("Ingrese Matricula", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.maskedtxtMatricula.Select();
                return;
            }
            if (this.txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Nombre", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNombre.Select();
                return;
            }
            if (this.txtApellido.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Apellido", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtApellido.Select();
                return;
            }
            if (this.maskedTxtTelefono.Text == "" )
            {
                MessageBox.Show("Ingrese Apellido", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.maskedTxtTelefono.Select();
                return;
            }

            //INSERTAR
            if (Operacion == "Insertar")
            {
                try
                {
                    txtFecha.Text = DateTime.Now.ToShortDateString();
                    objetoCN.InsertarEst(maskedtxtMatricula.Text, txtNombre.Text, txtApellido.Text,cbmCarrera.SelectedValue.ToString(),maskedTxtTelefono.Text
                     ,txtFecha.Text);
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
                    objetoCN.EditarEst(maskedtxtMatricula.Text, txtNombre.Text, txtApellido.Text,cbmCarrera.SelectedValue.ToString(),maskedTxtTelefono.Text, idEstudiante);
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

