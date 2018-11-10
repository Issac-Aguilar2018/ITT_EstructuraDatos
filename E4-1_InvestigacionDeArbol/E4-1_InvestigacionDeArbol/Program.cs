using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1_InvestigacionDeArbol
{
    class Program
    {
        static void Main(string[] args) ///Fernando Melendrez, Lares Brandon, Aguilar Issac, Perez Luis 
        {
            Arbolbinarioordenado arbol = new Arbolbinarioordenado();//se instancia el objeto de la clase Arbolbinarioordenado
            arbol.Insertar(10);//el primer valor es la raiz
            arbol.Insertar(5);//se llama el metodo insertar de la clase Arbolbinarioordenado
            arbol.Insertar(75);
            arbol.Insertar(2);
            arbol.Insertar(150);

            Console.WriteLine("Impresion Preorden: ");//se imprimen cada metodo
            arbol.ImprimirPre();

            Console.WriteLine("Impresion Entreorden: ");
            arbol.ImprimirEntre();

            Console.WriteLine("Impresion Postorden: ");
            arbol.ImprimirPost();

            Console.ReadKey();
        }
    }
    public class Arbolbinarioordenado //se crea una clase de tipo publica llamada Arbolbinarioordenado
    {
        class Nodo //clase de tipo nodo
        {
            public int info;
            public Nodo izq, dere; //dos punteros que seran nodo izquierdo y derecho
        }
        Nodo raiz;
        public Arbolbinarioordenado() //constructor sin parametros
        {
            raiz = null;
        }
        public void Insertar(int info)//funcion con parametros, esta funcion recibira este parametro con los valores que hay 
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info; //recibe el valor del parametro que se le envio 
            nuevo.izq = null;
            nuevo.dere = null;
            if (raiz == null)//esto solo entrara la primera vez, ya que la segunda la raiz ya tendra un valor
            {
                raiz = nuevo;
            }
            else //en la segunda vuelta entra el else
            {
                Nodo anterior = null, reco;//se crea un puntero llamado reco
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)//si info es menor que reco.info, entonces se empiezan a ingresar los valores del lado izquierdo de nuestro arbol
                        reco = reco.izq;
                    else //si no se cumple lo anterios, entonces reco se agregara del lado derecho de nuestro arbol
                        reco = reco.dere;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.dere = nuevo;
            }
        }
        private void ImprimirPre(Nodo reco)//este metodo imprime los valores tal cual como se ingresen
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");//este es el valor de la raiz
                ImprimirPre(reco.izq);
                ImprimirPre(reco.dere);
            }
        }
        public void ImprimirPre()
        {
            ImprimirPre(raiz);
            Console.WriteLine();
        }
        private void ImprimirEntre(Nodo reco)//en este metodo la raiz queda en medio, y los valores mas pequeños quedan a la izquierda 
        {                                    //y los valores mas grandes a la derecha
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");//para que la raiz quede en medio
                ImprimirEntre(reco.dere);
            }
        }
        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }
        private void ImprimirPost(Nodo reco)//este metodo hace que la raiz quede del lado derecho y todos los demas valores del lado izquierdo
        {                                   //pero siempre los valores mayores arriba
            if (reco != null)
            {
                ImprimirPost(reco.izq);//valores menores
                ImprimirPost(reco.dere);//valores mayores
                Console.Write(reco.info + " ");//la raiz queda aqui
            }
        }
        public void ImprimirPost() //son para mandar a llamar los metodos privados
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }
    }
}

