using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_circulares
{
    class Base
    {
        private Base _siguiente;

        private string _nombre;
        private int _minutos;

        public Base(string nombre, int minutos)
        {
            _nombre = nombre;
            _minutos = minutos;
        }

        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }


        public int Minutos
        {
            set { _minutos = value; }
            get { return _minutos; }
        }

        public Base Siguiente
        {
            set { _siguiente = value; }
            get { return _siguiente; }
        }

        public override string ToString()
        {
            return " Nombre: " + Nombre + ","
                + " Minutos: " + Minutos + "." + Environment.NewLine;
        }
    }
}

