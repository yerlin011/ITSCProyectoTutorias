using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Estudiantes
    {
        private CD_Estudiantes objetoCD = new CD_Estudiantes();

        public DataTable MostrarEst() {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable MostrarCarr()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCarreras();
            return tabla;
        }
        public DataTable MostrarMate()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMat();
            return tabla;
        }
        public void InsertarEst(string matricula, string nombre, string apellido, string codCarrera, string telefono, string fecha)
        {

            objetoCD.Insertar(matricula,nombre, apellido,Convert.ToInt32( codCarrera),telefono,Convert.ToDateTime(fecha));
        }

        public void EditarEst(string matricula, string nombre, string apellido,string codCarrera, string telefono, string idEstudiante)
        {
            objetoCD.Editar(matricula, nombre, apellido, Convert.ToInt32(codCarrera),telefono, Convert.ToInt32(idEstudiante));
        }

        public void EliminarEst(string idEstudiante)
        {

            objetoCD.Eliminar(Convert.ToInt32(idEstudiante));
        }
        //public void BuscarEsti(string buscar)
        //{
        //    objetoCD.Buscar(buscar);
        //}

        public DataTable BuscarEst(string buscar)
        {

            DataTable dt = new DataTable();
            dt = objetoCD.Buscar(buscar);
            return dt;
        }
    }
}
