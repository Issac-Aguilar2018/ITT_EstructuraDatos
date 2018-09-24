using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cant, Num, Mayor = 0, Menor = 0;
            Console.Write("¿Que cantidad de numeros quieres poner? ");
            Cant = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < Cant; i++)
            {
                Console.Write("Escriba los numeros: ");
                Num = Convert.ToInt16(Console.ReadLine());
                if (i == 0)
                {
                    Mayor = Num;
                    Menor = Num;
                }
                else if (i != 0)
                {
                    if (Num < Menor)
                    {
                        Menor = Num;
                    }
                    if (Num > Mayor)
                    {
                        Mayor = Num;
                    }
                }

            }
            Console.WriteLine("\nNumero mayor: {0}", Mayor);
            Console.WriteLine("Numero menor: {0}", Menor);
            Console.ReadKey();
        }
    }
}
