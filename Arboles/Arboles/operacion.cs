using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class operacion
    {
        private string _ecuacion;
        Nodo select;
        arboles arbol = new arboles();

        public operacion(string ecuacion)
        {
            _ecuacion = ecuacion;
        }

        public void alamacenar()
        {
            char[] array = _ecuacion.ToCharArray(); 

            foreach (char almacen in array) 
            {
                select = new Nodo(Convert.ToString(almacen));
                arbol.agregarLista(select);
            }
            
        }

        public void evaluarPost(string ev)
        {
            char[] array = ev.ToCharArray();

            foreach (char almacen in array)
            {
                select = new Nodo(Convert.ToString(almacen));
                arbol.agregarLista(select);
            }
        }

        public void evaluarPre(string ev)
        {
            char[] array = ev.ToCharArray();

            foreach (char almacen in array)
            {
                select = new Nodo(Convert.ToString(almacen));
                arbol.agregarLista(select);
            }

          
        }



    }
}
