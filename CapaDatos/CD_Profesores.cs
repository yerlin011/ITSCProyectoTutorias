using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Profesores
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMaestros";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string codigoMaest,string nombre, string departamento ,string correo, string telefono )
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarMaestros";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodMaestro", codigoMaest);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Departamento", departamento);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Telefono", telefono);





            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(string codigoMaest, string nombre, string departamento, string correo, string telefono, int idMaestro)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarMaestros";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodMaestro", codigoMaest);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Departamento", departamento);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@IdMaestro", idMaestro);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int idMaestro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarMaestros";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idMaestro", idMaestro);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public DataTable Buscar(string buscar)
        {

            DataTable dt = new DataTable();
            SqlDataReader Leerfilas;
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "SELECT * FROM MAESTRO where Nombre_Maestro like ('" + buscar + "%') ";
            Leerfilas = comando.ExecuteReader();
            dt.Load(Leerfilas);


            conexion.CerrarConexion();
            return dt;


        }
    }
}
