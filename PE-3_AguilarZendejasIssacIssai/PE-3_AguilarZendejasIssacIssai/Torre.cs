using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3_AguilarZendejasIssacIssai
{
    class Torre
    {
        public Stack<int> Torre_1 = new Stack<int>(); /// 3 Pilas para las 3 torres 
        public Stack<int> Torre_2 = new Stack<int>();
        public Stack<int> Torre_3 = new Stack<int>();

        public int Discos = 0; ///Variable auxiliar

        public void TorreDeHanoi() ///Metodo principal que llamara a los metodos Hanoi y Imprimir
        {
            Console.Write("Cuantos discos va a querer inciar: ");
            int Discos = Convert.ToInt16(Console.ReadLine());//
            for (int i = Discos; i > 0; i--)
            {
                Torre_1.Push(i); ///Llena la pila con los disco que indico el usuario 
            }
            Hanoi(Discos, Torre_1, Torre_2, Torre_3); /// Llama a los dos metodos 
            Imprimir(Torre_1, Torre_2, Torre_3);
            Console.ReadKey();
        }
        static void Imprimir(Stack<int> torre1, Stack<int> torre2, Stack<int> torre3)///Imprimi las 3 torres 
        {
            Console.WriteLine();///Los WriteLine es para que no haya ningun problema
            Console.ReadKey(); /// e igual el ReadKey 
            Console.Clear(); ///Limpiar la consola
            Console.Write("Torre 1: \n");
            foreach (int x in torre1) ///Despliega la torre 1, 2 y 3
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Torre 2: ");
            foreach (int x in torre2)
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Torre 3: ");
            foreach (int x in torre3)
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine();
        }
        public void Hanoi(int Dis, Stack<int> hanoi1, Stack<int> hanoi2, Stack<int> hanoi3) ///Este serian las formulas Recursivas para hacer el juego de Hanoi
        {
            Imprimir(hanoi1, hanoi2, hanoi3); ///Metodo que imprime las torres 
            if (Dis == 1)
            {
                hanoi3.Push(hanoi1.Pop()); ///Cuando haya un disco pasarlo automaticamente a la torre 3 
            }
            else/// Sino, va a seguir la formula y va a estar imprimiendo, es como un ciclo de hacer la formula e imprimir 
            {
                Hanoi(Dis - 1, hanoi1, hanoi3, hanoi2);

                Imprimir(hanoi1, hanoi2, hanoi3);

                Hanoi(1, hanoi1, hanoi2, hanoi3);

                Imprimir(hanoi1, hanoi2, hanoi3);

                Hanoi(Dis - 1, hanoi2, hanoi1, hanoi3);
            }
            Imprimir(hanoi1, hanoi2, hanoi3);
        }
    }
}
            
        

    

