using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Controlador;
using WFBS.Entidades;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Clases;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado.Modulo;
using WFBS.WebService;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado
{
    public partial class ListadoPrincipal : Form
    {
        public Modulo.Listado listaFuncionario, listaFuncionario_Cursos;
        public Modulo.Listado listaJefeFuncionario, listaJefeFuncionario_Cursos;
        public Modulo.Listado listaPerfil;
        public Modulo.Listado listaCargo;
        public Modulo.Listado listaCompetencia_Perfil, listaCompetencia, listaCompetencia_Observacion;
        public Modulo.Listado listaEvaluacion_Perfil, listarEvaluacion, listaEvaluacion_Pregunta, listaEvaluacion_Alternativa;

        private Cargando cargarFormulario;


        private BackgroundWorker iniciarSubFormulario;
        private CargarListaSubFormulario SubFormularioInicia;

        private double numero = 0, numero2 = 0;
        public int idPerfilComp = 0, idPerfilEva = 0, idEva = 0, idPre = 0, rutFun = 0, idCompetencia = 0;

        public FormularioPrincipal Formulario;

        public int Recuperarid(int numero)
        {
            switch (numero)
            {
                default:
                    return 0;
                case 1:
                    return rutFun;
                case 2:
                    return idPerfilComp;
                case 3:
                    return idCompetencia;
                case 4:
                    return idPerfilEva;
                case 5:
                    return idEva;
                case 6:
                    return idPre;
            }
        }


        public void PasarDatos(FormularioPrincipal form)
        {
            Formulario = form;
        }
        public ListadoPrincipal()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

        public void RestablecerNumero(double numero)
        {
            switch (numero)
            {
                case 1.11:
                    InicializarMapaSitio();
                    this.numero = numero;
                    this.numero2 = 0;
                    DefinirModulo(numero);
                    AbrirFormulario(listaFuncionario);
                    break;
                case 1.21:
                    InicializarMapaSitio();
                    this.numero = numero;
                    this.numero2 = 0;
                    DefinirModulo(numero);
                    AbrirFormulario(listaJefeFuncionario);
                    break;
                case 3:
                    InicializarMapaSitio();
                    this.numero = numero;
                    this.numero2 = 0;
                    DefinirModulo(numero);
                    AbrirFormulario(listaCompetencia_Perfil);
                    break;
                case 4:
                    InicializarMapaSitio();
                    this.numero = numero;
                    this.numero2 = 0;
                    DefinirModulo(numero);
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

            panel2.Size = new Size(91, 25);
            lblMapaSitio_1.Size = new Size(91, 25);
        }

        private void DefinirMapaDeSitio(double numero)
        {
            switch (numero)
            {
                case 1.11:
                    InicializarMapaSitio();
                    panel2.Size = new Size(121, 25);
                    lblMapaSitio_1.Size = new Size(121, 25);
                    panelMapaDeSitio.Visible = true;
                    lblMapaSitio_1.Text = "Funcionario";
                    lblMapaSitio_1.Visible = true;
                    lblSeparacionMapa_1.Visible = true;
                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;
                    break;
                case 1.12:
                    InicializarMapaSitio();
                    panelMapaDeSitio.Visible = true;
                    lblMapaSitio_2.Visible = true;
                    lblMapaSitio_2.Text = "Curso";
                    lblMapaSitio_1.Text = "Funcionario";
                    lblMapaSitio_1.Visible = true;
                    lblSeparacionMapa_1.Visible = true;
                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;
                    break;
                case 1.21:
                    InicializarMapaSitio();
                    panelMapaDeSitio.Visible = true;
                    lblMapaSitio_1.Text = "Jefe Funcionario";
                    lblMapaSitio_1.Visible = true;
                    lblSeparacionMapa_1.Visible = true;
                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;
                    break;
                case 1.22:
                    InicializarMapaSitio();
                    panelMapaDeSitio.Visible = true;
                    lblMapaSitio_2.Visible = true;
                    lblMapaSitio_2.Text = "Curso";
                    lblMapaSitio_1.Text = "Jefe Funcionario";
                    lblMapaSitio_1.Visible = true;
                    lblSeparacionMapa_1.Visible = true;
                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;
                    break;
                case 3.1:
                    InicializarMapaSitio();
                    panelMapaDeSitio.Visible = true;
                    lblMapaSitio_2.Visible = true;
                    lblMapaSitio_2.Text = "Competencia";
                    lblSeparacionMapa_1.Visible = true;
                    lblMapaSitio_1.Visible = true;
                    lblMapaSitio_1.Text = "Perfil";
                    btnRegresar.Visible = true ;
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
                    btnRegresar.Visible = true;
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
                    btnRegresar.Visible = true;
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
                    btnRegresar.Visible = true;
                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblSeparacionMapa_2.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;

                    break;
                case 4.3:
                    InicializarMapaSitio();
                    panelMapaDeSitio.Visible = true;
                    lblSeparacionMapa_3.Visible = true;
                    lblMapaSitio_4.Visible = true;
                    lblMapaSitio_4.Text = "Alternativa";
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
                    btnRegresar.Visible = true;
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

                    lblTitulo.Text = "Funcionario";
                    lblDescripcion.Visible = false;
                    DefinirMapaDeSitio(numero);
                    break;
                case 1.12:
                    lblTitulo.Text = "Cursos del Funcionario";
                    lblDescripcion.Text = "Aqui podras ver los cursos que a realizado el funcionario";
                    DefinirMapaDeSitio(numero);
                    break;

                case 1.21:
                    lblTitulo.Text = "Jefe Funcionario";
                    lblDescripcion.Visible = false;
                    DefinirMapaDeSitio(numero);
                    break;
                case 1.22:
                    lblTitulo.Text = "Cursos del Jefe";
                    lblDescripcion.Text = "Aqui podras ver los cursos que a realizado el funcionario";
                    DefinirMapaDeSitio(numero);
                    break;
                case 2.11:
                    lblTitulo.Text = "Perfil";
                    lblDescripcion.Visible = false;
                    break;
                case 2.21:
                    lblTitulo.Text = "Cargo";
                    lblDescripcion.Visible = false;
                    break;
                case 3:
                    InicializarMapaSitio();
                    lblTitulo.Text = "Perfil";
                    lblDescripcion.Text = "Seleccione el perfil de la competencia.";
                    lblDescripcion.Visible = true;
                    DefinirMapaDeSitio(numero);

                    break;
                case 3.1:
                    lblTitulo.Text = "Competencia";
                    lblDescripcion.Visible = false;
                    DefinirMapaDeSitio(numero);
                    break;
                case 3.2:
                    lblTitulo.Text = "Observacion";
                    lblDescripcion.Visible = false;
                    DefinirMapaDeSitio(numero);
                    break;
                case 4:
                    InicializarMapaSitio();
                    lblTitulo.Text = "Perfil ";
                    lblDescripcion.Text = "Seleccione el perfil de la evaluacion.";
                    lblDescripcion.Visible = true;
                    DefinirMapaDeSitio(numero);
                    break;
                case 4.1:
                    DefinirMapaDeSitio(numero);
                    lblTitulo.Text = "Evaluacion";
                    lblDescripcion.Visible = false;
                    break;
                case 4.2:
                    DefinirMapaDeSitio(numero);
                    lblTitulo.Text = "Preguntas";
                    lblDescripcion.Visible = false;
                    break;
                case 4.3:
                    DefinirMapaDeSitio(numero);
                    lblTitulo.Text = "Alternativas";
                    lblDescripcion.Visible = false;
                    break;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            switch (this.numero)
            {
                case 3:
                    switch (this.numero2)
                    {
                       case  3.1:
                            RestablecerNumero(3);
                            break;
                        case 3.2:
                            CargarFormulario(2, String.Empty);
                            this.numero2 = 3.1;
                            DefinirModulo(3.1);
                            Formulario.GenerarControlesSubFormulario(3.1);
                            AbrirFormulario(listaCompetencia);
                            DefinirMapaDeSitio(3.1);
                            break;
                    }
                    break;
                case 4:
                    switch (this.numero2)
                    {
                        case 4.1:
                            RestablecerNumero(4);
                            break;
                        case 4.2:
                            CargarFormulario(2, String.Empty);
                            this.numero2 = 4.1;
                            DefinirModulo(4.1);
                            Formulario.GenerarControlesSubFormulario(4.1);
                            AbrirFormulario(listarEvaluacion);
                            DefinirMapaDeSitio(4.1);
                            break;
                        case 4.3:
                            CargarFormulario(2, String.Empty);
                            this.numero2 = 4.2;
                            DefinirModulo(4.2);
                            Formulario.GenerarControlesSubFormulario(4.2);
                            AbrirFormulario(listaEvaluacion_Pregunta);
                            DefinirMapaDeSitio(4.2);
                            break;
                    }
                    break;
            }
        }

        private void lblMapaSitio_3_Click(object sender, EventArgs e)
        {

            switch (this.numero)
            {

                        case 4:
                    switch (this.numero2)
                    {
                        case 4.3:
                            CargarFormulario(2, String.Empty);
                            this.numero2 = 4.2;
                            DefinirModulo(4.2);
                            Formulario.GenerarControlesSubFormulario(4.2);
                            AbrirFormulario(listarEvaluacion);
                            DefinirMapaDeSitio(4.2);
                            break;

                    }
                    break;
            }
        }

        private void lblMapaSitio_2_Click(object sender, EventArgs e)
        {
            switch (this.numero)
            {
                case 3:
                    switch (this.numero2)
                    {
                        case 3.2:
                            CargarFormulario(2, String.Empty);
                            this.numero2 = 3.1;
                            DefinirModulo(numero);
                            Formulario.GenerarControlesSubFormulario(3.1);
                            AbrirFormulario(listaCompetencia);
                            DefinirMapaDeSitio(3.1);
                            break;
                    }
                    break;
                case 4:
                    switch (this.numero2)
                    {
                        case 4.2:
                            CargarFormulario(2, String.Empty);
                            this.numero2 = 4.1;
                            DefinirModulo(4.1);
                            Formulario.GenerarControlesSubFormulario(4.1);
                            AbrirFormulario(listaEvaluacion_Perfil);
                            DefinirMapaDeSitio(4.1);
                            break;

                    }
                    break;
            }
        }

        private void lblMapaSitio_1_Click(object sender, EventArgs e)
        {
            switch (this.numero)
            {
                case 3:
                    switch (this.numero2)
                    {
                        case 3.1:
                            RestablecerNumero(3);
                            break;
                    }
                    break;
                case 4:
                    switch (this.numero2)
                    {
                        case 4.1:
                            RestablecerNumero(4);
                            break;

                    }
                    break;
            }
        }

        public void ActualizarFormulario(double numero, DataSet listar, bool estado)
        {
            switch (numero)
            {
                case 1.11:
                    listaFuncionario.definirFormulario(numero, listar, estado);
                    break;
                case 1.21:
                    listaJefeFuncionario.definirFormulario(numero, listar, estado);
                    break;
                case 2.11:
                    listaPerfil.definirFormulario(numero, listar, estado);
                    break;
                case 2.21:
                    listaCargo.definirFormulario(numero, listar, estado);
                    break;
                case 3:
                    listaCompetencia_Perfil.definirFormulario(numero, listar, estado);
                    break;
                case 3.1:
                    listaCompetencia.definirFormulario(numero, listar, estado);
                    break;
                case 3.2:
                    listaCompetencia_Observacion.definirFormulario(numero, listar, estado);
                    break;
                case 4:
                    listaEvaluacion_Perfil.definirFormulario(numero, listar, estado);
                    break;
                case 4.1:
                    listarEvaluacion.definirFormulario(numero, listar, estado);
                    break;
                case 4.2:
                    listaEvaluacion_Pregunta.definirFormulario(numero, listar, estado);
                    break;
                case 4.3:
                    listaEvaluacion_Alternativa.definirFormulario(numero, listar, estado);
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
                    CargarFormulario(2, String.Empty);
                    this.numero2 = numero;
                    listaFuncionario_Cursos = new Modulo.Listado();
                    listaFuncionario_Cursos.definirFormulario(numero, listar, estado);
                    Formulario.GenerarControlesSubFormulario(1.12);
                    AbrirFormulario(listaFuncionario_Cursos);

                    break;
                case 1.21:
                    InicializarListados();
                    this.numero2 = 0;
                    listaJefeFuncionario = new Modulo.Listado();
                    listaJefeFuncionario.definirFormulario(numero, listar, estado);
                    listaJefeFuncionario.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);
                    AbrirFormulario(listaJefeFuncionario);
                    this.numero = numero;
                    break;
                case 1.22:
                    CargarFormulario(2, String.Empty);
                    this.numero2 = numero;
                    listaJefeFuncionario_Cursos = new Modulo.Listado();
                    listaJefeFuncionario_Cursos.definirFormulario(numero, listar, estado);
                    DefinirModulo(numero);
                    AbrirFormulario(listaJefeFuncionario_Cursos);
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
                    CargarFormulario(2, String.Empty);
                    this.numero2 = numero;
                    listaCompetencia = new Modulo.Listado();
                    listaCompetencia.definirFormulario(numero, listar, estado);
                    listaCompetencia.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    Formulario.GenerarControlesSubFormulario(3.1);
                    AbrirFormulario(listaCompetencia);
                    DefinirModulo(numero);
                    break;
                case 3.2:
                    CargarFormulario(2, String.Empty);
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
                    CargarFormulario(2, String.Empty);
                    listarEvaluacion = new Modulo.Listado();
                    listarEvaluacion.definirFormulario(numero, listar, estado);
                    listarEvaluacion.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);
                    Formulario.GenerarControlesSubFormulario(4.1);
                    AbrirFormulario(listarEvaluacion);
                    this.numero2 = numero;
                    break;
                case 4.2:
                    CargarFormulario(2, String.Empty);
                    listaEvaluacion_Pregunta = new Modulo.Listado();
                    listaEvaluacion_Pregunta.definirFormulario(numero, listar, estado);
                    listaEvaluacion_Pregunta.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);
                    Formulario.GenerarControlesSubFormulario(4.2);
                    AbrirFormulario(listaEvaluacion_Pregunta);
                    this.numero2 = numero;
                    break;
                case 4.3:
                    CargarFormulario(2, String.Empty);
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


            DataGridView btn = sender as DataGridView;
            if (Formulario.estadoActualCrud() == false)
            {
                switch (this.numero)
                {
                    case 1.11:
                        switch (this.numero2)
                        {
                            case 0:
                                if (btn.SelectedRows.Count.Equals(1))
                                {
                                    String rut = (btn.CurrentRow.Cells[0].Value.ToString().Replace("-", "").Trim());
                                    int run = int.Parse(rut.Substring(0, rut.Length - 1));
                                    rutFun = run;
                                    IniciarSubFormulario();
                                }
                                else
                                {
                                    SystemSounds.Hand.Play();
                                }
                                break;
                        }
                        break;
                    case 1.21:
                        switch (this.numero2)
                        {
                            case 0:
                                if (btn.SelectedRows.Count.Equals(1))
                                {
                                    String rut = (btn.CurrentRow.Cells[0].Value.ToString().Replace("-", "").Trim());
                                    int run = int.Parse(rut.Substring(0, rut.Length - 1));
                                    rutFun = run;
                                    IniciarSubFormulario();
                                }
                                else
                                {
                                    SystemSounds.Hand.Play();
                                }
                                break;
                        }
                        break;
                    case 3:

                        switch (this.numero2)
                        {
                            case 0:
                                if (btn.SelectedRows.Count.Equals(1))
                                {
                                    idPerfilComp = int.Parse(btn.CurrentRow.Cells[1].Value.ToString());
                                    IniciarSubFormulario();
                                }
                                else
                                {
                                    SystemSounds.Hand.Play();
                                }
                                break;
                            case 3.1:
                                if (btn.SelectedRows.Count.Equals(1))
                                {

                                    idCompetencia = int.Parse(btn.CurrentRow.Cells[0].Value.ToString());
                                    IniciarSubFormulario();
                                }
                                else
                                {
                                    SystemSounds.Hand.Play();
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
                                    idPerfilEva = int.Parse(btn.CurrentRow.Cells[1].Value.ToString());
                                    IniciarSubFormulario();
                                }
                                else
                                {
                                    SystemSounds.Hand.Play();
                                }
                                break;
                            case 4.1:
                                if (btn.SelectedRows.Count.Equals(1))
                                {
                                    idEva = int.Parse(btn.CurrentRow.Cells[0].Value.ToString());
                                    IniciarSubFormulario();
                                }
                                else
                                {
                                    SystemSounds.Hand.Play();
                                }
                                break;
                            case 4.2:
                                if (btn.SelectedRows.Count.Equals(1))
                                {
                                    idPre = int.Parse(btn.CurrentRow.Cells[0].Value.ToString());
                                    IniciarSubFormulario();
                                }
                                else
                                {
                                    SystemSounds.Hand.Play();
                                }
                                break;
                        }
                        break;


                }
            }
        }
        public void CargarFormulario(int estado, String mensaje)
        {
            switch (estado)
            {
                case 1:
                    cargarFormulario = new Cargando();
                    cargarFormulario.CambiarMensaje(mensaje);
                    AbrirFormulario(cargarFormulario);
                    break;
                case 2:
                    cargarFormulario.CerrarFormulario();
                    break;
            }
        }


        private void IniciarSubFormulario_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
            CargarListaSubFormulario iniciar = (CargarListaSubFormulario)e.Argument;
            switch (this.numero)
            {

                case 1.11:
                    switch (this.numero2)
                    {
                        case 0:
                            iniciar.mensaje = "Verificando cursos realizados.";
                            IniciarAplicacion.ReportProgress(1, iniciar);
                            try
                            {
                                daoWebService daoWebService = new daoWebService();
                                Cl_Persona per = new Cl_Persona();
                                per.run = iniciar.id.ToString();
                                List<Cl_Curso> lista = daoWebService.listarCursos(per);
                                DataTable dt = ConvertToDataTable(lista);
                                DataSet ds = new DataSet();
                                ds.Tables.Add(dt);
                                iniciar.lista = ds;
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }
                            catch (Exception)
                            {

                                iniciar.lista = null;
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }

                            break;
                    }
                    break;

                case 1.21:
                    switch (this.numero2)
                    {
                        case 0:
                            iniciar.mensaje = "Verificando cursos realizados.";
                            IniciarAplicacion.ReportProgress(1, iniciar);
                            try
                            {
                                daoWebService daoWebService = new daoWebService();
                                Cl_Persona per = new Cl_Persona();
                                per.run = iniciar.id.ToString();
                                List<Cl_Curso> lista = daoWebService.listarCursos(per);
                                DataTable dt = ConvertToDataTable(lista);
                                DataSet ds = new DataSet();
                                ds.Tables.Add(dt);
                                iniciar.lista = ds;
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }
                            catch (Exception)
                            {

                                iniciar.lista = null;
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }

                            break;
                    }
                    break;
                case 3:

                    switch (this.numero2)
                    {
                        case 0:
                            iniciar.mensaje = "Cargando Competencia";
                            IniciarAplicacion.ReportProgress(1, iniciar);
                            try
                            {
                                daoCompetencia daoCompetencia = new daoCompetencia();
                                iniciar.lista = daoCompetencia.Listar(iniciar.id);
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }
                            catch (Exception)
                            {

                                iniciar.lista = null;
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }

                            break;
                        case 3.1:
                            iniciar.mensaje = "Cargando Observacion";
                            IniciarAplicacion.ReportProgress(1, iniciar);
                            try
                            {
                                daoObservacion daoObservacion = new daoObservacion();
                                iniciar.lista = daoObservacion.Listar(iniciar.id);
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }
                            catch (Exception)
                            {

                                iniciar.lista = null;
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }

                            break;
                    }
                    break;
                case 4:
                    switch (this.numero2)
                    {
                        case 0:
                            iniciar.mensaje = "Cargando Evaluacion";
                            IniciarAplicacion.ReportProgress(1, iniciar);
                            try
                            {
                                daoCuestionario daoCuestionario = new daoCuestionario();
                                iniciar.lista = daoCuestionario.Listar(iniciar.id);
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }
                            catch (Exception)
                            {

                                iniciar.lista = null;
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }

                            break;
                        case 4.1:
                            iniciar.mensaje = "Cargando Preguntas";
                            IniciarAplicacion.ReportProgress(1, iniciar);
                            try
                            {
                                daoPreguntas daoPreguntas = new daoPreguntas();
                                iniciar.lista = daoPreguntas.Listar(iniciar.id);
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }
                            catch (Exception)
                            {

                                iniciar.lista = null;
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }

                            break;
                        case 4.2:
                            iniciar.mensaje = "Cargando Alternativas";
                            IniciarAplicacion.ReportProgress(1, iniciar);
                            try
                            {
                                daoAlternativa daoAlternativa = new daoAlternativa();
                                iniciar.lista = daoAlternativa.Listar(iniciar.id);
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }
                            catch (Exception)
                            {

                                iniciar.lista = null;
                                IniciarAplicacion.ReportProgress(2, iniciar);
                            }
                            break;

                    }
                    break;



            }


        }
        private void IniciarSubFormulario_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CargarListaSubFormulario iniciar = (CargarListaSubFormulario)e.UserState;
            int porcentaje = e.ProgressPercentage;

            switch (porcentaje)
            {
                case 1:
                    CargarFormulario(1, iniciar.mensaje);
                    break;
                case 2:
                    switch (this.numero)
                    {
                        case 1.11:
                            switch (this.numero2)
                            {
                                case 0:
                                    try
                                    {
                                        DataSet lista = iniciar.lista;
                                        if (lista != null)
                                        {
                                            this.DefinirFormulario(1.12, lista, true);

                                            this.numero2 = 1.12;
                                        }
                                        else
                                        {
                                            mensajeFuncionarioSinCursos();
                                        }


                                    }
                                    catch (Exception)
                                    {
                                        mensajeFuncionarioSinCursos();
                                    }
                                    break;
                            }
                            break;
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
                            switch (this.numero2)
                            {
                                case 0:
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
                            break;

                    }
                    break;

                    //    listarCompetenciaFinal = new Modulo.Listado();
            }
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

                switch (numero)
                {
                    case 1.11:
                        SubFormularioInicia.id = rutFun;
                        break;
                    case 1.21:
                        SubFormularioInicia.id = rutFun;
                        break;
                    case 3:
                        switch (this.numero2)
                        {
                            case 0:
                                SubFormularioInicia.id = idPerfilComp;
                                break;
                            case 3.1:
                                SubFormularioInicia.id = idCompetencia;
                                break;
                        }
                        break;

                    case 4:
                        switch (this.numero2)
                        {
                            case 0:
                                SubFormularioInicia.id = idPerfilEva;
                                break;
                            case 4.1:
                                SubFormularioInicia.id = idEva;
                                break;
                            case 4.2:
                                SubFormularioInicia.id = idPre;
                                break;
                        }
                        break;

                }

                iniciarSubFormulario.RunWorkerAsync(SubFormularioInicia);
            }
        }

        #region EVENTO DOBLE CLICK


        #endregion

        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection propiedades = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in propiedades)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in propiedades)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;

        }

        public void mensajeFuncionarioSinCursos()
        {
            AbrirFormulario(listaFuncionario);
            Ventanas.Mensaje mensaje = new Ventanas.Mensaje();
            mensaje.mensajeCursosFuncionario();
            mensaje.ShowDialog();
        }



        #region BUSCAR | FILTRAR FORMULARIO
        private void txtBuscar_OnValueChanged(object sender, EventArgs e)
        {
        //    MessageBox.Show(this.numero.ToString() + ' ' + this.numero2.ToString());
            switch (this.numero)
            {
                case 1.11:
                    switch (this.numero2)
                    {
                        case 0:
                            int numeroInterno = 0;
                            foreach (DataGridViewRow row in listaFuncionario.dt_Listar.Rows)
                            {
                                string resultadoRut = row.Cells[0].Value.ToString().ToLower();
                                string resultadorut2 = (row.Cells[0].Value.ToString().ToLower()).Replace("-", "");
                                string resultadorut3 = (row.Cells[0].Value.ToString().ToLower()).Remove(resultadoRut.Length - 2);
 

                                string texto = txtBuscar.Text.ToLower();


                                if (resultadoRut == texto || resultadorut2 == texto || resultadorut3 == texto)
                                {
                                    CurrencyManager cm = (CurrencyManager)BindingContext[listaFuncionario.dt_Listar.DataSource];
                                    cm.SuspendBinding();
                                    row.Visible = true;
                                    lblError.Text = "Rut Del Funcionario";
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
            try
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
            catch (InvalidOperationException)
            {

            }

        }
        #endregion
    }
}
