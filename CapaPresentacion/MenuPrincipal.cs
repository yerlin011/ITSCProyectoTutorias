using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        #region 
        //private SqlConnection Conexion = new SqlConnection(@"Data Source = YERLIN022\SQLEXPRESS;Initial Catalog =BD_Registro_Tutorias; Integrated Security = True");
        //SqlCommand cmd;
        //SqlDataReader dr;
        #endregion

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //GrafCarreras();
            //DashboardDatos();
            MostrarDashboard();

        }
        ArrayList Materia = new ArrayList();
        ArrayList Cant = new ArrayList();
        ArrayList Carrera = new ArrayList();
        ArrayList CantCarrera = new ArrayList();
        #region
        //private void GrafMaterias()
        //{
        //    cmd = new SqlCommand("MateriasTutorias", Conexion);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    Conexion.Open();
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        Materia.Add(dr.GetString(0));
        //        Cant.Add(dr.GetInt32(1));


        //    }
        //    chartMaterias.Series[0].Points.DataBindXY(Materia, Cant);
        //    dr.Close();
        //    Conexion.Close();
        //}
        //private void GrafCarreras()
        //{
        //    cmd = new SqlCommand("CarrerasTomanTutorias", Conexion);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    Conexion.Open();
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        Carrera.Add(dr.GetString(0));
        //        CantCarrera.Add(dr.GetInt32(1));


        //    }
        //    chartCarrerasPreferidas.Series[0].Points.DataBindXY(Carrera, CantCarrera);
        //    dr.Close();
        //    Conexion.Close();
        //}
        //private void DashboardDatos()
        //{
        //    cmd = new SqlCommand("DashboardDatos", Conexion);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlParameter totalEst = new SqlParameter("@IdEstudiante", 0); totalEst.Direction = ParameterDirection.Output;
        //    SqlParameter nCarrera = new SqlParameter("@IdCarrera", 0); nCarrera.Direction = ParameterDirection.Output;
        //    SqlParameter nMaestro = new SqlParameter("@IdMaestro", 0); nMaestro.Direction = ParameterDirection.Output;
        //    SqlParameter nMateria = new SqlParameter("@IdMateria", 0); nMateria.Direction = ParameterDirection.Output;
        //    SqlParameter nTutoria = new SqlParameter("@IdTutoria", 0); nTutoria.Direction = ParameterDirection.Output;
        //    cmd.Parameters.Add(totalEst);
        //    cmd.Parameters.Add(nCarrera);
        //    cmd.Parameters.Add(nMaestro);
        //    cmd.Parameters.Add(nMateria);
        //    cmd.Parameters.Add(nTutoria);
        //    Conexion.Open();
        //    cmd.ExecuteNonQuery();
        //    lblEstudiantes.Text = cmd.Parameters["@IdEstudiante"].Value.ToString();
        //    Conexion.Close();

        //}

        //private void chartMaterias_Click(object sender, EventArgs e)
        //{

        //}
        #endregion
        private void MostrarDashboard()
        {
            CN_Dashboard neg = new CN_Dashboard();
            E_Dashboard obj = new E_Dashboard();
            neg.Dashboard(obj);

            //RECUPERANDO DE LA ENTIDAD PARA CAMBIAR LOS DATOS DEL DASHBOARD //
            chartMaterias.Series[0].Points.DataBindXY(obj.Materia, obj.Cant);
            chartCarrerasPreferidas.Series[0].Points.DataBindXY(obj.Carrera, obj.CantCarrera);
            lblEstudiantes.Text = obj.TotalEstudiantes;
        }
      

    }
}
