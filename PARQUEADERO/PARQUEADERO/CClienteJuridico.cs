using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO
{
    class CClienteJuridico : CACliente
    {

        private string NIT;
        private string RazonSocial;

        public string NIT1 { get => NIT; set => NIT = value; }
        public string RazonSocial1 { get => RazonSocial; set => RazonSocial = value; }


        public CClienteJuridico(string tipoCliente, string pNIT, string pRS, 
        string pCC, string pNombre, int pCelular) : base(pCC, pNombre, pCelular)
        {
            this.NIT1 = pNIT;
            this.RazonSocial1 = pRS;
            base.TipoCliente1 = tipoCliente;
        }

        
    }
}
