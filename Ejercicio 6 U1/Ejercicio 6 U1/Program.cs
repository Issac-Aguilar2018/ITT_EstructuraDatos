using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, Posicion = 0, z = 1;            
            Console.Write("Escriba la cantidad de frases que necesitas: ");
            int b = Convert.ToInt16(Console.ReadLine());
            string[] Letra = new string[b];
            for (int i = 0; i < b; i++)
            {
                Console.Write("Palabras: ");
                Letra[i] = Console.ReadLine();
                int y = 0;
                foreach (char e in Letra[i])
                {
                    y++;
                }              
                if (y > x && Posicion < i)
                {
                    x = y;
                    Posicion = i;
                    z++;
                }
            }                      
            Console.WriteLine("\nPalabra Mayor: {0}", Letra[Posicion]);
            Console.WriteLine("Posicion: {0}", Posicion + 1);                  
            Console.ReadKey();
        }
    }
}
