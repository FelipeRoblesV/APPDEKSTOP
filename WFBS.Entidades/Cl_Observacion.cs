using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Cl_Observacion
    {
        public int id { get; set; }
        public long mensaje { get; set; }
        public char estado { get; set; }
        public Cl_Nivel nivel { get; set; }
        public Cl_Competencia competencia { get; set; }
        public char is_nivel_alto { get; set; }

        public Cl_Observacion(int id, long mensaje, char estado, Cl_Nivel nivel, Cl_Competencia competencia, char is_nivel_alto)
        {
            this.id = id;
            this.mensaje = mensaje;
            this.estado = estado;
            this.nivel = nivel;
            this.competencia = competencia;
            this.is_nivel_alto = is_nivel_alto;
        }

        public Cl_Observacion()
        {
            nivel = new Cl_Nivel();
            competencia = new Cl_Competencia();
        }
    }
}
