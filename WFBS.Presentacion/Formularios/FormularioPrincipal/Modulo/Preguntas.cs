using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Controlador;
using WFBS.Entidades;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Clases;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Otros;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo
{
    public partial class Preguntas : Form
    {
        private double numeroFormulario = 4.2;


        private int idPerfil, idEvaluacion, idPreguntas;

        private FormularioPrincipal formulario;
        private int numero = 0;
        private Cl_Preguntas preguntas;
        public Preguntas()
        {
            InitializeComponent();
        }

        private void llenarCombobox()
        {
            daoUtilidad dao = new daoUtilidad();

            DataSet perfil = dao.llenarComboboxCompetenciasDelPerfil(idPerfil);
            DataRow row = perfil.Tables[0].NewRow();
            row[1] = 0;
            row[0] = "<Seleccione una competencia>";
            perfil.Tables[0].Rows.InsertAt(row, 0);
            cbPerfil.DisplayMember = "Titulo";
            cbPerfil.ValueMember = "ID";
            cbPerfil.DataSource = perfil.Tables[0];
        }

        public void PasarDatos(FormularioPrincipal form)
        {
            this.formulario = form;
            idPerfil = form.RecuperaridDataGrid(4);
            idEvaluacion = form.RecuperaridDataGrid(5);
            llenarCombobox();
        }

        public void PasarDatos(Cl_Preguntas pre)
        {
            this.preguntas = pre;
        }


        public void limpiarFormulario()
        {
            cbPerfil.SelectedIndex = 0;
            txtPregunta.Text = String.Empty;
        }

        public void IniciarFormulario(int numero)
        {
            switch (numero)
            {
                case 1:
                    this.numero = numero;
                    btnAccion.Text = "Agregar Preguntas";
                    lblNombreFormulario.Text = "Agregar Preguntas";
                    break;
                case 2:
                    this.numero = numero;
                    btnAccion.Text = "Modificar Preguntas";
                    lblNombreFormulario.Text = "Modificar Preguntas";
                    llenarFormulario(preguntas);
                    break;
            }

        }

        public void llenarFormulario(Cl_Preguntas pre)
        {
            idPreguntas = pre.id;
            cbPerfil.SelectedValue = pre.competencia.id;
            txtPregunta.Text = pre.cuerpo; 
        }


        public Cl_Preguntas recuperarDatos()
        {
            Cl_Preguntas pre = new Cl_Preguntas();
            pre.competencia.id = int.Parse(cbPerfil.SelectedValue.ToString());
            pre.cuestionario.id = idEvaluacion;

            string pregunta = txtPregunta.Text.ToLower();
            pre.cuerpo = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(pregunta);
            pre.id = idPreguntas;

            return pre;
        }

        public bool ValidarFormulario()
        {
            bool respuesta = false;
            int contador = 0;

            if (cbPerfil.SelectedIndex != 0)
            {
                contador++;
                lblErrorPerfil.Visible = false;
            }
            else
            {
                lblErrorPerfil.Text = "Seleccione una competencia";
                lblErrorPerfil.Visible = true;
            }
            if (txtPregunta.Text != String.Empty)
            {
                contador++;
                lblErrorCuerpo.Visible = false;
            }
            else
            {
                lblErrorCuerpo.Text = "Ingrese datos en el campo cuerpo";
                lblErrorCuerpo.Visible = true;
            }


            if (contador == 2)
            {
                respuesta = true;
            }
            return respuesta;
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }


        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (this.numero)
            {
                case 1:

                    if (ValidarFormulario())
                    {
                        if (IniciarProceso.IsBusy == false)
                        {
                            IniciarProceso.RunWorkerAsync(recuperarDatos());
                        }
                    }
                    break;
                case 2:

                    if (ValidarFormulario())
                    {
                        if (IniciarProceso.IsBusy == false)
                        {
                            IniciarProceso.RunWorkerAsync(recuperarDatos());
                        }
                    }
                    break;
            }
        }


        private void IniciarProceso_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
            Cl_Preguntas pregunta = (Cl_Preguntas)e.Argument;
            CargarFormulario iniciar = new CargarFormulario();
            switch (this.numero)
            {
                case 1:
                    iniciar.Mensaje = "Agregando Pregunta";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoPreguntas dao = new daoPreguntas();
                        iniciar.respuesta = dao.Agregar(pregunta);


                        IniciarAplicacion.ReportProgress(2, iniciar);
                        System.Threading.Thread.Sleep(2500);
                        IniciarAplicacion.ReportProgress(3, iniciar);

                    }
                    catch (Exception)
                    {
                    }

                    break;
                case 2:
                    iniciar.Mensaje = "Modificando Pregunta";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoPreguntas dao = new daoPreguntas();
                        iniciar.respuesta = dao.Modificar(pregunta);
                        IniciarAplicacion.ReportProgress(2, iniciar);
                        System.Threading.Thread.Sleep(2500);
                        IniciarAplicacion.ReportProgress(3, iniciar);

                    }
                    catch (Exception)
                    {
                    }

                    break;
            }
        }
        private void IniciarProceso_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int porcentaje = e.ProgressPercentage;

            switch (this.numero)
            {
                case 1:
                    CargarFormulario iniciar = (CargarFormulario)e.UserState;
                    switch (porcentaje)
                    {

                        case 1:

                            Modulo.Otros.Cargando load = new Modulo.Otros.Cargando();
                            load.CambiarMensaje(iniciar.Mensaje);
                            formulario.AbrirModuloExterno(load);
                            break;
                        case 2:
                            Estado estado = new Estado();
                            estado.estado(iniciar.respuesta, 1);
                            formulario.AbrirModuloExterno(estado);
                            break;
                        case 3:
                            if (iniciar.respuesta)
                            {
                                formulario.recargarListados(4.21);
                                formulario.TerminarProceso(4.2);
                            }
                            else
                            {

                                formulario.AbrirModuloExterno(this);

                            }
                            break;




                    }
                    break;
                case 2:
                    CargarFormulario iniciar2 = (CargarFormulario)e.UserState;
                    switch (porcentaje)
                    {

                        case 1:

                            Modulo.Otros.Cargando load = new Modulo.Otros.Cargando();
                            load.CambiarMensaje(iniciar2.Mensaje);
                            formulario.AbrirModuloExterno(load);
                            break;
                        case 2:
                            Estado estado = new Estado();
                            estado.estado(iniciar2.respuesta, 2);
                            formulario.AbrirModuloExterno(estado);
                            break;
                        case 3:
                            if (iniciar2.respuesta)
                            {
                                formulario.recargarListados(4.21);
                                formulario.TerminarProceso(4.2);
                            }
                            else
                            {

                                formulario.AbrirModuloExterno(this);

                            }
                            break;




                    }
                    break;
            }
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            formulario.TerminarProceso(numeroFormulario);
        }



    }
}
