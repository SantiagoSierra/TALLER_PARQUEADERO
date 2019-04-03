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


        internal List<CClienteNatural> CNatural { get => cNatural; set => cNatural = value; }
        internal List<CClienteJuridico> CJuridico { get => cJuridico; set => cJuridico = value; }
        internal List<CAutomovil> Automoviles { get => automoviles; set => automoviles = value; }
        internal List<CCamion> Camiones { get => camiones; set => camiones = value; }
        internal List<CMoto> Motos { get => motos; set => motos = value; }

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
        public void ConsultarClienteJ(string cedula) {

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
                    result = 1;
                }
            }

            if (result == 0) {
                Console.WriteLine("El cliente juridico con esa cedula no se encuentra registrado");
            }
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
        public void ConsultarClienteN(string cedula) {

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

            if (result==0) {

                Console.WriteLine("El cliente con la cedula ingresada no se encuentra registrado.");

            }

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


            Automoviles.Add(new CAutomovil(placa, dimensiones, "Automovil", marca, color, cc));


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


            Camiones.Add(new CCamion(placa, dimensiones, "Camion", marca, color, cc));

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


            Motos.Add(new CMoto(placa, dimensiones, "Camion", marca, color, cc));

        }

    }
}
