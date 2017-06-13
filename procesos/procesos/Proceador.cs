using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesos
{
    class Proceador
    {
        private @base _inicio;
        private @base _ultimo;

        public void Enqueue(@base nuevo)
        {
            if (_inicio == null)
            {
                _inicio = nuevo;
                _ultimo = nuevo;
                //_inicio.Siguiente = _ultimo;
            }
            else
            {
                @base t = _inicio;

                _ultimo.Siguiente = nuevo;
                _ultimo = nuevo;
            }
        }

        public void Dequeue()
        {
            if (_inicio != null)
            {
                _inicio = _inicio.Siguiente;
            }
        }

        public @base Peek
        {
            get { return _inicio; }
        }
    }
}

