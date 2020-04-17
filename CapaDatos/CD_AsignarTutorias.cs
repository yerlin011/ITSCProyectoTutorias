using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class CD_AsignarTutorias
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable MostrarAsignaciones()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAsignaciones";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarMatr()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMatricula";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarMat()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMaterias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarCi()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCiclo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(int Matricula, int Asignatura,int Periodo)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAsignaciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Matricula", Matricula);
            comando.Parameters.AddWithValue("@Asignatura", Asignatura);
            comando.Parameters.AddWithValue("@Periodo",Periodo);
           



            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(int Matricula, int Asignatura, int Periodo, int idAsignarTutorias)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarAsignaciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Matricula", Matricula);
            comando.Parameters.AddWithValue("@Asignatura", Asignatura);
            comando.Parameters.AddWithValue("@Periodo", Periodo);


            comando.Parameters.AddWithValue("@IdAsignarTutorias", idAsignarTutorias);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int idAsignarTutorias)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAsignaciones";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdAsignarTutorias", idAsignarTutorias);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public DataTable Buscar(string buscar)
        {

            DataTable dt = new DataTable();
            SqlDataReader Leerfilas;
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "select Id_AsignarTutoria ,E.Matricula_Estudiante,M.Nombre_Materia,C.Periodo from ASIGNAR_TUTORIA as A INNER JOIN ESTUDIANTE AS E ON E.Id_Estudiante = A.Matricula INNER JOIN MATERIA AS M ON M.Id_Materia = A.Materia INNER JOIN CICLO AS C ON C.Id_Ciclo = A.Ciclo where E.Matricula_Estudiante like ('" + buscar + "%') or M.Nombre_Materia like ('" + buscar + "%') or C.Periodo like('" + buscar + "%')";
            Leerfilas = comando.ExecuteReader();
            dt.Load(Leerfilas);



            conexion.CerrarConexion();
            return dt;


        }
    }
}
