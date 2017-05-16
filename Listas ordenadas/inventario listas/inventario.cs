using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario_listas
{
    class inventario
    {
        public product lista;
        product primero = null;
        product actual;
        product anterior = null;


        public void mAgregar(product producto)
        {       
            if (primero == null)
            {
              primero = producto;
                lista = primero;
            }
           else
            {
                if(producto.Codigo<= primero.Codigo)
                {
                    producto.Siguiente = primero;
                    primero = producto;
                    lista = producto;
                }
                else
                {
                    while (lista.Siguiente != null)
                    {
                        if (producto.Codigo > lista.Siguiente.Codigo)
                        {
                            lista = lista.Siguiente;
                            break;
                        }

                        producto.Siguiente = lista.Siguiente;
                        lista.Siguiente = producto;
                    }
                }
               
           }
        }

        public int mEliminar(int _vCod)
        {
            actual = lista;

            if (actual != null)
            {

                while (actual != null)
                {
                    if (actual.Codigo == _vCod)
                    {
                        anterior = actual;
                        actual = actual.Siguiente;
                    }
                }

                if (actual == lista)
                    lista = actual.Siguiente;
                else
                    anterior.Siguiente = actual.Siguiente;

                actual = null;

                return 0;
            }
            return 1;
        }

        public product mBuscar(int _vCod)
        {

            product buscar = lista;

            while (buscar!=null &&  buscar.Codigo != _vCod)
            {
                buscar = buscar.Siguiente;
            }
            return buscar;

        }

        public string mListar()
        {
            string _vCadena = "";

            while (lista != null)
            {
                _vCadena += lista;
                lista = lista.Siguiente;
            }
            return _vCadena;
        }

        
    }
}
