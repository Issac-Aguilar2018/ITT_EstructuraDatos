using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de numeros del arreglo: ");
            int x = Convert.ToInt16(Console.ReadLine());
            int[] Arreglo = new int[x];
            Random Rand = new Random();
            Console.WriteLine("Numeros no ordenados:");
            for (int i = 0; i < x; i++)
            {
                Arreglo[i] = Rand.Next(1, 101);
                Console.Write("{0} ", Arreglo[i]);
            }
            Console.WriteLine("\nNumeros ordenados:");
            Array.Sort(Arreglo);
            for (int i = 0; i < x; i++)
            {
                Console.Write("{0} ", Arreglo[i]);
            }
            Console.ReadKey();
        }
    }
}
