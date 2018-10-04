using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            int Menu = 0;
            do
            {
                Console.Clear();
                Console.Write(
                    "\n1.- Ejercicio 1" +
                    "\n2.- Ejercicio 2" +
                    "\n3.- Ejercicio 3" +
                    "\n4.- Salir" +
                    "\n\nEliga una opcion: ");
                Menu = Convert.ToInt16(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        Console.Write("\nDigite la cantidad de numeros: ");
                        int x = Convert.ToInt16(Console.ReadLine());
                        int[] Arreglo = new int[x];
                        Finito Fin = new Finito();
                        for (int i = 0; i < Arreglo.Length; i++)
                        {
                            Console.Write("\nEscriba los numeros: ");
                            int Num = Convert.ToInt16(Console.ReadLine());
                            Arreglo[i] = Num;
                        }
                        Console.WriteLine("\nEl numero mayor es: {0}", Fin.Mayor(Arreglo, 0, Arreglo[0]));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("\nDigite la cantidad de numeros: ");
                        int x_1 = Convert.ToInt16(Console.ReadLine());
                        int[] Arreglo_1 = new int[x_1];
                        Finito Fini = new Finito();
                        for (int i = 0; i < Arreglo_1.Length; i++)
                        {
                            Console.Write("\nEscriba los numeros: ");
                            int Num = Convert.ToInt16(Console.ReadLine());
                            Arreglo_1[i] = Num;
                        }
                        Console.WriteLine("\nEl numero menor es: {0}", Fini.Menor(Arreglo_1, 0, Arreglo_1[0]));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("\nDigite la cantidad de numeros: ");
                        int x_2 = Convert.ToInt16(Console.ReadLine());
                        int[] Arreglo_2 = new int[x_2];
                        Finito Finito = new Finito();
                        for (int i = 0; i < Arreglo_2.Length; i++)
                        {
                            Console.Write("\nEscriba los numeros: ");
                            int Num = Convert.ToInt16(Console.ReadLine());
                            Arreglo_2[i] = Num;
                        }
                        Finito.Inversa(Arreglo_2, 0, Arreglo_2.Length - 1);
                        for (int j = 0; j < Arreglo_2.Length; j++)
                        {
                            Console.Write("{0} ", Arreglo_2[j]);
                        }
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Presione <Enter> para salir");
                        Console.ReadKey();
                        break;
                }
            } while (Menu != 4);
        }
    }
    class Finito
    {
        public int y = 0;
        public int Mayor(int[] x, int i, int May)
        {
            if (i != x.Length)
            {

                if (x[i] > May)
                {
                    May = Mayor(x, i + 1, x[i]);
                }
                else
                {
                    May = Mayor(x, i + 1, May);
                }
            }
            return May;
        }
        public int Menor(int[] x_1, int i_1, int Mini)
        {
            if (i_1 != x_1.Length)
            {
                if (x_1[i_1] < Mini)
                {
                    Mini = Menor(x_1, i_1 + 1, x_1[i_1]);
                }
                else
                {
                    Mini = Menor(x_1, i_1 + 1, Mini);
                }
            }
            return Mini;
        }
        public int Inversa(int[] x_2, int i_2, int Arreglo)
        {
            if (i_2 < Arreglo)
            {
                y = x_2[i_2];
                x_2[i_2] = x_2[Arreglo];
                x_2[Arreglo] = y;
                Inversa(x_2, i_2 + 1, Arreglo - 1);
            }
            return y;
        }
    }
}
