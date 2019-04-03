using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO
{
    class CCeldas
    {
        private String PlacaVehiculo;
        private float Dimensiones;
        private String IDCelda;
        private String Nombre;
        private bool Disponible;
        private double HoraInicio, HoraFin;
        private String Tipo;
        private CCeldas[] Celdas = new CCeldas[8];

        public CCeldas() {


        }

        public float Dimensiones1 { get => Dimensiones; set => Dimensiones = value; }
        public string IDCelda1 { get => IDCelda; set => IDCelda = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public bool Disponible1 { get => Disponible; set => Disponible = value; }
        public double HoraInicio1 { get => HoraInicio; set => HoraInicio = value; }
        public double HoraFin1 { get => HoraFin; set => HoraFin = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }

        public void CambiarEstado() {

        }

        public void RecorrerCeldas() {

        }

        public void CrearCeldas() {

            for (int i = 0; i < Celdas.GetLength(0); i++)
            {

                


            }

        }

    }
}
