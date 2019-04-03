using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PARQUEADERO
{
    class Program
    {
        static void Main(string[] args)
        {

            CSistema sistemaE = new CSistema();
            int opcion = -1;

            Console.WriteLine("Ingrese el numero de celdas del parqueadero");
            int nCeldas = Convert.ToInt16(Console.ReadLine());

            sistemaE.GenerarCeldas(nCeldas);

            

            while (opcion!=0)
            {

                Console.WriteLine("___________________________________________");
                Console.WriteLine("BIENVENIDO");

                Console.WriteLine("Menu");
                Console.WriteLine("1.Consultar estados de celdas");
                Console.WriteLine("2.Registrar cliente.");
                Console.WriteLine("3.Registrar vehiculo.");
                Console.WriteLine("4.Parquear vehiculo");
                Console.WriteLine("5.Liberar Celda y cobrar Servicio");
                Console.WriteLine("6.Consultar clientes.");
                Console.WriteLine("7.Consultar informacion de vehiculos y dueños");
                Console.WriteLine("0.Salir");
                Console.Write("opcion:");
                opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    sistemaE.ConsultarCeldas();
                    break;

                case 2:
                    Console.WriteLine("|REGISTRAR CLIENTE|");
                    Console.WriteLine("1.Cliente Juridico.");
                    Console.WriteLine("2.Cliente Natural.");
                    Console.WriteLine("0.Regresar.");
                    Console.Write("opcion=");
                    int opRc = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("__________________");

                    switch (opRc)
                    {
                        case 1:
                            sistemaE.CrearClienteJ();
                            break;

                        case 2:
                            sistemaE.CrearClienteN();
                            break;

                        case 0:
                            Console.WriteLine("Regresando...");
                            break;

                        default:
                            break;
                    }

                    break;

                case 3:

                     Console.WriteLine("Seleccione tipo de vehiculo a registrar");
                     Console.WriteLine("1.Automovil");
                     Console.WriteLine("2.Camion");
                     Console.WriteLine("3.Moto");
                     Console.WriteLine("0.Cancelar.");
                        Console.Write("opcion=");
                     int opV = Convert.ToInt16(Console.ReadLine());

                        switch (opV)
                        {
                            case 1:

                                sistemaE.CrearAutomovil();

                                break;

                            case 2:

                                sistemaE.CrearCamion();

                                break;

                            case 3:

                                sistemaE.CrearMoto();

                                break;

                            case 0:
                                Console.WriteLine("Regresando");
                                break;

                            default:
                                break;
                        }

                        break;

                case 4:
                        sistemaE.ParquearVehiculo();
                    break;

                case 5:
                        sistemaE.LiberarCelda();
                    break;

                case 6:
                    Console.WriteLine("CONSULTAR CLIENTE:");
                    Console.Write("Por favor ingrese la cedula=");
                    String cc = Console.ReadLine();


                        Console.WriteLine("Clientes encontrados:");
                        sistemaE.ConsultarClienteJ(cc);
                        sistemaE.ConsultarClienteN(cc);

                     

                    break;


                 case 7:
                  

                    sistemaE.ConsultarVehiculo();


                        break;

                default:
                    break;
            }


            }


            Console.ReadKey();

        }
    }
}
