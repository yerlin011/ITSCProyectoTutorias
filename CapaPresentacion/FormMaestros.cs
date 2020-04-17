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
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FormMaestros : Form
    {

        CN_Profesores objetoCN = new CN_Profesores();
        private string idMaestro = null;
        private bool Editar = false;
        public string Operacion = "Insertar";

        public FormMaestros()
        {
            InitializeComponent();
        }
        private void FormMaestros_Load(object sender, EventArgs e)
        {
            MostrarMaestros();
        }

        private void MostrarMaestros()
        {

            CN_Profesores objeto = new CN_Profesores();
            dataGridViewMaestros.DataSource = objeto.MostrarMaes();
            this.dataGridViewMaestros.Columns["Id_Maestro"].Visible = false;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormMantMaestros frm = new FormMantMaestros();
            frm.Operacion = "Insertar";
            frm.ShowDialog();
            MostrarMaestros();

            ////INSERTAR
            //if (Editar == false)
            //{
            //    try
            //    {
            //        objetoCN.InsertarMaes(txtNombre.Text,txtDepartamento.Text);
            //        MessageBox.Show("se inserto correctamente");
            //        MostrarMaestros();
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
            //        objetoCN.EditarMaes(txtNombre.Text, txtDepartamento.Text, idMaestro);
            //        MessageBox.Show("se edito correctamente");
            //        MostrarMaestros();
            //        LimpiarForm();
            //        Editar = false;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("no se pudo editar los datos por: " + ex);
            //    }
            //}
        }
        private void LimpiarForm()
        {
            //txtNombre.Clear();
            //txtDepartamento.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //EDITAR
            //Editar = true;
            if (dataGridViewMaestros.SelectedRows.Count > 0)
            {
                FormMantMaestros frm = new FormMantMaestros();
                frm.Operacion = "Editar";
                frm.txtCodigo.Text = dataGridViewMaestros.CurrentRow.Cells[1].Value.ToString();
                frm.txtNombre.Text = dataGridViewMaestros.CurrentRow.Cells["Nombre"].Value.ToString();
                frm.txtDepartamento.Text = dataGridViewMaestros.CurrentRow.Cells["Departamento"].Value.ToString();
                frm.txtCorreo.Text = dataGridViewMaestros.CurrentRow.Cells["Correo"].Value.ToString();
                frm.maskedTxtTelefono.Text = dataGridViewMaestros.CurrentRow.Cells["Telefono"].Value.ToString();


                frm.idMaestro = dataGridViewMaestros.CurrentRow.Cells["Id_Maestro"].Value.ToString();
                frm.ShowDialog();
                MostrarMaestros();


            }

            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaestros.SelectedRows.Count > 0)
            {
                DialogResult resul = MessageBox.Show("Esta seguro que desea eliminar este registro?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resul == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("No esta permitido eliminar ya que se borraran todos los registros que dependen de este");
                }
                //idMaestro = dataGridViewMaestros.CurrentRow.Cells["Id_Maestro"].Value.ToString();
                //objetoCN.EliminarMaes(idMaestro);
                //MessageBox.Show("Eliminado Correctamente");
                //MostrarMaestros();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarEstudiantes();
        }

        public void BuscarEstudiantes()
        {
            CN_Profesores objetobusqueda = new CN_Profesores();
            dataGridViewMaestros.DataSource = objetobusqueda.BuscarMaes(txtBuscar.Text);
            //dataGridView2.DataSource = objetoCN.BuscarEst(txtBuscar.Text.Trim());
            //MostrarEstudiantes();
            //conexion.Open();

            //SqlCommand cmd = conexion.CreateCommand();

            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT * FROM MAESTRO where Nombre_Maestro as Nombre like ('" + txtBuscar.Text + "%') ";
            //cmd.ExecuteNonQuery();

            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);

            //da.Fill(dt);

            //dataGridViewMaestros.DataSource = dt;

            //conexion.Close();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }

       
    }


