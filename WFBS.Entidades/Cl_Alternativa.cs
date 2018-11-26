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
        public string cuerpo { get; set; }
        public double nota { get; set; }
        public double notaMinima { get; set; }
        public double notaMaxima { get; set; }
        public char estado { get; set; }
        public Cl_Preguntas pregunta { get; set; }



        public Cl_Alternativa()
        {
            pregunta = new Cl_Preguntas();
        }
    }
}
