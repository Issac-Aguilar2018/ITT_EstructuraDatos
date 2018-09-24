using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Cuantas palabras quieres agregar: ");
            x = Convert.ToInt16(Console.ReadLine());            
            string[] Nombre = new string[x];
            for (int i = 0; i < Nombre.Length; i++)
            {
                Console.Write("\nEscriba una palabra y presionar <Enter>: ");
                Nombre[i] = Console.ReadLine();
            }
            Console.Write("El inverso del enunciado es: ");
            for (int i = x-1; i >= 0; i--)
            {
                Console.Write(" "+Nombre[i]);
            }
            Console.ReadKey();
        }
    }
}
