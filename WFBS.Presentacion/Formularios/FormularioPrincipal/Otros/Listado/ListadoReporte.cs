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
using WFBS.Presentacion.Formularios.FormularioPrincipal.Clases;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado
{
    public partial class ListadoReporte : Form
    {
        private Modulo.Listado listaReporte_Perfil, listaReporte_Evaluacion, listaReporte;

        private Cargando cargarFormulario;
        private BackgroundWorker iniciarSubFormulario;
        private CargarReporte SubFormularioInicia;

        private int numero = 0;
        private int idPer = 0, idEva = 0;

        public FormularioPrincipal Formulario;


        public void PasarDatos(FormularioPrincipal form)
        {
            Formulario = form;
        }

        public ListadoReporte()
        {
            InitializeComponent();
        }


        public void RestablecerNumero(int numero)
        {
            switch (numero)
            {
                case 2:
                    InicializarMapaSitio();
                    this.numero = 1;
                    AbrirFormulario(listaReporte_Perfil);
                    break;
                case 3:
                    InicializarMapaSitio();
                    this.numero = 1;
                    AbrirFormulario(listaReporte_Evaluacion);
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
            if (listaReporte_Evaluacion != null)
            {
                listaReporte_Evaluacion.Close();
            }
            if (listaReporte != null)
            {
                listaReporte.Close();
            }
        }

        private void InicializarMapaSitio()
        {
            panelMapaSitio.Visible = false;

            lblMapaSitio_1.Visible = false;
            lblMapaSitio_2.Visible = false;
            lblMapaSitio_3.Visible = false;


            lblMapaSitio_1.ForeColor = Color.FromArgb(255, 196, 68);
            lblMapaSitio_2.ForeColor = Color.FromArgb(255, 196, 68);
            lblMapaSitio_3.ForeColor = Color.FromArgb(255, 196, 68);

            lblSeparacion_1.ForeColor = Color.FromArgb(255, 196, 68);
            lblSeparacion_2.ForeColor = Color.FromArgb(255, 196, 68);

            lblSeparacion_2.Visible = false;
            lblSeparacion_2.Visible = false;
            lblSeparacion_2.Visible = false;

            btnRegresar.Visible = false;

        }

        private void DefinirMapaDeSitio(double numero)
        {
            switch (numero)
            {
                case 2:
                    InicializarMapaSitio();
                    panelMapaSitio.Visible = true;
                    lblMapaSitio_2.Visible = true;
                    lblMapaSitio_2.Text = "Evaluacion";
                    lblSeparacion_2.Visible = true;
                    lblMapaSitio_1.Visible = true;
                    lblMapaSitio_1.Text = "Perfil";

                    lblSeparacion_1.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;
                    break;
                case 3:
                    InicializarMapaSitio();
                    panelMapaSitio.Visible = true;
                    lblSeparacion_2.Visible = true;
                    lblMapaSitio_3.Visible = true;
                    lblMapaSitio_3.Text = "Reporte General";
                    lblMapaSitio_2.Visible = true;
                    lblMapaSitio_2.Text = "Evaluacion";
                    lblMapaSitio_2.ForeColor = Color.Gray;
                    lblSeparacion_1.Visible = true;
                    lblMapaSitio_1.Visible = true;
                    lblMapaSitio_1.Text = "Perfil";

                    lblSeparacion_1.ForeColor = Color.Gray;
                    lblSeparacion_2.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;
                    break;
            }
        }

        #region DEFINIR FORMULARIO
        private void DefinirModulo(double numero)
        {
            switch (numero)
            {
                case 1:
                    InicializarMapaSitio();
                    lblTitulo.Text = "Formulario PERFIL(REPORTE)";
                    lblDescripcion.Text = "Seleccione el perfil de la evaluacion";
                    break;
                case 2:
                    lblTitulo.Text = "Formulario EVALUACION(COMPETENCIA)";
                    DefinirMapaDeSitio(numero);
                    break;

                case 3:
                    lblTitulo.Text = "Formulario REPORTE(COMPETENCIA)";
                    DefinirMapaDeSitio(numero);
                    break;

            }
        }
        public void DefinirFormulario(int numero, DataSet listar, bool estado)
        {
            switch (numero)
            {
                case 1:
                    InicializarListados();
                    this.numero = numero;
                    listaReporte_Perfil = new Modulo.Listado();
                    listaReporte_Perfil.definirReporte(numero, listar, estado);
                    listaReporte_Perfil.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);

                    AbrirFormulario(listaReporte_Perfil);
                    break;
                case 2:
                    this.numero = numero;
                    listaReporte_Evaluacion = new Modulo.Listado();
                    listaReporte_Evaluacion.definirReporte(numero, listar, estado);
                    listaReporte_Evaluacion.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);
                    AbrirFormulario(listaReporte_Evaluacion);

                    break;
                case 3:
                    listaReporte = new Modulo.Listado();
                    listaReporte.definirFormulario(numero, listar, estado);
                    DefinirModulo(numero);
                    AbrirFormulario(listaReporte);
                    this.numero = numero;
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
                case 1:

                    if (btn.SelectedRows.Count.Equals(1))
                    {
                        idPer = int.Parse(btn.CurrentRow.Cells[0].Value.ToString());
                        IniciarSubFormulario();
                        MessageBox.Show("1 PERFIL REPORTE");
                    }
                    else
                    {
                        MessageBox.Show("2 PERFIL REPORTE");
                    }
                    break;


                case 2:
                    if (btn.SelectedRows.Count.Equals(1))
                    {
                        idEva = int.Parse(btn.CurrentRow.Cells[0].Value.ToString());
                        IniciarSubFormulario();
                        MessageBox.Show("1 EVALUACION REPORTE");
                    }
                    else
                    {
                        MessageBox.Show("2 EVALUACION REPORTE");
                    }
                    break;
            }
        }

        private void IniciarSubFormulario_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
            CargarReporte iniciar = (CargarReporte)e.Argument;
            switch (this.numero)
            {

                case 1:

                    iniciar.mensaje = "Cargando Evaluaciones";
                    IniciarAplicacion.ReportProgress(1, iniciar);
                    try
                    {
                        daoReporte dao = new daoReporte();

                        iniciar.lista = dao.listarEvaluacion(iniciar.id_Perfil);
                        IniciarAplicacion.ReportProgress(2, iniciar);
                    }
                    catch (Exception)
                    {

                        iniciar.lista = null;
                        IniciarAplicacion.ReportProgress(2, iniciar);
                    }

                    break;

                case 2:

                    iniciar.mensaje = "Cargando Reporte";
                    IniciarAplicacion.ReportProgress(1, iniciar);
                    try
                    {
                        daoReporte dao = new daoReporte();

                        iniciar.lista = dao.Listar(iniciar.id_Perfil, iniciar.id_Evaluacion);
                        IniciarAplicacion.ReportProgress(2, iniciar);
                    }
                    catch (Exception)
                    {

                        iniciar.lista = null;
                        IniciarAplicacion.ReportProgress(2, iniciar);
                    }

                    break;
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

        private void IniciarSubFormulario_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CargarReporte iniciar = (CargarReporte)e.UserState;
            int porcentaje = e.ProgressPercentage;

            switch (porcentaje)
            {
                case 1:
                    CargarFormulario(1, iniciar.mensaje);
                    break;
                case 2:
                    switch (this.numero)
                    {
                        case 1:
                            try
                            {
                                DataSet lista = iniciar.lista;
                                this.DefinirFormulario((numero + 1), lista, true);

                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                this.DefinirFormulario((numero + 1), lista, false);
                            }
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.lista;
                                this.DefinirFormulario((numero + 1), lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                this.DefinirFormulario((numero + 1), lista, false);
                            }
                            break;
                    }
                    break;



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
                SubFormularioInicia = new CargarReporte();
            }
            if (iniciarSubFormulario.IsBusy == false)
            {
                if (numero == 1)
                {
                    SubFormularioInicia.id_Perfil = idPer;
                }
                if (numero == 2)
                {
                    SubFormularioInicia.id_Evaluacion = idEva;
                }


                iniciarSubFormulario.RunWorkerAsync(SubFormularioInicia);
            }
        }

        private void panelContenido_DoubleClick(object sender, EventArgs e)
        {

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
