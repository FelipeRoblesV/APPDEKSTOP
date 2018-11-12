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
        public Cl_Perfil perfil { get; set; }
        public Cl_Periodo periodo { get; set; }

        public Cl_Cuestionario(int id, string nombre, char estado, Cl_Perfil perfil, Cl_Periodo periodo)
        {
            this.id = id;
            this.nombre = nombre;
            this.estado = estado;
            this.perfil = perfil;
            this.periodo = periodo;
        }

        public Cl_Cuestionario()
        {
            perfil = new Cl_Perfil();
            periodo = new Cl_Periodo();
        }
    }
}
