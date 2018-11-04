using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres
{
    class Proceso
    {
        // Lista
        List<int> ListNum = new List<int>(); 
        // Pila 
        Stack<int> Orden = new Stack<int>();
        Stack<int> Izq = new Stack<int>();
        Stack<int> PilaDerecha = new Stack<int>();

        // Metodo para llenar la pila
        public void LlenaPila(int Numeros) 
        {
            for (int i = 0; i < Numeros; i++) 
            {
             volver:
                Console.WriteLine("------------------------------------");
                Console.Write("\nAgrege el valor {0} de tal torre: ", i + 1);
                Console.WriteLine("------------------------------------");
                int Valor = int.Parse(Console.ReadLine()); 
                if (false == ListNum.Contains(Valor)) 
                {
                    ListNum.Add(Valor);
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Se Agrego el numero \n");
                    Console.WriteLine("------------------------------------");
                }
                else if (true == ListNum.Contains(Valor))
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Ya se agrego este valor\n");
                    Console.WriteLine("Pulse una tecla\n");
                    Console.WriteLine("------------------------------------");
                    Console.ReadKey();
                    goto volver; 
                }
            }
        }


        // Imprimela numeros agregados
        public void ImprimeListaNormal() 
        {
            ListNum.Sort(); 
            foreach (var item in ListNum) 
            {
                Console.WriteLine(item); 
            }
        }

        public void OrdenarlaPila() 
        {
            ListNum.Sort(); 
            ListNum.Reverse(); 
            foreach (var item in ListNum)
            {
                Orden.Push(item);
            }
        }

        public void ImprimirPilNormal()
        {
            foreach (var item in Orden)
            {
                Console.WriteLine(item); 
            }
        }
        // Imprime la pila ya ordenada
        public void ImprimirPilaOrdenada(int Numeros) 
        {
            Orden.Reverse(); 
            int Contador = Numeros - 1; 
            foreach (var item in Orden)
            {
                Console.SetCursorPosition(3, Contador); 
                Console.WriteLine(item);
                Contador--;
            }
        }
        // Imprime la pila central 
        public void ImprimePilaCentral(int Numeros) 
        {
            int Contador = 0;
            foreach (var item in Izq)
            {
                Console.SetCursorPosition(10, Contador);
                Console.WriteLine(item);
                Contador++;
            }
        }
        // Imprime la pila de la derecha
        public void ImprimePiladeDerecha() 
        {
            int Contador = 0;
            foreach (var item in PilaDerecha)
            {
                Console.SetCursorPosition(20, Contador); 
                Console.WriteLine(item);
                Contador++; 
            }
        }

        // Pasa los discos A la izquierda 
        public void PasaraIzquierda(int Numeros) 
        {
            for (int i = 0; i < Numeros; i++)
            {
                Izq.Push(Orden.Pop()); 
                Console.Clear();
                ImprimirPilNormal(); 
                ImprimePilaCentral(Numeros);
                Console.SetCursorPosition(0, Numeros + 2);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("pulse una telca");
                Console.WriteLine("------------------------------------");
                Console.ReadKey();
            }

        }
        //Pasa los discos a la derecha
        public void PasaraDerecha(int Numeros) 
        {
            for (int i = 0; i < Numeros; i++)
            {
                PilaDerecha.Push(Izq.Pop()); 
                Console.Clear();
                ImprimePilaCentral(Numeros);
                ImprimePiladeDerecha();
                Console.SetCursorPosition(0, Numeros + 2);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Pulse una tecla");
                Console.WriteLine("------------------------------------");
                Console.ReadKey();
            }

        }

        // Se Crea un menu 
        public void Meniu() 
        {

            Console.WriteLine("------------------------------------");
            Console.Write("Numeros en la torre: ");
            Console.WriteLine("------------------------------------");
            int Numeros = int.Parse(Console.ReadLine()); 
            LlenaPila(Numeros); 
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Pulse para mirar torres");
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
            Console.Clear();
            OrdenarlaPila();
            ImprimirPilNormal();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("pulse una telca");
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
            Console.Clear();
            PasaraIzquierda(Numeros);
            PasaraDerecha(Numeros);
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("FIN DEL JUEGO BYE BYE \n");
            Console.WriteLine("pulse una telca");
            Console.WriteLine("------------------------------------");
            Console.ReadLine();
        }
    }
}
