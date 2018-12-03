using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            Radix radix = new Radix(); ///Objeto
            radix.Imprimir(); ///Llamamos a pedir al metodo imprimir 
            Console.ReadKey();
        }
    }
    public class Radix
    {
        int[] Arreglo_1 = { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 }; /// 4 Arreglos con diferentes numeors 
        int[] Arreglo_2 = { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
        int[] Arreglo_3 = { 10, 40, 36, 5, 24, 2, 5, 8 };
        int[] Arreglo_4 = { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
        int[] Arreglo_5 = { 25, 108, 1024, 12, 351, 251, 39 };
        public void Operacion(int[] Arreglo)//Recibe un parametro de tipo int 
        {
            int x, y; ///Variables auxiliares
            for (x = 32; x >= 0; x--)
            {
                int z = 0;
                int[] Arreglo_1 = new int[Arreglo.Length];///Nuevo arreglo donde almacenara los nuevos numeros
                for (y = 0; y < Arreglo.Length; y++)
                {
                    bool m = Arreglo[y] << x >= 0; ///Pregunta si es mayor a 0 y sino lo movera de lugar 
                    if (x == 0 ? !m : m) ///Para entrar a este if tiene que x es igual a 0
                    {
                        Arreglo_1[z] = Arreglo[y];///Se mueven los arreglos
                        z++;
                    }
                    else///Condicion si no entra al if de arriba 
                    {
                        Arreglo[y - z] = Arreglo[y];
                    }
                }
                for (y = z; y < Arreglo_1.Length; y++)///Este for estara moviendo los numeros
                {
                    Arreglo_1[y] = Arreglo[y - z];
                }
                Arreglo = Arreglo_1;
            }
            Desplegar(Arreglo);///Desplegamos ya los numeros ordenados 
        }
        public void Desplegar(int[] Arreglo)///Metodo para desplegar los numeros 
        {
            for (int x = 0; x < Arreglo.Length; x++)
            {
                Console.Write(Arreglo[x] + ", ");
            }
            Console.ReadKey();
        }
        public void Imprimir() ///Metodo donde se va a imprimir los numeros ordenados originalmente puesto en los arreglos
        {                      /// y otra ya ordenados de menor a mayor
            Console.WriteLine("Arreglo 1 \nOrdenados aleatoriamente.."); ///Desplegamos los numeros aleatoriamente
            Desplegar(Arreglo_1);
            Console.WriteLine("\nOrdenados de Menor a Mayor..."); ///Desplegamos los numeros ordenados 
            Operacion(Arreglo_1);

            Console.WriteLine("\n\nArreglo 2 \nOrdenados aleatoriamente.."); /// Y es lo mismo con los siguientes arreglos...
            Desplegar(Arreglo_2);
            Console.WriteLine("\nOrdenados de Menor a Mayor...");
            Operacion(Arreglo_2);

            Console.WriteLine("\n\nArreglo 3 \nOrdenados aleatoriamente..");
            Desplegar(Arreglo_3);
            Console.WriteLine("\nOrdenados de Menor a Mayor...");
            Operacion(Arreglo_3);

            Console.WriteLine("\n\nArreglo 4 \nOrdenados aleatoriamente..");
            Desplegar(Arreglo_4);
            Console.WriteLine("\nOrdenados de Menor a Mayor...");
            Operacion(Arreglo_4);

            Console.WriteLine("\n\nArreglo 5 \nOrdenados aleatoriamente..");
            Desplegar(Arreglo_5);
            Console.WriteLine("\nOrdenados de Menor a Mayor...");
            Operacion(Arreglo_5);

            
        }
        
        
    }
}
