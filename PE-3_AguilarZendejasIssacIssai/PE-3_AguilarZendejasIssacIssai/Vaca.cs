using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3_AguilarZendejasIssacIssai
{
    class Vaca
    {
        public string Vacas { get; set; } ///Dos atributos para los nombre y el tiempo que se va a tardar en cruzar 
        public int TiempoCruzar { get; set; }
        public int Tiempo = 0,Tiempo_2=0,Tiempo_3=0,Tiempo_4=0,Tiempo_5=0,Tiempo_6; ///Variable que nos ayudara para calcular el tiempo
        public Vaca (string Nom, int Time)///Constructor con dos parametros
        {
            Vacas = Nom;
            TiempoCruzar = Time;
        }
        public void PuenteVacas()///Metodo principal para elaborar el problema de la vaca...
        {
            Console.WriteLine("Bienvenidos a los acertijos..." +
                "\nSupongamos que bob tiene cuatro vacas que quiere cruzar por un puente, " +
                "pero solo un yugo, que puede sostener hasta dos vacas, lado a lado, atadas al yugo " +
                "El yugo es demasiado pesado para que lo lleve a traves del puente, pero puede atar(y desatar) " +
                "vacas a el en muy poco tiempo. De sus cuatro vacas Mazie puede cruzarlo en 2 minutos, " +
                "Daisy puede cruzarlo en 4 minutos, Crazy puede cruzarlo en 10 minutos y lazy puede cruzar en 20 minutos. " +
                "Por supuesto, cuando dos vacas estan atadas al yugo, deben ir a la velocidad de la vaca mas lenta. " +
                "Describe cómo Bob puede conseguir que todas sus vacas crucen el puente en 34 minutos... ");
            List<Vaca> Info = new List<Vaca>(); ///Creamos 1 lista, un para los nombres y el tiempo

            Info.Add(new Vaca("Mazie", 2));///Agregamos la informacion de las vacas
            Info.Add(new Vaca("Daisy", 4));
            Info.Add(new Vaca("Crazy", 10));
            Info.Add(new Vaca("Lazy", 20));

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Solucion...");
            Console.Write("\nPasa las primera 2 vacas Mazie y Daisy " + ///Aqui va a desplegar las informaciones de las vacas
                "\n\nNombre: {0}  Velocidad: {1} " + "\nNombre: {2}  Velocidad: {3} ", Info.ElementAt(0).Vacas, Info.ElementAt(0).TiempoCruzar, Info.ElementAt(1).Vacas, Info.ElementAt(1).TiempoCruzar);
            Tiempo = Tiempo + Convert.ToInt32(Info.ElementAt(1).TiempoCruzar); ///Aqui calculara el tiempo que hicieron a cruzar el puente 
            Console.Write("\n\nTiempo de cruzar: " + Tiempo);
            Console.WriteLine("\nAhora, Mazie va a regresar...");
            Tiempo_6 = Tiempo_6 + Convert.ToInt32(Info.ElementAt(0).TiempoCruzar);/// Aqui este otro calculara el regreso de la vaca Mazie

            Console.ReadLine();

            Console.Write("\n\nAhora va a pasar el puente Crazy y Lazy "+ /// Y asi sucesivamente hasta que las 4 vacas cruzen el puente 
                "\n\nNombre: {0}  Velocidad {1}:   \nNombre: {2}  Velocidad: {3} ", Info.ElementAt(2).Vacas, Info.ElementAt(2).TiempoCruzar, Info.ElementAt(3).Vacas, Info.ElementAt(3).TiempoCruzar);
            Tiempo_2 = Tiempo_2 + Convert.ToInt32(Info.ElementAt(3).TiempoCruzar);
            Console.Write("\n\nTiempo de cruzar: " + Tiempo_2);
            Console.WriteLine("\nAhora, Daisy se va a regresar con bob...");
            Tiempo_3 = Tiempo_3 + Convert.ToInt32(Info.ElementAt(1).TiempoCruzar);
            Console.ReadLine();

            Console.Write("\n\nAhora va a pasar el puente Mazie y Daisy " +
                "\n\nNombre: {0}  Velocidad: {1} " + "\nNombre: {2}  Velocidad: {3} ", Info.ElementAt(0).Vacas, Info.ElementAt(0).TiempoCruzar, Info.ElementAt(1).Vacas, Info.ElementAt(1).TiempoCruzar);
            Tiempo_4 = Tiempo_4 + Convert.ToInt32(Info.ElementAt(1).TiempoCruzar);
            Console.Write("\n\nTiempo de cruzado: " + Tiempo_4);
            Console.ReadLine();
            Tiempo_5 = Tiempo + Tiempo_2 + Tiempo_3 + Tiempo_4 + Tiempo_6; ///Aqui calculamos todos los tiempos que se guardaron de cada cruzamiento del puente 
            Console.Write("\n\nAhora todas las vacas han cruzado el puente... " +
                "Tiempo en total: {0} Minutos", Tiempo_5); ///Despliega el resultado final... 
            Console.ReadKey();

        }
    }
}
