using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;


namespace CapaDatos
{
    public class CD_Empleado
    {
        private CD_Conexion conexion = new CD_Conexion();
        private String Email, Nombres, Contraseña;
        private String Mensaje;
        private SqlDataReader leer;
        private SqlCommand Comando = new SqlCommand();
        public String RecuperarContraseña(string dni)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "select * from Usuarios where Dni=" + dni;
            leer = Comando.ExecuteReader();
            if (leer.Read() == true)
            {
                Email = leer["Email"].ToString();
                Nombres = leer["Nombres"].ToString() + "  " + leer["Apellidos"].ToString();
                Contraseña = leer["Contraseña"].ToString();
                EnviarEmail();
                Mensaje = "Estimado" + Nombres + " ,Se ha enviado su contraseña a su correo: "+
                    " "+ Email;
                leer.Close();
            }
            else
            {
                Mensaje = "No existe datos...";
            }
            return Mensaje;
        }
           
        
        public void EnviarEmail()
        {
            ///    CORREO     /////
            MailMessage Correo = new MailMessage();
            Correo.From = new MailAddress("gomezmichael684@gmail.com");
            Correo.To.Add(Email);
            Correo.Subject="Recuperar Contraseña";
            Correo.Body = "Hola,"+Nombres+" usted solicito recuperar su contraseña, su contraseña es"+":"+Contraseña;
            Correo.Priority = MailPriority.Normal;
            ///    Smtp      /////
            SmtpClient ServerMail = new SmtpClient();
            ServerMail.Credentials = new NetworkCredential("gomezmichael684@gmail.com", "redimido29");
            ServerMail.Host = "Smtp.gmail.com";
            ServerMail.Port = 587;
            ServerMail.EnableSsl = true;

            try
            {
                ServerMail.Send(Correo);
            }
            catch (Exception Ex)
            {
                
            }
            Correo.Dispose();

        }
        public SqlDataReader IniciarSession(string user, string pass)
        {
            //string sql = "select * from Usuarios where Dni ='" + user + "' and Contraseña = '" + pass +"'";
            SqlCommand comando = new SqlCommand("SpLogin", conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", user);
            comando.Parameters.AddWithValue("@Password",pass);

            //comando.Connection = conexion.AbrirConexion();
            //comando.CommandText = sql;
            leer = comando.ExecuteReader();

            return leer;
        }
    }
}
