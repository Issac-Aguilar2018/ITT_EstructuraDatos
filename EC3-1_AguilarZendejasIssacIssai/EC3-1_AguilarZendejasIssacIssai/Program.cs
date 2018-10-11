using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC3_1_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Programa para conocer los metodos de la clase stack
            var Pila = new Stack();
            Pila.Push("Issac");
            Pila.Push("Gabriela");
            Pila.Push("Carlos");
            Pila.Push(19);
            Console.WriteLine("");
            foreach (var x in Pila)///Imprimir los datos 
            {
                Console.WriteLine(x);
            }
            bool TF = Pila.Contains("Issac");///Indica si es cierto que un elemento esta en la pila 
            Console.WriteLine("\nLa pila contiene a Issac: {0} ", TF);
            Console.WriteLine(Pila.Pop().GetType());// Saber de que tipo son los elementos almacenados en la pila
            Console.WriteLine(Pila.Contains(123).ToString());//Devuelve el elemento convertido a un string
            Console.WriteLine(Pila.ToArray());//Devuelve toda la pila convertida a una array 
            Console.WriteLine(Pila.GetEnumerator());//Permite usar para recorrer la pila con "enumeradores"
            Console.ReadKey();
        }
    }
}
