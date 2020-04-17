using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
   public class CN_Asistencia
    {
        CD_Asistencia objetoCD = new CD_Asistencia();


        public DataTable MostrarAsist()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarAsistencia();
            return tabla;
        }
        public DataTable MostrarMatri()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMatr();
            return tabla;
        }
        public DataTable MostrarCodTut()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCodigoTu();
            return tabla;
        }
       
        public void InsertarAsistencia(string CodMatricula, string CodTutoria,  string Fecha)
        {

            objetoCD.Insertar(Convert.ToInt32(CodMatricula), Convert.ToInt32(CodTutoria), Convert.ToDateTime(Fecha));
        }

        public void EditarAsistencia(string CodMatricula, string CodTutoria,string Fecha, string IdAsistencia)
        {
            objetoCD.Editar(Convert.ToInt32(CodMatricula), Convert.ToInt32(CodTutoria), Convert.ToDateTime(Fecha),Convert.ToInt32(IdAsistencia));
        }

        public void EliminarAsistencia(string IdAsistencia)
        {

            objetoCD.Eliminar(Convert.ToInt32(IdAsistencia));
        }
        public DataTable BuscarAsistencia(string buscar)
        {

            DataTable dt = new DataTable();
            dt = objetoCD.Buscar(buscar);
            return dt;
        }
    }
}
