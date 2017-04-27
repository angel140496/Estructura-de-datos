using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Matriz2
    {
        private string vCadena;
        private int _aux;
        public int[,] _matriz;
        int _tamaño;

        public Matriz2(int Tam)
        {
            _tamaño = Tam;
            _matriz= new int[_tamaño,_tamaño];
        }


        public void llenar()
        {
            _aux = 1;
            for(int i = 0; i < _tamaño; i++)
            {
                for (int j = 0; j < _tamaño; j++)
                {
                    
                    _matriz[i,j] = (_aux++);
                }
            }

        }

        public void llenarxRegInv()
        {
            _aux = (_tamaño*_tamaño);
            for (int i = 0; i < _tamaño; i++)
            {
                for (int j = 0; j < _tamaño; j++)
                {

                    _matriz[i, j] = (_aux--);
                }
            }

        }

        public void llenarXCol()
        {
            _aux = 1;
            for (int i = 0; i < _tamaño; i++)
            {
                for (int j = 0; j < _tamaño; j++)
                {

                    _matriz[j, i] = (_aux++);
                }
            }
        
        }

        public string mostrarDiagPrin()
        {

            vCadena = "";
            int i = 0; 

                for (int j = 0; j < _tamaño;)
                {

                    vCadena += _matriz[i,j].ToString("000") + " ";
                i++;
                    j++;
                    
                }
                
           
            return vCadena;

        }

        public string mostrarDiagSec()
        {

            vCadena = "";
            int i = 3;

            for (int j = 0; j < _tamaño;)
            {

                vCadena += _matriz[i, j].ToString("000") + " ";
                i--;
                j++;

            }


            return vCadena;

        }

        public string mostrarDiagArriba()
        {

            vCadena = "";
            int i = 1;

            for (int j = (i + 1); j < _tamaño;)
            {

                vCadena += _matriz[i, j].ToString("000") + " ";
                i++;
                j++;

            }


            return vCadena;

        }

        public void mostrarDiagAbajo()
        {

            vCadena = "";
            int i;
            for (i=1; i < _tamaño;)
            {
                for (int j = 0; j < i;)
                {

                    vCadena += _matriz[i, j].ToString("000") + " ";
                    i++;
                    j++;

                }

            }
           

        }

        public void mostrarGirDiagPrin()
        {

            vCadena = "";
            int aux;

            for (int i = 1; i < _matriz.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    aux = _matriz[i, j];
                    _matriz[i, j] = _matriz[j,i];
                    _matriz[j,i] = aux;
                }
            }
        }


        public string mostrar()
        {
            vCadena = "";
           for (int i = 0; i < _tamaño; i++)
                {
             
                for (int j = 0; j < _tamaño; j++)
                    {

                    vCadena += _matriz[i, j].ToString("000")+ " ";
                    }
                vCadena += Environment.NewLine;
                }
            vCadena += "\n\n";
            return vCadena;
        }



    }
}
