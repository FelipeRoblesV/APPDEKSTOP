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
using WFBS.Controlador;
using WFBS.Entidades;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Clases;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Otros;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo
{
    public partial class Evaluacion : Form
    {
        private double numeroFormulario = 4.1;
        private int idEvaluacion = 0, idPerfil = 0;
        private FormularioPrincipal formulario;
        private int numero = 0;
        private Cl_Cuestionario evaluacion;

        public Evaluacion()
        {
            InitializeComponent();
        }

        public void PasarDatos(FormularioPrincipal form)
        {
            this.formulario = form;
            idPerfil = form.RecuperaridDataGrid(4);


        }

        public void limpiarFormulario()
        {
            txtNombre.Text = String.Empty;
            dtpFechaInicio.Value = DateTime.Today;

            lblFechaTermino.Text = dtpFechaInicio.Value.ToLongDateString();
            btnsPonderacion.Value = false;
            numDiasHabiles.Value = 1;
            tbPonderacion.Value = 30;
        }


        public void PasarDatos(Cl_Cuestionario eva)
        {
            this.evaluacion = eva;
        }


        public void IniciarFormulario(int numero)
        {
            switch (numero)
            {
                case 1:
                    this.numero = numero;
                    btnAccion.Text = "Agregar Evaluacion";
                    lblNombreFormulario.Text = "Agregar Evaluacion";
                    dtpFechaInicio.MinDate = DateTime.Today;

                    DateTime hoy = DateTime.Today;
                    lblFechaTermino.Text = hoy.AddDays(1).ToLongDateString() ;

                    break;
                case 2:
                    this.numero = numero;
                    btnAccion.Text = "Modificar Evaluacion";
                    lblNombreFormulario.Text = "Modificar Evaluacion";
                    llenarFormulario(evaluacion);
                    break;
                case 3:
                    this.numero = numero;
                    btnAccion.Text = "Modificar Evaluacion";
                    lblNombreFormulario.Text = "Modificar Evaluacion";
                    bloquearFormulario();
                    llenarFormulario(evaluacion);
                    break;
            }

        }

        private void bloquearFormulario()
        {
            numDiasHabiles.Minimum = evaluacion.dias;
            dtpFechaInicio.Enabled = false;
            txtNombre.ReadOnly = true;
            btnsPonderacion.Enabled = false;

        }

        public void llenarFormulario(Cl_Cuestionario eva)
        {
            idEvaluacion = eva.id;
            txtNombre.Text = eva.nombre;
            dtpFechaInicio.Value = eva.fecha_inicio;
            numDiasHabiles.Value = eva.dias;
            tbPonderacion.Value = eva.ponderacion_autoevaluacion;
        }

        public Cl_Cuestionario recuperarDatos()
        {
            Cl_Cuestionario eva = new Cl_Cuestionario();
            eva.nombre = txtNombre.Text;
            eva.fecha_inicio = dtpFechaInicio.Value;
            eva.dias = int.Parse(numDiasHabiles.Value.ToString());
            eva.ponderacion_autoevaluacion = tbPonderacion.Value;
            eva.ponderacion_evaluacion = (100 - tbPonderacion.Value);
            eva.id = idEvaluacion;
            eva.perfil.id = idPerfil;
            return eva;
        }

        public bool ValidarFormulario(int numero)
        {
            bool respuesta = false;
            switch (numero)
            {
                case 1:
                    int contador = 0;

                    if (txtNombre.Text != String.Empty)
                    {
                        contador++;
                        lblErrorNombre.Visible = false;
                    }
                    else
                    {
                        lblErrorNombre.Text = "Ingrese datos en el campo nombre";
                        lblErrorNombre.Visible = true;
                    }

                    if (contador == 1)
                    {
                        respuesta = true;
                    }
                    break;


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

                    if (ValidarFormulario(1))
                    {
                        if (IniciarProceso.IsBusy == false)
                        {
                            IniciarProceso.RunWorkerAsync(recuperarDatos());
                        }
                    }
                    break;
                case 2:

                    // CAMBIAR A DOS CUANDO TENGA LAS VALIDACIONES

                    if (ValidarFormulario(1))
                    {
                        if (IniciarProceso.IsBusy == false)
                        {
                            IniciarProceso.RunWorkerAsync(recuperarDatos());
                        }
                    }
                    break;
                case 3:

                    // CAMBIAR A DOS CUANDO TENGA LAS VALIDACIONES

                    if (ValidarFormulario(1))
                    {
                        if (IniciarProceso.IsBusy == false)
                        {
                            IniciarProceso.RunWorkerAsync(recuperarDatos());
                        }
                    }
                    break;
            }
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
            pbAutoevaluacion.Value = tbPonderacion.Value;
            pbEvaluacion.Value = (100 - tbPonderacion.Value);
        }

        private void IniciarProceso_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
            Cl_Cuestionario evaluacion = (Cl_Cuestionario)e.Argument;
            CargarFormulario iniciar = new CargarFormulario();
            switch (this.numero)
            {
                case 1:
                    iniciar.Mensaje = "Agregando Evaluacion";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoCuestionario dao = new daoCuestionario();
                        iniciar.respuesta = dao.Agregar(evaluacion);


                        IniciarAplicacion.ReportProgress(2, iniciar);
                        System.Threading.Thread.Sleep(2500);
                        IniciarAplicacion.ReportProgress(3, iniciar);

                    }
                    catch (Exception)
                    {
                        formulario.ErrorConexion();
                    }

                    break;
                case 2:
                    iniciar.Mensaje = "Modificando Evaluacion";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoCuestionario dao = new daoCuestionario();
                        iniciar.respuesta = dao.Modificar(evaluacion);
                        IniciarAplicacion.ReportProgress(2, iniciar);
                        System.Threading.Thread.Sleep(2500);
                        IniciarAplicacion.ReportProgress(3, iniciar);

                    }
                    catch (Exception)
                    {
                        formulario.ErrorConexion();
                    }

                    break;
                case 3:
                    iniciar.Mensaje = "Modificando Evaluacion";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoCuestionario dao = new daoCuestionario();
                        iniciar.respuesta = dao.Modificar(evaluacion);
                        IniciarAplicacion.ReportProgress(2, iniciar);
                        System.Threading.Thread.Sleep(2500);
                        IniciarAplicacion.ReportProgress(3, iniciar);

                    }
                    catch (Exception)
                    {
                        formulario.ErrorConexion();
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
                                formulario.recargarListados(4.11);
                                formulario.TerminarProceso(4.1);
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
                                formulario.recargarListados(4.11);
                                formulario.TerminarProceso(4.1);
                            }
                            else
                            {

                                formulario.AbrirModuloExterno(this);

                            }
                            break;
                    }
                    break;
                case 3:
                    CargarFormulario iniciar3 = (CargarFormulario)e.UserState;
                    switch (porcentaje)
                    {

                        case 1:

                            Modulo.Otros.Cargando load = new Modulo.Otros.Cargando();
                            load.CambiarMensaje(iniciar3.Mensaje);
                            formulario.AbrirModuloExterno(load);
                            break;
                        case 2:
                            Estado estado = new Estado();
                            estado.estado(iniciar3.respuesta, 2);
                            formulario.AbrirModuloExterno(estado);
                            break;
                        case 3:
                            if (iniciar3.respuesta)
                            {
                                formulario.recargarListados(4.11);
                                formulario.TerminarProceso(4.1);
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

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            lblFechaTermino.Text = dtpFechaInicio.Value.ToLongDateString();
        }

        private void numDiasHabiles_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dtpFechaInicio.Value;

            lblFechaTermino.Text = fecha.AddDays(Convert.ToDouble(numDiasHabiles.Value)).ToLongDateString() ;
        }

        private void btnsPonderacion_Click(object sender, EventArgs e)
        {
            if (btnsPonderacion.Value == true)
            {
                tbPonderacion.Enabled = true;
            }
            else
            {
                tbPonderacion.Enabled = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (formulario.recibirMensaje(2))
            {
                formulario.TerminarProceso(numeroFormulario);
            }
        }
    }
}
