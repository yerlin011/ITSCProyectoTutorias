using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
  public  class CN_Profesores
    {

        private CD_Profesores objetoCD = new CD_Profesores();

        public DataTable MostrarMaes()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarMaes(string codigoMaest,string nombre, string departamento,string correo,string telefono)
        {

            objetoCD.Insertar(codigoMaest,nombre,departamento,correo,telefono);
        }

        public void EditarMaes(string codigoMaest, string nombre, string departamento, string correo, string telefono, string idMaestro)
        {
            objetoCD.Editar(codigoMaest, nombre, departamento, correo, telefono, Convert.ToInt32(idMaestro));
        }

        public void EliminarMaes(string idMaestro)
        {

            objetoCD.Eliminar(Convert.ToInt32(idMaestro));
        }
        public DataTable BuscarMaes(string buscar)
        {

            DataTable dt = new DataTable();
            dt = objetoCD.Buscar(buscar);
            return dt;
        }
    }
}
