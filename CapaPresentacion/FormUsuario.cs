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
    public partial class FormUsuario : Form
    {
        CN_Usuarios objetoCN = new CN_Usuarios();
        private string idUsuario = null;
        private bool Editar = false;
        public string Operacion = "Insertar";
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dataGridViewUsuarios.DataSource = objeto.MostrarUser();
            this.dataGridViewUsuarios.Columns["Id"].Visible = false;


        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            FormMantUser frm = new FormMantUser();
            frm.Operacion = "Insertar";
            frm.ShowDialog();
            MostrarUsuarios();
            ////INSERTAR
            //if (Editar == false)
            //{
            //    try
            //    {
            //        objetoCN.InsertarUser(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text);
            //        MessageBox.Show("se inserto correctamente");
            //        MostrarUsuarios();
            //        LimpiarForm();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("no se pudo insertar los datos por: " + ex);
            //    }
            //}
            //if (Editar == true)
            //{

            //    try
            //    {
            //        objetoCN.EditarUser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text,idUsuario);
            //        MessageBox.Show("se edito correctamente");
            //        MostrarUsuarios();
            //        LimpiarForm();
            //        Editar = false;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("no se pudo editar los datos por: " + ex);
            //    }
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //EDITAR
            //Editar = true;
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                FormMantUser frm = new FormMantUser();
                frm.Operacion = "Editar";
             
                frm.txtD.Text = dataGridViewUsuarios.CurrentRow.Cells["Dni"].Value.ToString();
                frm.txtnombre.Text = dataGridViewUsuarios.CurrentRow.Cells["Nombres"].Value.ToString();
                frm.txtApellido.Text = dataGridViewUsuarios.CurrentRow.Cells["Apellidos"].Value.ToString();
                frm.txtCargo.Text = dataGridViewUsuarios.CurrentRow.Cells["Cargo"].Value.ToString();
                frm.txtEmail.Text = dataGridViewUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                frm.txtPassword.Text = dataGridViewUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                frm.idUsuario     = dataGridViewUsuarios.CurrentRow.Cells["Id"].Value.ToString();
                frm.ShowDialog();
                MostrarUsuarios();

            }

            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void LimpiarForm()
        {
            //txtD.Clear();
            //txtnombre.Clear();
            //txtApellido.Clear();
            //txtCargo.Clear();
            //txtEmail.Clear();
            //txtPassword.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                idUsuario = dataGridViewUsuarios.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarUser(idUsuario);
                MessageBox.Show("Eliminado Correctamente");
                MostrarUsuarios();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {

            Buscar();
        }
        private void Buscar()
        {
            CN_Usuarios objetobusqueda = new CN_Usuarios();
            dataGridViewUsuarios.DataSource = objetobusqueda.BuscarUser(txtBuscar.Text);
        }

        
    }
    }

    


