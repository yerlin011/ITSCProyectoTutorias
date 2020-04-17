using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string dni, string nombre, string apellido, string cargo, string email, string contraseña)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dni", dni);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Cargo", cargo);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
          

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(string dni, string nombre, string apellido, string cargo, string email, string contraseña ,int idUsuario)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dni", dni);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Cargo", cargo);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
            comando.Parameters.AddWithValue("@Id", idUsuario);



            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int idUsuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id", idUsuario);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public DataTable Buscar(string buscar)
        {

            DataTable dt = new DataTable();
            SqlDataReader Leerfilas;
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "SELECT * FROM Usuarios where Nombres like ('" + buscar + "%')  ";
            Leerfilas = comando.ExecuteReader();
            dt.Load(Leerfilas);


            conexion.CerrarConexion();
            return dt;


        }
    }
}
