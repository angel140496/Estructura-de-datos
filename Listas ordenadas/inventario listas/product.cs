using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario_listas
{
    class product
    {
        private product _siguiente;

        private int _codigo;
        private string _nombre;
        private int _cantidad;
        private int _costo;

        public product(int codigo, string nombre, int cantidad, int costo)
        {
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _costo = costo;
        }

        public product Siguiente
        {
            get
            {
                return _siguiente;
            }
            set
            {
                _siguiente = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _cantidad;
            }

            set
            {
                _cantidad = value;
            }
        }

        public int Costo
        {
            get
            {
                return _costo;
            }

            set
            {
                _costo = value;
            }
        }

        public int Codigo
        {
            get
            {
                return _codigo;
            }
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
