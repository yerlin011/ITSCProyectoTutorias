using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();        }

        private void label1_Enter(object sender, EventArgs e)
        {

        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if(txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Empleado ObjEmpleado = new CN_Empleado();
                SqlDataReader Loguear;

                ObjEmpleado.Usuario = txtusuario.Text;
                ObjEmpleado.Contraseña = txtpass.Text;
                Loguear = ObjEmpleado.IniciarSession();
                if (Loguear.Read() == true)
                {
                    FrmMenu obj       = new FrmMenu();
                    Program.Cargo     = Loguear["Cargo"].ToString();
                    Program.Nombres   = Loguear["Nombres"].ToString();
                    Program.Apellidos = Loguear["Apellidos"].ToString();

                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o password Incorrecta");
                }
            }
            catch (Exception E)
            {

                MessageBox.Show("Error"+E.Message);
            }
           
          }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarContraseña Rp = new FormRecuperarContraseña();
            Rp.ShowDialog();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    CN_Empleado ObjEmpleado = new CN_Empleado();
                    SqlDataReader Loguear;

                    ObjEmpleado.Usuario = txtusuario.Text;
                    ObjEmpleado.Contraseña = txtpass.Text;
                    Loguear = ObjEmpleado.IniciarSession();
                    if (Loguear.Read() == true)
                    {
                        FrmMenu obj = new FrmMenu();
                        Program.Cargo = Loguear["Cargo"].ToString();
                        Program.Nombres = Loguear["Nombres"].ToString();
                        Program.Apellidos = Loguear["Apellidos"].ToString();

                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o password Incorrecta");
                    }
                }
                catch (Exception E)
                {

                    MessageBox.Show("Error" + E.Message);
                }
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
