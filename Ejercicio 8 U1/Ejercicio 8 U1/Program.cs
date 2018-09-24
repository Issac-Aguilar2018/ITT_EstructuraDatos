using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string Digitos,y,Inv = "";            
            do
            {
                Console.Write("Introduzca 5 digitos: ");
                Digitos = Console.ReadLine();
                x = Digitos.Length;
                if (x != 5)
                {
                    Console.WriteLine("Digitos incorrecto");
                }
            } while (x != 5);
            for (int i = 4; i >= 0; i--)
            {
                y = Digitos.Substring(i, 1);
                Inv = Inv + y;
            }
            if (Digitos == Inv)
            {
                Console.WriteLine("Es palindrome");
            }
            else
            {
                Console.WriteLine("No es palindrome");
            }
            Console.ReadKey();
        }
    }
}
