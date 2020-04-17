using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class CD_Ciclo
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCicloGestionar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
       

        public void Insertar(DateTime fechaInicio, DateTime fechaTermino,string Periodo)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarCiclos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FechaInicio" , fechaInicio);
            comando.Parameters.AddWithValue("@FechaTermino",fechaTermino);
            comando.Parameters.AddWithValue("@Periodo"     , Periodo);
       
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(DateTime fechaInicio, DateTime fechaTermino, string Periodo, int IdCiclo)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCiclos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@FechaTermino", fechaTermino);
            comando.Parameters.AddWithValue("@Periodo", Periodo);
            comando.Parameters.AddWithValue("@IdCiclo", IdCiclo);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int idCiclo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCiclos";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdCiclo", idCiclo);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public DataTable Buscar(string buscar)
        {

            DataTable dt = new DataTable();
            SqlDataReader Leerfilas;
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "Select * from CICLO where Periodo like ('" + buscar + "%') ";
            Leerfilas = comando.ExecuteReader();
            dt.Load(Leerfilas);



            conexion.CerrarConexion();
            return dt;


        }
    }
}
