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

        public int _proPen;
        public int _cicPen;

        public void mAgregar(@base nuevo)
        {
            if (_inicio == null)
            {
                _inicio = nuevo;
                _inicio.Siguiente = _inicio;
                _inicio.Anterior = _inicio;
            }
            else
            {
               @base t = _inicio;

                while (t.Siguiente != _inicio)
                {
                    t = t.Siguiente;
                }

                t.Siguiente = nuevo;
                nuevo.Anterior = t;
                nuevo.Siguiente = _inicio;
                _inicio.Anterior = nuevo;
            }
        }

        public @base mBuscar(@base proceso)
        {
            if (_inicio != null)
            {
                do
                {
                    if (proceso.Siguiente == proceso)
                        return proceso;
                    else
                        proceso = proceso.Siguiente;
                } while (proceso != _inicio);

            }

            return null;
        }

        public bool mEliminar(@base p1)
        {

            if (_inicio != null)
            {
                if (p1.Siguiente == _inicio && p1.Anterior == _inicio && p1 == _inicio)
                {
                    _inicio = null;
                }
                else if (p1 == _inicio)
                {
                    _inicio.Siguiente.Anterior = _inicio.Anterior;
                    _inicio.Anterior.Siguiente = _inicio.Siguiente;
                    _inicio = p1.Siguiente;
                }
                else if (p1.Siguiente == _inicio && p1.Anterior.Siguiente == p1)
                {
                    p1.Anterior.Siguiente = _inicio;
                    _inicio.Anterior = p1.Anterior;
                }
                else
                {
                    p1.Siguiente.Anterior = p1.Anterior;
                    p1.Anterior.Siguiente = p1.Siguiente;
                }
                return true;
            }

            return false;
        }


        public string mListar()
        {
            @base t = _inicio;

            int CicPend = 0;
            int ProPend = 0;
            string _vCadena = "";


            if (_inicio != null)
            {
                do
                {
                    _vCadena += t.ToString();
                    CicPend += t.Tiempo;

                    t = t.Siguiente;

                    ProPend++;

                } while (t != _inicio);
            }

            _proPen = ProPend;
            _cicPen = CicPend;

            return _vCadena;
        }

        public @base mActual()
        {
            return _inicio;
        }

        public void mMoverSiguiente()
        {
            if (_inicio != null)
                _inicio = _inicio.Siguiente;
        }
    }
}

