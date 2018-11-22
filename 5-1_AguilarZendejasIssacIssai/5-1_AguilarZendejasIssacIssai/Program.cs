using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args) 
        {
            Bubble bubble = new Bubble();///Objeto bubble
            bubble.Operacion();///Llama al metodo operacion de la clase bubble
            Console.ReadKey();
        }
    }
    public class Bubble
    {
        public void Operacion()
        {
            int x = 0;//Variable auxiliar 
            Console.Write("Ingrese la cantidad de numeros que va a querer ingresar: ");
            int y = int.Parse(Console.ReadLine());
            int[] Arreglo = new int[y]; ///Un arreglo que va a definir el tamaño por el usuario
            for (int i = 0; i < y; i++) ///Ciclo for donde estara pidiendo los numeros que estara ingresando el usuario
            {
                Console.Write("Numero: ");
                Arreglo[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < y; j++)//Metodo burbuja
            {
                for (int k = 0; k < y - 1; k++)
                {
                    if (Arreglo[j] < Arreglo[k])/// Un if que definira si se ordena de mayor o menor o de menor a mayor 
                    {
                        x = Arreglo[j];//Variable de apoyo
                        Arreglo[j] = Arreglo[k];///Los valores de j y k se cambian 
                        Arreglo[k] = x;
                    }
                }
            }
            for (int i = 0; i < y; i++)
            {
                Console.Write("\nOrdenados: {0} " , Arreglo[i]);///Imprime el resultado ya ordenados
            }
            Console.ReadKey();
        }
    }
}
