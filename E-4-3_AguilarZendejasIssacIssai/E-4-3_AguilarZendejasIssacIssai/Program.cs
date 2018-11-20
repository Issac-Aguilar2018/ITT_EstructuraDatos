using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_3_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args) /// Aqui tienen que agregar todos los caminos que se muestra en la imagen para que todo este bien a la hora de checar la trayectoria 
        {
            Grafos grafos = new Grafos();
            grafos.Menu();
            Console.ReadKey();
        }

        public class Grafos
        {
            public string linea; /// 2 Variables que nos ayudara guardar los datos correspondietes 
            public int tamaño = 0;
            public int[,] Matrix = new int[7, 7]; ///Matriz de 7 x 7 donde se guardara la informacion
            public void AgregarArco() ///Primer metodo donde crearemos los Nodos
            {
                Console.Clear();
                Console.WriteLine("Usted Selecciono: Agregar un Arco");
                Console.WriteLine();
                for (int i = 0; i < 1; i++)  ///El primer for donde solamente se va agregar 1 nodo
                {
                    for (int j = 0; j < 1; j++) /// E igual este for donde el usuario agregar el Nodo
                    {
                        Console.Write("Nodo de Inicio: "); ///El usuario pone el Nodo Inicio y el final 
                        linea = Console.ReadLine();
                        int fila = int.Parse(linea); ///Primero lo agregamos de manera string y despues lo convertimos a int para que no haya problema 
                        Console.Write("Nodo de Destino: ");
                        linea = Console.ReadLine();
                        int columna = int.Parse(linea);
                        int h = 1;
                        if (fila <= tamaño && columna <= tamaño) ///El for donde indica que cumpla los requesitos de la matriz
                        {
                            if (h > 0) ///Siempre tiene que ser mayor de cero 
                            {
                                Matrix[fila - 1, columna - 1] = h;///Lo guardamos en la matriz 
                                Console.WriteLine();
                                Console.WriteLine("¡Arco Agregado! ");
                                Console.WriteLine();
                                Console.WriteLine(" (" + fila + ") ----> (" + columna + ")");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            public void MostrarGrafo() ///Aqui se muestran todos los nodos que se hicieron 
            {
                Console.WriteLine("\n|1 = A|\n|2 = B|\n|3 = C|\n|4 = D|\n|5 = E|\n|6 = F|\n|7 = G|  "); ///Esto es para que se den cuenta que numeros corresponde a la letra de la imagen 
                for (int i = 0; i < tamaño; i++) ///Entrar al primero que corresponde al tamaño de la matrix 
                {
                    for (int j = 0; j < tamaño; j++) /// E igual aqui hace lo mismo
                    {
                        if (Matrix[i, j] > 0) /// Siempre tiene que ser mayor que 0 
                        {
                            Console.WriteLine("\n (" + (i + 1) + ") ----> (" + (j + 1) + ")"); ///Imprime todos los grafos que hicieron 
                        }
                    }
                }
                Console.ReadKey();
            }
            public void Trayectoria()
            {
                Console.Clear();
                Console.WriteLine("\n|1 = A|\n|2 = B|\n|3 = C|\n|4 = D|\n|5 = E|\n|6 = F|\n|7 = G|  ");
                Console.WriteLine("\nSe muestra la Matriz del Grafo: "); ///Aqui se muestra una tabla de 7 x 7 donde indica que numeros se cruzan entre si
                Console.WriteLine();                                     /// 1 Significa verdadero y 0 significa Falso
                for (int i = 0; i < tamaño; i++)                         ///   A B C D E F G
                {                                                        /// A
                    for (int j = 0; j < tamaño; j++)                     /// B... Asi es la tabla 
                    {
                        Console.Write(this.Matrix[i, j] + " "); ///Imprime la tabla 
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
                Console.ReadKey();
                Console.WriteLine("Trayectoria \nA => B => C => G => F => D => E"); ///No supe como imprimir las diferentes trayectorias 
            }
            public void Menu()
            {
                do
                {
                    Console.WriteLine("El Numero de nodos debe ser mayor a 1");
                    Console.Write("\nIngresa el Numero de nodos del grafo: ");
                    linea = Console.ReadLine();
                    tamaño = int.Parse(linea);
                    Console.Clear();
                } while (tamaño <= 1); ///Pedimos al usuario que ingrese el tamaño de la matriz, aqui el usuario tiene que ingresar solamente numeros y no letras 
                Console.Clear();
                Console.Write("¡Grafo Agregado!");
                Console.WriteLine("Cada Nodo fue Nombrado con la Sucesion de 1 a " + tamaño);
                Console.WriteLine();
                int[,] Matrix = new int[tamaño, tamaño];///Tamaño de la matriz
                int Menu;
                do
                {
                    Console.Clear();
                    Console.Write("" +
                        "1.- Agregar un Arco " +
                        "\n2.- Mostrar Grafo" +
                        "\n3.- Trayectorias" +
                        "\n4.- Salir" +
                        "\n\nEliga una opcion: ");
                    Menu = Convert.ToInt16(Console.ReadLine());
                    switch (Menu) ///Menu donde estan todos los metodos 
                    {
                        case 1:
                            AgregarArco();
                            Console.ReadKey();
                            break;
                        case 2:
                            MostrarGrafo();
                            Console.ReadKey();
                            break;
                        case 3:
                            Trayectoria();
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("\nPresione <Enter> para salir...");
                            Console.ReadKey();
                            break;
                    }
                } while (Menu != 4);
            }
        }
    }
}





    

