using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DixonBriones3APILAYCOLA.Clases
{

    class NodoPila
    {
        int dato;
        NodoPila frente;
        NodoPila siguiente;
        NodoPila cima;
        public NodoPila(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
        public static NodoPila CrearPila(NodoPila pila)
        {
            Console.WriteLine("Ingrese la cantidad de elemento a guardar");
            int valor = int.Parse(Console.ReadLine());
            pila = new NodoPila(valor);
            pila.frente = pila.cima = pila;
            return pila;
        }
        public static NodoPila APilar(NodoPila pila)
        {
            if (pila == null)
            {
                Console.WriteLine("La pila no ha sido creada");
                return pila;
            }

            Console.WriteLine("Ingrese elemento a guardar");
            int valor = int.Parse(Console.ReadLine());
            NodoPila nodoNuevo = new NodoPila(valor);
            NodoPila aux = pila;
            for (; aux.siguiente != null; aux = aux.siguiente) ;
            aux.siguiente = nodoNuevo;
            pila.cima = nodoNuevo;
            return pila;
        }
        public static NodoPila Desapilar(NodoPila pila)
        {
            if (pila == null)
            {
                Console.WriteLine("La pila no ha sido creada");
                return pila;
            }
         
            else
            {

                NodoPila aux = pila;
                for (; aux.siguiente.siguiente != null; aux = aux.siguiente) ;
                Console.WriteLine("Elemento: " + aux.siguiente.dato);
                aux.siguiente = aux.siguiente.siguiente;
                pila.cima = aux;
                return pila;

            }

        }

        public static void Imprimir(NodoPila pila)
        {
            if (pila == null)
                Console.WriteLine("La pila no ha sido creada");
            for (NodoPila aux = pila; aux != null; aux = aux.siguiente)
                Console.WriteLine("Dato:" + aux.dato + "\n");
        }

        public static void ImprimirCima(NodoPila pila)
        {
            if (pila == null)
            {
                Console.WriteLine("La pila no ha sido creada");
            }
            else
            {
                Console.WriteLine("Cima: " + pila.cima.dato);
            }

        }
    }
}