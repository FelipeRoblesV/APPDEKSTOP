using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Cl_Jefe_Funcionario
    {
        public int run { get; set; }
        public string dv { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public char sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public char estado { get; set; }
        public Cl_Usuario usuario { get; set; }

        public Cl_Jefe_Funcionario(int run, string dv, string nombre, string apellido, char sexo, DateTime fechaNacimiento, string correo, int telefono, char estado, Cl_Usuario usuario)
        {
            this.run = run;
            this.dv = dv;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.fechaNacimiento = fechaNacimiento;
            this.correo = correo;
            this.telefono = telefono;
            this.estado = estado;
            this.usuario = usuario;
        }

        public Cl_Jefe_Funcionario()
        {
            usuario = new Cl_Usuario();
        }
    }
}
