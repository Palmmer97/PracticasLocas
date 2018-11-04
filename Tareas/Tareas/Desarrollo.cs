using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    class Desarrollo
    {
        // Se Crean Las listas a ocupar 
        List<Datos> Pendientes = new List<Datos>(); 
        List<Datos> Terminadas = new List<Datos>(); 
        List<Datos> Proceso = new List<Datos>(); 

        // Metodo Ver tareas el cual es un menu 
        public void VerTareas()  
        {
            // Etiqueta de retorno 
        MirarTareas:
            Console.Clear(); 
            Console.WriteLine("Seleccione la lista: \n");
            Console.WriteLine("-------------------------- \n");
            Console.WriteLine("1. Todas las tareas");
            Console.WriteLine("2. Tareas Pendientes");
            Console.WriteLine("3. Tareas en Proceso");
            Console.WriteLine("4. Tareas Terminadas");
            Console.WriteLine("5. Volver al Menu");
            Console.WriteLine("-------------------------- \n");
            //  hace MAYUSCULAS lo ingresado 
            string Seleccion = Console.ReadLine().ToUpper(); 
            if (Seleccion == "1" || Seleccion == "TODAS LAS TAREAS" || Seleccion == "1. TODAS LAS TAREAS") 
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------ \n");
                Console.WriteLine("ID/Nombre/Descripcion/Fecha Inicio/Status/Fecha de Fin/Descripcion del status/Fin");
                Console.WriteLine("------------------------------------------------------------------------------ \n");
                foreach (var item in Pendientes)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio);
                }
                foreach (var item in Proceso)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio + "/ " + item.Status + "/ Aun no se termina /" + item.DescricionStatus);
                }
                foreach (var item in Terminadas)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio + "/ " + item.Status + "/ " + item.FechaFin + "/ " + item.DescricionStatus);
                }
                Console.WriteLine("\n¨Pulse alguna tecla ");
                Console.ReadKey();
                goto MirarTareas; 
            }
            else if (Seleccion == "2" || Seleccion == "TAREAS PENDIENTES" || Seleccion == "2. TAREAS PENDIENTES") 
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------ \n");
                Console.WriteLine("ID/Nombre/Descripcion/Fecha Inicio/Fecha Fin/Status/Fin");
                Console.WriteLine("------------------------------------------------------------------------------ \n");
                foreach (var item in Pendientes)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio);
                }
                Console.WriteLine("\nPulse alguna tecla ");
                Console.ReadKey();
                goto MirarTareas; 
            }
            else if (Seleccion == "3" || Seleccion == "TAREAS EN PROCESO" || Seleccion == "3. TAREAS EN PROCESO") 
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------ \n");
                Console.WriteLine("ID/Nombre/Descripcion/Fecha Inicio/Fecha Fin/Status/Descripcion del status/Fin");
                Console.WriteLine("------------------------------------------------------------------------------ \n");
                foreach (var item in Proceso)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio + "/ " + item.FechaFin + "/ " + item.Status + "/ " + item.DescricionStatus);
                }
                Console.WriteLine("\nPulse alguna tecla");
                Console.ReadKey();
                goto MirarTareas; 
            }
            else if (Seleccion == "4" || Seleccion == "TAREAS TERMINADAS" || Seleccion == "4. TAREAS TERMINADAS") 
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------ \n");
                Console.WriteLine("ID/Nombre/Descripcion/Fecha Inicio/Status/Fecha Fin/Descripcion del status/Fin");
                Console.WriteLine("------------------------------------------------------------------------------ \n");
                foreach (var item in Terminadas)
                {
                    Console.WriteLine(item.ID + "/ " + item.Nombre + "/ " + item.Descripcion + "/ " + item.FechaInicio + "/ " + item.Status + "/ " + item.FechaFin + "/ " + item.DescricionStatus);
                }
                Console.WriteLine("\nPulse alguna tecla");
                Console.ReadKey();
                goto MirarTareas; 
            }
            else if (Seleccion == "5" || Seleccion == "VOLVER AL MENU" || Seleccion == "5. VOLVER AL MENU") 
            {
                // Manda llamar al metodo 
                MainMenu(); 
            }
            else 
            {
                Console.WriteLine("--------------------------------- \n");
                Console.WriteLine("La Opcion no es valida");
                Console.WriteLine("Pulse una tecla para continuar ");
                Console.WriteLine("-------------------------------- \n");
                Console.ReadKey();
                goto MirarTareas; 
            }

        }

        // Metodo agregar tarea 
        public void AgregaTarea() 
        {
            // Objeto y Variable Randon 
            Datos Tarea = new Datos(); 
            Random Ran = new Random(); 
            int Variable = Ran.Next(0, 9), Variable1 = Ran.Next(0, 9), Variable2 = Ran.Next(0, 9);
            Console.WriteLine("------------------- \n");
            Console.Write("Numero de la tarea: ");
            Console.WriteLine("------------------- \n");
            // Se le asigna las 3 variables random con  su numero de tarea asi creando su ID 
            Tarea.ID = Variable.ToString() + Variable1.ToString() + Variable2.ToString() + Console.ReadLine();
            Console.WriteLine("------------------- \n");
            Console.Write("Nombre de la tarea: ");
            Console.WriteLine("------------------- \n");
            Tarea.Nombre = Console.ReadLine();
            Console.WriteLine("------------------- \n");
            Console.Write("Descripciona: ");
            Console.WriteLine("------------------- \n");
            Tarea.Descripcion = Console.ReadLine();
            Console.WriteLine("----------------------------------- \n");
            Console.Write("Fecha de inicio de tarea: ");
            Console.WriteLine("----------------------------------- \n");
            Tarea.FechaInicio = Console.ReadLine();
            //la tarea se anexa  con los atributos introducidos a la Lista de Pendientes
            Pendientes.Add(Tarea);
            Console.WriteLine("--------------------- \n");
            Console.WriteLine("Se agrego la tarea.");
            Console.WriteLine("Pulse alguna tecla");
            Console.WriteLine("--------------------- \n");
            Console.ReadKey();
        }


        // Edita el estatus de la tarea 
        public void MenuEditarStatus() 
        {

        Mirar:
            Console.Clear();
        Console.WriteLine("----------------------------------------------------- \n");
            Console.WriteLine("Escoja una opcion para editar: "); 
            Console.WriteLine("1. Tareas Pendientes");
            Console.WriteLine("2. Tareas en Proceso");
            Console.WriteLine("3. Tareas Terminadas");
            Console.WriteLine("4. Volver al Menu");
            Console.WriteLine("------------------------------------------------- \n");
            // Lo Hace mayusculas 
            string Seleccion = Console.ReadLine().ToUpper(); 
            if (Seleccion == "1" || Seleccion == "TAREAS PENDIENTES" || Seleccion == "1. TAREAS PENDIENTES") 
            {
                Console.Clear();
                Console.WriteLine("---------------- \n");
                Console.WriteLine(" ID     Nombre");
                Console.WriteLine("--------------- \n");
                // Imprime Taras pendientes
                foreach (var item in Pendientes)
                {
                    Console.WriteLine(item.ID + "  " + item.Nombre);
                }
                Console.WriteLine("----------------------------------- \n");
                Console.WriteLine("\nAgrege el ID de la tarea a editar: ");
                Console.WriteLine("----------------------------------- \n");
                string Editor = Console.ReadLine();
                int Contador = -1; 

                foreach (var item in Pendientes)
                {
                    Contador++; 
                    if (Editor == item.ID) 
                    {
                    Go:
                        Console.Clear();
                    Console.WriteLine("----------------------------------------------------------- \n");
                        Console.WriteLine("Cual es el Status de la tarea (Proceso / Terminado): ");
                        Console.WriteLine("------------------------------------------------------- \n");
                        string Determina = Console.ReadLine().ToUpper();
                        if (Determina == "PROCESO")
                        {
                            item.Status = "Proceso";
                            Console.WriteLine("------------------------ \n");
                            Console.WriteLine("descripcion del status:");
                            Console.WriteLine("--------------------- \n");
                            item.DescricionStatus = Console.ReadLine();
                            Proceso.Add(item);
                            Pendientes.RemoveAt(Contador);
                            Console.WriteLine("Pulse alguna tecla");
                            Console.ReadKey();
                            goto Mirar;
                        }
                        else if (Determina == "TERMINADO")
                        {
                            item.Status = "Terminado";
                            Console.WriteLine("---------------------------------------- \n");
                            Console.Write("agrege la fecha en que se termino el trabajo: ");
                            Console.WriteLine("----------------------------------------- \n");
                            item.FechaFin = Console.ReadLine();
                            Console.WriteLine("----------------------------------- \n");
                            Console.WriteLine("descripcion del status:");
                            Console.WriteLine("----------------------------------- \n");
                            item.DescricionStatus = Console.ReadLine();
                            Terminadas.Add(item);
                            Pendientes.RemoveAt(Contador);
                            Console.WriteLine("Pulse alguna telca ");
                            Console.ReadKey();
                            goto Mirar;
                        }
                        else
                        {
                            Console.WriteLine("-------------------- \n");
                            Console.WriteLine("Opcion no valida ");
                            Console.WriteLine("Pulse alguna telca");
                            Console.WriteLine("-------------------- \n");
                            Console.ReadKey();
                            goto Go;
                        }

                    }
                    else
                    {
                        goto Eso;
                    }
                Eso:
                    Console.ReadLine();
                }

            }
            else if (Seleccion == "2" || Seleccion == "TAREAS EN PROCESO" || Seleccion == "2. TAREAS EN PROCESO")
            {
                Console.Clear();
                Console.WriteLine("---------------- \n");
                Console.WriteLine(" ID     Nombre");
                Console.WriteLine("--------------- \n");
                foreach (var item in Proceso)
                {
                    Console.WriteLine(item.ID + "  " + item.Nombre);
                }
                Console.WriteLine("----------------------------------- \n");
                Console.WriteLine("\nAgrege el ID de la tarea a editar: ");
                Console.WriteLine("----------------------------------- \n");
                string Editor = Console.ReadLine();
                int Contador = -1;

                foreach (var item in Proceso)
                {
                    Contador++;
                    if (Editor == item.ID)
                    {
                        item.Status = "Terminado";
                        Console.WriteLine("----------------------------------- \n");
                        Console.Write("Agrege fecha en que se termino el trabajo: ");
                        Console.WriteLine("----------------------------------- \n");
                        item.FechaFin = Console.ReadLine();
                        Console.WriteLine("------------------------ \n");
                        Console.WriteLine("descripcion del status:");
                        Console.WriteLine("------------------------ \n");
                        item.DescricionStatus = Console.ReadLine();
                        Terminadas.Add(item);
                        Proceso.RemoveAt(Contador);
                        Console.WriteLine("Pulse alguna tecla");
                        Console.ReadKey();
                        goto Mirar;
                    }
                    else
                    {
                        goto Esos;
                    }
                Esos:
                    Console.ReadLine();
                }
            }

            else if (Seleccion == "3" || Seleccion == "TAREAS TERMINADAS" || Seleccion == "3. TAREAS TERMINADAS")
            {
                Console.Clear();
                Console.WriteLine("------------------ \n");
                Console.WriteLine(" ID     Nombre");
                Console.WriteLine("----------------- \n");
                foreach (var item in Terminadas)
                {
                    Console.WriteLine(item.ID + "  " + item.Nombre);
                }
                Console.WriteLine("--------------------------------------------- \n");
                Console.WriteLine("\nAgrege ID de la tarea a editar: ");
                Console.WriteLine("------------------------------------------------- \n");
                string Editor = Console.ReadLine();
                int Contador = -1;
            
                foreach (var item in Terminadas)
                {
                    Contador++;
                    if (Editor == item.ID)
                    {
                        item.Status = "Proceso";
                        item.FechaFin = " ";
                        Console.WriteLine("----------------------------------- \n");
                        Console.WriteLine("descripcion del status:");
                        Console.WriteLine("----------------------------------- \n");
                        item.DescricionStatus = Console.ReadLine();
                        Proceso.Add(item);
                        Terminadas.RemoveAt(Contador);
                        Console.WriteLine("Pulse una tecla ");
                        Console.ReadKey();
                        goto Mirar;
                    }
                    else
                    {
                        goto Eso;
                    }
                Eso:
                    Console.ReadLine();
                }

            }
            else if (Seleccion == "4" || Seleccion == "VOLVER AL MENU" || Seleccion == "4. VOLVER AL MENU")
            {
                MainMenu();
            }
        }

        // Menu principal 
        public void MainMenu()
        {
        Ini:
            Console.Clear();
        Console.WriteLine("----------------------------------- \n");
            Console.WriteLine("1. Ver Tareas");
            Console.WriteLine("2. Agregar Tareas");
            Console.WriteLine("3. Editar Status");
            Console.WriteLine("4. Salir");
            Console.WriteLine("----------------------------------- \n");
            string Menu = Console.ReadLine().ToUpper();
            if (Menu == "1" || Menu == "VER TAREAS")
            {
                VerTareas();
            }
            else if (Menu == "2" || Menu == "AGREGAR TAREAS")
            {
                Console.Clear();
                AgregaTarea();
                goto Ini;
            }
            else if (Menu == "3" || Menu == "EDITAR STATUS")
            {
                MenuEditarStatus();
            }

            else if (Menu == "4" || Menu == "SALIR")
            {
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Opcion no valida ");
                Console.WriteLine("Pulse alguna tecla ");
                Console.ReadKey();
                goto Ini;
            }
        }
    }
}
