using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
   public class CN_Empleado
    {
        CD_Empleado objdato = new CD_Empleado();

        String _Usuario;
        String _Contraseña;

        public String Usuario
        {
            set { _Usuario = value; }
            get { return _Usuario; }
        }

        public String Contraseña
        {
            set { _Contraseña = value; }
            get { return _Contraseña; }
        }

       public CN_Empleado() { }

        public SqlDataReader IniciarSession()
        {
            SqlDataReader Loguear;
            Loguear = objdato.IniciarSession(Usuario, Contraseña);

            return Loguear;
        }

        public string RecuperarPass(string dni)
        {
            string Mensaje;
            Mensaje = objdato.RecuperarContraseña(dni);

            return Mensaje;
        }
    }
}
