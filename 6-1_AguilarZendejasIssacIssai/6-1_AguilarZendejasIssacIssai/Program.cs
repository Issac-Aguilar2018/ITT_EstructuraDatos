using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            Busqueda busqueda = new Busqueda(); ///Objeto busqueda 
            busqueda.Menu(); ///Llamamos al Menu con los codigos
            Console.ReadKey();
        }
    }
    public class Busqueda
    {
        public void Menu() ///Metodo menu donde estara los 2 codigos de busqueda secuencial
        {
            int menu = 0;
            do
            {
                Console.Clear();
                Console.Write("1.- Codigo 1 " +
                    "\n2.- Codigo 2 " +
                    "\n3.- Salir " +
                    "\n\nEliga la opcion: ");
                menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1: ///Caso 1 donde estara el primer ejemplo 
                        Console.Clear();
                        Codigo_1();
                        Console.ReadKey();
                        break;
                    case 2: ///Caso 2 donde estara el segundo ejemplo
                        Console.Clear();
                        Codigo_2();
                        Console.ReadKey();
                        break;
                    case 3: ///Caso 3 para salir del programa 
                        Console.Write("Presione <Enter> para salir...");
                        Console.ReadKey();
                        break;
                }
            } while (menu != 3);
        }
        public void Codigo_1()///Metodo del codigo 1 
        {
            try ///Un try por si a una falla del programa 
            { 
                int Numero, yx = 0, pos = 0;///Variables auxiliares 
                bool Encontro = false; ///Un variable booleana 
                Console.Write("Ingrese el tamaño del arreglo: "); ///Al usuario le pedimos el tamaño del arreglo 
                int x = Convert.ToInt16(Console.ReadLine());
                int[] Arreglo = new int[x]; ///Arreglo 
                for (int i = 0; i < x; i++) ///For donde estara el usuario poniendo los numeros depediendo del tamaño del arreglo 
                {
                    Console.Write("Numero {0}: ", i + 1, i);
                    Arreglo[i] = Convert.ToInt16(Console.ReadLine());
                }
                Console.Write("\nQue numero estas buscando: ");///BUsqueda de un numero del arreglo 
                Numero = int.Parse(Console.ReadLine());
                while (!(Encontro) && yx < 10) 
                {
                    if (Numero == Arreglo[yx]) ///Aqui en el if buscara en el arreglo si esta ese numero que busca el usuario 
                    {
                        Encontro = true; ///Si lo encontro sera verdad de que esta ese numero 
                        pos = yx; ///Aqui igualamos para sacar la posicion 
                    }
                    yx = yx + 1;///Posicion del numero 
                }
                if (Encontro) ///Si lo encontro es verdad entra al if
                    Console.Write("EL dato se encuentra y esta en la posicion: " + (pos + 1));
                Console.ReadKey();
            }
            catch (Exception) ///Excepcion por si no se encuentra el numero 
            {
                Console.WriteLine("Numero no encontrado... ");
            }
        }
        public void Codigo_2()///Codigo 2
        {
            int[] Arreglo = { 10, 15, 12, 5, 6 }; ///Arreglo con numeros 
            int  Cantidad = 5; ///La cantidad de numeros que hay en el arreglo 
            for (int i = 0; i < Cantidad; i++) ///For donde mostrara los numeros del arreglo 
            {
                Console.Write("{0} ", Arreglo[i]);
            }
            Console.Clear();///LImpiamos la pantalla 
            Console.Write("Que numero estas buscando: ");///Pedimos que numero busca
            int x = Convert.ToInt16(Console.ReadLine());
            for(int j = 0; j < Cantidad; j++) ///For donde buscara el numero 
            {
                if (Arreglo[j] == x)///Un if con la condicion de que si el numero introducido por el usuario se encuentra en el arreglo y en que posicion se encuentra 
                    Console.Write("{0} encontrado en la posicion {1} ", x, j + 1);
            }
            Console.ReadKey();
        }
    }
}
