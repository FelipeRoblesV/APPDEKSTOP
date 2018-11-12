using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Cl_JefePerfil
    {
        public Cl_Funcionario funcionario { get; set; }
        public Cl_Perfil perfil { get; set; }

        public Cl_JefePerfil()
        {
            funcionario = new Cl_Funcionario();
            perfil = new Cl_Perfil();
        }

        public Cl_JefePerfil(Cl_Funcionario funcionario, Cl_Perfil perfil)
        {
            this.funcionario = funcionario;
            this.perfil = perfil;
        }
    }
}
