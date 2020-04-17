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
    public partial class FormMantUser : Form
    {
        CN_Usuarios objetoCN = new CN_Usuarios();
        public string idUsuario = null;
        private bool Editar = false;
        public string Operacion = "";
        
        public FormMantUser()
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            //if (Operacion == "Insertar")
            //{
            //    try
            //    {
            //        objetoCN.InsertarUser(txtD.Text, txtnombre.Text, txtCargo.Text, txtApellido.Text, txtEmail.Text, txtPassword.Text);
            //        MessageBox.Show("se inserto correctamente");
                    
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
            //        objetoCN.EditarUser(txtD.Text, txtnombre.Text, txtCargo.Text, txtApellido.Text, txtEmail.Text, txtPassword.Text, idUsuario);
            //        MessageBox.Show("se edito correctamente");

            //        this.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("no se pudo editar los datos por: " + ex);
            //    }
            //}
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (this.txtD.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Dni", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtD.Select();
                return;
            }
            if (this.txtnombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Nombre", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtnombre.Select();
                return;
            }
            if (this.txtApellido.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Apellido", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtApellido.Select();
                return;
            }
            if (this.txtCargo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Cargo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCargo.Select();
                return;
            }
            if (this.txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Email", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEmail.Select();
                return;
            }
            if (this.txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Clave", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Select();
                return;
            }



            //INSERTAR
            if (Operacion == "Insertar")
            {
                try
                {
                    objetoCN.InsertarUser(txtD.Text, txtnombre.Text, txtApellido.Text,txtCargo.Text, txtEmail.Text, txtPassword.Text);
                    MessageBox.Show("se inserto correctamente");

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
                    objetoCN.EditarUser(txtD.Text, txtnombre.Text, txtApellido.Text, txtCargo.Text, txtEmail.Text, txtPassword.Text, idUsuario);
                    MessageBox.Show("se edito correctamente");

                    this.Close();
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
