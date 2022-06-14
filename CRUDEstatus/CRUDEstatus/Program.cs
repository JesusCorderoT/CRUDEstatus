using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            string opci;
            do
            {
                EstatusAlumno ea = new EstatusAlumno();
                EstatusStruct esta = new EstatusStruct();
                Console.WriteLine("Menu de opciones, seleccione una");
                Console.WriteLine("1.- Consultar Todos ");
                Console.WriteLine("2.- Consultar 1");
                Console.WriteLine("3.- Agregar");
                Console.WriteLine("4.- Actualizar");
                Console.WriteLine("5.- Eliminar");
                Console.WriteLine("6.- Termina ");
                opci = Console.ReadLine();
                Console.WriteLine("Usted seleccionó la opcion: " + opci);

                switch (opci)
                {
                    case "1":
                        Console.WriteLine("1.- Consultar Todos ");


                        EstatusAlumno ess = new EstatusAlumno();

                        List<EstatusStruct> _lstPersonas = ess.ConsultaTodos();
                        foreach (EstatusStruct p in _lstPersonas)
                        {
                            Console.WriteLine("Nombre: " + p.NOM + " Apellidos: " + p.APP + "\n");
                        }

                        Console.ReadLine();

                        break;

                    case "2":
                        Console.WriteLine("2.- Consultar 1");
                        Console.WriteLine("Ingresa ID para buscar");
                        esta.IDE = Console.ReadLine();
                        EstatusAlumno.ConsultarUno(esta);
                        break;

                    case "3":
                        Console.WriteLine("3.- Agregar");

                        Console.WriteLine("Ingresa ID");
                        esta.IDE = Console.ReadLine();
                        Console.WriteLine("Ingresa nombre");
                        esta.NOM = Console.ReadLine();
                        Console.WriteLine("Ingresa apellidos");
                        esta.APP = Console.ReadLine();

                        EstatusAlumno.Agregar(esta);

                        break;

                    case "4":
                        Console.WriteLine("4.- Actualizar");
                        Console.WriteLine("Ingresa ID para actualizar");
                        esta.IDE = Console.ReadLine();

                        Console.WriteLine("Ingresa nombre");
                        esta.NOM = Console.ReadLine();
                        Console.WriteLine("Ingresa apellidos");
                        esta.APP = Console.ReadLine();


                        EstatusAlumno.Actualizar(esta);

                        break;

                    case "5":
                        Console.WriteLine("5.- Eliminar");
                        Console.WriteLine("Ingresa ID para eliminar");
                        esta.IDE = Console.ReadLine();
                        EstatusAlumno.Eliminar(esta);

                        break;

                    case "6":
                        Console.WriteLine("6.- Termina ");
                        return;


                    default:
                        Console.WriteLine("No valido");
                        break;

                }
                Console.WriteLine("");
                Console.WriteLine("Presiona una tecla para repetir ");
                Console.WriteLine("Presiona una 0 para cerrar ");
                Char opci3 = ' ';
                opci3 = Console.ReadKey().KeyChar;
                if (opci3 == '0')
                {
                    Environment.Exit(0);
                }
                else
                    Console.Clear();
            }
            while (opci != "f");

            Console.ReadKey();


            

        }
    }
}
