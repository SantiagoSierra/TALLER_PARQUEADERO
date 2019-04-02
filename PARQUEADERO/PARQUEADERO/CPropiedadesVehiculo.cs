using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO
{
    class CPropiedadesVehiculo : IVehiculo
    {
            String Placa, Color, Marca;
            float Dimensiones;
            bool Apagado, Movimiento;

            public string Placa1 { get => Placa; set => Placa = value; }
            public string Color1 { get => Color; set => Color = value; }
            public string Marca1 { get => Marca; set => Marca = value; }
            public float Dimensiones1 { get => Dimensiones; set => Dimensiones = value; }

            public CPropiedadesVehiculo(String pPlaca, float pDimensiones, String pMarca, String pColor)
            {
                this.Placa = pPlaca;
                this.Dimensiones = pDimensiones;
                this.Marca = pMarca;
                this.Color = pColor;

                this.Apagado = true;
                this.Movimiento = false;

            }
            public void Encender()
            {
                if (this.Apagado)
                {

                    Console.WriteLine("El Auto fue encendido");
                    this.Movimiento = true;
                    this.Apagado = false;

                }
                else
                {
                    Console.WriteLine("El auto Ya esta Encendido");
                }

            }
            public void Apagar()
            {
                if (this.Apagado)
                {
                    Console.WriteLine("El Auto Ya fue Apagado");
                    this.Apagado = false;
                    this.Movimiento = false;
                }
                else
                {

                    Console.WriteLine("El auto  fue Apagado");
                    this.Apagado = true;
                }

            }
            public void Estacionar()
            {
                if (Apagado == false && Movimiento == false)
                {
                    Console.WriteLine("El auto fue estacionado");


                }
                else
                {
                    Console.WriteLine("Verifique que el auto no este encendido y en movimiento. ");
                }

            }
        


    }
}
