using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Presentacion.Formularios.Login.Modulo.Clases
{
    public class IniciarAplicacion
    {
        public string mensaje { get; set; }
        public DataSet listarFuncionario { get; set; }
        public DataSet listarJefeFuncionario { get; set; }
        public DataSet listarPerfil { get; set; }
        public DataSet listarCargo { get; set; }

        public IniciarAplicacion()
        {

        }
    }
}
