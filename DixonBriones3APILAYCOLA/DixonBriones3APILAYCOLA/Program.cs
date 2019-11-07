using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DixonBriones3APILAYCOLA.Clases;
namespace DixonBriones3APILAYCOLA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opcion= 0, opcionge= 0;
            NodoPila pila = null;
            NodoCola cola = null;
            Console.WriteLine("Ingrese opción a trabajar \n" +
                        "(1) Pila \n" +
                        "(2) Cola\n" +
                        "(3) Salir \n");
            opcionge = int.Parse(Console.ReadLine());
            if (opcionge == 1)
            {
                do
                {
                    Console.WriteLine("Ingrese opción \n" +
                            "(1) Crear Pila \n" +
                            "(2) Apilar\n" +
                            "(3) Desapilar\n" +
                            "(4) Mostrar Cima\n" +
                            "(5) Imprimir toda la pila \n" +
                            "(6) Salir \n");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            pila = NodoPila.CrearPila(pila);
                            break;
                        case 2:
                            pila = NodoPila.APilar(pila);
                            break;
                        case 3:
                            pila = NodoPila.Desapilar(pila);
                            break;
                        case 4:
                            NodoPila.ImprimirCima(pila);
                            break; ;
                        case 5:
                            NodoPila.Imprimir(pila);
                            break;
                        default:
                            Console.WriteLine("Lo ingresado no esta correcto");
                            break;
                    }
                } while (opcion != 6);
            }if (opcionge == 2)
            {
                do
                {
                    Console.WriteLine("Ingrese opción \n" +
                                                "(1) Crear Cola \n" +
                                                "(2) Encolar\n" +
                                                "(3) Desencolar\n" +
                                                "(4) Mostrar Cima\n" +
                                                "(5) Imprimir toda la cola \n" +
                                                "(6) Salir \n");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            cola = NodoCola.CrearCola(cola);
                            break;
                        case 2:
                            cola = NodoCola.Encolar(cola);
                            break;
                        case 3:
                            cola = NodoCola.Desencolar(cola);
                            break;
                        case 4:
                            NodoCola.ImprimirCima(cola);
                            break; ;
                        case 5:
                            NodoCola.Imprimir(cola);
                            break;
                        default:
                            Console.WriteLine("Lo ingresado no esta correcto");
                            break;
                    }
                } while (opcion != 6);

            }
        }
        
    }
}
