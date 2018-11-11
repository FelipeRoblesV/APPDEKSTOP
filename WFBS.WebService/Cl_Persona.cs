using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.WebService
{
    public class Cl_Persona
    {
        public string run { get; set; }
        public char dv { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public char sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }

        public Cl_Persona(string run, char dv, string nombre, string apellido, char sexo, DateTime fechaNacimiento, string correo, int telefono)
        {
            this.run = run;
            this.dv = dv;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.fechaNacimiento = fechaNacimiento;
            this.correo = correo;
            this.telefono = telefono;
        }

        public Cl_Persona()
        {
        }
    }
}
