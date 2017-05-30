using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_doblemente_enlazada
{
    class listaDoble
    {
        producto _inicio = null;
        private int _codMayor;
        private int _codMenor;

        public void mAgregar(producto nuevo)
        {
            if (_inicio == null)
            {
                _inicio = nuevo;
                _codMayor = _inicio.Codigo;
                _codMenor = _inicio.Codigo;
            }
            else
            {
                mAgregarOrdenado(nuevo);
            }
        }

        private void mAgregarOrdenado(producto n)
        {
            producto t = _inicio;

            if (n.Codigo < _codMenor)
            {
                mAgregarInicio(n);
                _codMenor = n.Codigo;
            }
            else if (n.Codigo > _codMayor)
            {
                while (t.Siguiente != null)
                {
                    t = t.Siguiente;
                }
                t.Siguiente = n;
                n.Anterior = t;
                _codMayor = n.Codigo;
            }
            else
            {
                while (n.Codigo > t.Siguiente.Codigo)
                {
                    t = t.Siguiente;
                }
                n.Siguiente = t.Siguiente;
                t.Siguiente.Anterior = n;
                t.Siguiente = n;
                n.Anterior = t;
            }
        }

        public void mAgregarInicio(producto x)
        {
            x.Siguiente = _inicio;
            _inicio = x;
        }

        public producto mBuscar(int num)
        {
            producto r = null;
            bool encuentre = false;
            producto t = _inicio;


            while (t != null && !encuentre)
            {
                if (t.Codigo == num)
                {
                    encuentre = true;
                    r = t;
                }
                else
                {
                    t = t.Siguiente;
                }
            }

            return t;
            
        }

        public void mEliminar(int num)
        {
            producto eliminar = mBuscar(num);

            if (eliminar != null)
            {
                if (eliminar == _inicio)
                {
                    _inicio = _inicio.Siguiente;

                    if (_inicio != null)
                    {
                        _inicio.Anterior = null;
                    }
                }
                else
                {
                    if (eliminar.Siguiente == null)
                    {
                        eliminar.Anterior.Siguiente = null;
                    }
                    else
                    {
                        eliminar.Anterior.Siguiente = eliminar.Siguiente;
                        eliminar.Anterior.Siguiente = eliminar.Anterior;
                    }
                }
            }
        }

        public void mEliminarPrimero()
        {
            if (_inicio != null)
            {
                _inicio = _inicio.Siguiente;
            }
        }

        public void mEliminarUltimo()
        {
            producto x = _inicio;

            if (_inicio != null && _inicio.Siguiente == null)
            {
                _inicio = null;
            }
            else if (_inicio != null)
            {
                while (x.Siguiente.Siguiente != null)
                    x = x.Siguiente;

                x.Siguiente = null;

            }
        }

        public string rI()
        {
            if (_inicio == null)
            {
                return "";
            }
            else
            {
                return rI(_inicio);
            }
        }

        public string rI(producto x)
        {
            if (x.Siguiente == null)
            {
                return x.ToString();
            }
            else
            {
                return rI(x.Siguiente) + x.ToString();
            }
        }

        public string mListar()
        {
            producto t = _inicio;

            string _vCadena = "";

            while (t != null)
            {
                _vCadena += t.ToString();
                t = t.Siguiente;
            }

            return _vCadena;
        }
    }
}

  