using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class CN_AsignarTutorias
    {
        CD_AsignarTutorias objetoCD = new CD_AsignarTutorias();


        public DataTable MostrarAsigT()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarAsignaciones();
            return tabla;
        }
        public DataTable MostrarMatri()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMatr();
            return tabla;
        }
        public DataTable MostrarMater()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMat();
            return tabla;
        }
       
       
        public DataTable MostrarCic()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCi();
            return tabla;
        }
        public void InsertarAsig(string Matricula, string Asignatura, string Periodo)
        {

            objetoCD.Insertar(Convert.ToInt32(Matricula), Convert.ToInt32(Asignatura), Convert.ToInt32(Periodo));
        }

        public void EditarAsig(string Matricula, string Asignatura, string Periodo, string idAsignarTutorias)
        {
            objetoCD.Editar(Convert.ToInt32(Matricula), Convert.ToInt32(Asignatura), Convert.ToInt32(Periodo),
            Convert.ToInt32(idAsignarTutorias));
        }

        public void EliminarAsig(string idAsignarTutorias)
        {

            objetoCD.Eliminar(Convert.ToInt32(idAsignarTutorias));
        }
        public DataTable BuscarAsignaciones(string buscar)
        {

            DataTable dt = new DataTable();
            dt = objetoCD.Buscar(buscar);
            return dt;
        }

    }
}
