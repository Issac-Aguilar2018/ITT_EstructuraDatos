using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Menu_1();
            Console.ReadKey();
        }
    }
    public class Menu
    {
        public void Menu_1() ///Metodo menu donde estara los 2 codigos de busqueda binaria 
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
                        Codigo codigo = new Codigo();
                        codigo.Cargar();
                        codigo.Imprimir();
                        Console.Write("\n\nElemento a buscar: ");
                        int num = int.Parse(Console.ReadLine());
                        codigo.Busqueda(num);
                        Console.ReadKey();
                        break;
                    case 2: ///Caso 2 donde estara el segundo ejemplo
                        Console.Clear();
                        Codigo_2 codigo_2 = new Codigo_2();
                        codigo_2.Busqueda_2();
                        Console.ReadKey();
                        break;
                    case 3: ///Caso 3 para salir del programa 
                        Console.Write("Presione <Enter> para salir...");
                        Console.ReadKey();
                        break;
                }
            } while (menu != 3);
        }
    }
    class Codigo
    {
        int[] Arreglo; ///Un Arreglo donde se podra usar en cualquiera de los metodos 
        public void Cargar() ///Metodo para estar almacenando los numeros
        {
            Console.Write("Ingrese el tamaño del arreglo: "); ///Tamaño del arreglo 
            int x = Convert.ToInt16(Console.ReadLine());
            Arreglo = new int[x];
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.Write("Ingrese los numeros " + (i + 1) + ": "); ///Aqui en el for estara pidiendo los numeros 
                int y = Convert.ToInt16(Console.ReadLine());
                Arreglo[i] = y;
            }
        }
        public void Busqueda(int Num) ///Metodo que busca el numero 
        {
            int x = 0, y = 9, z = 0; ///Variable auxiliares 
            bool TF = false;      ///Un booleano cuando no se encuentre el numero 
            while (x <= y && TF == false)
            {
                z = (x + y) / 2; ///Saber la posicion del numero encontrado en el arreglo 
                if (Arreglo[z] == Num) ///Si el valor es igual a la mitad que seria el valor buscado 
                    TF = true;
                if (Arreglo[z] > Num)  ///El valor deseado es mayor 
                    y = z - 1;
                else                   ///El valor deseado es menor 
                    x = z + 1;
            }
            if (TF == false)///Si el valor no se encontro ni entro en los if entonces es falso 
            { Console.Write("\nEL dato {0} no se encuentra", Num); }
            else///Si el valor se encontro en el arreglo entra al if 
            { Console.Write("\nEl dato {0} se encuentra y esta en la posicion {1}", Num, z + 1); }
        }
        public void Imprimir() ///Metodo que imprime el arreglo 
        {
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.Write(Arreglo[i] + "  ");
            }
        }
    }
    public class Codigo_2
    {
        public void Busqueda_2()
        {
            int[] Arreglo = { 10, 15, 12, 5, 6, 7, 3, 1, 21 }; ///Arreglo con numeros 
            Array.Sort(Arreglo); ///Ordena los numeros, es mas facil ordenar los numeros con Array sort
            for (int i = 0; i < Arreglo.Length; i++) ///For donde mostrara los numeros del arreglo 
            {
                Console.Write("{0} ", Arreglo[i]);
            }
            Console.Write("\nQue nuemro desea buscar: "); ///Preguntamos al usuario que numero desea buscar
            int x = Convert.ToInt16(Console.ReadLine());
            int U = Arreglo.Length, P = 0, Central = (P + U) / 2; ///Variables auxiliares
            while (P <= U && Arreglo[Central] != x) ///Condicion
            {
                if (x < Arreglo[Central]) ///El valor deseado es mayor 
                {
                    U = Central - 1;
                }
                else                     ///El valor deseado es menor 
                {
                    P = Central + 1;
                }
                Central = (U + P) / 2;  ///Condicion para sacar la posicion donde se encuentra el numero 
            }
            if (x == Arreglo[Central])  ///Cuando el valor deseado y si se encuentra en el arreglo va a entrar al primer if 
            {
                Console.Write("\nEl dato {0} se encuentra y esta en la posicion {1}", x,Central +1); 
            }
            else                       ///Sino al else 
            {
                Console.Write("\nEl dato no se encuentra...");
            }
        }
    }
}
        

    


