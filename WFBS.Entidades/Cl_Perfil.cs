using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Cl_Perfil
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string abreviacion { get; set; }
        public char obsoleto { get; set; }
        public char estado { get; set; }

        public Cl_Perfil(int id, string nombre, string abreviacion, char obsoleto, char estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.abreviacion = abreviacion;
            this.obsoleto = obsoleto;
            this.estado = estado;
        }

        public Cl_Perfil()
        {
        }
    }
}
