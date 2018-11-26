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
        public string mensaje { get; set; }
        public char estado { get; set; }
        public char is_nivel_alto { get; set; }
        public Cl_Competencia competencia { get; set; }

        public Cl_Observacion(int id, string mensaje, char estado, char is_nivel_alto)
        {
            this.id = id;
            this.mensaje = mensaje;
            this.estado = estado;
            this.is_nivel_alto = is_nivel_alto;
        }

        public Cl_Observacion()
        {
            competencia = new Cl_Competencia();
        }
    }
}
