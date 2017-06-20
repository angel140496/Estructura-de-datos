using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Nodo
    {
        private string _resultado
        {
            get;
        }
        public string resultado
        {
            get
            {
                return 
                    _resultado;
            }
        }

        public Nodo Izquierda
        {
            get; set;
        }

        public Nodo Derecha
        {
            get; set;
        }

        public Nodo siguiente
        {
            get; set;
        }

        public Nodo Anterior
        {
            get; set;
        }

        public Nodo(string nodo)
        {
            this._resultado = nodo;
            Izquierda = null;
            Derecha = null;
            siguiente = null;
            Anterior = null;
        }

        public override string ToString()
        {
            return _resultado + "";
        }
    }
}

