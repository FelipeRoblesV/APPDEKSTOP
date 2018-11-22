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
    public partial class Competencia : Form
    {

        private double numeroFormulario = 3.1;
        private int idCompetencia = 0, idPerfil = 0;
        private FormularioPrincipal formulario;
        private int numero = 0;
        private Cl_Competencia competencia;


        public Competencia()
        {
            InitializeComponent();

        }
        public void PasarDatos(FormularioPrincipal form)
        {
            this.formulario = form;
            idPerfil = form.RecuperaridDataGrid(2);
        }

        public void PasarDatos(Cl_Competencia comp)
        {
            this.competencia = comp;
        }


        public void limpiarFormulario()
        {
            txtNombre.Text = String.Empty;
            txtSiglas.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            numNotaMinima.Value = 0;
            //numNotaEsperada.Value = 0;
            //numNotaMaxima.Value = 0;


        }


        public void IniciarFormulario(int numero)
        {
            switch (numero)
            {
                case 1:
                    this.numero = numero;
                    btnAccion.Text = "Agregar Competencia";
                    lblNombreFormulario.Text = "Agregar Competencia";
                    break;
                case 2:
                    this.numero = numero;
                    btnAccion.Text = "Modificar Competencia";
                    lblNombreFormulario.Text = "Modificar Competencia";
                    llenarFormulario(competencia);
                    break;
            }

        }

        public void llenarFormulario(Cl_Competencia com)
        {
            txtNombre.Text = com.nombre;
            txtSiglas.Text = com.siglas;
            txtDescripcion.Text = com.descripcion;
            numNotaMinima.Value = Convert.ToDecimal(com.nota_minima);
            numNotaMaxima.Value = Convert.ToDecimal(com.nota_maxima);
            numNotaEsperada.Value = Convert.ToDecimal(com.nota_esperada);
            idCompetencia = com.id;
        }


        public Cl_Competencia recuperarDatos()
        {
            Cl_Competencia com = new Cl_Competencia();
            com.nombre = txtNombre.Text;
            com.siglas = txtSiglas.Text;
            com.descripcion = txtDescripcion.Text;
            com.nota_minima = Convert.ToDouble(numNotaMinima.Value);
            com.nota_maxima = Convert.ToDouble(numNotaMaxima.Value);
            com.nota_esperada = Convert.ToDouble(numNotaEsperada.Value);
            com.id = this.idCompetencia;
            com.perfil.id = idPerfil;

            return com;
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
            if (txtSiglas.Text != String.Empty)
            {
                contador++;
                lblErrorSiglas.Visible = false;
            }
            else
            {
                lblErrorSiglas.Text = "Ingrese datos en el campo Abreviacion";
                lblErrorSiglas.Visible = true;
            }

            if (txtDescripcion.Text != String.Empty)
            {
                contador++;
                lblErrorDescripcion.Visible = false;
            }
            else
            {
                lblErrorDescripcion.Text = "Ingrese datos en el campo Descripcion";
                lblErrorDescripcion.Visible = true;
            }

            if (numNotaMaxima.Maximum != 0)
            {
                contador++;
                lblErrorNotaMinima.Visible = false;
            }
            else
            {
                lblErrorNotaMinima.Text = "Ingrese datos en la nota minima";
                lblErrorNotaMinima.Visible = true;
            }

            if (numNotaEsperada.Maximum != 0)
            {
                contador++;
                lblErrorNotaMaxima.Visible = false;
            }
            else
            {
                lblErrorNotaMaxima.Text = "Ingrese datos en la nota Maxima";
                lblErrorNotaMaxima.Visible = true;
                lblErrorNotaEsperada.Text = "Ingrese datos en la nota esperada";
                lblErrorNotaEsperada.Visible = true;
            }

            if (contador == 5)
            {
                respuesta = true;
            }
            return respuesta;
        }




        private void numNotaMinima_ValueChanged(object sender, EventArgs e)
        {
            if (numNotaMinima.Value != 0)
            {
                numNotaEsperada.Minimum = numNotaMinima.Value;
                numNotaMaxima.Minimum = numNotaMinima.Value;
                numNotaMaxima.Maximum = 30;
                numNotaMaxima.ReadOnly = false;
            }
        }

        private void numNotaMaxima_ValueChanged(object sender, EventArgs e)
        {
            if (numNotaMinima.Value != 0)
            {
                numNotaEsperada.Maximum = numNotaMaxima.Value;
            }
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
            Cl_Competencia competencia = (Cl_Competencia)e.Argument;
            CargarFuncionario iniciar = new CargarFuncionario();
            switch (this.numero)
            {
                case 1:
                    iniciar.Mensaje = "Agregando Competencia";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoCompetencia dao = new daoCompetencia();
                        iniciar.respuesta = dao.Agregar(competencia);


                        IniciarAplicacion.ReportProgress(2, iniciar);
                        System.Threading.Thread.Sleep(2500);
                        IniciarAplicacion.ReportProgress(3, iniciar);

                    }
                    catch (Exception)
                    {
                    }

                    break;
                case 2:
                    iniciar.Mensaje = "Modificando Competencia";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoCompetencia dao = new daoCompetencia();
                        iniciar.respuesta = dao.Modificar(competencia);
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
                    CargarFuncionario iniciar = (CargarFuncionario)e.UserState;
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
                                formulario.recargarListados(3.11);
                                formulario.TerminarProceso(3.1);
                            }
                            else
                            {

                                formulario.AbrirModuloExterno(this);

                            }
                            break;
                    }
                    break;
                case 2:
                    CargarFuncionario iniciar2 = (CargarFuncionario)e.UserState;
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
                                formulario.recargarListados(3.11);
                                formulario.TerminarProceso(3.1);
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
