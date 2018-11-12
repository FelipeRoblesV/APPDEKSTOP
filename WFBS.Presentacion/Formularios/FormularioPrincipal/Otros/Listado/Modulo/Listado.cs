using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado.Modulo
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        public void definirFormulario(DataSet lista)
        {
            if (lista != null)
            {
                dt_Listar.DataSource = lista.Tables[0];
            }
            else
            {
                dt_Listar.Visible = false;
                lblMensaje.Visible = true;
                
            }

        }
    }
}
