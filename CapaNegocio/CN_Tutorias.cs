using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
   public  class CN_Tutorias
    {
        CD_Tutorias objetoCD = new CD_Tutorias();


        public DataTable MostrarTutori()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarTu();
            return tabla;
        }
        public DataTable MostrarMate()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMat();
            return tabla;
        }
        public DataTable MostrarDias()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarDia();
            return tabla;
        }
        public DataTable MostrarHora()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarHor();
            return tabla;
        }
        public DataTable MostrarMaest()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMaes();
            return tabla;
        }
        public DataTable MostrarCic()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCi();
            return tabla;
        }
        public void InsertarTut(string CodMateria, string CodDia, string CodHorario, string CodMaestro, string Periodo)
        {

            objetoCD.Insertar(Convert.ToInt32(CodMateria), Convert.ToInt32(CodDia), Convert.ToInt32(CodHorario), Convert.ToInt32(CodMaestro), Convert.ToInt32(Periodo));
        }

        public void EditarTut(string CodMateria,string CodDia, string CodHorario,string CodMaestro, string Periodo, string IdTutoria)
        {
            objetoCD.Editar(Convert.ToInt32(CodMateria), Convert.ToInt32(CodDia), Convert.ToInt32(CodHorario), Convert.ToInt32(CodMaestro),Convert.ToInt32(Periodo),
            Convert.ToInt32(IdTutoria));
        }

        public void EliminarTut(string IdTutoria)
        {

            objetoCD.Eliminar(Convert.ToInt32(IdTutoria));
        }
        public DataTable BuscarTutor(string buscar)
        {

            DataTable dt = new DataTable();
            dt = objetoCD.Buscar(buscar);
            return dt;
        }
        
    }
}
