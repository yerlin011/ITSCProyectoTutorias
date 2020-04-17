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
    public partial class FormMantCiclos : Form
    {
        CN_Ciclo objetoCN = new CN_Ciclo();
        public string idCiclos = null;
        public bool Editar = false;
        public string Operacion = "";
        public FormMantCiclos()
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
            if (this.FechaInicio.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Fecha Inicio", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FechaInicio.Select();
                return;
            }
            if (this.FechaTermino.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Fecha Termino", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FechaTermino.Select();
                return;
            }
            if (this.maskedTxtPeriodo.Text  == "    -")
            {
                MessageBox.Show("Ingrese Periodo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.maskedTxtPeriodo.Select();
                return;
            }


            //INSERTAR
            if (Operacion == "Insertar")
            {
                try
                {
                    objetoCN.InsertarCiclo(FechaInicio.Text, FechaTermino.Text, maskedTxtPeriodo.Text);
                    MessageBox.Show("Ciclo academico Registrado Correctamente", "Mensaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    objetoCN.EditarCiclo(FechaInicio.Text, FechaTermino.Text, maskedTxtPeriodo.Text, idCiclos);
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
