using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Dashboard

    {


        ArrayList _Materia = new ArrayList();
        ArrayList _Cant = new ArrayList();
        ArrayList _Carrera = new ArrayList();
        ArrayList _CantCarrera = new ArrayList();
        string _totalEstudiantes;

        public ArrayList Materia
        {
            get
            {
                return _Materia;
            }

            set
            {
                _Materia = value;
            }
        }

        public ArrayList Cant
        {
            get
            {
                return _Cant;
            }

            set
            {
                _Cant = value;
            }
        }

        public ArrayList Carrera
        {
            get
            {
                return _Carrera;
            }

            set
            {
                _Carrera = value;
            }
        }

        public ArrayList CantCarrera
        {
            get
            {
                return _CantCarrera;
            }

            set
            {
                _CantCarrera = value;
            }
        }

        public string TotalEstudiantes
        {
            get
            {
                return _totalEstudiantes;
            }

            set
            {
                _totalEstudiantes = value;
            }
        }
    }
}
