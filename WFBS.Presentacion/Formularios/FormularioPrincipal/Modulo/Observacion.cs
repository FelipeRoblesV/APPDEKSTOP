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
using WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Clases;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Otros;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo
{
    public partial class Observacion : Form
    {
        private double numeroFormulario = 3.2;
        private int idObservacion = 0, idCompetencia = 0;
        private FormularioPrincipal formulario;
        private int numero = 0;
        private Cl_Observacion observacion;

        public Observacion()
        {
            InitializeComponent();
        }

        public void PasarDatos(FormularioPrincipal form)
        {
            this.formulario = form;
            idCompetencia = form.RecuperaridDataGrid(3);
        }



        public void PasarDatos(Cl_Observacion obs)
        {
            this.observacion = obs;
        }


        public void limpiarFormulario()
        {
            txtMensaje.Text = String.Empty;
            rbAlto.Checked = false;
            rbBajo.Checked = false;
        }


        public void IniciarFormulario(int numero)
        {
            switch (numero)
            {
                case 1:
                    this.numero = numero;
                    btnAccion.Text = "Agregar Observacion";
                    lblNombreFormulario.Text = "Agregar Observacion";
                    break;
                case 2:
                    this.numero = numero;
                    btnAccion.Text = "Modificar Observacion";
                    lblNombreFormulario.Text = "Modificar Observacion";
                    llenarFormulario(observacion);
                    break;
            }

        }

        public void llenarFormulario(Cl_Observacion obs)
        {
            idObservacion = obs.id;
            txtMensaje.Text = obs.mensaje;
            if (obs.is_nivel_alto == '1')
            {
                rbAlto.Checked = true;
            }
            else if (obs.is_nivel_alto == '0')
            {
                rbBajo.Checked = false;
            }
        }

        public Cl_Observacion recuperarDatos()
        {
            Cl_Observacion obs = new Cl_Observacion();
            obs.mensaje = txtMensaje.Text;
         
            if(rbAlto.Checked)
            {
                obs.is_nivel_alto = '1';
            }
            else if(rbBajo.Checked) 
            {
                obs.is_nivel_alto ='0';
            }
            obs.id = this.idObservacion;
            obs.competencia.id = this.idCompetencia;
            return obs;
        }


        public bool ValidarFormulario()
        {
            bool respuesta = false;
            int contador = 0;

            if (txtMensaje.Text != String.Empty)
            {
                contador++;
                lblErrorMensaje.Visible = false;
            }
            else
            {
                lblErrorMensaje.Text = "Ingrese datos en el campo Mensaje";
                lblErrorMensaje.Visible = true;
            }

            if(rbAlto.Checked == true ||  rbBajo.Checked == true)
            {
                contador++;
                lblErrorNivel.Visible = false;
            }
            else
            {
                lblErrorNivel.Text = "Seleccione un nivel";
                lblErrorNivel.Visible = true;
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
            Cl_Observacion observacion = (Cl_Observacion)e.Argument;
            CargarFormulario iniciar = new CargarFormulario();
            switch (this.numero)
            {
                case 1:
                    iniciar.Mensaje = "Agregando Observacion";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoObservacion dao = new daoObservacion();
                       iniciar.respuesta = dao.Agregar(observacion);

                        IniciarAplicacion.ReportProgress(2, iniciar);
                        System.Threading.Thread.Sleep(2500);
                        IniciarAplicacion.ReportProgress(3, iniciar);

                    }
                    catch (Exception)
                    {
                    }

                    break;
                case 2:
                    iniciar.Mensaje = "Modificando Observacion";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoObservacion dao = new daoObservacion();
                        iniciar.respuesta = dao.Modificar(observacion);
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
            CargarFormulario iniciar = (CargarFormulario)e.UserState;

            switch (this.numero)
            {
                case 1:
       
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
                                formulario.recargarListados(3.21);
                                formulario.TerminarProceso(3.2);
                            }
                            else
                            {

                                formulario.AbrirModuloExterno(this);

                            }
                            break;
                    }
                    break;
                case 2:
                    switch (porcentaje)
                    {

                        case 1:

                            Modulo.Otros.Cargando load = new Modulo.Otros.Cargando();
                            load.CambiarMensaje(iniciar.Mensaje);
                            formulario.AbrirModuloExterno(load);
                            break;
                        case 2:
                            Estado estado = new Estado();
                            estado.estado(iniciar.respuesta, 2);
                            formulario.AbrirModuloExterno(estado);
                            break;
                        case 3:
                            if (iniciar.respuesta)
                            {
                                formulario.recargarListados(3.21);
                                formulario.TerminarProceso(3.2);
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
