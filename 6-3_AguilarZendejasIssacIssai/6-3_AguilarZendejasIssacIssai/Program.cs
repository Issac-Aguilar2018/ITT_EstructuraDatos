using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            Hash hash = new Hash(8);
            hash.Mostrar();
            Console.ReadKey();
        }
    }
    public class Hash
    {
        int[] Arreglo; ///Arreglo de tipo int 
        int x = 0; ///Variable auxiliar 
        public Hash(int y) ///Constructor 
        {
            x = y;
            Arreglo = new int[y];
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Arreglo[i] = 0;///Posicion 0 
            }
        }
        public void OperacionHash(int [] CArreglo, int[] Arreglo_1) ///Metodo operacion hash
        {
            for (int i = 0; i < CArreglo.Length; i++)///Este for recorre el arreglo 
            {
                int Ele = CArreglo[i];///Se guardan las posiciones
                int IA = Ele % 8;
                while(Arreglo[IA] != 0) ///Condicion que no se encuentre un 0
                {
                    IA++;
                    IA %= x;
                }
                Arreglo[IA] = Ele; ///Se guardar 
            }
        }
        public void Imprimir()///Impresion de los metodos 
        {
            int Aumentar = 0, i, j; ///Variables auxiliares
            for (i = 0; i < 1; i++)
            {
                Aumentar += 8;              
                Console.WriteLine();
                for (j = Aumentar - 8; j < Aumentar; j++) ///Imprime los numeros del 0 al 7
                {
                    Console.Write("  {0} ", j);
                }
                Console.WriteLine();                
                Console.WriteLine();
                for (j = Aumentar - 8; j < Aumentar; j++)
                {
                    if (Arreglo[j].Equals("-1"))
                    {
                        Console.Write("[      ");
                    }
                    {
                        Console.Write(" {0} ", Arreglo[j]);///Imprime los numeros del arreglo 
                    }
                }
                Console.WriteLine();              
            }
        }
        public int Buscar(int Ele)///Metodo de buscar 
        {
            int IA = Ele % 8;
            int Contador = 0; ///Variable auxiliar 
            while (Arreglo[IA] != 0)//Condicion para encontrar el numero deseado 
            {
                if (Arreglo[IA] == Ele)///Cuando el elemento se encuentre en el arreglo se pasa a este if 
                {
                    Console.WriteLine("\nEl valor " + Ele + " se encuentra en la posicion: " + IA);
                    return Arreglo[IA];
                }
                IA++;
                IA %= x;
                if (Contador > 8) ///Por si no se encuentra 
                {
                    break;
                }
            }
            return 0;
        }
        public void Mostrar()
        {
            int[] Elementos = { 1, 2, 13, 22, 200, 123, 111, 12 }; ///Arreglo donde tienen numeros definidos 
            OperacionHash(Elementos, Arreglo); ///Llamamos a los metodos 
            Imprimir();
            Buscar(2);
            Console.ReadKey();
        }
    }
}
