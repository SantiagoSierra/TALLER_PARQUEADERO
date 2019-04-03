using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO
{
    class CSistema
    {

        private List<CClienteJuridico> cJuridico = new List<CClienteJuridico>();
        private List<CClienteNatural> cNatural = new List<CClienteNatural>();
        private List<CAutomovil> automoviles = new List<CAutomovil>();
        private List<CCamion> camiones = new List<CCamion>();
        private List<CMoto> motos = new List<CMoto>();
        private List<CCeldas> celdas = new List<CCeldas>();


        internal List<CClienteNatural> CNatural { get => cNatural; set => cNatural = value; }
        internal List<CClienteJuridico> CJuridico { get => cJuridico; set => cJuridico = value; }
        internal List<CAutomovil> Automoviles { get => automoviles; set => automoviles = value; }
        internal List<CCamion> Camiones { get => camiones; set => camiones = value; }
        internal List<CMoto> Motos { get => motos; set => motos = value; }
        internal List<CCeldas> Celdas { get => celdas; set => celdas = value; }

        public void CrearClienteJ() {

            Console.WriteLine("REGISTRAR CLIENTE JURIDICO");
            Console.Write("Ingrese NIT=");
            string nit = Console.ReadLine();
            Console.Write("Ingrese razon social=");
            string rsocial = Console.ReadLine();
            Console.Write("Ingrese cedula de ciudadania=");
            string cc = Console.ReadLine();
            Console.Write("Ingrese Nombre=");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese celular=");
            int celular = Convert.ToInt32(Console.ReadLine());

            CJuridico.Add(new CClienteJuridico("Juridico", nit, rsocial, cc, nombre, celular));
            Console.WriteLine("cliente Juridico registrado con exito.");

        }
        public int ConsultarClienteJ(string cedula) {

            int result = 0;

            foreach (var item in CJuridico)
            {

               if (item.CC1 == cedula) {
                    Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                    Console.WriteLine("nombre;" + item.Nombre1);
                    Console.WriteLine("Nit:"+item.NIT1);
                    Console.WriteLine("CC:"+item.CC1);
                    Console.WriteLine("Razon social:" + item.RazonSocial1);
                    Console.WriteLine("Numero celular:"+item.Celular1);
                    Console.WriteLine("Tipo de cliente:"+item.TipoCliente1);
                    Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");

                    foreach (var automovil in automoviles)
                    {
                        if (automovil.CedulaPropietario1 == item.CC1)
                            Console.WriteLine("Placas de sus automoviles");
                        Console.WriteLine("Placa:" + automovil.Placa1 + ", Marca:" + automovil.Marca1);

                    }
                    foreach (var camion in camiones)
                    {
                        if (camion.CedulaPropietario1 == item.CC1)
                            Console.WriteLine("Placas de camiones asociados");
                            Console.WriteLine("Placa:" + camion.Placa1 +", Marca:" + camion.Marca1);
                        

                    }
                    foreach (var moto in motos)
                    {
                        if (moto.CedulaPropietario1 == item.CC1)
                            Console.WriteLine("Placas de motos asociadas");
                            Console.WriteLine("Placa:" + moto.Placa1+", Marca:" + moto.Marca1);

                    }
                    result = 1;
                }
            }

            return result;
        }
        
        public void CrearClienteN() {

            Console.WriteLine("REGISTRAR CLIENTE NATURAL");
            Console.Write("Por favor ingrese la cedula=");
            string cc = Console.ReadLine();
            Console.Write("Por favor ingrese el nombre=");
            string nombre = Console.ReadLine();
            Console.Write("ingrese su numero celular=");
            int celular = Convert.ToInt32(Console.ReadLine());


            CNatural.Add(new CClienteNatural("Natural", cc, nombre, celular));
            Console.WriteLine("cliente Natural registrado con exito.");

        }
        public int ConsultarClienteN(string cedula) {

            int result = 0;

            foreach (var item in CNatural)
            {

                if (item.CC1 == cedula) {

                    Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                    Console.WriteLine("Cliente registrado:");
                    Console.WriteLine("nombre:"+item.Nombre1);
                    Console.WriteLine("cedula:"+item.CC1);
                    Console.WriteLine("celular:"+item.Celular1);
                    Console.WriteLine("Tipo de cliente:"+item.TipoCliente1);
                    Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                    result = 1;
                }

            }


            return result;
        }

        public void CrearAutomovil() {

            Console.WriteLine("REGISTRAR AUTOMOVIL");
            Console.Write("Ingrese la placa del automovil=");
            String placa = Console.ReadLine();

            Console.Write("Ingrese la marca=");
            String marca = Console.ReadLine();

            Console.Write("Ingrese el color=");
            String color = Console.ReadLine();

            Console.Write("Ingrese dimension del vehiculo=");
            String s = Console.ReadLine();

            float dimensiones = float.Parse(s);

            Console.Write("Ingrese la cedula del dueño de este vehiculo=");
            String cc = Console.ReadLine();


                int rCJ = ConsultarClienteJ(cc);
                int rCN = ConsultarClienteN(cc);
            

            if (rCJ == 1 || rCN == 1)
            {

                Automoviles.Add(new CAutomovil(placa, dimensiones, "Automovil", marca, color, cc));
                Console.WriteLine("+ un Automovil registrado con exito.");

            }
            else {
                Console.WriteLine("(El cliente no fue encontrado) !por favor registre el cliente, para asociar el Automovil con placa"+placa);
            
            }


        }

        public void CrearCamion() {

            Console.WriteLine("REGISTRAR CAMION");
            Console.Write("Ingrese la placa del camion=");
            String placa = Console.ReadLine();

            Console.Write("Ingrese la marca=");
            String marca = Console.ReadLine();

            Console.Write("Ingrese el color=");
            String color = Console.ReadLine();

            Console.Write("Ingrese dimension del camion=");
            String s = Console.ReadLine();

            float dimensiones = float.Parse(s);

            Console.Write("Ingrese la cedula del dueño de este Camion=");
            String cc = Console.ReadLine();


            int rCJ = ConsultarClienteJ(cc);
            int rCN = ConsultarClienteN(cc);

            if (rCJ == 1 || rCN == 1)
            {

             Camiones.Add(new CCamion(placa, dimensiones, "Camion", marca, color, cc));
                Console.WriteLine("+ un Camion registrado");

            }
            else
            {
                Console.WriteLine("(Cliente no encontrado) !registre el cliente para asociar el Camion con placa" + placa);
            }

            

        }

        public void CrearMoto() {

            Console.WriteLine("REGISTRAR MOTO");
            Console.Write("Ingrese la placa de la moto=");
            String placa = Console.ReadLine();

            Console.Write("Ingrese la marca=");
            String marca = Console.ReadLine();

            Console.Write("Ingrese el color=");
            String color = Console.ReadLine();

            Console.Write("Ingrese dimension de la moto=");
            String s = Console.ReadLine();

            float dimensiones = float.Parse(s);

            Console.Write("Ingrese la cedula del dueño de esta Moto=");
            String cc = Console.ReadLine();

            int rCJ = ConsultarClienteJ(cc);
            int rCN = ConsultarClienteN(cc);


            if (rCJ == 1 || rCN == 1)
            {

                Motos.Add(new CMoto(placa, dimensiones, "Camion", marca, color, cc));
                Console.WriteLine("+ una Moto registrada con exito.");
            }
            else
            {
                Console.WriteLine("(Cliente no encontrado) registre el cliente para asociar esta Moto con placa." + placa);
            }

        }

        public String ConsultarVehiculo() {

            String placaEncontrada = "N/A";

            Console.WriteLine("Ingrese la placa del vehiculo");
            String placa = Console.ReadLine();

            Console.WriteLine("¿Que tipo de vehiculo es?");
            Console.WriteLine("1. Automovil.");
            Console.WriteLine("2. Camion");
            Console.WriteLine("3. Moto");
            int opT = Convert.ToInt16(Console.ReadLine());

            switch (opT)
            {

                case 1:

                    foreach (var item in automoviles)
                    {
                        if (placa == item.Placa1)
                        {

                            Console.WriteLine("Cedula del propietario vehiculo:" + item.CedulaPropietario1);
                            Console.WriteLine("Marca del automovil:" + item.Marca1);
                            Console.WriteLine("Color del vehiculo:" + item.Color1);
                            Console.WriteLine("Dimensiones:" + item.Dimensiones1);
                            placaEncontrada = item.Placa1;
                        }

                    }

                    break;

                case 2:

                    foreach (var item in camiones)
                    {
                        if (placa == item.Placa1)
                        {
                            Console.WriteLine("Cedula del propietario vehiculo:" + item.CedulaPropietario1);
                            Console.WriteLine("Marca del automovil:" + item.Marca1);
                            Console.WriteLine("Color del vehiculo:" + item.Color1);
                            Console.WriteLine("Dimensiones:" + item.Dimensiones1);
                            placaEncontrada = item.Placa1;
                        }
                    }


                    break;

                case 3:

                    foreach (var item in motos)
                    {
                        if (placa == item.Placa1)
                        {
                            Console.WriteLine("Cedula del propietario vehiculo:" + item.CedulaPropietario1);
                            Console.WriteLine("Marca del automovil:" + item.Marca1);
                            Console.WriteLine("Color del vehiculo:" + item.Color1);
                            Console.WriteLine("Dimensiones:" + item.Dimensiones1);
                            placaEncontrada = item.Placa1;
                        }
                    }


                    break;

                default:
                    break;

            }

            return placaEncontrada;
        }


        public void GenerarCeldas(int nCeldas)
        {


            for (int i = 0; i < nCeldas; i++)
            {

                CCeldas celdita = new CCeldas();


                Console.WriteLine("Ingrese la dimension de la celda");
                String s = Console.ReadLine();

                celdita.Dimensiones1 = float.Parse(s);

                celdita.IDCelda1 = "N"+(i+1);

                Console.WriteLine("Ingrese el nombre de la celda");
                celdita.Nombre1 = Console.ReadLine();

            
                celdita.HoraInicio1 = 0;
                celdita.HoraFin1 = 0;

                celdita.Disponible1 = true;

                Console.WriteLine("¿Para que tipo de vehiculo es esta celda? 1.Automovil, 2.Camion, 3.Moto");
                int opT = Convert.ToInt16(Console.ReadLine());

                switch (opT)
                {

                    case 1:
                        celdita.Tipo1 = "Automovil";
                        break;

                    case 2:
                        celdita.Tipo1 = "Camion";
                        break;

                    case 3:
                        celdita.Tipo1 = "Moto";
                        break;


                    default:
                        break;
                }


                celdita.PlacaVehiculo1 = "N/A";

                Celdas.Add(celdita);

            }   

        }

        public void ConsultarCeldas() {


            Console.WriteLine("Celdas disponibles:");
            foreach (var item in Celdas)
            {
                if (item.Disponible1 == true)
                {
                    Console.WriteLine("ID de la celda:" + item.IDCelda1);
                    Console.WriteLine("El nombre de la celda:" + item.Nombre1);
                    Console.WriteLine("estado celda: Celda disponible");
                    Console.WriteLine("La dimensiones de la celda:" + item.Dimensiones1);
                    Console.WriteLine("");
                }
  
            }

            Console.WriteLine("_ _ _ _ _ _ _ _  _ _ _");
            Console.WriteLine("Celdas Ocupadas:");
            foreach (var item in Celdas)
            {
                if (item.Disponible1 == false)
                {
                    Console.WriteLine("ID de la celda:" + item.IDCelda1);
                    Console.WriteLine("Nombre de la celda: " + item.Nombre1);
                    Console.WriteLine("Placa del vehiculo: " + item.PlacaVehiculo1);
                    Console.WriteLine("Hora Inicio" + item.HoraInicio1);
                }
            }

        }


        public void ParquearVehiculo() {

            String placa = ConsultarVehiculo();

            if (placa != "N/A") {

                Console.WriteLine("Vehiculo encontrado");
                Console.WriteLine("Celdas:");
                ConsultarCeldas();
                Console.WriteLine("Ingrese id de la celda para agregar el vehiculo");
                String idCelda = Console.ReadLine();

                foreach (var item in Celdas)
                {

                    if (idCelda == item.IDCelda1 && item.Disponible1 == true)
                    {

                        item.Disponible1 = false;
                        item.PlacaVehiculo1 = placa;

                        Console.WriteLine("Ingrese Hora de inicio");
                        item.HoraInicio1 = Convert.ToDouble(Console.ReadLine());

                    }
                    else {

                        Console.WriteLine("Esta celda no esta disponible!!!");
                    }


                }

            }
            else
            {

                Console.WriteLine("Esta placa no esta registrada, Registre un cliente y asociele los vehiculos");


            }


        }

        public void LiberarCelda() {

            Console.WriteLine("Ingrese el ID de la celda");
            String idCelda = Console.ReadLine();
            int v = 1;

            foreach (var celda in celdas)
            {

                if (idCelda == celda.IDCelda1) {

                    Console.WriteLine("Ingrese la hora Final=");
                    celda.HoraFin1 = Convert.ToDouble(Console.ReadLine());

                    CalcularPago(celda.HoraInicio1, celda.HoraFin1);

                    celda.Disponible1 = false;
                    celda.HoraFin1 = 0;
                    celda.HoraInicio1 = 0;
                    celda.PlacaVehiculo1 = "N/A";
                    
                }

            }



        }

        public void CalcularPago(double horaI, double horaF) {


            Console.WriteLine("El cliente debe pagar un total de:"+(horaF-horaI));

        }

    }
}
