using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesos
{
    class @base
    {
        private @base _siguiente;
        private @base _anterior;

        private int _tiempo;
        private int _proceso;

        public @base(int rand)
        {
            _tiempo = rand;
        }
        public int Tiempo
        {
            set { _tiempo = value; }
            get { return _tiempo; }
        }

        public int Proceso
        {
            set { _proceso = value; }
            get { return _proceso; }
        }

        public @base Siguiente
        {
            set { _siguiente = value; }
            get { return _siguiente; }
        }

        public @base Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public override string ToString()
        {
            return "Proceso: " + _proceso + " Tiempo: " + _tiempo + "      ";
        }
    }
}

