using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Cl_Periodo
    {
        public int id { get; set; }
        public DateTime fecha_inicio { get; set; }
        public int dias { get; set; }
        public int ponderacion_evaluacion { get; set; }
        public int ponderacion_autoevaluacion { get; set; }
        public char estado { get; set; }
        public DateTime fecha_termino { get; set; }

        public Cl_Periodo(int id, DateTime fecha_inicio, int dias, int ponderacion_evaluacion, int ponderacion_autoevaluacion, char estado, DateTime fecha_termino)
        {
            this.id = id;
            this.fecha_inicio = fecha_inicio;
            this.dias = dias;
            this.ponderacion_evaluacion = ponderacion_evaluacion;
            this.ponderacion_autoevaluacion = ponderacion_autoevaluacion;
            this.estado = estado;
            this.fecha_termino = fecha_termino;
        }

        public Cl_Periodo()
        {
        }
    }
}
