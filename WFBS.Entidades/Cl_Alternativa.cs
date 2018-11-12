using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Cl_Alternativa
    {
        public int id { get; set; }
        public long cuerpo { get; set; }
        public double nota { get; set; }
        public char estado { get; set; }
        public Cl_Preguntas pregunta { get; set; }

        public Cl_Alternativa(int id, long cuerpo, double nota, char estado, Cl_Preguntas pregunta)
        {
            this.id = id;
            this.cuerpo = cuerpo;
            this.nota = nota;
            this.estado = estado;
            this.pregunta = pregunta;
        }

        public Cl_Alternativa()
        {
            pregunta = new Cl_Preguntas();
        }
    }
}
