using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Arbol
    {
        private Nodo raiz;
        private Nodo trabajo;

        private int i = 0;

        public Arbol()
        {
            raiz = null;
        }

        internal Nodo Raiz { get { return raiz; } set { raiz = value; } }

        public Nodo Insertar(int nDato, Nodo nNodo)
        {
            Nodo temp = null;

            if (nNodo == null)
            {
                temp = new Nodo();
                temp.Dato = nDato;

                return temp;
            }

            if (nDato < nNodo.Dato)
            {
                nNodo.Izq = Insertar(nDato, nNodo.Izq);
            }
            if (nDato > nNodo.Dato)
            {
                nNodo.Der = Insertar(nDato, nNodo.Der);
            }

            return nNodo;
        }

        public void Transversa(Nodo nNodo)
        {
            if (nNodo == null)            
                return;

            for (int n = 0; n < i; n++)
                Console.Write(" | ");

            Console.WriteLine(nNodo.Dato);

            if (nNodo.Izq != null)
            {
                i++;
                Console.Write("I ");
                Transversa(nNodo.Izq);
                i--;
            }
            if (nNodo.Der != null)
            {
                i++;
                Console.Write("D ");
                Transversa(nNodo.Der);
                i--;
            }
        }

        public int EncuentraMinimo(Nodo nNodo)
        {
            if (nNodo == null)
                return 0;

            trabajo = nNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }

            return minimo;
        }

        public Nodo EncuentraNodoMinimo(Nodo nNodo)
        {
            if (nNodo == null)
                return null;

            trabajo = nNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }

            return trabajo;
        }

        public int EncuentraMaximo(Nodo nNodo)
        {
            if (nNodo == null)
                return 0;

            trabajo = nNodo;
            int maximo = trabajo.Dato;

            while (trabajo.Der != null)
            {
                trabajo = trabajo.Der;
                maximo = trabajo.Dato;
            }

            return maximo;
        }

        public Nodo EncuentraNodoMaximo(Nodo nNodo)
        {
            if (nNodo == null)
                return null;

            trabajo = nNodo;
            int maximo = trabajo.Dato;

            while (trabajo.Der != null)
            {
                trabajo = trabajo.Der;
                maximo = trabajo.Dato;
            }

            return trabajo;
        }

        public void TransversaOrdenada(Nodo nNodo)
        {
            if (nNodo == null)
                return;

            // Si tengo izquierda, proceso a la izquierda
            if (nNodo.Izq != null)
            {
                i++;
                TransversaOrdenada(nNodo.Izq);
                i--;
            }

            Console.Write("{0}, ", nNodo.Dato);

            if (nNodo.Der != null)
            {
                i++;
                TransversaOrdenada(nNodo.Der);
                i--;
            }
        }
    
        public Nodo BuscarPadre(int nDato, Nodo nNodo)
        {
            Nodo temp = null;

            if (nNodo == null)
                return null;

            // Verifico si soy el padre
            if (nNodo.Izq != null)
                if (nNodo.Izq.Dato == nDato)
                    return nNodo;

            if (nNodo.Der != null)
                if (nNodo.Der.Dato == nDato)
                    return nNodo;

            // Si tengo izquierda, proceso a la izquierda
            if (nNodo.Izq != null && nDato < nNodo.Dato)
            {
                temp = BuscarPadre(nDato, nNodo.Izq);
            }

            // Si tengo derecha, proceso a la derecha
            if (nNodo.Der != null && nDato > nNodo.Dato)
            {
                temp = BuscarPadre(nDato, nNodo.Der);
            }

            return temp;
        }

        public Nodo Borrar( int nDato, Nodo nNodo)
        {
            Nodo temp = null;

            if (nNodo == null)
                return null;

            if (nDato < nNodo.Dato)
            {
                nNodo.Izq = Borrar(nDato, nNodo.Izq);
            }
            else if (nDato > nNodo.Dato)
            {
                nNodo.Der = Borrar(nDato, nNodo.Der);
            }
            else // Casos para borrar
            {
                // sin hijos
                if (nNodo.Izq == null && nNodo.Der == null)
                {
                    nNodo = null;
                    //return nNodo;
                }
                else if (nNodo.Izq == null)
                {
                    //Nodo padre = BuscarPadre(nDato, nNodo);
                    //padre.Der = nNodo.Der;

                    nNodo = nNodo.Der;
                }
                else if (nNodo.Der == null)
                {
                    //Nodo padre = BuscarPadre(nDato, nNodo);
                    //padre.Der = nNodo.Der;

                    nNodo = nNodo.Izq;
                }
                else
                {
                    trabajo = EncuentraNodoMinimo(nNodo.Der);
                    nNodo.Dato = trabajo.Dato;
                    nNodo.Der = Borrar(trabajo.Dato, nNodo.Der);
                }
            }

            return nNodo;
        }

    }
}
