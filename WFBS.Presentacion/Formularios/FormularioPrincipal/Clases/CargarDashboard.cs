using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Clases
{
  public class CargarDashboard
    {
        public string mensaje { get; set; }
        public int totalFuncionario { get; set; }
        public int totalJefeFuncionario { get; set; }
        public int totalPerfil { get; set; }
        public int totalCargo { get; set; }
        public int totalEvaluacion { get; set; }
        public int totalPreguntas { get; set; }
        public int totalAlternativas { get; set; }
        public int totalCompetencia { get; set; }
        public DataSet listaDashboard { get; set; }

        public CargarDashboard()
        {

        }

    }
}
