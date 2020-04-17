using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Asistencia
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarAsistencia()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAsistencia4";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarMatr()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMatriculaAsistencias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarCodigoTu()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCodTutorias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }


    
        
        public void Insertar(int CodMatricula, int CodTutoria,DateTime Fecha)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAsistencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodMatricula", CodMatricula);
            comando.Parameters.AddWithValue("@CodTutoria", CodTutoria);
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(int CodMatricula, int CodTutoria, DateTime Fecha, int IdAsistencia)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarAsistencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodMatricula", CodMatricula);
            comando.Parameters.AddWithValue("@CodTutoria", CodTutoria);
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.Parameters.AddWithValue("@IdAsistencia", IdAsistencia);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int IdAsistencia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAsistencia";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdAsistencia", IdAsistencia);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public DataTable Buscar(string buscar)
        {

            DataTable dt = new DataTable();
            SqlDataReader Leerfilas;
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "select DISTINCT Id_Asistencia ,A.CodEstudiante ,E.Matricula_Estudiante ,A.CodTutorias,M.Nombre_Materia,D.Nombre_Dias,H.Nombre_Horario,MA.Nombre_Maestro,PER.Periodo ,A.fecha from ASISTENCIA AS A INNER JOIN ESTUDIANTE AS E ON Id_Estudiante = A.CodEstudiante INNER JOIN CREAR_TUTORIA AS C ON Id_Tutoria = A.CodTutorias INNER JOIN MATERIA as M ON M.Id_Materia = C.Codigos_Asignatura INNER JOIN DIAS AS D ON D.Id_Dias = C.Codigos_Dias INNER JOIN HORARIO AS H ON H.Id_Horario = C.Codigos_Horas INNER JOIN MAESTRO as MA ON MA.Id_Maestro = C.Codigos_Maestro INNER JOIN CICLO AS PER ON PER.Id_Ciclo = C.Codigos_Ciclo INNER JOIN ASIGNAR_TUTORIA AS AT ON AT.Matricula = E.Id_Estudiante where E.Matricula_Estudiante like ('" + buscar + "%') or A.CodTutorias like ('" + buscar + "%') ";



            Leerfilas = comando.ExecuteReader();
            dt.Load(Leerfilas);



            conexion.CerrarConexion();
            return dt;


        }
    }
}
