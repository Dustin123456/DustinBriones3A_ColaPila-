using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace tareaColaPila
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Colat = new Queue();
            Stack Pilat = new Stack();
            Console.WriteLine("ESCOJA LA ESTRUCTURA A USAR, SIENDO 1 PARA PILA Y 2 PARA COLA.");               
            int Opcion = int.Parse(Console.ReadLine());
            if(Opcion==1)
            {
                int Eleccion = 0;
                do
                {
                
                    Console.Clear();
                    Eleccion = Menu();
                    switch (Eleccion)
                    {
                        case 1:
                            Apilar(ref Pilat);
                            break;
                        case 2:
                            Desapilar(ref Pilat);
                            break;
                        case 3:
                            Vaciar(ref Pilat);
                            break;
                        case 4:
                            Console.WriteLine();
                            Mostrar(Pilat);
                            break;
                        case 5: break;
                        default:
                            Texto("ERROR: ELIJA UNA OPCION DISPONIBLE.");
                            break;
                    }
                }
                while (Eleccion != 5);
                Console.WriteLine("PROGRAMA FINALIZADO, PRESIONE UNA TECLA PARA SALIR.");
            Console.ReadKey();
            }
            else if(Opcion==2)
            {
                int Eleccion = 0;
                do
                {
                    Console.Clear();
                    Eleccion = MenuC();
                    switch (Eleccion)
                    {
                        case 1:
                            Encolar(ref Colat);
                            break;
                        case 2:
                            Desencolar(ref Colat);
                            break;
                        case 3:
                            Vaciarc(ref Colat);
                            break;
                        case 4:
                            Console.WriteLine();
                            Mostrarc(Colat);
                            break;
                        case 5: break;
                        default:
                            Texto("ERROR: ELIJA UNA OPCION DISPONIBLE.");
                            break;
                    }
                }
                while (Eleccion != 5);
                Console.WriteLine("PROGRAMA FINALIZADO, PRESIONE UNA TECLA PARA SALIR.");
                Console.ReadKey();
            }
        }
        static int MenuC()
        {
            Console.WriteLine(" 1) ENCOLAR ELEMENTO.");
            Console.WriteLine(" 2) DESENCOLAR ELEMENTO.");
            Console.WriteLine(" 3) VACIAR LA COLA.");
            Console.WriteLine(" 4) MOSTRAR COLA.");
            Console.WriteLine(" 5) FINALIZAR EJECUCION DE COLA.");
            Console.WriteLine(" INGRESE SU ELECCION: ");
            int dato = int.Parse(Console.ReadLine());
            return dato;
        }
        static void Encolar(ref Queue colita)
        {
            Console.Write("   INGRESE VALOR QUE DESEA ENCOLAR: ");

            int valor = int.Parse(Console.ReadLine());
            colita.Enqueue(valor);
        }
        static void Desencolar(ref Queue colita)
        {
            if (colita.Count > 0)
            {
                int valor = (int)colita.Dequeue();
                Texto("ELEMENTO " + valor + " ELIMINADO");
            }
        }
        static void Vaciarc(ref Queue colita)
        {
            if (colita.Count > 0)
            {
                colita.Clear();
                Texto("LA COLA A SIDO VACIADA.");
            }
            else
            {
                Texto("LA COLA NO CONTIENE ELEMENTOS.");
            }


        }
        static void Mostrarc(Queue colita)
        {
            if (colita.Count > 0)
            {
                foreach (int dato in colita)
                {
                    if (dato < 10)
                        Console.WriteLine(dato);
                    else
                        Console.WriteLine(dato);
                }
                Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR.");
                Console.ReadKey();
            }
            else
            {
                Texto("LA PILA NO CONTIENE ELEMENTOS.");
            }
        }









            static int Menu()
        
            {
                Console.WriteLine(" 1) APILAR ELEMENTO.");
                Console.WriteLine(" 2) DESAPILAR ELEMENTO.");
                Console.WriteLine(" 3) VACIAR LA PILA.");
                Console.WriteLine(" 4) MOSTRAR PILA.");
                Console.WriteLine(" 5) FINALIZAR EJECUCION DE PILA.");
                Console.WriteLine(" INGRESE SU ELECCION: ");
                int dato = int.Parse(Console.ReadLine());
                return dato;
            }

            static void Apilar(ref Stack pilita )
            {
                Console.Write("   INGRESE VALOR QUE DESEA APILAR: ");

                int valor = int.Parse(Console.ReadLine());
                pilita.Push(valor);
            }
            static void Desapilar(ref Stack pilita)
            {
                if (pilita.Count > 0)
                {
                    int valor = (int)pilita.Pop();
                    Texto("ELEMENTO " + valor + " ELIMINADO");
                }
            }
            static void Vaciar(ref Stack pilita)
            {
                if (pilita.Count > 0)
                {
                    pilita.Clear();
                    Texto("LA PILA A SIDO VACIADA.");
                }
                else
                {
                    Texto("LA PILA NO CONTIENE ELEMENTOS.");
                }


            }
            static void Mostrar(Stack pilita)
            {
                if (pilita.Count > 0)
                {
                    foreach (int dato in pilita)
                    {
                        if (dato < 10)
                            Console.WriteLine(dato);
                        else
                            Console.WriteLine(dato);
                    }
                    Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR.");
                    Console.ReadKey();
                }
                else
                {
                    Texto("LA PILA NO CONTIENE ELEMENTOS.");
                }
            }
            static void Texto(String Muestralo)
            {

                Console.WriteLine(Muestralo);
                Console.WriteLine(" PRESIONE UNA TECLA PARA CONTINUAR.");
                Console.ReadKey();

            }
    }
}