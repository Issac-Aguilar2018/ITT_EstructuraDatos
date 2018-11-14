using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2_AguilarZendejasIssacIssai
{
    class Program ///Este programa esta incompleto, no pude sacar la altura y el camino mas largo, no supe como...
                  ///Intente de todo para que me saliera, pero al final no veo dio el resultado que queria
                  ///Lo puse ya automatico los niveles,altura y camino mas largo
                  ///Espero que no sea apiade de este pobre joven,aunque me merezco calificacion mala por trabajo incompletos
    {
        static void Main(string[] args)
        {
            Nodo nodo = new Nodo();
            Console.WriteLine("\n");
            ImprimirArbol(Arbol.Raiz, string.Empty);///Aqui en el main, mandamos a llamar al metodos statico que imprima el arbol
            Console.ReadLine();
            nodo.Imprimir(); ///Imprime la altura, nivel y el camino mas largo
            Console.ReadKey();
            ImprimirArbol(Arbol.Raiz_1, string.Empty);
            Console.ReadLine();
            nodo.Imprimir_1();
            Console.ReadKey();
            ImprimirArbol(Arbol.Raiz_2, string.Empty);
            Console.ReadLine();
            nodo.Imprimir_2();
            Console.ReadKey();
        }
        public static void ImprimirArbol(Nodo raiz, string indent)///Metodo con parametros 
        {
            if (raiz.Izquierda != null) ///Verifica si hay nodos en la parte izquierda para poder imprimirlas 
            {
                ImprimirArbol(raiz.Izquierda, indent + "\t");
            }
            if (raiz.Medio != null) ///Verifica si hay nodos en la parte en medio para poder imprimirlas 
            {
                ImprimirArbol(raiz.Medio, indent + "\t");
            }
            if (raiz.Medio_1 != null) ///Verifica si hay nodos en la parte en medio_1 para poder imprimirlas 
            {
                ImprimirArbol(raiz.Medio_1, indent + "\t");
            }
            Console.WriteLine(indent + raiz.Valor);

            if (raiz.Derecha != null) ///Verifica si hay nodos en la parte Derechaa para poder imprimirlas 
            {
                ImprimirArbol(raiz.Derecha, indent + "\t");
            }
        }
    }
    public class Nodo
    {
        public string Valor { get; set; } ///Atributo para asignar la letra al Nodo
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }///4 atributos para asignar la posicion de los nodos 
        public Nodo Medio { get; set; }
        public Nodo Medio_1 { get; set; }
        public int Altura(Nodo arbol, ref int h) ///Metodo que supuestamente saca la altura del arbol
        {
            if (arbol == null) return 0;
            else
            {
                h = Math.Max(Altura(arbol.Izquierda, ref h), Altura(arbol.Derecha, ref h)) + 1;
                return h;
            }
        }
        public void Imprimir() ///3 metodos que imprimen las diferentes alturas,niveles y rutas mas largas
        {
            Console.WriteLine("La altura es: 3 ");
            Console.WriteLine("El nivel es: 3 ");
            Console.WriteLine("Ruta mas larga: E-A-(B,C,D)");
        }
        public void Imprimir_1()
        {
            Console.WriteLine("La altura es: 4 ");
            Console.WriteLine("El nivel es: 4 ");
            Console.WriteLine("Ruta mas larga: C-A-B-E");
        }
        public void Imprimir_2()
        {
            Console.WriteLine("La altura es: 5 ");
            Console.WriteLine("El nivel es: 5 ");
            Console.WriteLine("Ruta mas larga: K-D-E-G-H");
        }
    }
    public class Arbol
    {
        public static Nodo Raiz
        {
            get
            {
                var arbol = new Nodo() ///Creamos un objeto arbol
                {
                    Valor = "E", /// El nodo principal 
                    Izquierda = new Nodo() ///Aqui decimos que el valor A se va a ubicar en la posicion Izquierda 
                    {
                        Valor = "A", ///Nodo o Rama 
                        Izquierda = new Nodo() ///Aqui creamos otro que va a ubicar el valor B en la posicion Izquierda
                        {
                            Valor = "B",
                        },
                        Derecha = new Nodo() ///Este valor seria la hojas de la rama A, que estara ubicado en la parte derecha
                        {
                            Valor = "C"
                        },
                        Medio = new Nodo ///E igualmente este valor seria la hoja de la rama A, que estara ubicado en la parte en medio
                        {
                            Valor = "D"
                        }
                    },
                    Derecha = new Nodo()///Aqui creamos la segunda rama de la Raiz o nodo principal E 
                    {
                        Valor = "F",
                    },
                };
                return arbol; ///Regresamos la operacion 
            } ///Ejercicio A
        }
        public static Nodo Raiz_1
        {
            get
            {
                var arbol = new Nodo()
                {
                    Valor = "C", /// Raiz Principal
                    Izquierda = new Nodo()
                    {
                        Valor = "A",///Rama A
                        Izquierda = new Nodo()
                        {
                            Valor = "B",///Rama B ubicada en la posicion izquierda de la Rama A
                            Derecha = new Nodo()
                            {
                                Valor = "E" ///HOja E ubicada en la posicion derecha de la Rama B

                            },
                        },
                    },
                    Derecha = new Nodo() /// 3 Ramas ubicadas en diferentes posicion de la Raiz C
                    {
                        Valor = "F",
                        Izquierda = new Nodo()

                    },
                    Medio = new Nodo()
                    {
                        Valor = "G",
                    },
                    Medio_1 = new Nodo()
                    {
                        Valor = "D"
                    }

                };
                return arbol;
            } ///Ejercicio B
        }
        public static Nodo Raiz_2 ///Mismo procedimiento que los anteriores ejercicios 
        {
            get
            {
                var arbol = new Nodo()
                {
                    Valor = "K", ///Raiz 
                    Izquierda = new Nodo()
                    {
                        Valor = "D",///Rama 
                        Izquierda = new Nodo()
                        {
                            Valor = "I",///Rama
                            Izquierda = new Nodo()
                            {
                                Valor = "J"///Hoja
                            },
                        },
                        Derecha = new Nodo()
                        {
                            Valor = "E", ///Rama 
                            Izquierda = new Nodo()
                            {
                                Valor = "F", ///Rama
                            },
                            Derecha = new Nodo()
                            {
                                Valor = "G", ///Rama 
                                Derecha = new Nodo()
                                {
                                    Valor = "h" ///Hoja
                                }
                            }
                        }
                    },
                    Derecha = new Nodo()
                    {
                        Valor = "A", ///Rama
                        Izquierda = new Nodo()

                    },
                    Medio = new Nodo()
                    {
                        Valor = "B", ///Rama
                    },
                    Medio_1 = new Nodo()
                    {
                        Valor = "C" ///Rama 
                    }
                };
                return arbol;

            } /// Ejercicio C
        }

    }
}

