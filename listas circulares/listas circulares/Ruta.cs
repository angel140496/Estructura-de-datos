using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_circulares
{
    class Ruta
    {
        private Base _inicio;
        int Minutos, Temp;

        public void mAgregar(Base nuevo)
        {
            if (_inicio == null)
            {
                _inicio = nuevo;
                _inicio.Siguiente = _inicio;
            }
            else
            {
                Base t = _inicio;
                while (t.Siguiente != _inicio)
                {
                    t = t.Siguiente;
                }

                t.Siguiente = nuevo;
                t = t.Siguiente;
                t.Siguiente = _inicio;
            }
        }

        public Base mBuscar(string nombre)
        {
            Base t = _inicio;

            if (_inicio != null)
            {
                while (t.Nombre != nombre)
                {
                    if (t.Siguiente == _inicio)
                        return null;
                    else
                        t = t.Siguiente;
                }
            }

            return t;
        }
        public bool mEliminar(string nombre)
        {
            Base t = _inicio;

            if (_inicio != null)
            {
                while (t != null)
                {
                    if (t.Siguiente.Nombre == nombre)
                    {
                        t.Siguiente = t.Siguiente.Siguiente;
                        return true;
                    }
                    else if (t.Siguiente.Nombre == nombre)
                    {
                        t.Siguiente = t.Siguiente.Siguiente;
                        return true;
                    }
                    else if (t.Nombre == nombre)
                    {
                        _inicio = t.Siguiente;
                        return true;
                    }

                    t = t.Siguiente;
                }
            }

            return true;
        }

        public string mTarjeta(string nombreT, int inicioT, int finalT)
        {
            Base t = mBuscar(nombreT);
            Minutos = 0;
            Temp = 0;
            string _vCadena = "";

            if (_inicio != null)
            {
                if (inicioT > finalT)
                {
                    while (inicioT != finalT)
                    {
                        _vCadena += t.Nombre + " = " + inicioT.ToString("00") + ":" + Minutos.ToString("00") + Environment.NewLine;
                        t = t.Siguiente;
                        Minutos = Minutos + t.Minutos;


                        if (Minutos >= 60)
                        {
                            if (Minutos > 60)
                            {
                                while (Minutos != 60)
                                {
                                    Minutos--;
                                    Temp++;
                                }

                                if (inicioT == 12)
                                {
                                    inicioT = 0;
                                    inicioT = inicioT + 1;
                                    Minutos = Temp;
                                }
                                else
                                {
                                    inicioT = inicioT + 1;
                                    Minutos = Temp;
                                }
                            }
                            else
                            {
                                inicioT = inicioT + 1;
                                Minutos = 0;
                            }
                        }
                    }
                }
                else
                {
                    while (inicioT < finalT)
                    {
                        _vCadena += t.Nombre + " = " + inicioT.ToString("00") + ":" + Minutos.ToString("00") + Environment.NewLine;
                        t = t.Siguiente;
                        Minutos = Minutos + t.Minutos;

                        if (Minutos >= 60)
                        {
                            if (Minutos > 60)
                            {
                                while (Minutos != 60)
                                {
                                    Minutos--;
                                    Temp++;
                                }

                                inicioT = inicioT + 1;
                                Minutos = Temp;
                            }
                            else
                            {
                                inicioT = inicioT + 1;
                                Minutos = 0;
                            }
                        }
                    }
                }
            }

            return _vCadena;
        }

        public string mListar()
        {
            Base t = _inicio;

            string _vCadena = "";

            if (_inicio != null)
            {
                do
                {
                    _vCadena += t.ToString();
                    t = t.Siguiente;
                } while (t != _inicio);
            }

            return _vCadena;
        }
    }
}

