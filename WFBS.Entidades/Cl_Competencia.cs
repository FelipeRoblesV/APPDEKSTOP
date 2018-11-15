using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Cl_Competencia
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string siglas { get; set; }
        public double nota_minima { get; set; }
        public double nota_maxima { get; set; }
        public double nota_esperada { get; set; }
        public char estado { get; set; }
        public Cl_Perfil perfil { get; set; }

        public Cl_Competencia(int id, string nombre, string descripcion, string siglas, double nota_minima, double nota_maxima, double nota_esperada, char estado, Cl_Perfil perfil)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.siglas = siglas;
            this.nota_minima = nota_minima;
            this.nota_maxima = nota_maxima;
            this.nota_esperada = nota_esperada;
            this.estado = estado;
            this.perfil = perfil;
        }

        public Cl_Competencia()
        {
            perfil = new Cl_Perfil();
        }
    }
}
