using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Ciclo
    {
        private CD_Ciclo objetoCD = new CD_Ciclo();

        public DataTable MostrarCicl()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        
        public void InsertarCiclo(string fechaInicio, string fechaTermino, string Periodo)
        {

            objetoCD.Insertar(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaTermino),Periodo);
        }

        public void EditarCiclo(string fechaInicio, string fechaTermino, string Periodo, string idCiclo)
        {
            objetoCD.Editar(Convert.ToDateTime(fechaInicio), Convert.ToDateTime(fechaTermino), Periodo, Convert.ToInt32(idCiclo));
        }

        public void EliminarCiclo(string idCiclo)
        {

            objetoCD.Eliminar(Convert.ToInt32(idCiclo));
        }
        //public void BuscarEsti(string buscar)
        //{
        //    objetoCD.Buscar(buscar);
        //}

        public DataTable BuscarCiclo(string buscar)
        {

            DataTable dt = new DataTable();
            dt = objetoCD.Buscar(buscar);
            return dt;
        }
    }
}
