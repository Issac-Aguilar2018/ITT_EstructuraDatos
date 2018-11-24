using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU4_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            int Menu = 0;
            do
            {
                Console.Clear();
                Console.Write("" +
                    "\n1.-Ejercicio 1" +
                    "\n2.-Ejercicio 2" +
                    "\n3.-Salir" +
                    "\n\nElige una opcion: ");
                Menu = Convert.ToInt16(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        Console.Clear();
                        Imprimir imprimir = new Imprimir();
                        imprimir.Desplegar();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Arbolbinario arbol = new Arbolbinario();
                        arbol.Menu();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Presione <Enter> para salir...");
                        Console.ReadKey();
                        break;
                }
            } while (Menu != 3);
            Console.ReadKey();
        }
    }
    public class Arbolbinario
    {
        public void Imprimir_1()
        {
            ArbolBinario arbol = new ArbolBinario();

            arbol.z = new Nodo("A");
            arbol.z.Izquierda = new Nodo("B");
            arbol.z.Medio = new Nodo("C");
            arbol.z.Derecha = new Nodo("D");
            arbol.z.Izquierda.Izquierda = new Nodo("E");
            arbol.z.Izquierda.Medio = new Nodo("F");
            arbol.z.Izquierda.Derecha = new Nodo("G");
            arbol.z.Derecha.Izquierda = new Nodo("H");
            arbol.z.Derecha.Medio = new Nodo("I");
            arbol.z.Derecha.Derecha = new Nodo("J");
            arbol.z.Izquierda.Izquierda.Izquierda = new Nodo("K");
            arbol.z.Izquierda.Izquierda.Medio = new Nodo("L");
            arbol.z.Izquierda.Izquierda.Derecha = new Nodo("M");
            arbol.z.Izquierda.Derecha.Medio = new Nodo("N");
            arbol.z.Derecha.Izquierda.Medio = new Nodo("O");
            arbol.z.Derecha.Derecha.Izquierda = new Nodo("P");
            arbol.z.Derecha.Derecha.Derecha = new Nodo("Q");
            arbol.z.Izquierda.Derecha.Medio.Izquierda = new Nodo("R");
            arbol.z.Izquierda.Derecha.Medio.Derecha = new Nodo("S");

            Console.WriteLine("Arbol A");
            Console.WriteLine("Preorden");
            arbol.PrintPreorder();
            Console.WriteLine();
            Console.WriteLine("\nPosorden ");
            arbol.PrintPostorder();
            Console.WriteLine();
            Console.ReadKey();
        }
        public void Imprimir()
        {
            ArbolBinario arbol = new ArbolBinario();

            arbol.z = new Nodo("A");
            arbol.z.Izquierda = new Nodo("B");
            arbol.z.Derecha = new Nodo("E");
            arbol.z.Izquierda.Izquierda = new Nodo("C");
            arbol.z.Izquierda.Derecha = new Nodo("D");
            arbol.z.Derecha.Derecha = new Nodo("F");
            arbol.z.Derecha.Derecha.Izquierda = new Nodo("G");
            arbol.z.Derecha.Derecha.Derecha = new Nodo("H");

            Console.WriteLine("\nArbol B");
            Console.WriteLine("Preorden ");
            arbol.PrintPreorder();
            Console.WriteLine();
            Console.WriteLine("\nPosorden ");
            arbol.PrintPostorder();
            Console.WriteLine();
            Console.ReadKey();
        }
        public class Nodo
        {
            public string x;
            public Nodo Izquierda, Derecha, Medio;

            public Nodo(string y)
            {
                x = y;
                Izquierda = Derecha = Medio = null;
            }
        }

        public class ArbolBinario
        {
            public Nodo z;
            public ArbolBinario()
            {
                z = null;
            }
            public void PostOrden(Nodo node)
            {
                if (node == null)
                    return;

                PostOrden(node.Izquierda);

                PostOrden(node.Medio);


                PostOrden(node.Derecha);


                Console.Write(node.x + " ");
            }
            public void PreOrden(Nodo node)
            {
                if (node == null)
                    return;

                Console.Write(node.x + " ");

                PreOrden(node.Izquierda);

                PreOrden(node.Medio);

                PreOrden(node.Derecha);
            }
            public void PrintPostorder() { PostOrden(z); }
            public void PrintPreorder() { PreOrden(z); }
        }
        public void Menu()
        {
            int Menu = 0;
            do
            {
                Console.Clear();
                Console.Write("" +
                    "\n1.-Arbol A" +
                    "\n2.-Arbol B" +
                    "\n3.-Salir" +
                    "\n\nElige una opcion: ");
                Menu = Convert.ToInt16(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        Console.Clear();
                        Imprimir_1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Imprimir();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Presione <Enter> para salir...");
                        Console.ReadKey();
                        break;
                }
            } while (Menu != 3);
        }
    }
    public class Grafo
    {
        public int Vert { get; set; }
        List<int>[] list;
        public Grafo(int valor)
        {
            Vert = valor;
            list = new List<int>[valor];
            for (int i = 0; i < valor; i++)
            {
                list[i] = new List<int>();
            }
        }
        public void Guardar(int Ind, int Val)
        {
            list[Ind].Add(Val);
        }
        public void EU(int valor, int x)
        {
            List<string> Ciudad = new List<string>();
            if (x == 1 || x == 2)
            {
                Ciudad.Add("Boston");
                Ciudad.Add("Chicago");
                Ciudad.Add("Denver");
                Ciudad.Add("LA");
                Ciudad.Add("New York");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Miami");
                Ciudad.Add("Atlanta");
            }
            if (x == 3)
            {
                Ciudad.Add("Atlanta");
                Ciudad.Add("Chicago");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");
                Ciudad.Add("Denver");
                Ciudad.Add("LA");
                Ciudad.Add("New York");
                Ciudad.Add("Miami");
            }
            if (x == 4)
            {
                Ciudad.Add("Denver");
                Ciudad.Add("Chicago");
                Ciudad.Add("New York");
                Ciudad.Add("Atlanta");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");
                Ciudad.Add("LA");
                Ciudad.Add("Miami");
            }

            bool[] Visitar = new bool[Vert];
            Stack<int> Pila = new Stack<int>();
            Visitar[valor] = true;
            Pila.Push(valor);
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("El camino para llegar al ultimo elmento es: ");
            while (Pila.Count != 0)
            {
                valor = Pila.Pop();
                Console.Write("{0}-> ", Ciudad[valor]);
                foreach (int i in list[valor])
                {
                    if (!Visitar[i])
                    {
                        Visitar[i] = true;
                        Pila.Push(i);
                    }
                }
            }
            Console.Write("Final de la ruta...");
        }
    }
    public class Imprimir
    {
        public void Desplegar()
        {
            int x = 0;
            do
            {
                Console.Clear();
                Console.Write("1)Boston-Los Angeles\n2)New York-San Francisco\n3)Atlanta-San Francisco\n4)Denver-New York\n5)Salir\n\nEliga la opcion: ");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Grafo Ruta = new Grafo(5);
                        Ruta.Guardar(0, 1);
                        Ruta.Guardar(1, 2);
                        Ruta.Guardar(2, 3);
                        Ruta.EU(0, 1);
                        Console.WriteLine("El recorrido es de 2,602 millas");
                        Console.WriteLine("\nPresione para continuar...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Grafo Ruta_1 = new Grafo(7);
                        Ruta_1.Guardar(0, 1);
                        Ruta_1.Guardar(1, 2);
                        Ruta_1.Guardar(2, 3);
                        Ruta_1.Guardar(4, 5);
                        Ruta_1.EU(4, 2);
                        Console.WriteLine("El recorrido es de 2,587 millas");
                        Console.WriteLine("\nPresione para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Grafo Ruta_2 = new Grafo(4);
                        Ruta_2.Guardar(0, 1);
                        Ruta_2.Guardar(1, 2);
                        Ruta_2.EU(0, 3);
                        Console.WriteLine("El recorrido es de 2,461 millas");
                        Console.WriteLine("\nPresione para continuar...");
                        Console.ReadKey();
                        break;

                    case 4:
                        Grafo Ruta_3 = new Grafo(4);
                        Ruta_3.Guardar(0, 1);
                        Ruta_3.Guardar(1, 2);
                        Ruta_3.EU(0, 4);
                        Console.WriteLine("El recorrido es de 1,630 millas");
                        Console.WriteLine("\nPresione para continuar...");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Presione <Enter> para salir...");
                        Console.ReadKey();
                        break;
                }
            } while (x != 5);
        }   
    }
}
            
            
    

            
   

