using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Clases
{
   public class CargarListaSubFormulario
    {
        public int id { get; set; }
        public DataSet lista { get; set; }
        public string mensaje { get; set; }

        public CargarListaSubFormulario(int id, DataSet lista, string mensaje)
        {
            this.id = id;
            this.lista = lista;
            this.mensaje = mensaje;
        }

        public CargarListaSubFormulario()
        {
        }
    }
}
