using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacasCruzapuente
{
    class Proceso
    {
        // Crea la lista Inicio y fin  del puente
        List<Vacas> InicioPuente = new List<Vacas>(); 
        List<Vacas> FinPuente = new List<Vacas>();
        // Crea un objeto con su respectivo nombre con ayuda del constructor
        Vacas Conic = new Vacas("Conic", 2); 
        Vacas Alek = new Vacas("Alek", 4); 
        Vacas Nirvana = new Vacas("Nirvana", 10); 
        Vacas Mitzy = new Vacas("Mitzy", 20);

        // Meotodo que agrega los objetos a la lista Iniciopuente
        public void AgregarElementos() 
        {
            // los elementos se van agregando  
            InicioPuente.Add(Conic); 
            InicioPuente.Add(Alek); 
            InicioPuente.Add(Nirvana); 
            InicioPuente.Add(Mitzy); 
        }
        // Acertijo en consola 
        public void Acertijo() 
        {
            Console.WriteLine("Acertijo:" );
            Console.WriteLine("    \nSupongamos que Bob tiene cuatro vacas que quiere cruzar por un puente, pero solo un yugo, que puede sostener hasta dos vacas, lado a lado, atadas al yugo. El yugo es demasiado pesado para que lo lleve a través del puente, pero puede atar (y desatar) vacas a él en muy poco tiempo. De sus cuatro vacas, Conic puede cruzar el puente en 2 minutos, Alek puede cruzarlo en 4 minutos, Nirvana puede cruzarlo en 10 minutos y Mitzy puede cruzar en 20 minutos. Por supuesto, cuando dos vacas están atadas al yugo, deben ir a la velocidad de la vaca más lenta. Describe cómo Bob puede conseguir que todas sus vacas crucen el puente en 34 minutos. ");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Pulse una telca");
            Console.ReadKey();
            Console.Clear(); 
        }

        //Imprimir lista inicio puente 
        public void AntePuente() 
        {
            foreach (var item in InicioPuente) 
            {
                // imprime item
                Console.WriteLine(item.Nombre); 
            }
            // Cambia las posiciones de  7 en x y 0 en y
            Console.SetCursorPosition(7, 0);
            // Crea el puente
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-"); 
            Console.SetCursorPosition(7, 2);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-"); 
        }
        // Imprime la lista FinPuente
        public void FinePuente() 
        {
            int Contador = 0; 
            foreach (var item in FinPuente) 
            {
                Console.SetCursorPosition(30, Contador); 
                Console.WriteLine(item.Nombre); 
                Contador++; 
            }
        }

        //llama los metodos AntePuente y FinePuente
        public void ImprimirAmbos() 
        {
            AntePuente(); 
            FinePuente();
        }
        // Proceoso1
        public void Proceso1() 
        {
            FinPuente.Add(InicioPuente[0]); 
            FinPuente.Add(InicioPuente[1]); 
            InicioPuente.RemoveAt(0); 
            InicioPuente.RemoveAt(0); 
            Console.Clear(); 
            ImprimirAmbos(); 
            Desa1(); 
        }
        // Imprime El Desarrollo 1 
        public void Desa1() 
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Proceso: ");
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("Cruzan: Conic #2min# + Alek #4min# = 4 min");
        }
        // Proceso2
        public void Proceso2() 
        {
            InicioPuente.Add(FinPuente[0]); 
            FinPuente.RemoveAt(0); 
            Console.Clear(); 
            ImprimirAmbos(); 
            Desa1(); 
            Desa2(); 
        }
        // imprime Desarrollo 2
        public void Desa2() 
        {
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("Vuelve: Conic#2min# = 2 min");
        }
        // Paso 3
        public void Proceso3() 
        {
            FinPuente.Add(InicioPuente[0]); 
            FinPuente.Add(InicioPuente[1]); 
            InicioPuente.RemoveAt(0); 
            InicioPuente.RemoveAt(0); 
            Console.Clear(); 
            ImprimirAmbos(); 
            Desa1(); 
            Desa2(); 
            Desa3(); 
        }
        // Imprime Desarrollo 3
        public void Desa3() 
        {
            Console.SetCursorPosition(50, 4);
            Console.WriteLine("Cruzan: Nirvana#10min# + Mitzy#20min# = 20 min");
        }
        // PAso 4
        public void Proceso4() 
        {
            InicioPuente.Add(FinPuente[0]); 
            FinPuente.RemoveAt(0); 
            Console.Clear(); 
            ImprimirAmbos(); 
            Desa1();  
            Desa2();
            Desa3();
            Desa4();
        }
        // imrprime Desarrollo 4
        public void Desa4() 
        {
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("Vuelve:  Alek#4min# = 4 min");
        }
        //PAso 5
        public void Proceso5()
        {
            FinPuente.Add(InicioPuente[0]); 
            FinPuente.Add(InicioPuente[1]); 
            InicioPuente.RemoveAt(0); 
            InicioPuente.RemoveAt(0); 
            Console.Clear(); 
            ImprimirAmbos(); 
            Desa1(); 
            Desa2();
            Desa3();
            Desa4();
            Desa5();
        }
        // imprime el ultimo proceso y el tiempo final 
        public void Desa5() 
        {
            Console.SetCursorPosition(50, 6);
            Console.WriteLine("Cruzan: Conic #2min# + Alek #4min# = 4 min\n");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("Tiempo Final:   34 min");
        }
        // MEtodo sin importancia solo es pulsar teclas
        public void Metodo() 
        {
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Pulse una tecla.");
            Console.ReadKey();
        }
        // MEtodo Menu
        public void MainMenain() 
        {
            AgregarElementos();
            Acertijo();
            AntePuente();
            Metodo();
            Proceso1();
            Metodo();
            Proceso2();
            Metodo();
            Proceso3();
            Metodo();
            Proceso4();
            Metodo();
            Proceso5();
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("Game Over :c");
                
Console.WriteLine("███████████████████████████████");
Console.WriteLine("████╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬████");
Console.WriteLine("██╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬██");
Console.WriteLine("█╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬█");
Console.WriteLine("█╬╬╬███████╬╬╬╬╬╬╬╬╬███████╬╬╬█");
Console.WriteLine("█╬╬██╬╬╬╬███╬╬╬╬╬╬╬███╬╬╬╬██╬╬█");
Console.WriteLine("█╬██╬╬╬╬╬╬╬██╬╬╬╬╬██╬╬╬╬╬╬╬██╬█");
Console.WriteLine("█╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬█");
Console.WriteLine("█╬╬╬╬█████╬╬╬╬╬╬╬╬╬╬╬█████╬╬╬╬█");
Console.WriteLine("█╬╬█████████╬╬╬╬╬╬╬█████████╬╬█");
Console.WriteLine("█╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬█");
Console.WriteLine("█╬╬╬╬╬╬╬╬╬╬╬╬╬╬█╬╬╬╬╬╬╬╬╬╬╬╬╬╬█");
Console.WriteLine("█╬╬╬╬╬╬╬╬╬╬╬╬╬╬█╬╬╬╬╬╬╬╬╬╬╬╬╬╬█");
Console.WriteLine("█╬╬╬╬╬╬╬╬╬╬╬╬╬╬█╬╬╬╬╬╬╬╬╬╬╬╬╬╬█");
Console.WriteLine("█╬╬╬▓▓▓▓╬╬╬╬╬╬╬█╬╬╬╬╬╬╬▓▓▓▓╬╬╬█");
Console.WriteLine("█╬╬▓▓▓▓▓▓╬╬█╬╬╬█╬╬╬█╬╬▓▓▓▓▓▓╬╬█");
Console.WriteLine("█╬╬╬▓▓▓▓╬╬██╬╬╬█╬╬╬██╬╬▓▓▓▓╬╬╬█");
Console.WriteLine("█╬╬╬╬╬╬╬╬██╬╬╬╬█╬╬╬╬██╬╬╬╬╬╬╬╬█");
Console.WriteLine("█╬╬╬╬╬████╬╬╬╬███╬╬╬╬████╬╬╬╬╬█");
Console.WriteLine("█╬╬╬╬╬╬╬╬╬╬╬╬╬███╬╬╬╬╬╬╬╬╬╬╬╬╬█");
Console.WriteLine("██╬╬█╬╬╬╬╬╬╬╬█████╬╬╬╬╬╬╬╬█╬╬██");
Console.WriteLine("██╬╬██╬╬╬╬╬╬███████╬╬╬╬╬╬██╬╬██");
Console.WriteLine("██╬╬▓███╬╬╬████╬████╬╬╬███▓╬╬██");
Console.WriteLine("███╬╬▓▓███████╬╬╬███████▓▓╬╬███");
Console.WriteLine("███╬╬╬╬▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓╬╬╬╬███");
Console.WriteLine("████╬╬╬╬╬╬╬╬╬╬███╬╬╬╬╬╬╬╬╬╬████");
Console.WriteLine("█████╬╬╬╬╬╬╬╬╬╬█╬╬╬╬╬╬╬╬╬╬█████");
Console.WriteLine("██████╬╬╬╬╬╬╬╬███╬╬╬╬╬╬╬╬██████");
Console.WriteLine("███████╬╬╬╬╬╬╬███╬╬╬╬╬╬╬███████");
Console.WriteLine("████████╬╬╬╬╬╬███╬╬╬╬╬╬████████");
Console.WriteLine("█████████╬╬╬╬╬███╬╬╬╬╬█████████");
Console.WriteLine("███████████╬╬╬╬█╬╬╬╬███████████");
Console.WriteLine("███████████████████████████████");

            Console.ReadKey();
        }
    }
}
