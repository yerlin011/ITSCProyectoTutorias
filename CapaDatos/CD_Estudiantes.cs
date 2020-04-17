using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class CD_Estudiantes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar() { 
       
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEstudiantes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
            
        }
        public DataTable MostrarCarreras()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCarreras";
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


        public void Insertar(string matricula, string nombre, string apellido, int codCarrera, string telefono, DateTime fecha)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEstudiantes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Matricula", matricula);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@CodCarrera", codCarrera);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Fecha", fecha);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(string matricula, string nombre, string apellido, int codCarrera,string telefono,int IdEstudiante)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarEstudiantes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Matricula", matricula);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@IdCarrera", codCarrera);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@idEstudiante", IdEstudiante);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int idEstudiante)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEstudiantes";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public DataTable Buscar(string buscar)
        {

            DataTable dt = new DataTable();
            SqlDataReader Leerfilas;
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "select E.Id_Estudiante  ,E.Matricula_Estudiante,E.Nombre_Estudiante,E.Apellido_Estudiante,C.Nombre_Carrera,E.Telefono,E.Fecha from ESTUDIANTE as E inner join CARRERA as C on E.Codigos_Carrera = C.Id_Carrera  where E.Nombre_Estudiante like ('" + buscar + "%') or E.Matricula_Estudiante like ('" + buscar + "%')  ";
            Leerfilas = comando.ExecuteReader();
            dt.Load(Leerfilas);
           


            conexion.CerrarConexion();
            return dt;

            
        }

    }
}
