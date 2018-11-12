using Bunifu.Framework.UI;
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
using WFBS.Entidades;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Clases;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado.Modulo;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado
{
    public partial class ListadoPrincipal : Form
    {
        private Modulo.Listado listaFuncionario, listaJefeFuncionario, listaPerfil, listaCargo, listaCompetencia,listarCompetenciaFinal, listarObservacion, listaEvaluacion, listaReporte;
        private BackgroundWorker IniciarSubFormulario_Background;
        private Cl_Perfil perfil;
        private CargarListaSubFormulario SubFormularioInicia;
        private int numero = 0, idPerfilCOMP = 0;

        public ListadoPrincipal()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

        public void DefinirFormulario(int numero, DataSet listar,bool estado)
        {
            switch (numero)
            {
                case 1:
                    listaFuncionario = new Modulo.Listado();
                    listaFuncionario.definirFormulario(numero, listar, estado);
                    AbrirFormulario(listaFuncionario);
                    break;
                case 2:
                    listaJefeFuncionario = new Modulo.Listado();
                    listaJefeFuncionario.definirFormulario(numero, listar,estado);
                    AbrirFormulario(listaJefeFuncionario);
                    break;
                case 3:
                    listaPerfil = new Modulo.Listado();
                    listaPerfil.definirFormulario(numero, listar, estado);
                    AbrirFormulario(listaPerfil);
                    break;
                case 4:
                    listaCargo = new Modulo.Listado();
                    listaCargo.definirFormulario(numero, listar, estado);
                    AbrirFormulario(listaCargo);
                    break;
                case 5:
                    listaCompetencia = new Modulo.Listado();
                    listaCompetencia.definirFormulario(numero, listar, estado);
                    listaCompetencia.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    AbrirFormulario(listaCompetencia);
                    this.numero = numero;
                    break;
                case 6:
                    listaEvaluacion = new Modulo.Listado();
                    listaEvaluacion.definirFormulario(numero, listar, estado);
                    AbrirFormulario(listaEvaluacion);
                    break;
            }
        }




        private void IniciarSubFormulario(int numero)
        {
            switch (numero)
            {
                case 1:
                    if (IniciarSubFormulario_Background == null)
                    {
                        if (SubFormularioInicia == null)
                        {
                            SubFormularioInicia = new CargarListaSubFormulario();
                        }
                        IniciarSubFormulario_Background = new BackgroundWorker();
                        IniciarSubFormulario_Background.WorkerReportsProgress = true;
                        IniciarSubFormulario_Background.DoWork += new DoWorkEventHandler(IniciarSubFormulario_DoWork);
                        IniciarSubFormulario_Background.RunWorkerCompleted += new RunWorkerCompletedEventHandler(IniciarSubFormulario_RunWorkerCompleted);
                        IniciarSubFormulario_Background.ProgressChanged += new ProgressChangedEventHandler(IniciarSubFormulario_ProgressChanged);
                    }
                    if (IniciarSubFormulario_Background.IsBusy == false)
                    {
                        SubFormularioInicia.id = idPerfilCOMP;
                        IniciarSubFormulario_Background.RunWorkerAsync(SubFormularioInicia);
                    }

                    break;
            }
           
        }

        private void IniciarSubFormulario_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AbrirFormulario(listarCompetenciaFinal);
        }

        private void IniciarSubFormulario_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CargarListaSubFormulario iniciar = (CargarListaSubFormulario)e.UserState;
            listarCompetenciaFinal = new Modulo.Listado();

            try
            {
                DataSet lista = iniciar.lista;
                listarCompetenciaFinal.definirSubFormulario(1, lista, true);
            }
            catch (Exception)
            {
                DataSet lista = null;
                listarCompetenciaFinal.definirSubFormulario(1, lista, false);
            }




        }

        private void IniciarSubFormulario_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
            CargarListaSubFormulario iniciar = (CargarListaSubFormulario)e.Argument;

            switch (this.numero)
            {
                case 5:
                    iniciar.mensaje = "Cargando Competencia";
                    daoCompetencia daoCompetencia = new daoCompetencia();
                    iniciar.lista = daoCompetencia.Listar(iniciar.id);
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    break;
            }

        }

        private void dt_Listar_DoubleClick(object sender, EventArgs e)
        {
            BunifuCustomDataGrid btn = sender as BunifuCustomDataGrid;

            switch (this.numero)
            {
                case 5:
                    if (btn.SelectedRows.Count.Equals(1))
                    {
                        idPerfilCOMP = int.Parse(btn.CurrentRow.Cells[1].Value.ToString());
                        IniciarSubFormulario(1);

                    }
                    break;
            }
        }



        private void AbrirFormulario(object formHijo)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();
        }
    }
}
