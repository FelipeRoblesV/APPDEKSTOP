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

        private BackgroundWorker iniciarSubFormulario;
        private CargarListaSubFormulario SubFormularioInicia;

        private double numero = 0, numero2 = 0;
        private int idComp = 0, idEva = 0;

        public FormularioPrincipal Formulario;


        public void PasarDatos(FormularioPrincipal form)
        {
            Formulario = form;
        }
        public ListadoPrincipal()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

        public void RestablecerNumero (double numero)
        {
            switch (numero)
            {
                case 3:
                    MessageBox.Show(this.numero.ToString());
                    InicializarMapaSitio();
                    this.numero = numero;
                    this.numero2 = 0;
                    AbrirFormulario(listaCompetencia_Perfil);
                    break;
                case 4:
                    MessageBox.Show(this.numero.ToString());
                    InicializarMapaSitio();
                    this.numero = numero;
                    this.numero2 = 0;
                    AbrirFormulario(listaEvaluacion_Perfil);
                    break;
            }

            
        }

        public bool isActive()
        {
            if (numero2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void InicializarListados()
        {
            if (listaFuncionario_Cursos != null)
            {
                listaFuncionario_Cursos.Close();
            }
            if (listaJefeFuncionario_Cursos != null)
            {
                listaJefeFuncionario_Cursos.Close();
            }
            if (listaCompetencia != null)
            {
                listaCompetencia.Close();
            }
            if (listaCompetencia_Observacion != null)
            {
                listaCompetencia_Observacion.Close();
            }
            if (listarEvaluacion != null)
            {
                listarEvaluacion.Close();
            }
            if (listaEvaluacion_Pregunta != null)
            {
                listaEvaluacion_Pregunta.Close();
            }
            if (listaEvaluacion_Alternativa != null)
            {
                listaEvaluacion_Alternativa.Close();
            }

        }

        private void InicializarMapaSitio()
        {
            panelMapaDeSitio.Visible = false;

            lblMapaSitio_1.Visible = false;
            lblMapaSitio_2.Visible = false;
            lblMapaSitio_3.Visible = false;
            lblMapaSitio_4.Visible = false;

            lblMapaSitio_1.ForeColor = Color.FromArgb(255, 196, 68);
            lblMapaSitio_2.ForeColor = Color.FromArgb(255, 196, 68);
            lblMapaSitio_3.ForeColor = Color.FromArgb(255, 196, 68);
            lblMapaSitio_4.ForeColor = Color.FromArgb(255, 196, 68);

            lblSeparacionMapa_1.ForeColor = Color.FromArgb(255, 196, 68);
            lblSeparacionMapa_2.ForeColor = Color.FromArgb(255, 196, 68);
            lblSeparacionMapa_3.ForeColor = Color.FromArgb(255, 196, 68);

            lblSeparacionMapa_1.Visible = false;

            lblSeparacionMapa_2.Visible = false;
            lblSeparacionMapa_3.Visible = false;
            btnRegresar.Visible = false;


        }

        private void DefinirMapaDeSitio( double numero)
        {
            switch (numero)
            {
                case 3.1:
                    InicializarMapaSitio();
                    panelMapaDeSitio.Visible = true;
                    lblMapaSitio_2.Visible = true;
                    lblMapaSitio_2.Text = "Competencia";
                    lblSeparacionMapa_1.Visible = true;
                    lblMapaSitio_1.Visible = true;
                    lblMapaSitio_1.Text = "Perfil";

                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;
                    break;
                case 3.2:
                    InicializarMapaSitio();
                    panelMapaDeSitio.Visible = true;
                    lblSeparacionMapa_2.Visible = true;
                    lblMapaSitio_3.Visible = true;
                    lblMapaSitio_3.Text = "Observacion";
                    lblMapaSitio_2.Visible = true;
                    lblMapaSitio_2.Text = "Competencia";
                    lblMapaSitio_2.ForeColor = Color.Gray;
                    lblSeparacionMapa_1.Visible = true;
                    lblMapaSitio_1.Visible = true;
                    lblMapaSitio_1.Text = "Perfil";

                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblSeparacionMapa_2.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;
                    break;

                case 4.1:
                    InicializarMapaSitio();
                    panelMapaDeSitio.Visible = true;
                    lblMapaSitio_2.Visible = true;
                    lblMapaSitio_2.Text = "Evaluacion";
                    lblSeparacionMapa_1.Visible = true;
                    lblMapaSitio_1.Visible = true;
                    lblMapaSitio_1.Text = "Perfil";

                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;
                    break;
                case 4.2:
                    InicializarMapaSitio();
                    panelMapaDeSitio.Visible = true;
                    lblSeparacionMapa_2.Visible = true;
                    lblMapaSitio_3.Visible = true;
                    lblMapaSitio_3.Text = "Preguntas";
                    lblMapaSitio_2.Visible = true;
                    lblMapaSitio_2.Text = "Evaluacion";
                    lblMapaSitio_2.ForeColor = Color.Gray;
                    lblSeparacionMapa_1.Visible = true;
                    lblMapaSitio_1.Visible = true;
                    lblMapaSitio_1.Text = "Perfil";

                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblSeparacionMapa_2.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;

                    break;
                case 4.3:
                    InicializarMapaSitio();
                    panelMapaDeSitio.Visible = true;
                    lblSeparacionMapa_3.Visible = true;
                    lblMapaSitio_3.Visible = true;
                    lblMapaSitio_3.Text = "Alternativa";
                    lblSeparacionMapa_2.Visible = true;
                    lblMapaSitio_3.Visible = true;
                    lblMapaSitio_3.Text = "Preguntas";
                    lblMapaSitio_3.ForeColor = Color.Gray;
                    lblMapaSitio_2.Visible = true;
                    lblMapaSitio_2.Text = "Evaluacion";
                    lblMapaSitio_2.ForeColor = Color.Gray;
                    lblSeparacionMapa_1.Visible = true;
                    lblMapaSitio_1.Visible = true;
                    lblMapaSitio_1.Text = "Perfil";

                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblSeparacionMapa_2.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;

                    break;
            }
        }

        #region DEFINIR FORMULARIO
        private void DefinirModulo(double numero)
        {
            switch (numero)
            {
                case 1.11:
                    lblTitulo.Text = "Formulario Funcionario";
                    break;
                case 1.12:
                    lblTitulo.Text = "Formulario Funcionario(CURSO)";
                    break;

                case 1.21:
                    lblTitulo.Text = "Formulario Jefe Funcionario";
                    break;
                case 1.22:
                    lblTitulo.Text = "Formulario Jefe Funcionario(CURSO)";
                    break;
                case 2.11:
                    lblTitulo.Text = "Formulario Perfil";
                    break;
                case 2.21:
                    lblTitulo.Text = "Formulario Cargo";
                    break;
                case 3:
                    InicializarMapaSitio();
                    lblTitulo.Text = "Formulario PERFIL(COMPETENCIA)";
                    lblDescripcion.Text = "Seleccione el perfil de la competencia";
                    
                    break;
                case 3.1:
                    lblTitulo.Text = "Formulario COMPETENCIA(COMPETENCIA)";
                    DefinirMapaDeSitio(numero);
                    break;
                case 3.2:
                    lblTitulo.Text = "Formulario OBSERVACION(COMPETENCIA)";
                    DefinirMapaDeSitio(numero);
                    break;
                case 4:
                    InicializarMapaSitio();
                    lblTitulo.Text = "Formulario PERFIL(EVALUACION)";
                    lblDescripcion.Text = "Seleccione el perfil de la evaluacion";
                    break;
                case 4.1:
                    DefinirMapaDeSitio(numero);
                    lblTitulo.Text = "Formulario EVALUACION(EVALUACION)";
                    break;
                case 4.2:
                    DefinirMapaDeSitio(numero);
                    lblTitulo.Text = "Formulario PREGUNTA(EVALUACION)";
                    break;
                case 4.3:
                    DefinirMapaDeSitio(numero);
                    lblTitulo.Text = "Formulario PREGUNTA(ALTERNATIVA)";
                    break;
            }
        }
        public void DefinirFormulario(double numero, DataSet listar, bool estado)
        {
            switch (numero)
            {
                case 1.11:
                    InicializarListados();
                    this.numero2 = 0;
                    this.numero = numero;
                    listaFuncionario = new Modulo.Listado();
                    listaFuncionario.definirFormulario(numero, listar, estado);
                    listaFuncionario.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);
                    
                    AbrirFormulario(listaFuncionario);
                    break;
                case 1.12:
                    listaFuncionario_Cursos = new Modulo.Listado();
                    listaFuncionario_Cursos.definirFormulario(numero, listar, estado);
                    AbrirFormulario(listaFuncionario_Cursos);
                    this.numero2 = numero;

                    break;
                case 1.21:
                    InicializarListados();
                    listaJefeFuncionario = new Modulo.Listado();
                    listaJefeFuncionario.definirFormulario(numero, listar, estado);
                    listaJefeFuncionario.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);
                    AbrirFormulario(listaJefeFuncionario);
                    this.numero = numero;
                    break;
                case 1.22:
                    InicializarListados();
                    listaJefeFuncionario_Cursos = new Modulo.Listado();
                    listaJefeFuncionario_Cursos.definirFormulario(numero, listar, estado);
                    DefinirModulo(numero);
                    AbrirFormulario(listaJefeFuncionario_Cursos);
                    this.numero2 = numero;
                    break;
                case 2.11:
                    InicializarListados();
                    this.numero = numero;
                    listaPerfil = new Modulo.Listado();
                    listaPerfil.definirFormulario(numero, listar, estado);
                    DefinirModulo(numero);
                    AbrirFormulario(listaPerfil);
                    break;
                case 2.21:
                    InicializarListados();
                    listaCargo = new Modulo.Listado();
                    listaCargo.definirFormulario(numero, listar, estado);
                    DefinirModulo(numero);
                    AbrirFormulario(listaCargo);
                    break;
                case 3:
                    InicializarListados();
                    this.numero = numero;
                    this.numero2 = 0;
                    listaCompetencia_Perfil = new Modulo.Listado();
                    listaCompetencia_Perfil.definirFormulario(numero, listar, estado);
                    listaCompetencia_Perfil.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);
                    AbrirFormulario(listaCompetencia_Perfil);

                    break;
                case 3.1:
                    this.numero2 = numero;
                    listaCompetencia = new Modulo.Listado();
                    listaCompetencia.definirFormulario(numero, listar, estado);
                    listaCompetencia.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    Formulario.GenerarControlesSubFormulario(3.1);
                    AbrirFormulario(listaCompetencia);
                    DefinirModulo(numero);
                    break;
                case 3.2:
                    this.numero2 = numero;
                    listaCompetencia_Observacion = new Modulo.Listado();
                    listaCompetencia_Observacion.definirFormulario(numero, listar, estado);
                    DefinirModulo(numero);
                    Formulario.GenerarControlesSubFormulario(3.2);
                    AbrirFormulario(listaCompetencia_Observacion);
                    
                    break;
                case 4:
                    InicializarListados();
                    this.numero = numero;
                    this.numero2 = 0;
                    listaEvaluacion_Perfil = new Modulo.Listado();
                    listaEvaluacion_Perfil.definirFormulario(numero, listar, estado);
                    listaEvaluacion_Perfil.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);
                    AbrirFormulario(listaEvaluacion_Perfil);
                    
                    break;
                case 4.1:
                    listarEvaluacion = new Modulo.Listado();
                    listarEvaluacion.definirFormulario(numero, listar, estado);
                    listarEvaluacion.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);
                    Formulario.GenerarControlesSubFormulario(4.1);
                    AbrirFormulario(listarEvaluacion);
                    this.numero2 = numero;
                    break;
                case 4.2:
                    listaEvaluacion_Pregunta = new Modulo.Listado();
                    listaEvaluacion_Pregunta.definirFormulario(numero, listar, estado);
                    listaEvaluacion_Pregunta.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);
                    Formulario.GenerarControlesSubFormulario(4.2);
                    AbrirFormulario(listaEvaluacion_Pregunta);
                    this.numero2 = numero;
                    break;
                case 4.3:
                    listaEvaluacion_Alternativa = new Modulo.Listado();
                    listaEvaluacion_Alternativa.definirFormulario(numero, listar, estado);
                    DefinirModulo(numero);
                    Formulario.GenerarControlesSubFormulario(4.3);
                    AbrirFormulario(listaEvaluacion_Alternativa);
                    this.numero2 = numero;
                    break;
            }
        }
        #endregion


        public double saberNumero()
        {
            return numero;
        }

        private void dt_Listar_DoubleClick(object sender, EventArgs e)
        {
            BunifuCustomDataGrid btn = sender as BunifuCustomDataGrid;

            switch (this.numero)
            {
                case 1.11:
                    if (btn.SelectedRows.Count.Equals(1))
                    {
             //           id = int.Parse(btn.CurrentRow.Cells[1].Value.ToString());
                        MessageBox.Show("1 FUNCIONARIO");
                    }
                    else
                    {
                        MessageBox.Show("2 FUNCIONARIO");
                    }
                    break;
                case 1.21:
                    if (btn.SelectedRows.Count.Equals(1))
                    {
                    //    id = int.Parse(btn.CurrentRow.Cells[1].Value.ToString());
                        MessageBox.Show("1 JEFE");
                    }
                    else
                    {
                        MessageBox.Show("2 JEFE");
                    }
                    break;
                case 3:

                    switch (this.numero2)
                    {
                        case 0:
                            if (btn.SelectedRows.Count.Equals(1))
                            {
                                idComp = int.Parse(btn.CurrentRow.Cells[1].Value.ToString());
                                IniciarSubFormulario();
                                MessageBox.Show("1 PERFIL COMP -" + idComp.ToString());
                            }
                            else
                            {
                                MessageBox.Show("2 PERFILCOMP");
                            }
                            break;
                        case 3.1:
                            if (btn.SelectedRows.Count.Equals(1))
                            {
                                idComp = int.Parse(btn.CurrentRow.Cells[0].Value.ToString());
                                IniciarSubFormulario();
                                MessageBox.Show("1 COMPETENCIA -" + idComp.ToString());
                            }
                            else
                            {
                                MessageBox.Show("2 COMPETENCIA");
                            }
                            break;
                    }

                    break;
                case 4:
                    switch (this.numero2)
                    {
                        case 0:
                            if (btn.SelectedRows.Count.Equals(1))
                            {
                                idEva = int.Parse(btn.CurrentRow.Cells[1].Value.ToString());
                                IniciarSubFormulario();
                                MessageBox.Show("1 EVALUACION " + idEva.ToString());
                            }
                            else
                            {
                                MessageBox.Show("2 EVALUACION");
                            }
                            break;
                        case 4.1:
                            if (btn.SelectedRows.Count.Equals(1))
                            {
                                idEva = int.Parse(btn.CurrentRow.Cells[0].Value.ToString());
                                IniciarSubFormulario();
                                MessageBox.Show("1 PREGUNTAS " + idEva.ToString());
                            }
                            else
                            {
                                MessageBox.Show("2 PREGUNTAS");
                            }
                            break;
                        case 4.2:
                            if (btn.SelectedRows.Count.Equals(1))
                            {
                                idEva = int.Parse(btn.CurrentRow.Cells[0].Value.ToString());
                                IniciarSubFormulario();
                                MessageBox.Show("1 ALTERNATIVAS " + idEva.ToString());
                            }
                            else
                            {
                                MessageBox.Show("2 ALTERNATIVAS");
                            }
                            break;
                    }
                    break;
    
                  
            }
        }


        private void IniciarSubFormulario_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
            CargarListaSubFormulario iniciar = (CargarListaSubFormulario)e.Argument;

            switch (this.numero)
            {
                case 3:

                    switch (this.numero2)
                    {
                        case 0:
                            iniciar.mensaje = "Cargando Competencia";
                            daoCompetencia daoCompetencia = new daoCompetencia();
                            iniciar.lista = daoCompetencia.Listar(iniciar.id);
                            IniciarAplicacion.ReportProgress(1, iniciar);
                            break;
                        case 3.1:
                            iniciar.mensaje = "Cargando Observacion";
                            daoObservacion daoObservacion = new daoObservacion();
                            iniciar.lista = daoObservacion.Listar(iniciar.id);
                            IniciarAplicacion.ReportProgress(2, iniciar);
                            break;

                    }
                    break;
                            
             

                case 4:
                    switch (this.numero2)
                    {
                        case 0:
                            iniciar.mensaje = "Cargando Evaluacion";
                            daoCuestionario daoCuestionario = new daoCuestionario();
                            iniciar.lista = daoCuestionario.Listar(iniciar.id);
                            IniciarAplicacion.ReportProgress(3, iniciar);
                            break;
                        case 4.1:
                            iniciar.mensaje = "Cargando Preguntas";
                            daoPreguntas daoPreguntas = new daoPreguntas();
                            iniciar.lista = daoPreguntas.Listar(iniciar.id);
                            IniciarAplicacion.ReportProgress(4, iniciar);
                            break;
                        case 4.2:
                            iniciar.mensaje = "Cargando Alternativas";
                            daoAlternativa daoAlternativa = new daoAlternativa();
                            iniciar.lista = daoAlternativa.Listar(iniciar.id);
                            IniciarAplicacion.ReportProgress(5, iniciar);
                            break;

                    }
                    break;



            }


        }


        private void IniciarSubFormulario_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CargarListaSubFormulario iniciar = (CargarListaSubFormulario)e.UserState;

            switch (this.numero)
            {
                case 3:
                    switch (this.numero2)
                    {
                        case 0:
                            try
                            {
                                DataSet lista = iniciar.lista;
                                this.DefinirFormulario(3.1, lista, true);
                                this.numero2 = 3.1;

                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                this.DefinirFormulario(3.1, lista, false);
                                this.numero2 = 3.1;
                            }
                            break;
                        case 3.1:
                            try
                            {
                                DataSet lista = iniciar.lista;
                                this.DefinirFormulario(3.2, lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                this.DefinirFormulario(3.2, lista, false);
                            }
                            break;
                    }
   
                    break;
                case 4:
                    try
                    {
                        DataSet lista = iniciar.lista;
                        this.DefinirFormulario(4.1, lista, true);
                        this.numero2 = 4.1;
                    }
                    catch (Exception)
                    {
                        DataSet lista = null;
                        this.DefinirFormulario(4.1, lista, false);
                        this.numero2 = 4.1;
                    }
                    break;
                case 4.1:
                    try
                    {
                        DataSet lista = iniciar.lista;
                        this.DefinirFormulario(4.2, lista, true);
                        this.numero2 = 4.2;
                    }
                    catch (Exception)
                    {
                        DataSet lista = null;
                        this.DefinirFormulario(4.2, lista, false);
                        this.numero2 = 4.2;
                    }
                    break;
                case 4.2:
                    try
                    {
                        listaEvaluacion_Alternativa = new Modulo.Listado();
                        DataSet lista = iniciar.lista;
                        this.DefinirFormulario(4.3, lista, true);

                        this.numero2 = 4.3;
                    }
                    catch (Exception)
                    {
                        DataSet lista = null;
                        this.DefinirFormulario(4.3, lista, false);
                        this.numero2 = 4.3;
                    }
                    break;
            }


            //    listarCompetenciaFinal = new Modulo.Listado();
        }

        private void IniciarSubFormulario()
        {
            SubFormularioInicia = null;

            if (iniciarSubFormulario == null)
            {
                iniciarSubFormulario = new BackgroundWorker();
                iniciarSubFormulario.WorkerReportsProgress = true;
                iniciarSubFormulario.DoWork += new DoWorkEventHandler(IniciarSubFormulario_DoWork);
                iniciarSubFormulario.ProgressChanged += new ProgressChangedEventHandler(IniciarSubFormulario_ProgressChanged);
            }
            if (SubFormularioInicia == null)
            {
                SubFormularioInicia = new CargarListaSubFormulario();
            }
            if (iniciarSubFormulario.IsBusy == false)
            {

                if(numero == 3)
                {
                    SubFormularioInicia.id = idComp;
                }
                if (numero == 4)
                {
                    SubFormularioInicia.id = idEva;
                }


                iniciarSubFormulario.RunWorkerAsync(SubFormularioInicia);
            }
        }

        #region EVENTO DOBLE CLICK


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
