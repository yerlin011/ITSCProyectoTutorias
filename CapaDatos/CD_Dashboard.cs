using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Dashboard
    {
        CD_Conexion Con = new  CD_Conexion();
        SqlCommand cmd;
        SqlDataReader dr;
        E_Dashboard obj = new E_Dashboard();
        public void EstMaterias(E_Dashboard obj)
        {
            //cmd.CommandText = "MateriasTutorias";
            cmd = new SqlCommand("MateriasTutorias", Con.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Con.AbrirConexion();

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.Materia.Add(dr.GetString(0));
                obj.Cant.Add(dr.GetInt32(1));


            }
            dr.Close();
            Con.CerrarConexion();
        }
        public void EstCarreras(E_Dashboard obj)
        {
            cmd = new SqlCommand("CarrerasTomanTutorias", Con.Conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            Con.AbrirConexion();

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.Carrera.Add(dr.GetString(0));
                obj.CantCarrera.Add(dr.GetInt32(1));


            }
            dr.Close();
            Con.CerrarConexion();
        }
        public void SumarioDatos(E_Dashboard obj)
        {
            cmd = new SqlCommand("DashboardDatos", Con.Conexion);

            //cmd.CommandText = "DashboardDatos";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter totalEst = new SqlParameter("@IdEstudiante", 0); totalEst.Direction = ParameterDirection.Output;
            SqlParameter nCarrera = new SqlParameter("@IdCarrera", 0); nCarrera.Direction = ParameterDirection.Output;
            SqlParameter nMaestro = new SqlParameter("@IdMaestro", 0); nMaestro.Direction = ParameterDirection.Output;
            SqlParameter nMateria = new SqlParameter("@IdMateria", 0); nMateria.Direction = ParameterDirection.Output;
            SqlParameter nTutoria = new SqlParameter("@IdTutoria", 0); nTutoria.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(totalEst);
            cmd.Parameters.Add(nCarrera);
            cmd.Parameters.Add(nMaestro);
            cmd.Parameters.Add(nMateria);
            cmd.Parameters.Add(nTutoria);
            Con.AbrirConexion();

            cmd.ExecuteNonQuery();
            obj.TotalEstudiantes = cmd.Parameters["@IdEstudiante"].Value.ToString();
            Con.CerrarConexion();

        }
    }
}
