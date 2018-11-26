using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.WebService
{
    public class Cl_Curso
    {
        public string nombre { get; set; }
        public string sigla { get; set; }
        public string instituto { get; set; }
        public DateTime fecha { get; set; }

        public Cl_Curso(string nombre, string sigla, string instituto, DateTime fecha)
        {
            this.nombre = nombre;
            this.sigla = sigla;
            this.instituto = instituto;
            this.fecha = fecha;
        }

        public Cl_Curso()
        {
        }
    }
}
