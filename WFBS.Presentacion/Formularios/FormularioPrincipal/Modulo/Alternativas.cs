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
    public partial class Alternativas : Form
    {
        private double numeroFormulario = 4.3;
        private int idPregunta = 0, idAlternativa = 0;
        private FormularioPrincipal formulario;
        private int numero = 0;
        private Cl_Alternativa alternativa;

        public Alternativas()
        {
            InitializeComponent();
        }


        private void llenarNota()
        {
            daoUtilidad dao = new daoUtilidad();

            DataSet nota = dao.llenarMaximoMinimoNota(idPregunta);
            foreach (DataRow item in nota.Tables[0].Rows)
            {
                numNotaIndividual.Maximum = Convert.ToDecimal(item[1].ToString());
                numNotaIndividual.Minimum = Convert.ToDecimal(item[0].ToString());
            }
        }


        public void PasarDatos(FormularioPrincipal form)
        {
            this.formulario = form;
            idPregunta = form.RecuperaridDataGrid(6);
            llenarNota();
        }

        public void limpiarFormulario()
        {
            numNotaIndividual.Value = 1;
            txtAlternativa.Text = String.Empty;

        }


        public void PasarDatos(Cl_Alternativa alt)
        {
            this.alternativa = alt;
        }



        public void IniciarFormulario(int numero)
        {
            switch (numero)
            {
                case 1:
                    this.numero = numero;
                    btnAccion.Text = "Agregar Alternativa";
                    lblNombreFormulario.Text = "Agregar Alternativa";
                    break;
                case 2:
                    this.numero = numero;
                    btnAccion.Text = "Modificar Alternativa";
                    lblNombreFormulario.Text = "Modificar Alternativa";
                    llenarFormulario(alternativa);
                    break;
            }

        }

        public void llenarFormulario(Cl_Alternativa alt)
        {

            idAlternativa = alt.id;
            numNotaIndividual.Value = Convert.ToDecimal(alt.nota);
            txtAlternativa.Text = alt.cuerpo;
        }

        public static string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }
        public Cl_Alternativa recuperarDatos()
        {
            Cl_Alternativa alt = new Cl_Alternativa();
            alt.nota = Convert.ToDouble(numNotaIndividual.Text);
            string alternativa = txtAlternativa.Text.ToLower();
            alt.cuerpo = FirstCharToUpper(alternativa);
            alt.id = idAlternativa;
            alt.pregunta.id = idPregunta;
            return alt;
        }

        public bool ValidarFormulario()
        {
            bool respuesta = false;
            int contador = 0;

            if (txtAlternativa.Text != String.Empty)
            {
                contador++;
                lblErrorAlternativa.Visible = false;
            }
            else
            {
                lblErrorAlternativa.Text = "Ingrese datos en el campo alternativa";
                lblErrorAlternativa.Visible = true;
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
            Cl_Alternativa alternativa = (Cl_Alternativa)e.Argument;
            CargarFuncionario iniciar = new CargarFuncionario();
            switch (this.numero)
            {
                case 1:
                    iniciar.Mensaje = "Agregando Alternativa";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoAlternativa dao = new daoAlternativa();
                        iniciar.respuesta = dao.Agregar(alternativa);


                        IniciarAplicacion.ReportProgress(2, iniciar);
                        System.Threading.Thread.Sleep(2500);
                        IniciarAplicacion.ReportProgress(3, iniciar);

                    }
                    catch (Exception)
                    {
                    }

                    break;
                case 2:
                    iniciar.Mensaje = "Modificando Alternativa";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        daoAlternativa dao = new daoAlternativa();
                        iniciar.respuesta = dao.Modificar(alternativa);
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
                                formulario.recargarListados(4.31);
                                formulario.TerminarProceso(4.3);
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
                                formulario.recargarListados(4.31);
                                formulario.TerminarProceso(4.3);
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
