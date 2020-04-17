using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;


namespace CapaNegocio
{
   public class CN_Dashboard
    {
        public void Dashboard(E_Dashboard obj)
        {
            CD_Dashboard accesDB = new CD_Dashboard();
            accesDB.EstMaterias(obj);
            accesDB.EstCarreras(obj);
            accesDB.SumarioDatos(obj);
        }

    }
}
