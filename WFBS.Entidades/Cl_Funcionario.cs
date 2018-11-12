using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Cl_Funcionario
    {
        public int run { get; set; }
        public char dv { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public char sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public char estado { get; set; }
        public Cl_Jefe_Funcionario jefe_funcionario { get; set; }
        public Cl_Usuario usuario { get; set; }
        public Cl_Perfil perfil { get; set; }

        public Cl_Funcionario(int run, char dv, string nombre, string apellido, char sexo, DateTime fechaNacimiento, string correo, int telefono, char estado, Cl_Jefe_Funcionario jefe_funcionario, Cl_Usuario usuario, Cl_Perfil perfil)
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
            this.jefe_funcionario = jefe_funcionario;
            this.usuario = usuario;
            this.perfil = perfil;
        }

        public Cl_Funcionario()
        {
            perfil = new Cl_Perfil();
            usuario = new Cl_Usuario();
            jefe_funcionario = new Cl_Jefe_Funcionario();
        }


    }
}
