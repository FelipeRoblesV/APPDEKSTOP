using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Controlador;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Clases;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros
{
    public partial class Dashboard : Form
    {
        private FormularioPrincipal form;
        public Dashboard()
        {
            InitializeComponent();
            lblUsuario.Text = Properties.Settings.Default.UsuarioConectado;
        }

        public void pasarDatos(FormularioPrincipal formulario)
        {
            form = formulario;
        }
        public void IniciarAplicacion()
        {
            CargarDashboard cargar = new CargarDashboard();
            IniciarDashboard.RunWorkerAsync(cargar);
        }

        private void Actualizacion_Formulario_Tick(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void IniciarDashboard_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
            CargarDashboard iniciar = (CargarDashboard)e.Argument;

            iniciar.mensaje = "Iniciando Dashboard";
            IniciarAplicacion.ReportProgress(1, iniciar);

            daoDashboard dao = new daoDashboard();
            iniciar.totalFuncionario = dao.TotalFuncionario();
            iniciar.totalJefeFuncionario = dao.totalJefeFuncionario();
            iniciar.totalCargo = dao.totalCargo();
            iniciar.totalPerfil = dao.totalPerfil();
            iniciar.totalPreguntas = dao.totalPreguntas();
            iniciar.totalAlternativas = dao.totalAlternativas();
            iniciar.totalCompetencia = dao.totalCompetencia();
            iniciar.totalEvaluacion = dao.totalEvaluacion();
            iniciar.listaDashboard = dao.listar();
            IniciarAplicacion.ReportProgress(2, iniciar);
        }

        private void IniciarDashboard_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CargarDashboard iniciar = (CargarDashboard)e.UserState;
            int numero = e.ProgressPercentage;

            switch (numero)
            {
                case 1:
                    form.CargandoFormulario(iniciar.mensaje);
                    break;
                case 2:
                    lblTotaFuncionario.Text = iniciar.totalFuncionario.ToString();
                    lblTotalJefeFuncionario.Text = iniciar.totalJefeFuncionario.ToString();
                    lblTotalCargo.Text = iniciar.totalCargo.ToString();
                    lblTotalPerfil.Text = iniciar.totalPerfil.ToString();
                    lblTotalPreguntas.Text = iniciar.totalPreguntas.ToString();
                    lblTotalAlternativa.Text = iniciar.totalAlternativas.ToString();
                    lblTotalCompetencia.Text = iniciar.totalCompetencia.ToString();
                    lblTotalEvaluacion.Text = iniciar.totalEvaluacion.ToString();
                    lblUsuario.Text = Properties.Settings.Default.UsuarioConectado;
                    break;
            }
        }

        private void IniciarDashboard_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            form.TerminarDashboard();
        }
    }
}
