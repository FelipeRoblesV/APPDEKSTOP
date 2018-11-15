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
        private Modulo.Listado listaFuncionario,listaFuncionario_Cursos;
        private Modulo.Listado listaJefeFuncionario, listaJefeFuncionario_Cursos;
        private Modulo.Listado listaPerfil;
        private Modulo.Listado listaCargo;
        private Modulo.Listado listaCompetencia_Perfil, listaCompetencia, listaCompetencia_Observacion;
        private Modulo.Listado listaEvaluacion_Perfil, listarEvaluacion, listaEvaluacion_Pregunta, listaEvaluacion_Alternativa;

        private BackgroundWorker IniciarSubFormulario_Background;
        private CargarListaSubFormulario SubFormularioInicia;
        private double numero = 0;
        private int idPerfilCOMP = 0;

        public ListadoPrincipal()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

        #region DEFINIR FORMULARIO
        private void DefinirModulo(double numero)
        {
            switch (numero)
            {
                case 1:
                    lblTitulo.Text = "Formulario Funcionario";
                    break;
                case 1.1:
                    lblTitulo.Text = "Formulario Funcionario(CURSO)";
                    break;

                case 2:
                    lblTitulo.Text = "Formulario Jefe Funcionario";
                    break;
                case 2.1:
                    lblTitulo.Text = "Formulario Jefe Funcionario(CURSO)";
                    break;
                case 3:
                    lblTitulo.Text = "Formulario Perfil";
                    break;
                case 4:
                    lblTitulo.Text = "Formulario Cargo";
                    break;
                case 5:
                    lblTitulo.Text = "Formulario PERFIL(COMPETENCIA)";
                    break;
                case 5.1:
                    lblTitulo.Text = "Formulario COMPETENCIA(COMPETENCIA)";
                    break;
                case 5.2:
                    lblTitulo.Text = "Formulario OBSERVACION(COMPETENCIA)";
                    break;
                case 6:
                    lblTitulo.Text = "Formulario PERFIL(EVALUACION)";
                    break;
                case 6.1:
                    lblTitulo.Text = "Formulario EVALUACION(EVALUACION)";
                    break;
                case 6.2:
                    lblTitulo.Text = "Formulario PREGUNTA(EVALUACION)";
                    break;
                case 6.3:
                    lblTitulo.Text = "Formulario PREGUNTA(ALTERNATIVA)";
                    break;
            }
        }
        public void DefinirFormulario(double numero, DataSet listar, bool estado)
        {
            switch (numero)
            {
                case 1:
                    listaFuncionario = new Modulo.Listado();
                    listaFuncionario.definirFormulario(numero, listar, estado);
                    this.numero = numero;
                    DefinirModulo(numero);
                    AbrirFormulario(listaFuncionario);
                    break;
                case 1.1:
                    listaFuncionario_Cursos = new Modulo.Listado();
                    listaFuncionario_Cursos.definirFormulario(numero, listar, estado);
                    listaFuncionario_Cursos.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    AbrirFormulario(listaFuncionario_Cursos);
                    this.numero = numero;
                    break;
                case 2:
                    listaJefeFuncionario = new Modulo.Listado();
                    listaJefeFuncionario.definirFormulario(numero, listar, estado);
                    listaJefeFuncionario.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    AbrirFormulario(listaJefeFuncionario);
                    this.numero = numero;
                    break;
                case 2.2:
                    listaJefeFuncionario_Cursos = new Modulo.Listado();
                    listaJefeFuncionario_Cursos.definirFormulario(numero, listar, estado);
                    listaJefeFuncionario_Cursos.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    AbrirFormulario(listaJefeFuncionario_Cursos);
                    this.numero = numero;
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
                    listaCompetencia_Perfil = new Modulo.Listado();
                    listaCompetencia_Perfil.definirFormulario(numero, listar, estado);
                    listaCompetencia_Perfil.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    AbrirFormulario(listaCompetencia_Perfil);
                    this.numero = numero;
                    break;
                case 5.1:
                    listaCompetencia = new Modulo.Listado();
                    listaCompetencia.definirFormulario(numero, listar, estado);
                    listaCompetencia.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    AbrirFormulario(listaCompetencia);
                    this.numero = numero;
                    break;
                case 5.2:
                    listaCompetencia_Observacion = new Modulo.Listado();
                    listaCompetencia_Observacion.definirFormulario(numero, listar, estado);
                    listaCompetencia_Observacion.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    AbrirFormulario(listaCompetencia_Observacion);
                    this.numero = numero;
                    break;
                case 6:
                    listaEvaluacion_Perfil = new Modulo.Listado();
                    listaEvaluacion_Perfil.definirFormulario(numero, listar, estado);
                    listaEvaluacion_Perfil.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    AbrirFormulario(listaEvaluacion_Perfil);
                    this.numero = numero;
                    break;
                case 6.1:
                    listarEvaluacion = new Modulo.Listado();
                    listarEvaluacion.definirFormulario(numero, listar, estado);
                    listarEvaluacion.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    AbrirFormulario(listarEvaluacion);
                    this.numero = numero;
                    break;
                case 6.2:
                    listaEvaluacion_Pregunta = new Modulo.Listado();
                    listaEvaluacion_Pregunta.definirFormulario(numero, listar, estado);
                    listaEvaluacion_Pregunta.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    AbrirFormulario(listaEvaluacion_Pregunta);
                    this.numero = numero;
                    break;
                case 6.3:
                    listaEvaluacion_Alternativa = new Modulo.Listado();
                    listaEvaluacion_Alternativa.definirFormulario(numero, listar, estado);
                    listaEvaluacion_Alternativa.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    AbrirFormulario(listaEvaluacion_Alternativa);
                    this.numero = numero;
                    break;
            }
        }
        #endregion


        //private void IniciarSubFormulario(int numero)
        //{
        //    switch (numero)
        //    {
        //        case 1:
        //            if (IniciarSubFormulario_Background == null)
        //            {
        //                if (SubFormularioInicia == null)
        //                {
        //                    SubFormularioInicia = new CargarListaSubFormulario();
        //                }
        //                IniciarSubFormulario_Background = new BackgroundWorker();
        //                IniciarSubFormulario_Background.WorkerReportsProgress = true;
        //                IniciarSubFormulario_Background.DoWork += new DoWorkEventHandler(IniciarSubFormulario_DoWork);
        //                IniciarSubFormulario_Background.RunWorkerCompleted += new RunWorkerCompletedEventHandler(IniciarSubFormulario_RunWorkerCompleted);
        //                IniciarSubFormulario_Background.ProgressChanged += new ProgressChangedEventHandler(IniciarSubFormulario_ProgressChanged);
        //            }
        //            if (IniciarSubFormulario_Background.IsBusy == false)
        //            {
        //                SubFormularioInicia.id = idPerfilCOMP;
        //                IniciarSubFormulario_Background.RunWorkerAsync(SubFormularioInicia);
        //            }

        //            break;
        //    }
           
        //}

        //private void IniciarSubFormulario_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    AbrirFormulario(listarCompetenciaFinal);
        //}

        //private void IniciarSubFormulario_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    CargarListaSubFormulario iniciar = (CargarListaSubFormulario)e.UserState;
        //    listarCompetenciaFinal = new Modulo.Listado();

        //    try
        //    {
        //        DataSet lista = iniciar.lista;
        //        listarCompetenciaFinal.definirFormulario(1, lista, true);
        //    }
        //    catch (Exception)
        //    {
        //        DataSet lista = null;
        //        listarCompetenciaFinal.definirFormulario(1, lista, false);
        //    }




        //}

        //private void IniciarSubFormulario_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
        //    CargarListaSubFormulario iniciar = (CargarListaSubFormulario)e.Argument;

        //    switch (this.numero)
        //    {
        //        case 5:
        //            iniciar.mensaje = "Cargando Competencia";
        //            daoCompetencia daoCompetencia = new daoCompetencia();
        //            iniciar.lista = daoCompetencia.Listar(iniciar.id);
        //            IniciarAplicacion.ReportProgress(1, iniciar);

        //            break;
        //    }

        //}

        #region EVENTO DOBLE CLICK
        private void dt_Listar_DoubleClick(object sender, EventArgs e)
        {
            BunifuCustomDataGrid btn = sender as BunifuCustomDataGrid;

            switch (this.numero)
            {
                case 5:
                    if (btn.SelectedRows.Count.Equals(1))
                    {
                        idPerfilCOMP = int.Parse(btn.CurrentRow.Cells[1].Value.ToString());
                   //     IniciarSubFormulario(1);

                    }
                    break;
            }
        }

        #endregion

        #region BUSCAR | FILTRAR FORMULARIO
        private void txtBuscar_OnValueChanged(object sender, EventArgs e)
        {

            switch (this.numero)
            {
                case 1:
                    int numeroInterno = 0;
                    foreach (DataGridViewRow row in listaFuncionario.dt_Listar.Rows)
                    {
                        string resultadoRut = row.Cells[0].Value.ToString().ToLower();
                        string resultadorut2 = (row.Cells[0].Value.ToString().ToLower()).Replace("-", "");
                        string resultadorut3 = (row.Cells[0].Value.ToString().ToLower()).Remove(resultadoRut.Length - 2);
                        string resultadoNombre = row.Cells[1].Value.ToString().ToLower();
                        string resultadoApellido = row.Cells[2].Value.ToString().ToLower();
                        string resultadoSexo = row.Cells[3].Value.ToString().ToLower();
                        string resultadoRutJefe = row.Cells[7].Value.ToString().ToLower();
                        string resultadoNombreJefe = row.Cells[8].Value.ToString().ToLower();
                        string resultadoPerfil = row.Cells[9].Value.ToString().ToLower();


                        string texto = txtBuscar.Text.ToLower();

                        if (resultadoNombre == texto)
                        {
                            CurrencyManager cm = (CurrencyManager)BindingContext[listaFuncionario.dt_Listar.DataSource];
                            cm.SuspendBinding();
                            row.Visible = true;
                            lblError.Text = "Nombre del Funcionario.";
                            lblError.Visible = true;
                            numeroInterno = 1;
                        }
                        else if (resultadoRut == texto || resultadorut2 == texto || resultadorut3 == texto)
                        {
                            CurrencyManager cm = (CurrencyManager)BindingContext[listaFuncionario.dt_Listar.DataSource];
                            cm.SuspendBinding();
                            row.Visible = true;
                            lblError.Text = "Rut Del Funcionario";
                            lblError.Visible = true;
                            numeroInterno = 1;
                        }
                        else if (resultadoApellido == texto)
                        {
                            CurrencyManager cm = (CurrencyManager)BindingContext[listaFuncionario.dt_Listar.DataSource];
                            cm.SuspendBinding();
                            row.Visible = true;
                            lblError.Text = "Apellido del Funcionario.";
                            lblError.Visible = true;
                            numeroInterno = 1;
                        }
                        else if (resultadoSexo == texto)
                        {
                            CurrencyManager cm = (CurrencyManager)BindingContext[listaFuncionario.dt_Listar.DataSource];
                            cm.SuspendBinding();
                            row.Visible = true;
                            lblError.Text = "Sexo del Funcionario.";
                            lblError.Visible = true;
                            numeroInterno = 1;
                        }
                        else if (resultadoRutJefe == texto)
                        {
                            CurrencyManager cm = (CurrencyManager)BindingContext[listaFuncionario.dt_Listar.DataSource];
                            cm.SuspendBinding();
                            row.Visible = true;
                            lblError.Text = "rut del jefe de perfil";
                            lblError.Visible = true;
                            numeroInterno = 1;
                        }
                        else if (resultadoNombreJefe == texto)
                        {
                            CurrencyManager cm = (CurrencyManager)BindingContext[listaFuncionario.dt_Listar.DataSource];
                            cm.SuspendBinding();
                            row.Visible = true;
                            lblError.Text = "Nombre del Jefe de Perfil";
                            lblError.Visible = true;
                            numeroInterno = 1;
                        }
                        else if (resultadoPerfil == texto)
                        {
                            CurrencyManager cm = (CurrencyManager)BindingContext[listaFuncionario.dt_Listar.DataSource];
                            cm.SuspendBinding();
                            row.Visible = true;
                            lblError.Text = "Perfil del funcionario";
                            lblError.Visible = true;
                            numeroInterno = 1;
                        }
                        else
                        {
                            row.DataGridView.CurrentCell = null;
                            CurrencyManager cm = (CurrencyManager)BindingContext[listaFuncionario.dt_Listar.DataSource];
                            cm.SuspendBinding();
                            row.Visible = false;
                            if (numeroInterno == 0)
                            {
                                lblError.Text = "No hay Resultados de busqueda.";
                            }
                            lblError.Visible = true;
                        }
                    }
                    break;

            }
        }
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventArgs key = e as KeyEventArgs;


            if (key.KeyCode == Keys.Enter)
            {

                switch (this.numero)
                {
                    case 1:
                        foreach (DataGridViewRow row in listaFuncionario.dt_Listar.Rows)
                        {
                            txtBuscar.Text = String.Empty;
                            CurrencyManager cm = (CurrencyManager)BindingContext[listaFuncionario.dt_Listar.DataSource];
                            cm.SuspendBinding();
                            row.Visible = true;
                            lblError.Visible = false;
                        }
                        break;
                }


            }

            if (key.KeyCode == Keys.Back)
            {
                switch (this.numero)
                {
                    case 1:
                        if (txtBuscar.Text.Trim().Count() < 2)
                        {
                            foreach (DataGridViewRow row in listaFuncionario.dt_Listar.Rows)
                            {
                                txtBuscar.Text = String.Empty;
                                CurrencyManager cm = (CurrencyManager)BindingContext[listaFuncionario.dt_Listar.DataSource];
                                cm.SuspendBinding();
                                row.Visible = true;
                                lblError.Visible = false;
                            }
                        }
                        break;
                }
            }

        }
        #endregion

        #region ABRIR FORMULARIO
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
        #endregion
    }
}
