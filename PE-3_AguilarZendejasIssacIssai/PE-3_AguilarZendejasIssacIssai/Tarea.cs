using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3_AguilarZendejasIssacIssai
{
    class Tarea
    {
        public string NombreTarea { get; set; } /// 7 Atributos para cada accion que hagamos
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public int FechaInicio { get; set; }
        public int FechaFin { get; set; }
        public string Status { get; set; }
        public string Avance { get; set; }
        public Tarea(string Nombre, int Id, string Descrip, int FI, int FF, string Sta,string Ava) ///Un constructor con 7 parametros
        {
            NombreTarea = Nombre;
            ID = Id;
            Descripcion = Descrip;
            FechaInicio = FI;
            FechaFin = FF;
            Status = Sta;
            Avance = Ava;
        }

        public List<Tarea> NoIniciado = new List<Tarea>(); /// 4 listas para estar almacenando las informaciones
        public List<Tarea> EnProceso = new List<Tarea>();
        public List<Tarea> Terminado = new List<Tarea>();
        public List<Tarea> Globales = new List<Tarea>();

        public void Consultorio() ///Metodo para consultar la informacion de las tareas
        {
            int Menu = 0;
            do /// Un do while para que sea un ciclo y no salirse del programa 
            {
                Console.Clear();
                int Menu_1 = 0;
                Console.Write("1.- Agregar una nueva Tarea " +
                    "\n2.- Consultar las tareas  " +
                    "\n3.- Salir" +
                    "\n\nEscoga una opcion: ");
                Menu = Convert.ToInt16(Console.ReadLine());
                switch (Menu) ///Un menu con 3 opciones 
                {

                    case 1: /// Caso 1, Alimentamos al programa con la informacion que esta pidiendo 
                        Console.Clear();
                        Console.Write("Nombre Tarea: ");
                        NombreTarea = Console.ReadLine();
                        Console.Write("ID de la tarea: ");
                        ID = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Descripcion de la tarea: ");
                        Descripcion = Console.ReadLine();
                        Console.Write("Fecha de inicio: ");
                        FechaInicio = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Fecha de entregar: ");
                        FechaFin = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Status de la tarea (Nueva tarea/Tarea en proceso): ");
                        Status = Console.ReadLine();

                        switch (Status) ///Dependiendo del status que ponga el usuario, sera uno de los dos casos que hay 
                        {
                            case "Nueva tarea":
                                Globales.Add(new Tarea(NombreTarea,ID,Descripcion,FechaInicio,FechaFin,Status,Avance));
                                NoIniciado.Add(new Tarea(NombreTarea, ID, Descripcion, FechaInicio, FechaFin, Status,Avance)); ///Los dos casos se guardaran en las listas que creamos
                                break;
                            case "Tarea en proceso":
                                EnProceso.Add(new Tarea(NombreTarea, ID, Descripcion, FechaInicio, FechaFin, Status,Avance));
                                Globales.Add(new Tarea(NombreTarea, ID, Descripcion, FechaInicio, FechaFin, Status,Avance)); 
                                break;
                        }
                        break;
                    case 2: ///Otro caso para consultar las tareas
                        Console.Clear();
                        Console.Write("1.- Global " +
                    "\n2.- Tarea pediente  " +
                    "\n3.- En proceso" +
                    "\n4.- Terminado" +
                    "\n\nEscoga una opcion: ");
                        Menu_1 = Convert.ToInt16(Console.ReadLine());
                        switch (Menu_1)
                        {
                            case 1: ///En global, te mostrara la tarea pendiente que tengas 
                                Console.Clear();
                                Console.WriteLine("Bienvenido alumno, aqui estan sus tareas globales...");                               
                                Console.Write("\nNombre: {0} \nID: {1} \nFecha de entrega: {2} \nDescripcion: {3} \nStatus: {4} \nAvance: {5}", NombreTarea, ID, FechaFin, Descripcion, Status,Avance);
                                Console.ReadKey();
                                break;
                            case 2: ///En tarea pendiente, Solamente te monstrara que tareas tienes pendiente 
                                Console.Clear();
                                Console.WriteLine("Tareas pendientes...");
                                Console.Write("\nNombre: {0} \nFecha de entrega: {1} \nDescripcion: {2}", NombreTarea, FechaFin, Descripcion);
                                Console.ReadKey();
                                break;
                            case 3: ///En proceso, aqui podras dar un avance a la tarea 
                                Console.Clear();
                                Console.Write("¿Vas a entregar avance de la tarea? Si/No \n");
                                string x = Console.ReadLine();
                                if (x == "Si") ///Si el usuario quiere poner el avance entrara al primer if
                                {
                                    Console.Write("\nEscriba el avance: ");
                                    Avance = Console.ReadLine();
                                    Status = "En proceso"; ///Ahora se va actualizar el status de la tarea 
                                    EnProceso.Add(new Tarea(NombreTarea, ID, Descripcion, FechaInicio, FechaFin, Status, Avance)); ///Guardaremos o actualizamos la lista 
                                    Console.ReadKey();
                                }
                                else ///Si el usuario no tiene nada o entro por error 
                                {
                                    Console.WriteLine("Presione <Enter> para irse al inicio... ");
                                    Console.ReadKey();
                                }
                                break;
                            case 4:///En terminado, aqui el "Profesor" decidira si el usuario trajo la tarea completa..
                                Console.Clear();
                                Console.WriteLine("¿Listo para entregar la tarea? Si/No \n");
                                string y = Console.ReadLine();
                                if (y == "Si") ///Si el usuario introduce Si, el "Profesor" va a calificar el trabajo
                                {
                                    Console.Clear();
                                    Console.Write("\nNombre: {0} \nID: {1} \nFecha de entrega: {2} \nDescripcion: {3} \nStatus: {4} \nAvance: {5}", NombreTarea, ID, FechaFin, Descripcion, Status, Avance);
                                    Console.Write("\n¿Tarea completa? Si/No \n");
                                    string z = Console.ReadLine();
                                    if (z == "Si") ///Si la tarea esta completa entrara al if 
                                    {
                                        Console.Clear();
                                        Console.Write("Felicidades tienes un 100...");
                                        Status = "Terminado"; ///Cambiamos el status de la tarea 
                                        Terminado.Add(new Tarea(NombreTarea, ID, Descripcion, FechaInicio, FechaFin, Status, Avance)); ///Agregamos el cambio a las 2 listas 
                                        Globales.Add(new Tarea(NombreTarea, ID, Descripcion, FechaInicio, FechaFin, Status, Avance));
                                        foreach (var Tarea in EnProceso)
                                        {
                                            NoIniciado.Remove(Tarea); /// Aqui se supone que tiene que eliminar el contenido de las 2 listas, pero desconozco si esto bien en la hora de estar borrando informacion 
                                            EnProceso.Remove(Tarea);
                                            break;
                                        }
                                        Console.ReadKey();
                                    }
                                    else ///Si la tarea esta mal, el usuario regresa al inicio 
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Presione <Enter> para irse al inicio y termine bien su tarea... ");
                                        Console.ReadKey();
                                    }
                                }
                                else /// Tarea no echa 
                                {
                                    Console.Clear();
                                    Console.WriteLine("Presione <Enter> para irse al inicio... ");
                                    Console.ReadKey();
                                }
                                break;
                        }
                        break;
                    default: /// Caso para salir del programa 
                        Console.WriteLine("Presione <Enter> para salir...");
                        break;
                }
            } while (Menu != 3);
        }
    }
}
