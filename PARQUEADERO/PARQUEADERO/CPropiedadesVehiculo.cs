using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO
{
    class CPropiedadesVehiculo : IVehiculo
    {
           private String Placa, Color, Marca;
           private float Dimensiones;
           private bool Apagado, Movimiento;
           private String TipoVehiculo; 
            

            public string Placa1 { get => Placa; set => Placa = value; }
            public string Color1 { get => Color; set => Color = value; }
            public string Marca1 { get => Marca; set => Marca = value; }
            public float Dimensiones1 { get => Dimensiones; set => Dimensiones = value; }
            public string TipoVehiculo1 { get => TipoVehiculo; set => TipoVehiculo = value; }

            public CPropiedadesVehiculo(String pPlaca, float pDimensiones, String pTipoVehiculo, String pMarca, String pColor)
            {
                this.Placa = pPlaca;
                this.Dimensiones = pDimensiones;
                this.TipoVehiculo = pTipoVehiculo;
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
