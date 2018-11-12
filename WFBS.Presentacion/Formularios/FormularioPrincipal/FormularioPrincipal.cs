using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Otros;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal
{
    public partial class FormularioPrincipal : Form
    {


        private ListadoPrincipal ListarFuncionario, ListarJefeFuncionario, ListarPerfil, ListarCargo,ListarCompetencia, ListarEvaluacion;
        private ListadoReporte ListadoReporte;
        private Aplicacion app;
        private Dashboard dashboard;
        private Logotipo logo = new Logotipo();
        private int numero = 0;
        private double numero2 = 0;
        private int estadoDashboard = 0, estadoFuncionario = 0, estadoPerfil = 0, estadoCompetencia = 0, estadoEvaluacion = 0, estadoReporte = 0;


        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        #region INICIAR FORMULARIOS
        public void pasarDatos(Aplicacion apli)
        {
            this.app = apli;
        }
        public void DefinirAplicacion(int numero)
        {
            switch (numero)
            {
                case 1:
                    dashboard = new Dashboard();
                    break;
            }
        }

        public void DefinirFormulario(int numero, DataSet lista)
        {
            switch (numero)
            {
                case 1:
                    ListarFuncionario = new ListadoPrincipal();
                    ListarFuncionario.DefinirFormulario(numero,lista);
                    //ListarFuncionario.DefinirModulo(1);
                    break;
                case 2:
                    ListarJefeFuncionario = new ListadoPrincipal();
                    ListarFuncionario.DefinirFormulario(numero, lista);
                    break;
                case 3:
                    ListarPerfil = new ListadoPrincipal();
                    ListarFuncionario.DefinirFormulario(numero, lista);
                    break;
                case 4:
                    ListarCargo = new ListadoPrincipal();
                    ListarFuncionario.DefinirFormulario(numero, lista);
                    break;
                case 5:
                    ListarCompetencia = new ListadoPrincipal();
                    ListarFuncionario.DefinirFormulario(numero, lista);

                    break;
                case 6:
                    ListarEvaluacion = new ListadoPrincipal();
                    ListarFuncionario.DefinirFormulario(numero, lista);
                    break;
                case 7:
                    ListadoReporte = new ListadoReporte();
                    ListarFuncionario.DefinirFormulario(numero, lista);
                    break;
            }
        }

        #endregion


        #region ACCION DE LOS BOTONES PARA EL SUBFORMULARIO

        private void btnAccionSubMenu_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;

            if (btn.Name == btnCerrar.Name)
            {
                PanelCRUD.Visible = false;
                panelSubMenuOculto.Visible = false;
                panelMenuDatagrid.Visible = false;
                IniciarProcemiento(1);
            }



            switch (this.numero2)
            {
                case 2.1:
                    if (btn.Name == btnAgregar.Name)
                    {
                        //if (ModuloFuncionario == null)
                        //{ ModuloFuncionario = new Modulos.ModuloFuncionario(); }
                        //PanelCRUD.Visible = true;
                        //ModuloFuncionario.InicializarAgregarFuncionario();
                        //AbrirModulo(ModuloFuncionario);
                    }


                    break;
                case 2.2:
                    if (btn.Name == btnAgregar.Name)
                    {
                        //if (ModulojefeFuncionario == null)
                        //{ ModulojefeFuncionario = new Modulos.ModuloJefeFuncionario(); }
                        //PanelCRUD.Visible = true;
                        //AbrirModulo(ModulojefeFuncionario);
                    }
                    break;
            }
        }
        #endregion









        #region METODOS ABRIR FORMULARIO


        private void AbrirFormulario(object formHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void AbrirModulo(object formHijo)
        {
            if (this.PanelCRUD.Controls.Count > 0)
                this.PanelCRUD.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelCRUD.Controls.Add(fh);
            this.PanelCRUD.Tag = fh;
            fh.Show();
        }

        #endregion
    }
}
