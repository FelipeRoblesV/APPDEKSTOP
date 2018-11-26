using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
   public class Cl_Funcionario_Cargo
    {

        public Cl_Funcionario funcionario { get; set; }
        public Cl_Cargo cargo { get; set; }

        public Cl_Funcionario_Cargo()
        {
            funcionario = new Cl_Funcionario();
            cargo = new Cl_Cargo();
        }
    }
}
