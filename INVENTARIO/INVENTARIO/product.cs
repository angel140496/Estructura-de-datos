using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTARIO
{
    class product
    {
        private int _codigo;
        private string _nombre;
        private int _cantidad;
        private int _costo;
        private int _posicion;

        public product(int codigo, string nombre, int cantidad, int costo, int posicion)
        {
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _costo = costo;
            _posicion = posicion;
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

        public int posicion
        {
            get
            {
               
                return _posicion;
            }

            set
            {
                _posicion = value;
            }
        }
        public override string ToString()
        {
            
            return "Código: " + Codigo + ","
                   + " Nombre: " + Nombre + ","
                   + " Cantidad: " + Cantidad + ","
                   + " Costo: $ " + Costo + ","
                   + " Posicion: " + posicion + "." + Environment.NewLine;
        }
    }
}
