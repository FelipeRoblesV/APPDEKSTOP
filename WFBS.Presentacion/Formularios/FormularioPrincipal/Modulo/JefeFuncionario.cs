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
using WFBS.WebService;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo
{
    public partial class JefeFuncionario : Form
    {
        private double numeroFormulario = 1.21;

        private Otros.Jefe_Funcionario.Controles controles;
        private FormularioPrincipal formulario;
        private int numero = 0;
        private int estadorut = 0;
        private Cl_Jefe_Funcionario jefe;

        public JefeFuncionario()
        {
            InitializeComponent();
        }

        public void PasarDatos(FormularioPrincipal form)
        {
            this.formulario = form;
        }

        public void PasarDatos(Cl_Jefe_Funcionario jefecito)
        {
            this.jefe = jefecito;
        }


        public void IniciarFormulario(int numero)
        {
            switch (numero)
            {
                case 1:
                    this.numero = numero;
                    panelBotones.Visible = false;
                    PanelContenido.Visible = false;
                    btnAccion.Text = "Agregar Jefe Funcionario";
                    lblNombreFormulario.Text = "Agregar Jefe Funcionario";
                    controles = new Otros.Jefe_Funcionario.Controles();
                    AbrirFormulario(controles);
                    break;
                case 2:
                    this.numero = numero;
                    panelBotones.Visible = false;
                    PanelContenido.Visible = false;
                    btnAccion.Text = "Modificar Funcionario";
                    lblNombreFormulario.Text = "Modificar Funcionario";
                    controles = new Otros.Jefe_Funcionario.Controles();
                    controles.llenarFormulario(jefe);
                    txtRutFuncionario.Text = jefe.run + jefe.dv;
                    lblErrorRut.Visible = false;
                    panelSuperior.BackColor = Color.FromArgb(56, 67, 87);
                    txtRutFuncionario.BackColor = Color.FromArgb(70, 84, 109);
                    txtRutFuncionario.ReadOnly = true;
                    btnVerificarFuncionario.Visible = false;
                    panelBotones.Visible = true;
                    PanelContenido.Visible = true;
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
                            daoFuncionario dao = new daoFuncionario();
                            if (dao.ExisteRut(rut) == false)
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
                                lblErrorRut.Text = "Rut ingresado ya existe.";
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
                string rut = btn.Text.Replace(".", "").Replace("-", "").Trim();
                Utilidad util = new Utilidad();
                if (rut.Count() == 8)
                {
                    if (util.validarRut(txtRutFuncionario.Text))
                    {
                        daoFuncionario dao = new daoFuncionario();
                        if (dao.ExisteRut(rut) == false)
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
                            lblErrorRut.Text = "Rut ingresado ya existe.";
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

            if (estadorut == 1)
            {
                if (e.KeyChar == (char)Keys.Back)
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
                case 2:

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
            Cl_Jefe_Funcionario funcionario = (Cl_Jefe_Funcionario)e.Argument;
            CargarFuncionario iniciar = new CargarFuncionario();
            switch (this.numero)
            {
                case 1:
                    iniciar.Mensaje = "Agregando Jefe Funcionario";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        funcionario.run = int.Parse(txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Substring(0, txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Length - 1));
                        funcionario.dv = txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Substring(txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Length - 1, 1);
                        daoJefeFuncionario dao = new daoJefeFuncionario();
                        iniciar.respuesta = dao.Agregar(funcionario);


                        IniciarAplicacion.ReportProgress(2, iniciar);
                        System.Threading.Thread.Sleep(2500);
                        IniciarAplicacion.ReportProgress(3, iniciar);

                    }
                    catch (Exception)
                    {
                    }

                    break;
                case 2:
                    iniciar.Mensaje = "Modificando Funcionario";
                    IniciarAplicacion.ReportProgress(1, iniciar);

                    try
                    {
                        funcionario.run = int.Parse(txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Substring(0, txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Length - 1));
                        funcionario.dv = txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Substring(txtRutFuncionario.Text.Replace(".", "").Replace("-", "").Trim().Length - 1, 1);
                        daoJefeFuncionario dao = new daoJefeFuncionario();
                        iniciar.respuesta = dao.Modificar(funcionario);


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
                                formulario.recargarListados(1.211);
                                formulario.TerminarProceso(1.21);
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
                                formulario.recargarListados(1.121);
                                formulario.TerminarProceso(1.21);
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
