using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO
{
    abstract class CACliente 
    {

       private string CC;
       private string Nombre;
       private int Celular;
       private string TipoCliente;


        public string CC1 { get => CC; set => CC = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Celular1 { get => Celular; set => Celular = value; }
        public string TipoCliente1 { get => TipoCliente; set => TipoCliente = value; }


        public CACliente(string pCC, string pNombre, int pCelular) {

            this.CC = pCC;
            this.Nombre = pNombre;
            this.Celular = pCelular;
            
        }

        
    }
}
