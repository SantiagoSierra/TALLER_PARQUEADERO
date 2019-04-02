using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO
{
    class CClienteNatural : CACliente
    {

        public CClienteNatural(string pTipoCliente, string pCC, string pNombre, int pCelular) 
                              : base(pCC, pNombre, pCelular)
        {
            base.TipoCliente1 = pTipoCliente;
        }

    }
}
