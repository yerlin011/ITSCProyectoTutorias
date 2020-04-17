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
    public partial class FormRecuperarContraseña : Form
    {
        CN_Empleado obj = new CN_Empleado();
        public FormRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if  (this.txtdni.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Dni", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtdni.Select();
                return;
            }
           else
            txtMensaje.Text = obj.RecuperarPass(txtdni.Text);
            Limpiar();
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtdni.Clear();
        }

        private void txtdni_Enter(object sender, EventArgs e)
        {
            if (txtdni.Text == "Ingresar Usuario")
            {
                txtdni.Text = "";
                txtdni.ForeColor = Color.Black;
            }
        }

        private void txtdni_Leave(object sender, EventArgs e)
        {
            if (txtdni.Text == "")
            {
                txtdni.Text = "Ingresar Usuario";
                txtdni.ForeColor = Color.Black;
            }
        }

        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRecuperarContraseña_Load(object sender, EventArgs e)
        {
            
        }
    }
}
