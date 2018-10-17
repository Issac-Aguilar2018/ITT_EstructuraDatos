using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Metodos Queue, La cola tiene un comportamiento contrario a la pila.
            Queue Cola = new Queue(); ///Enqueue sirve para colocar los elementos al final del queue 
            Cola.Enqueue("Aguilar");
            Cola.Enqueue(19);
            Cola.Enqueue("Issac");
            Cola.Enqueue('i');
            foreach (var x in Cola)///Imprimir la cola 
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nMetodo Dequeue: " + Cola.Dequeue());///Elemento primero en la cola
            foreach (var x in Cola)///Ahora va imprimir con 3 elementos, porque ya que el primer elemento que ingresa a la cola es el primer elemento que sale.
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nElementos en el queue: " + Cola.Count);///Elementos que hay en el queu          
            Console.WriteLine("Elemento al principio: " + Cola.Peek());///Devuelve un elemento al principio sin eliminarlo             
            bool TF = Cola.Contains(19);
            Console.WriteLine("Elemento [19] se encuentra en la cola: " + TF);///Saber si el elemento se encuentra en la cola                                                      
            Console.ReadKey();
        }
    }
}
