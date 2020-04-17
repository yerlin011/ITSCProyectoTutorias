using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objetoCD = new CD_Usuarios();

        public DataTable MostrarUser()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarUser(string dni, string nombre, string apellido, string cargo, string email, string contraseña)
        {

            objetoCD.Insertar(dni,nombre,apellido,cargo,email,contraseña);
        }

        public void EditarUser(string dni, string nombre, string apellido, string cargo, string email, string contraseña, string idUsuario)
        {
            objetoCD.Editar(dni, nombre, apellido, cargo, email, contraseña, Convert.ToInt32(idUsuario));
        }

        public void EliminarUser(string idUsuario)
        {

            objetoCD.Eliminar(Convert.ToInt32(idUsuario));
        }
        public DataTable BuscarUser(string buscar)
        {

            DataTable dt = new DataTable();
            dt = objetoCD.Buscar(buscar);
            return dt;
        }

    }
}
