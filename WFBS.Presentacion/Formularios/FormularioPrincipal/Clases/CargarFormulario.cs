using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Clases
{
   public class CargarFormulario
    {
        public object Formulario { get; set; }

        public CargarFormulario(object formulario)
        {
            Formulario = formulario;
        }

        public CargarFormulario()
        {
        }
    }
}
