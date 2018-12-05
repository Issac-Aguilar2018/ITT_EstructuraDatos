using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_U5_AguilarIssac
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Codigos();
            Console.ReadKey();
        }
    }
    public class Bubble
    {
        public void Operacion()
        {
            int x = 0, a = 0;//Variable auxiliar 
            Console.Write("Ingrese la cantidad de numeros que va a querer ingresar: ");
            int y = int.Parse(Console.ReadLine());
            int[] Arreglo = new int[y]; ///Un arreglo que va a definir el tamaño por el usuario
            for (int i = 0; i < y; i++) ///Ciclo for donde estara pidiendo los numeros que estara ingresando el usuario
            {
                Console.Write("Numero del 0 al 2: ");
                a = int.Parse(Console.ReadLine());
                while(a > 2 || a < 0)///Condicion para que solo introduzca numeros del 0 al 2
                {
                    Console.WriteLine("Numero incorrecto...");
                    Console.Clear();
                    Console.Write("Ingrese numero del 0 al 2: ");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                Arreglo[i] = a;
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
                Console.Write("\nOrdenados: {0} ", Arreglo[i]);///Imprime el resultado ya ordenados
            }
            Console.ReadKey();
        }
    }
    public class Radix
    {
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
        public void Imprimir() ///Metodo donde se imprimira ordenadamente los numeros y los numeros se generaron con el random
        {                     
            int x = 0;///Variable auxiliar
            int[] Arreglo = new int[80]; ///Arreglo con un tamaño de 80 numeros
            Random random = new Random();///Creamos el random
            for (int i = 0; i < 80; i++)
            {
                x = random.Next(0, 100);///El random ira del 1 al 99
                if (Arreglo.Contains(x)) ///Condicion de que si un numero se repite se va a restar -1 para que asi evite que se repiten 
                {
                    i = i - 1;
                }
                else ///Si el numero no se ha repetido pasa automatico 
                {
                    Arreglo[i] = x;
                }
            }
            Console.WriteLine("Arreglo 1 \nOrdenados aleatoriamente.."); ///Desplegamos los numeros aleatoriamente
            Desplegar(Arreglo);
            Console.WriteLine("\nOrdenados de Menor a Mayor..."); ///Desplegamos los numeros ordenados 
            Operacion(Arreglo);
        }
    }
    public class ShellSort
    {
        int[] Arreglo; /// Definimos el arreglo 
        public void Operacion() ///Metodo operacion donde se pedira el tamaño del arreglo 
        {
            Console.Write("Ingrese el tamaño del arreglo: ");
            int x = Convert.ToInt16(Console.ReadLine());
            Arreglo = new int[x];
            for (int f = 0; f < Arreglo.Length; f++)
            {
                Console.Write("Ingrese elemento: "); ///Aqui el usuario ingresara los numeros dependiendo del tamaño del arreglo 
                int y = Convert.ToInt16(Console.ReadLine());
                Arreglo[f] = y;
            }
        }
        public void Shell()///Metodo shell 
        {
            int x = 0,y = 0,z = 0,a = 0; ///Variables auxiliares
            x = Arreglo.Length / 2;
            while (x > 0) ///Los while es para estar comparando
            {
                y = 1;
                while (y != 0)
                {
                    y = 0;
                    a = 1;
                    while (a <= (Arreglo.Length - x))
                    {
                        if (Arreglo[a - 1] > Arreglo[(a - 1) + x])///Dentro del if estara la condicion para el ordenamiento de numeros
                        {
                            z = Arreglo[(a - 1) + x];             
                            Arreglo[(a - 1) + x] = Arreglo[a - 1];
                            Arreglo[(a - 1)] = z;
                            y = 1;
                        }
                        a++;///Aumento 
                    }
                }
                x = x / 2;
            }
        }
        public void Imprimir() ///Metodo donde imprimira los numeros ordenados
        {
            Console.WriteLine("Ordenados...");
            for (int f = 0; f < Arreglo.Length; f++)
            {
                Console.Write(Arreglo[f] + "  ");
            }
            Console.ReadKey();
        }
    }
    public class Quicksort
    {
        int[] Arreglo_int; ///Definimos 2 arreglos de tipo int y char 
        char[] Arreglo_char;
        public void Ordenamiento() ///Metodo ordenamiento 
        {
            int x = 0;///Variable auxiliar
            Arreglo_int = new int[180]; ///Aqui definimos el tamaño de los 2 arreglos 
            Arreglo_char = new char[180];
            String Letras = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. Duis ac massa est.";
            ///En un string ponemos la frase completa 
            foreach (char y in Letras.ToUpper())///Aqui en el foreach pasara por letra por letra y lo convertira en mayuscula 
            {
                Arreglo_char[x] = y;
                x++;
            }
            for (int i = 0; i < Arreglo_char.Length; i++)///En este for pasara por todas las letras que se guardaron en el arreglo char 
            {
                switch (Arreglo_char[i])
                {
                    case 'A':
                        Arreglo_int[i] = 1;
                        break;
                    case 'B':
                        Arreglo_int[i] = 2;
                        break;
                    case 'C':
                        Arreglo_int[i] = 3;
                        break;
                    case 'D':
                        Arreglo_int[i] = 4;
                        break;
                    case 'E':
                        Arreglo_int[i] = 5;
                        break;
                    case 'F':
                        Arreglo_int[i] = 6;
                        break;
                    case 'G':
                        Arreglo_int[i] = 7;
                        break;
                    case 'H':
                        Arreglo_int[i] = 8;
                        break;
                    case 'I':
                        Arreglo_int[i] = 9;
                        break;
                    case 'J':
                        Arreglo_int[i] = 10;
                        break;
                    case 'K':
                        Arreglo_int[i] = 11;
                        break;
                    case 'L':
                        Arreglo_int[i] = 12;
                        break;
                    case 'M':
                        Arreglo_int[i] = 13;
                        break;
                    case 'N':
                        Arreglo_int[i] = 14;
                        break;
                    case 'O':
                        Arreglo_int[i] = 15;
                        break;
                    case 'P':
                        Arreglo_int[i] = 16;
                        break;
                    case 'Q':
                        Arreglo_int[i] = 17;
                        break;
                    case 'R':
                        Arreglo_int[i] = 18;
                        break;
                    case 'S':
                        Arreglo_int[i] = 19;
                        break;
                    case 'T':
                        Arreglo_int[i] = 20;
                        break;
                    case 'U':
                        Arreglo_int[i] = 21;
                        break;
                    case 'V':
                        Arreglo_int[i] = 22;
                        break;
                    case 'W':
                        Arreglo_int[i] = 23;
                        break;
                    case 'X':
                        Arreglo_int[i] = 24;
                        break;
                    case 'Y':
                        Arreglo_int[i] = 25;
                        break;
                    case 'Z':
                        Arreglo_int[i] = 26;
                        break;

                } ///Este switch gigante estara poniendo los valores a las letras correspondiente al abecedario
            }
        }
        public void Operacion(int[] Arreglo, int Inicio, int Fin)///Metodo Operacion
        {
            int x = Inicio, y = Fin, Central = (x + y) / 2; ///Declaramos varias variables 
            int z = Arreglo[Central]; ///Convertimos el arreglo double a int, para que asi no tengamos problemas de conversion
            do
            {
                while (Arreglo[x] < z) x++; ///Condicion cuando x sea menor que z
                while (Arreglo[y] > z) y--; ///Condicion cuando y sea mayor que z
                if (x <= y)
                {
                    int a = Arreglo[(Convert.ToInt32(x))];
                    Arreglo[x] = Arreglo[Convert.ToInt32(y)]; ///Aqui intercambiamos lo de "x" a "y"
                    Arreglo[y] = a;                           ///y de "y" a "x"
                    x++; ///Aumentar
                    y--; ///Disminuir
                }
            } while (x <= y);
            if (Inicio < y) Operacion(Arreglo, Inicio, y); ///Recursividad donde ponemos las condiciones
            if (x < Fin) Operacion(Arreglo, x, Fin);       ///Cuando y es mayor que inicio y cuando x es mayor que fin
        }
        public void Imprimir()
        {
            Ordenamiento(); ///LLamamos al metodos ordenamiento 
            Operacion(Arreglo_int, 0, Arreglo_int.Length - 1); ///LLamamos al metodo operacion
            Console.WriteLine("Ordenados Numero");
            string Abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; 
            foreach (var i in Arreglo_int)///Este foreach estara imprimiendo las numeros ya ordenadas 
            {
                if (i != 0) ///Como la oracion tiene puntos, comas y espacio lo marcara como 0, entonces con este if los elimina 
                {
                    Console.Write("  " + i);
                }
            }
            Console.WriteLine("\n\nOrdenados letras");
            foreach (var i in Arreglo_int) ///Tambien este foreach imprime las letras 
            {
                if (i != 0) ///E igual con el anterior se elimina los 0 
                {
                    Console.Write("  " + Abecedario[i -1]);
                }
            }
            Console.ReadKey();
        }
    }
    public class Menu ///Una clase entera para el Menu, donde crearemos los objetos de cada clase para asi llamar a todos los metodos
    {
        public void Codigos()
        {
            Bubble bubble = new Bubble();
            Radix radix = new Radix();
            ShellSort shellSort = new ShellSort();
            Quicksort quicksort = new Quicksort();
            int menu = 0;
            do
            {
                Console.Clear();
                Console.Write("" +
                    "\n1.- Bubble " +
                    "\n2.- Radix " +
                    "\n3.- Shell " +
                    "\n4.- Quick " +
                    "\n5.- Salir " +
                    "\n\nEliga la opcion: ");
                menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        bubble.Operacion();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        radix.Imprimir();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        shellSort.Operacion();
                        shellSort.Shell();
                        shellSort.Imprimir();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        quicksort.Imprimir();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Presione <Enter> para salir... ");
                        break;
                }
            } while (menu != 5);
        }
    }
}
