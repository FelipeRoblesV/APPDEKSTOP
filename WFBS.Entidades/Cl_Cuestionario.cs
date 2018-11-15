using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Cl_Cuestionario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public char estado { get; set; }
        public DateTime fecha_inicio { get; set; }
        public int dias { get; set; }
        public int ponderacion_evaluacion { get; set; }
        public int ponderacion_autoevaluacion { get; set; }
        public DateTime fecha_termino { get; set; }
        public Cl_Perfil perfil { get; set; }

        public Cl_Cuestionario(int id, string nombre, char estado, DateTime fecha_inicio, int dias, int ponderacion_evaluacion, int ponderacion_autoevaluacion, DateTime fecha_termino, Cl_Perfil perfil)
        {
            this.id = id;
            this.nombre = nombre;
            this.estado = estado;
            this.fecha_inicio = fecha_inicio;
            this.dias = dias;
            this.ponderacion_evaluacion = ponderacion_evaluacion;
            this.ponderacion_autoevaluacion = ponderacion_autoevaluacion;
            this.fecha_termino = fecha_termino;
            this.perfil = perfil;
        }

        public Cl_Cuestionario()
        {
            perfil = new Cl_Perfil();
        }
    }
}
