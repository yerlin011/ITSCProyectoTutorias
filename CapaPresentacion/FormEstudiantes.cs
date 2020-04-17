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

    public partial class FormEstudiantes : Form
    {
        #region
        //SqlConnection conexion = new SqlConnection("Data Source = YERLIN022\\SQLEXPRESS;Initial Catalog = REGISTRO_TUTORIAS_ACADEMICA; Integrated Security = True");
        #endregion

        CN_Estudiantes objetoCN = new CN_Estudiantes();
        public string idEstudiante = null;
        public bool Editar = false;
        public string Operacion = "Insertar";


        public FormEstudiantes()
        {
            InitializeComponent();
        }


        private void Registro_Load_1(object sender, EventArgs e)
        {

            MostrarCarreras();
            MostrarEstudiantes();
            MostrarMaterias();
            
        }

        private void MostrarEstudiantes()
        {

            CN_Estudiantes objeto = new CN_Estudiantes();
            dataGridView2.DataSource = objeto.MostrarEst();
            this.dataGridView2.Columns["Id_Estudiante"].Visible = false;
        }
        private void MostrarCarreras()
        {

            CN_Estudiantes objeto = new CN_Estudiantes();
            FormMantEstudiantes frm = new FormMantEstudiantes();
            frm.cbmCarrera.DataSource = objeto.MostrarCarr();
            frm.cbmCarrera.DisplayMember = "Nombre_Carrera";
            frm.cbmCarrera.ValueMember = "Id_Carrera";
        }
        private void MostrarMaterias()
        {
            //CN_Estudiantes objeto = new CN_Estudiantes();
            //FormMantEstudiantes frm = new FormMantEstudiantes();

            //frm.cmbMateria.DataSource = objeto.MostrarMate();
            //frm.cmbMateria.DisplayMember = "Nombre_Materia";
            //frm.cmbMateria.ValueMember = "Id_Materia";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ////INSERTAR
            //if (Operacion == "Insertar")
            //{
            //    try
            //    {
            //        txtFecha.Text = DateTime.Now.ToShortDateString();
            //        objetoCN.InsertarEst(txtMatricula.Text, txtNombre.Text, txtApellido.Text,cbmCarrera.SelectedValue.ToString(),txtEstado.Text,txtFecha.Text);
            //        MessageBox.Show("se inserto correctamente");
            //        MostrarEstudiantes();
            //        LimpiarForm();
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
            //        objetoCN.EditarEst(txtMatricula.Text, txtNombre.Text, txtApellido.Text,cbmCarrera.SelectedValue.ToString(), txtEstado.Text, idEstudiante);
            //        MessageBox.Show("se edito correctamente");
            //        MostrarEstudiantes();
            //        LimpiarForm();
            //        //Editar = false;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("no se pudo editar los datos por: " + ex);
            //    }
            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        //    //EDITAR
        //    //Editar = true;
        //    Operacion = "Editar";
        //    if (dataGridView2.SelectedRows.Count > 0)
        //    {
        //        txtMatricula.Text = dataGridView2.CurrentRow.Cells["Matricula_Estudiante"].Value.ToString();
        //        txtNombre.Text = dataGridView2.CurrentRow.Cells["Nombre_Estudiante"].Value.ToString();
        //        txtApellido.Text = dataGridView2.CurrentRow.Cells["Apellido_Estudiante"].Value.ToString();
        //        cbmCarrera.Text = dataGridView2.CurrentRow.Cells["Nombre_Carrera"].Value.ToString();
        //        txtEstado.Text = dataGridView2.CurrentRow.Cells["Estado_Estudiante"].Value.ToString();

        //        idEstudiante = dataGridView2.CurrentRow.Cells["Id_Estudiante"].Value.ToString();


        //    }

        //    else
        //        MessageBox.Show("seleccione una fila por favor");
        }

        private void LimpiarForm()
        {
            //txtMatricula.Clear();
            //txtNombre.Clear();
            //txtApellido.Clear();
            //cbmCarrera.Text = "Carrera";
            //txtEstado.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                idEstudiante = dataGridView2.CurrentRow.Cells["Id_Estudiante"].Value.ToString();
                objetoCN.EliminarEst(idEstudiante);
                MessageBox.Show("Eliminado Correctamente");
                MostrarEstudiantes();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registro_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            //CN_Empleado objbe = new CN_Empleado();
            //dataGridView2.DataSource = objetoCN.BuscarEst(txtBuscar.Text);
            //objetoCN.BuscarEst(txtMatricula.Text, txtNombre.Text);
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CN_Estudiantes objetobusqueda = new CN_Estudiantes();
            dataGridView2.DataSource =objetobusqueda.BuscarEst(txtBuscar.Text);

            //BuscarEstudiantes();

        }

        public void BuscarEstudiantes()
        {
          
           #region
        //    //dataGridView2.DataSource = objetoCN.BuscarEst(txtBuscar.Text.Trim());
        //    //MostrarEstudiantes();
        //    conexion.Open();

        //    SqlCommand cmd = conexion.CreateCommand();

        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "SELECT * FROM ESTUDIANTE where Nombre_Estudiante like ('" + txtBuscar.Text + "%') or Matricula_Estudiante like ('" + txtBuscar.Text + "%') ";
        //    cmd.ExecuteNonQuery();

        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);

        //    da.Fill(dt);

        //    dataGridView2.DataSource = dt;

        //    conexion.Close();
           #endregion
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarF2_Click(object sender, EventArgs e)
        {

           
            
            if (dataGridView2.SelectedRows.Count > 0)
            {

                FormMantEstudiantes frm = new FormMantEstudiantes();


                //EDITAR
                //frm.Editar = true;
                frm.Operacion = "Editar";
                frm.MostrarCarreras();
                frm.Materias();
                
                frm.idEstudiante = dataGridView2.CurrentRow.Cells["Id_Estudiante"].Value.ToString();

                frm.maskedtxtMatricula.Text = dataGridView2.CurrentRow.Cells["Matricula_Estudiante"].Value.ToString();
                frm.txtNombre.Text = dataGridView2.CurrentRow.Cells["Nombre_Estudiante"].Value.ToString();
                frm.txtApellido.Text = dataGridView2.CurrentRow.Cells["Apellido_Estudiante"].Value.ToString();
                frm.cbmCarrera.Text = dataGridView2.CurrentRow.Cells["Nombre_Carrera"].Value.ToString();
                frm.maskedTxtTelefono.Text = dataGridView2.CurrentRow.Cells["TELEFONO"].Value.ToString();

                frm.ShowDialog();
                MostrarEstudiantes();

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMantEstudiantes frm = new FormMantEstudiantes();
            frm.Operacion = "Insertar";
            frm.MostrarCarreras();
            frm.Materias();

            frm.ShowDialog();
            MostrarEstudiantes();
        }

        private void btnAsignarTutoria_Click(object sender, EventArgs e)
        {
           

            if (dataGridView2.SelectedRows.Count > 0)
            {
                FormAsignarTutorias hijo = new FormAsignarTutorias();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();

                hijo.Show();

                FormMantAsignarTutoria frm = new FormMantAsignarTutoria();
                
                frm.Operacion = "Insertar";
                frm.MostrarMatriculas();
                frm.MostrarMaterias();
                frm.MostrarCiclos();



                frm.IdAsignarTutorias = dataGridView2.CurrentRow.Cells[0].Value.ToString();

                frm.cmbMatricula.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
             

                frm.ShowDialog();
                hijo.MostrarAsigTutorias();

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }

        }
    }
}


        

 

