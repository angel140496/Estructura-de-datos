using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tortuga
{
    class Tortuga
    {
        
        private string vCadena;
        private int[,] _matriz;
        private int i,j;
        private int k;
        private short cont=0;
        private bool prumita=false;
        public Tortuga()
        {
            _matriz = new int[20, 20];
            
        }

        public void avanzar(int aux)
        {
            if (prumita == true)
            {
                if (cont == 0)
                {
                    for (k = 0; k < aux; k++)
                    {
                        if (i != 19)
                        {
                            _matriz[i, j] = 1;
                            i++;
                        }


                    }
                }

                if (cont == 2)
                {
                    for (k = 0; k < aux; k++)
                    {
                        if (i != 0)
                        {
                            _matriz[i, j] = 1;
                            i--;
                        }

                    }
                }
                if (cont == 1)
                {
                    for (k = 0; k < aux; k++)
                    {

                        if (j != 19)
                        {
                            _matriz[i - 1, j + 1] = 1;
                            j++;
                        }


                    }
                }

                if (cont == 3)
                {
                    for (k = 0; k < aux; k++)
                    {
                        if (j != 0)
                        {
                            _matriz[i - 1, j - 1] = 1;
                            j--;
                        }

                    }
                }
            }else
            {
                if (cont == 0)
                {
                    for (k = 0; k < aux; k++)
                    {
                        if (i != 19)
                        {
                            
                            i++;
                        }


                    }
                }

                if (cont == 2)
                {
                    for (k = 0; k < aux; k++)
                    {
                        if (i != 0)
                        {
                            
                            i--;
                        }

                    }
                }
                if (cont== 1)
                {
                    for (k = 0; k < aux; k++)
                    {

                        if (j != 19)
                        {
                            
                            j++;
                        }


                    }
                }

                if (cont == 3)
                {
                    for (k = 0; k < aux; k++)
                    {
                        if (j != 0)
                        {
                            
                            j--;
                        }

                    }
                }
            }
        }
       /*
        * D == 0
        * R == 1
        * U == 2
        * L == 3
        * 
        * 
        * aux = 0
        * 
        * 
        */ 

        public void setDir(short dir)
        {
            cont = dir;
        }

        public void gIzquierda()
        {
            if (cont != 0)
            {
                cont--;
            }
            else
            {
                cont = 3;
            }
         
        }

        public void gDerecha()
        {
            if (cont != 3)
            {
                cont++;
            }
            else
            {
                cont= 0;
            }
        }
        public void plumaArriba()
        {
            prumita = false;
            
        }

        public void plumaAbajo()
        {
            prumita = true;

        }

        public string tablero() { 
        vCadena = "";
           for (int i = 0; i<20; i++)
                {
             
                for (int j = 0; j<20; j++)
                    {

                    vCadena += "0"+ " ";
                    }
      vCadena += Environment.NewLine;
                }
      vCadena += "\n\n";
            return vCadena;
        }

        public string mostrar()
        {
            vCadena = "";
            for (int i = 0; i < 20; i++)
            {

                for (int j = 0; j < 20; j++)
                {

                    vCadena += _matriz[i, j].ToString() + " ";
                }
                vCadena += Environment.NewLine;
            }
            vCadena += "\n\n";
            return vCadena;
        }
    }
}
