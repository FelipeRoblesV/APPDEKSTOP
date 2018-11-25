using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBS.Presentacion;

namespace WFBS.Intercambio
{
    public class CerrarFormulario
    {

        public void Cerrar()
        {
            Aplicacion aplicacion = new Aplicacion();
            aplicacion.Controles(1);
        }

    }
}
