using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3_AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir imprimir = new Imprimir();
            imprimir.Menuu();
            Console.ReadKey();   
        }
    }
    public class Imprimir
    {
        public void Menuu()
        {
            int Menu = 0;
            do
            {
                Console.Clear();
                Vaca Obje = new Vaca("", 0);
                Torre torre = new Torre();
                Tarea tarea = new Tarea("", 0, "", 0, 0, "", "");
                Console.Write("1.-Vacas " +
                    "\n2.-Tareas " +
                    "\n3.-Torre de hanoi " +
                    "\n4.-Salir" +
                    "\n\nEscoga una opcion: ");
                Menu = Convert.ToInt16(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        Console.Clear();
                        Obje.PuenteVacas();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        tarea.Consultorio();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        torre.TorreDeHanoi();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\nHasta luego,Presione <Enter> para salir...");
                        Console.ReadKey();
                        break;
                }
            } while (Menu != 4);
        }
    }
}
