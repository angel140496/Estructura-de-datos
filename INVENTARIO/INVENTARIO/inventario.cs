using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTARIO
{
    class inventario
    {
        public product[] _P1 = new product[20];
        public int aux = 0;





        public void mAgregar(product producto)
        {
            

                if (_P1[producto.posicion] == null)
                {
                    _P1[producto.posicion] = producto;
                    
                }
            }
        
        public product mBuscar(int _vCod)
        {
            for (short i = 0; i < _P1.Length; i++)
            {
                if (_P1[i] != null)
                {
                    if (_P1[i].Codigo == _vCod)
                    {
                        return _P1[i];
                    }
                }
            }

            return null;
        }

        public int mEliminar(int _vCod)
        {
            for (short i = 0; i < _P1.Length; i++)
            {
                if (_P1[i] != null)
                {
                    if (_P1[i].Codigo == _vCod)
                    {
                        _P1[i] = null;
                        aux--;
                        return 1;
                    }
                }
            }

            return 0;
        }

        public string mListar()
        {
            string _vCadena = "";

            for (short i = 0; i < _P1.Length; i++)
            {
                if (_P1[i] != null)
                {
                    _vCadena += _P1[i].ToString() + Environment.NewLine;
                }
            }

            return _vCadena;
        }
    }
}
