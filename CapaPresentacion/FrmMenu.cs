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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            PrivilegiosUsuarios();
            MostrarUsuariosActivos();
        }

        private void PrivilegiosUsuarios()
        {
            ///Desabilitando los botones
            ///Ocultando los Botones
            ///Bloquiando el acceso al evento de los botones
            if (Program.Cargo != "Administrador")
            {
                btnTutoria.Enabled = false;
                btnMaestro.Enabled = false;
                btnUsuarios.Enabled = false;
            }
                //if (Program.Cargo != "Administrador")
                //{
                //    btnTutoria.Visible= false;
                //    btnMaestro.Visible = false;
                //}

            }
        private void MostrarUsuariosActivos()
        {
            lblCargo.Text    = Program.Cargo;
            lblNombre.Text   = Program.Nombres;
            lblApellido.Text = Program.Apellidos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.Cargo == "Administrador")
            {
                panelLeft.Height = btnMenu.Height;
                panelLeft.Top = btnMenu.Top;

                AbrirFrmHija(new MenuPrincipal());



            }else
            {
                MessageBox.Show("Usuario No tiene permiso para esta opcion");
            }



        }

        private void btnTutoria_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnTutoria.Height;
            panelLeft.Top = btnTutoria.Top;

            AbrirFrmHija(new BtnReportTutoria());
        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnEst.Height;
            panelLeft.Top = btnEst.Top;
            AbrirFrmHija(new FormEstudiantes());

        }

        private void btnMaestro_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnMaestro.Height;
            panelLeft.Top = btnMaestro.Top;
            AbrirFrmHija(new FormMaestros());


        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            //panelLeft.Height = btnRep.Height;
            //panelLeft.Top = btnRep.Top;
            //AbrirFrmHija(new FormReportes());
        }
        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnAsistencia.Height;
            panelLeft.Top = btnAsistencia.Top;
            AbrirFrmHija(new FormAsistencia());
        }

        private void AbrirFrmHija(object frmHija)
        {
            if(this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
                Form fr = frmHija as Form;
                fr.TopLevel = false;
                fr.Dock = DockStyle.Fill;
                this.Contenedor.Controls.Add(fr);
                this.Contenedor.Tag = fr;
                fr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnUsuarios.Height;
            panelLeft.Top = btnUsuarios.Top;
            AbrirFrmHija(new FormUsuario());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        int posY = 0;
        int posX = 0;
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;

            }else
            {
                Left = Left + (e.X - posX);
                Top =  Top   + (e.Y - posY);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;

            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void Contenedor_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;

            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

       

       

     
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 949)
            {
                panel2.Width = 70;
            }
            else panel2.Width = 949;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Esta seguro que desea cerrar sesión?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                FormLogin frmL = new FormLogin();
                frmL.Show();
            }
            

        }

        int lx, ly;
        int sw, sh;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos al departamento de nivelación");
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            
        }

        

        private void btnAsignarTutorias_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnAsignarTutorias.Height;
            panelLeft.Top = btnAsignarTutorias.Top;
            AbrirFrmHija(new FormAsignarTutorias());
        }

        private void btnCiclo_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnCiclo.Height;
            panelLeft.Top = btnCiclo.Top;
            AbrirFrmHija(new FormCiclos());
        }

        
    }
    }

