using BinaryTree;
using System;


namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();

            //Nodo raiz = arbol.Insertar(6, null);
            //arbol.Insertar(2, raiz);
            //arbol.Insertar(8, raiz);
            //arbol.Insertar(1, raiz);
            //arbol.Insertar(4, raiz);
            //arbol.Insertar(3, raiz);
            //arbol.Insertar(5, raiz);
            //arbol.Insertar(7, raiz);
            //arbol.Insertar(11, raiz);
            //arbol.Insertar(9, raiz);
            //arbol.Insertar(10, raiz);
            //arbol.Insertar(0, raiz);
            //arbol.Insertar(-1, raiz);
            //arbol.Insertar(12, raiz);
            //arbol.Insertar(14, raiz);

            //Nodo raiz = arbol.Insertar(20, null);
            //arbol.Insertar(18, raiz);
            //arbol.Insertar(22, raiz);
            //arbol.Insertar(10, raiz);
            //arbol.Insertar(5, raiz);
            //arbol.Insertar(15, raiz);
            //arbol.Insertar(3, raiz);
            //arbol.Insertar(14, raiz);
            //arbol.Insertar(13, raiz);
            //arbol.Insertar(17, raiz);

            Nodo raiz = arbol.Insertar(50, null);
            arbol.Insertar(20, raiz);
            arbol.Insertar(10, raiz);
            arbol.Insertar(24, raiz);
            arbol.Insertar(80, raiz);
            arbol.Insertar(55, raiz);
            arbol.Insertar(85, raiz);
            arbol.Insertar(23, raiz);
            arbol.Insertar(58, raiz);
            arbol.Insertar(60, raiz);
            arbol.Insertar(70, raiz);
            arbol.Insertar(59, raiz);
            arbol.Insertar(28, raiz);
            arbol.Insertar(35, raiz);
            arbol.Insertar(40, raiz);
            arbol.Insertar(51, raiz);
            arbol.Insertar(88, raiz);
            arbol.Insertar(90, raiz);
            arbol.Insertar(83, raiz);
            arbol.Insertar(81, raiz);

            arbol.Transversa(raiz);

            //Console.WriteLine("El menor es {0}", arbol.EncuentraMinimo(raiz));
            //Console.WriteLine("El mayor es {0}", arbol.EncuentraMaximo(raiz));

            //arbol.TransversaOrdenada(raiz);

            //Console.WriteLine();

            //Nodo tempMin = arbol.EncuentraNodoMinimo(raiz);
            //Console.WriteLine(tempMin.Dato);

            //Nodo tempMax = arbol.EncuentraNodoMaximo(raiz);
            //Console.WriteLine(tempMax.Dato);

            //Console.WriteLine("--------");

            //Nodo padre = arbol.BuscarPadre(11, raiz);
            //Console.WriteLine(padre.Dato);

            Console.WriteLine("--------");

            var nRaiz = arbol.Borrar(50, raiz);

            arbol.Transversa(nRaiz);

        }
    }
}
