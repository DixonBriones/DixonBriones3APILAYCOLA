using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DixonBriones3APILAYCOLA
{
    class NodoCola
    {
       
            int dato;
            NodoCola frente;
            NodoCola siguiente;
            NodoCola cima;
            public NodoCola(int dato)
            {
                this.dato = dato;
                this.siguiente = null;
            }
            public static NodoCola CrearCola(NodoCola cola)
            {
                Console.WriteLine("Ingrese la cantidad de elemento a guardar");
                int valor = int.Parse(Console.ReadLine());
                cola = new NodoCola(valor);
                cola.frente = cola.cima = cola;
                return cola;
            }
            public static NodoCola Encolar(NodoCola cola)
            {
                if (cola == null)
                {
                    Console.WriteLine("La cola no ha sido creada");
                    return cola;
                }

                Console.WriteLine("Ingrese elemento a guardar");
                int valor = int.Parse(Console.ReadLine());
                NodoCola nodoNuevo = new NodoCola(valor);
                NodoCola aux = cola;
                for (; aux.siguiente != null; aux = aux.siguiente) ;
                aux.siguiente = nodoNuevo;
                cola.cima = nodoNuevo;
                return cola;
            }
            public static NodoCola Desencolar(NodoCola cola)
            {
                if (cola == null)
                {
                    Console.WriteLine("La pila no ha sido creada");
                    return cola;
                }
               
                else
                {

                Console.WriteLine("Elemento: " + cola.dato);

                cola.frente = cola.siguiente;
                return cola.siguiente;//return null;

            }

            }

            public static void Imprimir(NodoCola cola)
            {
                if (cola == null)
                    Console.WriteLine("La pila no ha sido creada");
                for (NodoCola aux = cola; aux != null; aux = aux.siguiente)
                    Console.WriteLine("Dato:" + aux.dato + "\n");
            }

            public static void ImprimirCima(NodoCola cola)
            {
                if (cola == null)
                {
                    Console.WriteLine("La cola no ha sido creada");
                }
                else
                {
                    Console.WriteLine("Cima: " + cola.cima.dato );
                }

            }
        }
    
}
