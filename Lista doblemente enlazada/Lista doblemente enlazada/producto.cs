using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_doblemente_enlazada
{
    class producto
    {
        private producto _siguiente;
        private producto _anterior;


        private int _codigo;
        private string _nombre;
        private int _cantidad;
        private int _costo;

        public producto(int codigo, string nombre, int cantidad, int costo)
        {
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _costo = costo;
        }

        public int Codigo
        {
            set { _codigo = value; }
            get { return _codigo; }
        }

        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }

        public int Cantidad
        {
            set { _cantidad = value; }
            get { return _cantidad; }
        }

        public int Costo
        {
            set { _costo = value; }
            get { return _costo; }
        }

        public producto Siguiente
        {
            set { _siguiente = value; }
            get { return _siguiente; }
        }

        public producto Anterior
        {
            set { _anterior = value; }
            get { return _anterior; }
        }

        public override string ToString()
        {
            return "Código: " + Codigo + ","
                + " Nombre: " + Nombre + ","
                + " Cantidad: " + Cantidad + ","
                + " Costo: $ " + Costo + "." + Environment.NewLine;
        }
    }
}
    