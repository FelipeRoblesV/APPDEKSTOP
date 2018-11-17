using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo
{
    public partial class Evaluacion : Form
    {
        public Evaluacion()
        {
            InitializeComponent();
        }

        public void AgregarFuncionario()
        {
            dtpFechaInicio.MinDate = DateTime.Today;
            lblNombreFormulario.Text = "Agregar Funcionario";
            tbPonderacion.Value = 70;
        }

        private void Inicializar()
        {
            txtNombre.Text = String.Empty;
            txtDiasHabiles.Text = String.Empty;
            dtpFechaInicio.Value = DateTime.Today;
            tbPonderacion.Value = 1;
        }




        private void btnBotonesPrincipales_Click(object sender, EventArgs e)
        {
            BunifuFlatButton btn = sender as BunifuFlatButton;
        }

        private void tbPonderacion_ValueChanged(object sender, EventArgs e)
        {
            if (tbPonderacion.Value < 1)
            {
                tbPonderacion.Value = 1;
            }

            if (tbPonderacion.Value > 99)
            {
                tbPonderacion.Value = 99;
            }
            lblPonderacionAuto.Text = tbPonderacion.Value.ToString() + '%';
            lblPonderacionEvaluacion.Text = (100 - tbPonderacion.Value).ToString() + '%';
        }
    }
}
