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
using WFBS.Presentacion.Formularios.FormularioPrincipal.Otros;
using WFBS.WebService;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo
{
    public partial class Funcionario : Form
    {
        private Otros.Funcionario.Controles controles;
        private FormularioPrincipal formulario;
        private int numero = 0;
        private int estadorut = 0;
        public Funcionario()
        {
            InitializeComponent();

        }

        private bool respuesta;

        public void PasarDatos(FormularioPrincipal form)
        {
            this.formulario = form;
        }

        private void limpiarFormulario()
        {
            txtRutFuncionario.Text = String.Empty;
        }


        public void IniciarFormulario(int numero)
        {
            switch (numero)
            {
                case 1:
                    this.numero = numero;
                    panelBotones.Visible = false;
                    PanelContenido.Visible = false;
                    btnAccion.Text = "Agregar Funcionario";
                    lblNombreFormulario.Text = "Agregar Funcionario";
                    controles = new Otros.Funcionario.Controles();
                    AbrirFormulario(controles);
                    break;
            }

        }


        private void txtRutFuncionario_TextChanged(object sender, EventArgs e)
        {
            TextBox btn = sender as TextBox;

            if (btn.Name == txtRutFuncionario.Name)
            {

                Utilidad util = new Utilidad();
                string rut = btn.Text.Replace(".", "").Replace("-", "").Trim();
                if (btn.Text == String.Empty)
                {
                    lblErrorRut.Visible = false;
                    PanelContenido.Visible = false;
                    panelSuperior.BackColor = Color.FromArgb(56, 67, 87);
                    txtRutFuncionario.BackColor = Color.FromArgb(70, 84, 109);
                    txtRutFuncionario.MaxLength = 13;
                    panelBotones.Visible = false;
                    estadorut = 0;
                }
                else
                {
                    if (rut.Count() > 8)
                    {
                        if (util.validarRut(txtRutFuncionario.Text))
                        {
                            //  btnComprobar.Visible = true;
                            lblErrorRut.Text = String.Empty;
                            lblErrorRut.Visible = false;
                            PanelContenido.Visible = true;
                            btnVerificarFuncionario.Visible = true;
                            panelSuperior.BackColor = Color.FromArgb(73, 152, 67);
                            txtRutFuncionario.BackColor = Color.FromArgb(73, 152, 67);
                            txtRutFuncionario.MaxLength = txtRutFuncionario.Text.Count();
                            panelBotones.Visible = true;
                            estadorut = 1;
                        }
                        else
                        {
                            lblErrorRut.Text = "Rut ingresado no es valido";
                            lblErrorRut.Visible = true;
                            //  btnComprobar.Visible = false;
                            PanelContenido.Visible = false;
                            btnVerificarFuncionario.Visible = false;
                            panelSuperior.BackColor = Color.FromArgb(152, 75, 67);
                            txtRutFuncionario.BackColor = Color.FromArgb(152, 75, 67);
                            txtRutFuncionario.MaxLength = 13;
                            panelBotones.Visible = false;
                            estadorut = 0;
                        }
                    }
                    else
                    {
                        panelSuperior.BackColor = Color.FromArgb(176, 171, 162);
                        txtRutFuncionario.BackColor = Color.FromArgb(176, 171, 162);
                        lblErrorRut.Text = "Ingresando rut";
                        lblErrorRut.Visible = true;
                        PanelContenido.Visible = false;
                        btnVerificarFuncionario.Visible = false;
                        estadorut = 0;
                        txtRutFuncionario.MaxLength = 13;
                        panelBotones.Visible = false;
                    }

                }

            }

        }

        private void txtGeneral_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox btn = sender as TextBox;

                if (e.KeyCode == Keys.Enter)
                {
                    string rut =  btn.Text.Replace(".", "").Replace("-","").Trim();
                    Utilidad util = new Utilidad();
                    if (rut.Count() == 8)
                    {
                        if (util.validarRut(txtRutFuncionario.Text))
                        {
                            //  btnComprobar.Visible = true;
                            lblErrorRut.Text = String.Empty;
                            lblErrorRut.Visible = false;
                            PanelContenido.Visible = true;
                            btnVerificarFuncionario.Visible = true;
                            panelSuperior.BackColor = Color.FromArgb(73, 152, 67);
                            txtRutFuncionario.BackColor = Color.FromArgb(73, 152, 67);
                          txtRutFuncionario.MaxLength = txtRutFuncionario.Text.Count();
                        panelBotones.Visible = true;
                          estadorut = 1;
                    }
                        else
                        {
                            lblErrorRut.Text = "Rut ingresado no es valido";
                            lblErrorRut.Visible = true;
                            //  btnComprobar.Visible = false;
                            PanelContenido.Visible = false;
                            btnVerificarFuncionario.Visible = false;
                            panelSuperior.BackColor = Color.FromArgb(152, 75, 67);
                            txtRutFuncionario.BackColor = Color.FromArgb(152, 75, 67);
                           txtRutFuncionario.MaxLength = 13;
                        panelBotones.Visible = false;
                        estadorut = 0;
                    }
                    }
            }

        }

        public void CambiarEstado()
        {
            estadorut = 0;
        }

        private void txtRutFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {

            TextBox btn = sender as TextBox;

            if(estadorut == 1)
            {
                if(e.KeyChar == (char)Keys.Back)
                {
                    if (formulario.recibirMensajeFuncionario())
                    {
                        controles.limpiarFormulario();
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }



    }

        private void btnVerificarFuncionario_Click(object sender, EventArgs e)
        {
            daoWebService dao = new daoWebService();
            string rut = txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim();
            string run = rut.Substring(0, rut.Length - 1);
            Cl_Persona per = dao.RecuperarPersona(run);



        }


        #region ABRIR FORMULARIO
        private void AbrirFormulario(object formHijo)
        {
            if (this.PanelContenido.Controls.Count > 0)
                this.PanelContenido.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenido.Controls.Add(fh);
            this.PanelContenido.Tag = fh;
            fh.Show();
        }
        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            controles.limpiarFormulario();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (this.numero)
            {
                case 1:

                    if (controles.ValidarFormulario())
                    {
                        if (IniciarProceso.IsBusy == false)
                        {
                            IniciarProceso.RunWorkerAsync(controles.recuperarDatos());
                        }
                    }
                    break;
            }
        }

        private void IniciarProceso_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
            Cl_Funcionario iniciar = (Cl_Funcionario)e.Argument;

            switch (this.numero)
            {
                case 1:
                    IniciarAplicacion.ReportProgress(1);

                    try
                    {
                        daoFuncionario dao = new daoFuncionario();

                        iniciar.run = int.Parse(txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Substring(0, txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Length - 1));
                        iniciar.dv = txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Substring(txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Length -1, 1);
                        bool respuesta =dao.Agregar(iniciar);
                        IniciarAplicacion.ReportProgress(2,respuesta);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
            }
        }

        private void IniciarProceso_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int porcentaje = e.ProgressPercentage;

            switch (porcentaje)
            {
                case 1:
                    formulario.CargarFromularioCRUD();


                    break;
                case 2:
                    bool resp = (bool)e.UserState;
                    respuesta = resp;
                    break;
            }
        }

        private void IniciarEstado_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
            bool iniciar = (bool)e.Argument;
            IniciarAplicacion.ReportProgress(1, iniciar);



        }

        private void IniciarEstado_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bool iniciar = (bool)e.UserState;
            formulario.estadoFinalCrud(1, iniciar, this);
        }

        private void IniciarProceso_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IniciarEstado.RunWorkerAsync(respuesta);
        }
    }
}