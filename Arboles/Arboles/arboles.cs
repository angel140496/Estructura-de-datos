using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class arboles
    {
        private Nodo Inicio;
        private Nodo Fin;
        private Nodo Raiz;
        private Nodo inicioPila;
        private Nodo finalPila;
        private Nodo num;

        public void agregarLista(Nodo A)
        {
            if (Inicio == null)
            {

                Inicio = A;
            }
            else

                agregar(A, Inicio);
        }

        private void agregar(Nodo A, Nodo final)
        {
            if (final.siguiente == null)
            {
                final.siguiente = A;
                A.Anterior = final;
                Fin = A;
            }
            else
                agregar(A, final.siguiente);
        }

        private void apilar(Nodo A)
        {
            if (inicioPila == null)
                inicioPila = A;
            else
                agregarAPila(A, inicioPila);
        }

        private void agregarAPila(Nodo A, Nodo final)
        {
            if (final.siguiente == null)
            {
                final.siguiente = A;
                A.Anterior = final;
                finalPila = A;
            }
            else
                agregarAPila(A, final.siguiente);
        }

        private string retirar()
        {
            string numm;
            numm = Convert.ToString(finalPila.resultado);
            finalPila = finalPila.Anterior;
            if (finalPila != null)
            {
                finalPila.siguiente = null;
            }
                
            return numm;
        }

        public void crearArbol()
        {
            Raiz = null;
            string tecl;

            Nodo arbolC = Inicio, cAnterior = null, cSiguiente = null;

            while (arbolC != null)
            {
                cSiguiente = arbolC.siguiente;
                tecl = Convert.ToString(arbolC.resultado);
                if (tecl == "*" )
                {
                    Raiz = arbolC;
                    arbolC.Izquierda = arbolC.Anterior;
                    arbolC.Derecha = arbolC.siguiente;
                    eliminarNodos(arbolC, cAnterior, cSiguiente);
                }

                if (tecl == "/")
                {
                    Raiz = arbolC;
                    arbolC.Izquierda = arbolC.Anterior;
                    arbolC.Derecha = arbolC.siguiente;
                    eliminarNodos(arbolC, cAnterior, cSiguiente);
                }
                cAnterior = arbolC;
                arbolC = arbolC.siguiente;
            }

            arbolC = Inicio;
            cAnterior = null;
            cSiguiente = null;
            
            while (arbolC != null)
            {
                cSiguiente = arbolC.siguiente;
                tecl = Convert.ToString(arbolC.resultado);
                if (tecl == "+")
                {
                    Raiz = arbolC;
                    arbolC.Izquierda = arbolC.Anterior;
                    arbolC.Derecha = arbolC.siguiente;
                    eliminarNodos(arbolC, cAnterior, cSiguiente);
                }

                if (tecl == "-")
                {
                    Raiz = arbolC;
                    arbolC.Izquierda = arbolC.Anterior;
                    arbolC.Derecha = arbolC.siguiente;
                    eliminarNodos(arbolC, cAnterior, cSiguiente);
                }
                cAnterior = arbolC;
                arbolC = arbolC.siguiente;
            }

            Inicio = null;
        }

        private void eliminarNodos(Nodo arbolC, Nodo cAnterior, Nodo cSiguiente)
        {
            if (arbolC.Anterior != Inicio)
            {
                arbolC.Anterior = cAnterior.Anterior;
                cAnterior.Anterior.siguiente = arbolC;
            }
            else
            {
                Inicio = Inicio.siguiente;
                Inicio.Anterior = null;
            }

            if (arbolC.siguiente != Fin)
            {
                arbolC.siguiente = cSiguiente.siguiente;
                cSiguiente.siguiente.Anterior = arbolC;
            }
            else
            {
                Fin.Anterior.siguiente = null;
                Fin = Fin.Anterior;
            }
        }

        public string PostOrden()
        {
            if (Raiz == null)
                return "";
            else
                return postOrder(Raiz);
        }

        private string postOrder(Nodo t)
        {
            string lista = "";
            if (t.Izquierda != null)
            {
                lista+=postOrder(t.Izquierda);
            }
                
            if (t.Derecha != null)
            {
                lista += postOrder(t.Derecha);
            }
                
            lista += t.ToString();
            return lista;
        }

        public string postOrdenNotacion()
        {
            Nodo arbolCreado = Inicio;
            int aux = 0,nu1,nu2;
            string res = "", operat,operat2;
           
            while (arbolCreado != null)
            {
                if (Char.IsNumber(Convert.ToChar(arbolCreado.resultado)) == true)
                {
                    num = new Nodo (arbolCreado.resultado);

                    apilar(num);
                }

                else

                {
                    operat = arbolCreado.ToString();
                    nu1 = Convert.ToInt32(retirar());
                    nu2 = Convert.ToInt32(retirar());
                    switch (operat)
                    {
                        case "/":
                            aux = nu2 / nu1;
                            break;
                        case "*":
                            aux = nu2 * nu1;
                            break;
                        case "-":
                            aux = nu2 - nu1;
                            break;
                        case "+":
                            aux = nu2 + nu1;
                            break;
                    }
                    operat2=Convert.ToString(aux);
                    num = new Nodo(operat2);
                    apilar(num);
                }

                arbolCreado = arbolCreado.siguiente;

                if (arbolCreado == null)
                    res = Convert.ToString(retirar());
            }

            inicioPila = null;
            finalPila = null;
            Inicio = null;
            return res;
        }

        public string PreOrden()
        {
            if (Raiz == null)
                return "";
            else
                return PreOrder(Raiz);
        }

        private string PreOrder(Nodo t)
        {
            string listas = "";

            listas += t.ToString();

            if (t.Izquierda != null)
            {
                listas += PreOrder(t.Izquierda);
            }
               
            if (t.Derecha != null)
            {
                listas += PreOrder(t.Derecha);
            }
                

            return listas;
        }
        public string preOrdenNotacion()
        {
            Nodo arbolCreado = Fin;
            int aux = 0,nu1,nu2;
            string res = "",operat,operat2; 

            while (arbolCreado != null)
            {
                if (Char.IsNumber(Convert.ToChar(arbolCreado.resultado)) == true)
                {
                    num = new Nodo(arbolCreado.resultado);
                    apilar(num);
                }
                else
                {
                    operat = arbolCreado.ToString();
                    nu1 = Convert.ToInt32(retirar());
                    nu2 = Convert.ToInt32(retirar());

                    switch (operat)
                    {
                        case "/":
                            aux = nu1 / nu2;
                            break;
                        case "*":
                            aux = nu1 * nu2;
                            break;
                        case "-":
                            aux = nu1 - nu2;
                            break;
                        case "+":
                            aux = nu1 - nu2;
                            break;
                    }
                    operat2 = Convert.ToString(aux);
                    num = new Nodo(operat2);
                    apilar(num);
                }

                arbolCreado = arbolCreado.Anterior;
                if (arbolCreado == null)
                {
                    res = Convert.ToString(retirar());
                }       
            }

            inicioPila = null;
            finalPila = null;
            Inicio = null;
            return res;
        }

       

        public string imprimir()
        {
            string Lista = "";
            Nodo datoc = inicioPila;
            while (datoc != null) 
            {
                Lista += datoc.ToString();
                datoc = datoc.siguiente;
            }

            return Lista;
        }



    }
}