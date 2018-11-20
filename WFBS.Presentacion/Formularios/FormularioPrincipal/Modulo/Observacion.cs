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

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo
{
    public partial class Observacion : Form
    {
        private double numeroFormulario = 2.11;
        private int id = 0;
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
        }



        public void PasarDatos(Cl_Observacion obs)
        {
            this.observacion = obs;
        }


        public void limpiarFormulario()
        {
            txtMensaje.Text = String.Empty;
            chkNivel.Checked = false;
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
            txtMensaje.Text = obs.mensaje;
            chkNivel.Checked = obs.is_nivel_alto;
        }

        public Cl_Observacion recuperarDatos()
        {
            Cl_Observacion obs = new Cl_Observacion();
            obs.mensaje = txtMensaje.Text;
            obs.is_nivel_alto = chkNivel.Checked;
            obs.id = this.id;

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

            if (contador == 1)
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
            CargarFuncionario iniciar = new CargarFuncionario();
            switch (this.numero)
            {
                case 1:
                    iniciar.Mensaje = "Agregando Observacion";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoObservacion dao = new daoObservacion();
                        iniciar.respuesta = dao.Agregar(perfil);

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
                        daoPerfil dao = new daoPerfil();
                        iniciar.respuesta = dao.Modificar(perfil);
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

    }
}
