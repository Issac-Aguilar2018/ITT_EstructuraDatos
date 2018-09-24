using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, Posicion = 0, y = 0;
            Console.Write("Escriba la cantidad de intentos que necesita: ");
            int Intentos = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < Intentos; i++)
            {
                Console.Write("Numeros: ");
                y = Convert.ToInt16(Console.ReadLine());
                if (y > x)
                {
                    x = y;
                    Posicion = i + 1;
                }
            }
            Console.WriteLine("El numero mayor ingresados es: {0}", x);
            Console.WriteLine("Se encuentra en la posicion: {0}", Posicion);
            Console.ReadKey();
        }
    }
}
