using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Cl_Nivel
    {
        public int id { get; set; }
        public double nota_minima { get; set; }
        public double nota_maxima { get; set; }
        public double nota_esperada { get; set; }
        public char estado { get; set; }

        public Cl_Nivel(int id, double nota_minima, double nota_maxima, double nota_esperada, char estado)
        {
            this.id = id;
            this.nota_minima = nota_minima;
            this.nota_maxima = nota_maxima;
            this.nota_esperada = nota_esperada;
            this.estado = estado;
        }

        public Cl_Nivel()
        {
        }
    }
}
