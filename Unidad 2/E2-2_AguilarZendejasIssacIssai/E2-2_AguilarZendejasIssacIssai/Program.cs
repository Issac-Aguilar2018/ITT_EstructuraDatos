using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            Fibonacci Fibo = new Fibonacci();
            Fibo.Interactiva();
            Console.ReadLine();            
            Fibo.Recursivo(x);
            Fibo.Recursivo_1();
            Console.ReadKey();
        }
    }
    class Fibonacci
    {
        public int Fibo = 0, Primera = 0, Ultima = 1, Fibo_1 =0,Primera_1 = 0, Ultima_1 = 1;
        public void Interactiva()
        {
            string Respuesta;
            do
            {                
                Console.Clear();
                Console.Write("Cuantos numeros fibonacci quieres: ");
                int x = Convert.ToInt16(Console.ReadLine());
                for (int i = 0; i < x; i++)
                {
                    Fibo = Primera;
                    Primera = Ultima;
                    Ultima = Primera + Fibo;
                    Console.WriteLine(Primera);                    
                }                
                Stopwatch Tiempo = new Stopwatch();
                Tiempo.Start();
                Tiempo.Stop();
                Console.WriteLine("\nEl tiempo de ejecucion es de: {0}", Tiempo.Elapsed.TotalMilliseconds.ToString());
                Console.WriteLine("Desea continuar? Si/No");
                Respuesta = Console.ReadLine();
              
            } while (Respuesta != "No");            
        }
        public int Recursivo(int b)
        {
            if (b < 2)
            {
                return b;
            }
            else
            {
                return (Recursivo(b - 1) + Recursivo(b - 2));
            }                    
        }
        public void Recursivo_1()
        {
            Console.WriteLine("Clase Recursivo");
            Console.Write("Cuantos numeros fibonacci quieres: ");
            int x = Convert.ToInt16(Console.ReadLine());
            while (Ultima_1 <= x)
            {
                Console.WriteLine(Recursivo(Ultima_1));
                Ultima_1++;
            }
            Stopwatch Tiempo = new Stopwatch();
            Tiempo.Start();
            Tiempo.Stop();
            Console.WriteLine("\nEl tiempo de ejecucion es de: {0}", Tiempo.Elapsed.TotalMilliseconds.ToString());
        }
    }
}
