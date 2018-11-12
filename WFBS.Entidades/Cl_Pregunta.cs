using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Cl_Preguntas
    {
        public int id { get; set; }
        public string cuerpo { get; set; }
        public char estado { get; set; }
        public Cl_Cuestionario cuestionario { get; set; }
        public Cl_Competencia competencia { get; set; }

        public Cl_Preguntas(int id, string cuerpo, char estado, Cl_Cuestionario cuestionario, Cl_Competencia competencia)
        {
            this.id = id;
            this.cuerpo = cuerpo;
            this.estado = estado;
            this.cuestionario = cuestionario;
            this.competencia = competencia;
        }

        public Cl_Preguntas()
        {
            cuestionario = new Cl_Cuestionario();
            competencia = new Cl_Competencia();
        }


    }
}
