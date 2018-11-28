using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metodo de Quick Sort\n"); ///En el Main creamos al objeto quicksort que nos ayudara a llamar a los metodos de la clase Quick sort
            Quicksort quicksort = new Quicksort();
            quicksort.Sort();
            Console.ReadKey();
        }
    }
    public class Quicksort
    {
        double[] Vector = new double[] { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 }; /// 4 Arreglos con diferentes numeros 
        double[] Vector_1 = new double[] { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12,0,10 };
        double[] Vector_2 = new double[] { 3, 7, 15, 1.333, 155, 100, 15, 1.44, 5, 2,3,2 };
        double[] Vector_3 = new double[] { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };
        public void Sort() ///Metodo sort lo que hara es desplegar los numeros de los arreglos y llamara 
        {                  ///al metodo Operacion donde se hara todo el procedimiento y por ultimo, desplegara ya ordenados
            for (int i = 0; i < Vector.Length; i++) ////Vector                   
            {                                      ///For donde despliega el Vector
                Console.Write(Vector[i] + ", ");
            }
            Operacion(Vector, 0, Vector.Length - 1); ///Metodo donde se hara el procedimiento 
            Desplegar();///Metodo Desplegar
            Console.ReadKey();
            Console.ReadLine();

            for (int i = 0; i < Vector_1.Length; i++) ///Vector 1
                                                      ///Los puse 3 veces para que desplegara los 3 vectores restantes...
            {                                         ///y es el mismo procedimiento de cada uno 
                Console.Write(Vector_1[i] + ", ");    
            }
            Operacion(Vector_1, 0, Vector_1.Length - 1);
            Desplegar_1();
            Console.ReadKey();
            Console.ReadLine();

            for (int i = 0; i < Vector_2.Length; i++) ///Vector 2
            {
                Console.Write(Vector_2[i] + ", ");
            }
            Operacion(Vector_2, 0, Vector_2.Length - 1);
            Desplegar_2();
            Console.ReadKey();
            Console.ReadLine();

            for (int i = 0; i < Vector_3.Length; i++) ///Vector 3
            {
                Console.Write(Vector_3[i] + ", "); 
            }
            Operacion(Vector_3, 0, Vector_3.Length - 1);
            Desplegar_3();
            Console.ReadKey();
            Console.ReadLine();
        }
        public void Operacion(double[] Arreglo, double Inicio, double Fin)///Metodo Operacion
        {
            double x = Inicio, y = Fin, Central = (x + y) / 2; ///Declaramos varias variables 
            double z = Arreglo[Convert.ToInt32(Central)]; ///Convertimos el arreglo double a int, para que asi no tengamos problemas de conversion
            do
            {
                while (Arreglo[Convert.ToInt32(x)] < z) x++; ///Condicion cuando x sea menor que z
                while (Arreglo[Convert.ToInt32(y)] > z) y--; ///Condicion cuando y sea mayor que z
                if (x <= y)
                {
                    double a = Arreglo[(Convert.ToInt32(x))];
                    Arreglo[Convert.ToInt32(x)] = Arreglo[Convert.ToInt32(y)]; ///Aqui intercambiamos lo de "x" a "y"
                    Arreglo[Convert.ToInt32(y)] = a;                           ///y de "y" a "x"
                    x++; ///Aumentar
                    y--; ///Disminuir
                }
            } while (x <= y);                             
            if (Inicio < y) Operacion(Arreglo, Inicio, y); ///Recursividad donde ponemos las condiciones
            if (x < Fin) Operacion(Arreglo, x, Fin);       ///Cuando y es mayor que inicio y cuando x es mayor que fin
        }
        public void Desplegar()///Metodo desplegar
        {
            Console.WriteLine("\n\nOrdenados de Menor a Mayor.."); ///Ya aqui desplegamos los numeros de menor a mayor 
            for (int i = 0; i < Vector.Length; i++)                /// y sera el mismo procedimiento de desplegar con los otros vectores
            {
                Console.Write("{0} ", Vector[i]);
            }
            Console.ReadLine();          
        }
        public void Desplegar_1()
        {
            Console.WriteLine("\n\nOrdenados de Menor a Mayor..");
            for (int i = 0; i < Vector_1.Length; i++)
            {
                Console.Write("{0} ", Vector_1[i]);
            }
            Console.ReadLine();
        }
        public void Desplegar_2()
        {
            Console.WriteLine("\n\nOrdenados de Menor a Mayor..");
            for (int i = 0; i < Vector_2.Length; i++)
            {
                Console.Write("{0} ", Vector_2[i]);
            }
            Console.ReadLine();
        }
        public void Desplegar_3()
        {
            Console.WriteLine("\n\nOrdenados de Menor a Mayor..");
            for (int i = 0; i < Vector_3.Length; i++)
            {
                Console.Write("{0} ", Vector_3[i]);
            }
            Console.ReadLine();
        }
    }
}

