using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3._3_BlackJack_AguilarZendejasIssacIssai
{
    class Program/// Programa del juego de blackJack
    {
        static void Main(string[] args)
        {
            BlackJack black = new BlackJack(); ///Creamos el objeto black
            black.Juego();///LLamamos al metodo Juego donde se encuetra el juego de 21
            Console.ReadKey();
            ///Los problemas de este programa...
            ///Con este programa batalle mucho. El principal problema era generar las cartas, no me salia me daban puros 0s y por fin de varios dias me salio mas o menos,pero 
            ///Siguio con error y ese error no lo pude arreglar, el error es de que a veces me aparece 1 en vez de As, otro es de que cuando es mas de 10 me sale
            ///10 J Diamante al momento de llamarlo en el metodo juego, intente arreglarlo, pero no tuve exito. Otro problema que tuve fue en el random, pero ahi 
            ///ayudaron mis amigos para saber como moverla para que revolviera las cartas. y por ultimo problema que tuve fue el As no pude hacer condiciones para
            ///que algunas veces valga 1 o 11... en pocas palabras el programa se revelaba contra su creador. 
        }
    }
    public class BlackJack
    {
        public int Numero_Cartas { get; set; }/// Nos ayudara asignarles el numero y simbolo a las cartas
        public string Descripcion { get; set; }
        List<BlackJack> Baraja = new List<BlackJack>(); ///Creamos 2 lista 
        List<BlackJack> list = new List<BlackJack>();
        public List<BlackJack> ObternerCartas()/// Este metodo ObternerCartas vamos a crear la baraja 
        {
            Baraja = new List<BlackJack>();
            BlackJack Black;
            String De = "";
            int Contador = 12;
            for (int i = 1; i < Contador; i++) /// En total hice 4 for para cada simbolo y dentro de esos 4 for se encuentran otros 5 que corresponde 
            {                                  /// Para el A,2,3,4,5,6,7,8,9,10,J,Q,K
                if (i == 1) /// Esta condicion dice que cuando sea 1 se convierte en As y le damos valor de 1 
                {
                    Black = new BlackJack();
                    Black.Descripcion = "As Trebol";
                    Black.Numero_Cartas = 1;
                    Baraja.Add(Black);
                }
                if (i == 11)/// Esta condicion dice que cuando sea 11 se convierte en J y le damos valor de 10 y asi sucesivamente con el resto de simbolos 
                {
                    Black = new BlackJack();
                    Black.Numero_Cartas = 10;
                    Black.Descripcion = "J Trebol";
                    Baraja.Add(Black);
                }
                if (i == 11)
                {
                    Black = new BlackJack();
                    Black.Numero_Cartas = 10;
                    Black.Descripcion = "Q Trebol";
                    Baraja.Add(Black);
                }
                if (i == 11)
                {
                    Black = new BlackJack();
                    Black.Numero_Cartas = 10;
                    Black.Descripcion = "Q Trebol";
                    Baraja.Add(Black);
                }
                else if (i >= 2 || i <= 9)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "Trebol";
                    Black.Numero_Cartas = i;
                    Baraja.Add(Black);
                }
            }
            for (int i = 1; i < Contador; i++)
            {
                if (i == 1)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "As Corazon";
                    Black.Numero_Cartas = 1;
                    Baraja.Add(Black);
                }
                if (i == 11)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "J Corazon";
                    Black.Numero_Cartas = 10;
                    Baraja.Add(Black);
                }
                if (i == 11)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "Q Corazon";
                    Black.Numero_Cartas = 10;
                    Baraja.Add(Black);
                }
                if (i == 11)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "K Corazon";
                    Black.Numero_Cartas = 10;
                    Baraja.Add(Black);
                }
                else if (i >= 2 || i <= 9)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "Corazon";
                    Black.Numero_Cartas = i;
                    Baraja.Add(Black);
                }
            }
            for (int i = 1; i < Contador; i++)
            {
                if (i == 1)
                {
                    Black = new BlackJack();
                    Black.Descripcion = " As Diamante";
                    Black.Numero_Cartas = 1;
                    Baraja.Add(Black);
                }
                if (i == 11)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "J Diamante";
                    Black.Numero_Cartas = 10;
                    Baraja.Add(Black);
                }
                if (i == 11)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "Q Diamante";
                    Black.Numero_Cartas = 10;
                    Baraja.Add(Black);
                }
                if (i == 11)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "K Diamante";
                    Black.Numero_Cartas = 10;
                    Baraja.Add(Black);
                }
                else if (i >= 2 || i <= 10)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "Diamantes";
                    Black.Numero_Cartas = i;
                    Baraja.Add(Black);
                }
            }
            for (int i = 1; i < Contador; i++)
            {
                if (i == 1)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "As Picas";
                    Black.Numero_Cartas = 1;
                    Baraja.Add(Black);
                }
                if (i == 11)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "J Picas";
                    Black.Numero_Cartas = 10;
                    Baraja.Add(Black);
                }
                if (i == 11)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "Q Picas";
                    Black.Numero_Cartas = 10;
                    Baraja.Add(Black);
                }
                if (i == 11)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "K Picas";
                    Black.Numero_Cartas = 10;
                    Baraja.Add(Black);
                }
                else if (i >= 2 || i <= 10)
                {
                    Black = new BlackJack();
                    Black.Descripcion = "Picas";
                    Black.Numero_Cartas = i;
                    Baraja.Add(Black);
                }
            }
            return Baraja;/// Regresamos la baraja que contiene la 52 cartas 
        }

        public Queue<BlackJack> Revolver_Cartas() /// En este metodo lo que hace es revolver las cartas que creo en el metodo ObtenerCartas
        {
            List<BlackJack> Carta = ObternerCartas();
            Queue<BlackJack> Revueltas = new Queue<BlackJack>();
            Random r = new Random();
            for (int i = 0; i < 52; i++) /// Un ciclo de la 52 cartas que creamos para revolver las cartas
            {
                int ran = r.Next(Carta.Count); //Lo que hacemos aqui es eligir un numero azar de la lista de las 52 cartas, lo sacamos y lo metemos al queue 
                Revueltas.Enqueue(Carta[ran]);
                Carta.RemoveAt(ran);
            }
            return Revueltas;///Regresamos el queue donde esta revueltas las cartas 
        }
        public void Juego()///Este es el principal metodo donde se encuetra el juego del 21
        {
            int DarCartas = 0, Puntos = 0;
            BlackJack blackJack = new BlackJack();
            Queue<BlackJack> list = Revolver_Cartas();
            BlackJack jack;
            for (int i = 0; i < 5; i++) /// Un ciclo que dura 5 cartas que le den al usuario 
            {
                jack = list.Dequeue();///Llamamos a lista para que saque la primera carta 
                DarCartas++;///Esta variable nos dira cuantas carta nos faltara para ganar con 5 cartas 
                Console.WriteLine("Carta Num.{0} es: {1} {2} ", i + 1, jack.Numero_Cartas, jack.Descripcion);
                Puntos = jack.Numero_Cartas + Puntos;
                Console.WriteLine("Puntos: " + Puntos);
                Console.ReadKey();
                if (Puntos == 21 || DarCartas == 5) ///Las condiciones para ver si el usuario gano o perdio 
                {
                    if (Puntos == 21)
                    {
                        Console.WriteLine("\n21!!! \nGanastes");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nHaz ganado, tuvistes 5 cartas");
                        break;
                    }
                }
                else if (Puntos > 21)
                {
                    Console.WriteLine("\nMas de 21, perdiste");
                    break;
                }
            }
        }
    }
}

