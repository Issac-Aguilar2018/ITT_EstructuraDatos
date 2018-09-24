using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca A: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Introduzca B: ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.Write("Introduzca C: ");
            int c = Convert.ToInt16(Console.ReadLine());
            if ( a < b && a < c)
            {
                Console.Write("El numero menor es: {0}", a);
            }
            if (b < c && b < a)
            {
                Console.Write("El numero menor es: {0}", b);
            }
            if (c < b && c < a)
            {
                Console.Write("El numero menor es: {0}", c);
            }
            Console.ReadKey();
        }
    }
}
