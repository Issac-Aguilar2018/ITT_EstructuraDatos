using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_1_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            For FacFor = new For();
            FacFor.Desplegar();
            Console.ReadLine();
            Console.WriteLine("Factorial con pseudocodigo");
            Console.Write("Introduzca un numero: ");
            int x = Convert.ToInt16(Console.ReadLine());
            Pseudo pseu = new Pseudo(x);
            pseu.Desplegar();
            Console.ReadKey();
        }
        public class For
        {
            public int Resultado = 0, x = 1;
            public For()
            {
                Resultado = 0;
            }
            public int Procedimiento()
            {
                for (int i = 1; i < 7; i++)
                {
                    x = x * i;
                }
                return x;
            }
            public void Desplegar()
            {
                Console.WriteLine("Factorial con for");
                Console.WriteLine("El factorial de 6 es: {0}", Procedimiento());
                Stopwatch Tiempo = new Stopwatch();
                Tiempo.Start();
                Tiempo.Stop();
                Console.WriteLine("El tiempo de ejecucion es de: {0}", Tiempo.Elapsed.TotalMilliseconds.ToString());
            }
        }
        public class Pseudo
        {
            public int y;
            public Pseudo(int x)
            {
                y = x;
            }
            public int Procedimiento(int a)
            {
                if (a == 0)
                {
                    return 1;
                }
                else
                {
                    return a * Procedimiento(a - 1);
                }
            }
            public void Desplegar()
            {
                Console.WriteLine("\nEl resultado es: {0}", Procedimiento(y));
                Stopwatch Tiempo = new Stopwatch();
                Tiempo.Start();
                Tiempo.Stop();
                Console.WriteLine("El tiempo de ejecucion es de: {0}", Tiempo.Elapsed.TotalMilliseconds.ToString());
            }
        }
    }
}
    

