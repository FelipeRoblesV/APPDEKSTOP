using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Clases
{
    class CargarReporte
    {
        public int id_Perfil { get; set; }
        public int id_Evaluacion { get; set; }
        public DataSet lista { get; set; }
        public string mensaje { get; set; }

        public CargarReporte()
        {

        }
    }
}
