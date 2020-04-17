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
    public partial class FormMantMaestros : Form
    {
        public FormMantMaestros()
        {
            InitializeComponent();
        }
        CN_Profesores objetoCN = new CN_Profesores();
        public string idMaestro = null;
        //private bool Editar = false;
        public string Operacion = "";

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
        private void FormMantMaestros_Load(object sender, EventArgs e)
        {

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Codigo ", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCodigo.Select();
                return;
            }

            if (this.txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Nombre completo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNombre.Select();
                return;
            }
            if (this.txtDepartamento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Departamento", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDepartamento.Select();
                return;
            }
            
            if (this.txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Correo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCorreo.Select();
                return;
            }
            if (this.maskedTxtTelefono.Text == "   -   -")
            {
                MessageBox.Show("Ingrese Telefono", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.maskedTxtTelefono.Select();
                return;
            }

            //INSERTAR
            if (Operacion == "Insertar")
            {
                try
                {
                    objetoCN.InsertarMaes(txtCodigo.Text ,txtNombre.Text, txtDepartamento.Text,txtCorreo.Text, maskedTxtTelefono.Text);

                    MessageBox.Show("Maestro Registrado Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    objetoCN.EditarMaes(txtCodigo.Text, txtNombre.Text, txtDepartamento.Text, txtCorreo.Text, maskedTxtTelefono.Text, idMaestro);
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

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
