using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado.Modulo;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado
{
    public partial class ListadoPrincipal : Form
    {
        private Modulo.Listado listaFuncionario, listaJefeFuncionario, listaPerfil, listaCargo, listaCompetencia, listaEvaluacion, listaReporte;

        public ListadoPrincipal()
        {
            InitializeComponent();
        }

        public void DefinirFormulario(int numero, DataSet listar)
        {
            switch (numero)
            {
                case 1:
                    listaFuncionario = new Modulo.Listado();
                    listaFuncionario.definirFormulario(listar);
                    break;
                case 2:
                    listaJefeFuncionario = new Modulo.Listado();
                    listaJefeFuncionario.definirFormulario(listar);
                    break;
                case 3:
                    listaPerfil = new Modulo.Listado();
                    listaPerfil.definirFormulario(listar);
                    break;
                case 4:
                    listaCargo = new Modulo.Listado();
                    listaCargo.definirFormulario(listar);
                    break;
                case 5:
                    listaCompetencia = new Modulo.Listado();
                    listaCompetencia.definirFormulario(listar);
                    break;
                case 6:
                    listaEvaluacion = new Modulo.Listado();
                    listaEvaluacion.definirFormulario(listar);
                    break;
                case 7:
                    listaReporte = new Modulo.Listado();
                    listaReporte.definirFormulario(listar);
                    break;
            }
        }
    }
}
