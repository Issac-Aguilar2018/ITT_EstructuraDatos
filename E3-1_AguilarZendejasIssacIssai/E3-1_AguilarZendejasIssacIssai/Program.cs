using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Programa mejorando la clase. 
            ////Aqui en el main tenemos un switch con 4 opciones. 
            ///Este programa lo hice con switch, porque pense que podria reiniciar las variables para volver hacer todo sin reiniciar el programa 
            Console.Title = "Consular calificaciones";
            int Menu = 0;
            List<Escuela> Escue = new List<Escuela>();///Lista de objetos
            Escuela Salon;
            do
            {
                Console.Clear();
                Console.Write(
                    "\n1.- Agregar Clases" +
                    "\n2.- Agregar alumnos" +
                    "\n3.- Ver alumnos" +
                    "\n4.- Salir" +
                    "\n\nEliga una opcion: ");
                Menu = Convert.ToInt16(Console.ReadLine());
                switch (Menu)
                {
                    case 1: /////Aqui el usuario ingresara cuantas clases hay y entrara al for donde pedira el nombre de la clase y cuantos alumnos hay en cada clase.                      
                        Console.Clear();
                        Console.Write("Cuantas clases hay: ");
                        int x = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < x; i++)
                        {
                            Console.Write("Nombre de la clase: ");
                            string Nom = Console.ReadLine();
                            Console.Write("Cuantos alumnos tiene cada clase: ");
                            int Alumnos = Convert.ToInt16(Console.ReadLine());
                            Salon = new Escuela(Alumnos, Nom);/// La informacion se va almacenar en una lista de objetos que creamos 
                            Escue.Add(Salon);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2: /// la segunda opcion es donde vamos agregar a los alumnos y adentro estar un foreach donde va a estar almacenando la informacion donde corresponde
                            /// Y llamamos al metodo alumno que creamos en la clase escuela 
                        foreach (Escuela i in Escue)
                        {
                            i.Alumno();
                        }
                        break;
                    case 3:/// La tercera opcion es donde va a ver las calificaciones que puso el usuario. y tambien llamamos al metodo VerAlumno. 
                        foreach (Escuela i in Escue)
                        {
                            Console.Clear();
                            i.VerAlumno();
                            Console.ReadKey();
                        }
                        break;
                    default:/// Opcion para salir del programa                                             
                        Console.WriteLine("Presione <Enter> para salir");
                        Console.ReadKey();
                        break;
                }
            } while (Menu != 4);
        }
    }
    public class Escuela
    {
        public string Clases; ///Variables que nos ayudaran guardando informacion 
        public string[] Alum;
        public int[] Calificaciones;
        public Escuela(int Alumnos, string Nom) /// Constructor con parametros para agregar la informacion 
        {
            Clases = Nom;
            Alum = new string[Alumnos];
            Calificaciones = new int[Alumnos];
        }
        public void Alumno()/// Metodo donde agregaremos al alumno y la calificacion. Este for dependera de cuantos alumnos hay en una clase y eso tambien aplicaria a las calificaciones 
        {
            for (int i = 0; i < Alum.Length; i++)
            {
                Console.Clear();
                Console.Write("Clase {0} \nIntroduzca al alumno: ", Clases);
                Alum[i] = Console.ReadLine();
            }
            for (int j = 0; j < Alum.Length; j++)
            {
                Console.Write("\nIntroduzca la calificacion del alumno {0}: ", Alum[j + 0]);
                Calificaciones[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
        public void VerAlumno()///Metodo para ver las califaciones del los alumnos de las clases que se crearon.
        {
            Console.WriteLine("Calificaciones de la materia de {0}", Clases);
            for (int i = 0; i < Alum.Length; i++)
            {
                Console.WriteLine(Alum[i] + " " + "  " + Calificaciones[i]);
            }
        }
    }
}                        