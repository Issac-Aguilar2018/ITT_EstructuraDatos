using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E3_AguilarZendejasIssacIssai
{
    class Operacion
    {
        List<string> lista = new List<string>();
        LinkedList<string> ListaLigada = new LinkedList<string>();
        List<Clase> Colegio = new List<Clase>();
        Stack Pila = new Stack();
        Queue Cola = new Queue();
        List<Clase> Clases = new List<Clase>();

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Pila.Push(5);
            Pila.Push(3);
            Pila.Pop();
            Pila.Push(2);
            Pila.Push(8);
            Pila.Pop();
            Pila.Pop();
            Pila.Push(9);
            Pila.Push(1);
            Pila.Pop();
            Pila.Push(7);
            Pila.Push(6);
            Pila.Pop();
            Pila.Pop();
            Pila.Push(4);
            Pila.Pop();
            Pila.Pop();
            foreach (var item in Pila)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
        }

        public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.         
            Stopwatch Tiempo = new Stopwatch();
            Tiempo.Start();
            for (int i = 0; i < 9877; i++)
            {
                lista.Add("Hola mundo");
            }
            Tiempo.Stop();
            Stopwatch Tiempo_1 = new Stopwatch();
            Tiempo_1.Start();
            for (int i = 0; i < 9877; i++)
            {
                ListaLigada.AddLast("Hola");
            }
            Tiempo_1.Stop();

            Console.Write("Lista: {0} ", Tiempo.Elapsed.ToString());
            Console.Write("\nLista ligada: {0}", Tiempo_1.Elapsed.ToString());
        }

        public void Ejercicio4()
        {

            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.

            int Alto = 0, Bajo = 100;
            double Calificacion = 0, Promedio = 0;

            Clase Escue = new Clase();

            Console.Write("\nNombre de la clase: ");
            Escue.NombreClase = Console.ReadLine();
            Console.Write("\nNombre del maestro: ");
            Escue.Maestro = Console.ReadLine();
            for (int i = 0; i < 31; i++)
            {
                Clase Escuela = new Clase();
                Console.Write("\nNombre del alumno: ");
                Escuela.Alumno = Console.ReadLine();
                Console.Write("Calificacion del alumno {0} es: ", (i + 1));
                Escuela.Calificacion = int.Parse(Console.ReadLine());
                if (Escuela.Calificacion > Alto)
                {
                    Alto = Escuela.Calificacion;
                }
                if (Bajo > Escuela.Calificacion)
                {
                    Bajo = Escuela.Calificacion;
                }
                Colegio.Add(Escuela);
            }

            foreach (var item in Colegio)
            {
                Calificacion += item.Calificacion;
                Promedio = Calificacion / Colegio.Count;
            }
            Console.WriteLine("\nCalificaciones del mas alto: {0} ", Alto);
            Console.WriteLine("Calificaciones del mas bajo: {0} ", Bajo);
            Console.WriteLine("El promedio es: {0} ", Promedio);
        }
    }
}

