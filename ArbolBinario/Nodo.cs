using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Nodo
    {
        private int dato;

        private Nodo izq;
        private Nodo der;

        public int Dato { get { return dato; } set { dato = value; } }
        internal Nodo Izq { get { return izq; } set { izq = value; } }
        internal Nodo Der { get { return der; } set { der = value; } }

        public Nodo()
        {
            dato = 0;
            izq = null;
            der = null;
        }

    }
}
