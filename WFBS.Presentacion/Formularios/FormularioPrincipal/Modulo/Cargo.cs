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
    public partial class Cargo : Form
    {
        private double numeroFormulario = 2.21;
        private int id;
        private FormularioPrincipal formulario;
        private int numero = 0;
        private Cl_Cargo cargo;
        public Cargo()
        {
            InitializeComponent();
        }

        public void PasarDatos(FormularioPrincipal form)
        {
            this.formulario = form;
        }

        public void limpiarFormulario()
        {
            txtNombre.Text = String.Empty;
            txtAbreviacion.Text = String.Empty;

        }


        public void PasarDatos(Cl_Cargo car)
        {
            this.cargo = car;
        }



        public void IniciarFormulario(int numero)
        {
            switch (numero)
            {
                case 1:
                    this.numero = numero;
                    btnAccion.Text = "Agregar Cargo";
                    lblNombreFormulario.Text = "Agregar Cargo";
                    break;
                case 2:
                    this.numero = numero;
                    btnAccion.Text = "Modificar Cargo";
                    lblNombreFormulario.Text = "Modificar Cargo";
                    llenarFormulario(cargo);
                    break;
            }

        }

        public void llenarFormulario(Cl_Cargo car)
        {
            id = car.id;
            txtNombre.Text = car.nombre;
            txtAbreviacion.Text = car.abreviacion;
        }


        public Cl_Cargo recuperarDatos()
        {
            Cl_Cargo car = new Cl_Cargo();
            car.nombre = txtNombre.Text;
            car.abreviacion = txtAbreviacion.Text;
            car.id = id;

            return car;
        }

        public bool ValidarFormulario()
        {
            bool respuesta = false;
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
            if (txtAbreviacion.Text != String.Empty)
            {
                contador++;
                lblErrorAbreviacion.Visible = false;
            }
            else
            {
                lblErrorAbreviacion.Text = "Ingrese datos en el campo Abreviacion";
                lblErrorAbreviacion.Visible = true;
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
            Cl_Cargo cargo = (Cl_Cargo)e.Argument;
            CargarFormulario iniciar = new CargarFormulario();
            switch (this.numero)
            {
                case 1:
                    iniciar.Mensaje = "Agregando Cargo";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoCargo dao = new daoCargo();
                        iniciar.respuesta = dao.Agregar(cargo);


                        IniciarAplicacion.ReportProgress(2, iniciar);
                        System.Threading.Thread.Sleep(2500);
                        IniciarAplicacion.ReportProgress(3, iniciar);

                    }
                    catch (Exception)
                    {
                    }

                    break;
                case 2:
                    iniciar.Mensaje = "Modificando Cargo";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoCargo dao = new daoCargo();
                        iniciar.respuesta = dao.Modificar(cargo);
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
                                formulario.recargarListados(2.211);
                                formulario.TerminarProceso(2.21);
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
                                formulario.recargarListados(2.211);
                                formulario.TerminarProceso(2.21);
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
            if (formulario.recibirMensaje(2))
            {
                formulario.TerminarProceso(numeroFormulario);
            }
        }
    }
}
