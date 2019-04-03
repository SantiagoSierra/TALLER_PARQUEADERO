using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARQUEADERO
{

    class CMoto : CPropiedadesVehiculo
    {


        private String CedulaPropietario;

        public CMoto(String pPlaca, float pDimensiones, String pTipoVehiculo, String pMarca, String pColor, String pCedula)
                       : base(pPlaca, pDimensiones, pTipoVehiculo, pMarca, pColor)
        {
            this.CedulaPropietario = pCedula;
        }

        public string CedulaPropietario1 { get => CedulaPropietario; set => CedulaPropietario = value; }
    }

   



}
