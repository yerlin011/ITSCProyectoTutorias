using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Tutorias
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarTu()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTutorias";
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
        public DataTable MostrarDia()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarHor()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarHorarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarMaes()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarNombreMaestro";
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
        public void Insertar(int CodMateria, int CodDia, int CodHorario, int CodMaestro, int Periodo)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarTutorias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdMateria", CodMateria);
            comando.Parameters.AddWithValue("@IdDia", CodDia);
            comando.Parameters.AddWithValue("@IdHorario", CodHorario);
            comando.Parameters.AddWithValue("@IdMaestro", CodMaestro);
            comando.Parameters.AddWithValue("@IdCiclo", Periodo);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(int CodMateria, int CodMaestro, int CodDia, int CodHorario, int Periodo, int IdTutoria)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarTutorias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdMateria", CodMateria);
            comando.Parameters.AddWithValue("@IdMaestro", CodMaestro);
            comando.Parameters.AddWithValue("@IdDia", CodDia);
            comando.Parameters.AddWithValue("@IdHorario", CodHorario);
            comando.Parameters.AddWithValue("@IdCiclo", Periodo);

            comando.Parameters.AddWithValue("@IdTutoria", IdTutoria);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int IdTutoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarTutorias";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdTutoria", IdTutoria);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public DataTable Buscar(string buscar)
        {

            DataTable dt = new DataTable();
            SqlDataReader Leerfilas;
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "select T.Id_Tutoria,M.Nombre_Materia as Materia,D.Nombre_Dias as Dias, H.Nombre_Horario as Horario,MA.Nombre_Maestro as Nombre, C.Periodo from CREAR_TUTORIA AS T inner join MATERIA as M on T.Codigos_Asignatura = M.Id_Materia inner join DIAS as D on T.Codigos_Dias = D.Id_Dias inner join HORARIO as H on T.Codigos_Horas = H.Id_Horario inner join MAESTRO as MA on T.Codigos_Maestro = MA.Id_Maestro  inner join CICLO as C on T.Codigos_Ciclo=C.Id_Ciclo where M.Nombre_Materia like ('" + buscar + "%') or MA.Nombre_Maestro like ('" + buscar + "%') or D.Nombre_Dias like('" + buscar + "%') ";
            Leerfilas = comando.ExecuteReader();
            dt.Load(Leerfilas);



            conexion.CerrarConexion();
            return dt;


        }
    }
}
