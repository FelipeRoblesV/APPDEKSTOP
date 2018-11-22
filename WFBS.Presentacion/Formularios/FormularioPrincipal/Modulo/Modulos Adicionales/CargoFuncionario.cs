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

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Modulos_Adicionales
{
    public partial class CargoFuncionario : Form
    {
        private int numero = 0;
        private FormularioPrincipal formulario;
        private int run;
        public CargoFuncionario()
        {
            InitializeComponent();
        }

        public void pasarDatos(FormularioPrincipal form)
        {
            formulario = form;
        }
        public void pasarDatos(int run)
        {
            this.run = run;
            CargarListas();
        }

        public void CargarListas()
        {
            if (run != 0)
            {
             Cl_Funcionario_Cargo cargoFunci = new Cl_Funcionario_Cargo();
                daoFuncionarioCargo dao = new daoFuncionarioCargo();
                DataTable dtIN = new DataTable();
                DataTable dtOUT = new DataTable();
                cargoFunci.funcionario.run = run;
                DataSet dataIN = dao.Verificar_Cargos_IN(cargoFunci);
                DataSet dataOut = dao.Verificar_Cargos_OUT(cargoFunci);

                dtIN = dataIN.Tables[0];
                lbCargoIn.DisplayMember = dtIN.Columns[1].ColumnName;
                lbCargoIn.ValueMember = dtIN.Columns[0].ColumnName;
                lbCargoIn.DataSource = dtIN;

                dtOUT = dataOut.Tables[0];
                lbCargoOut.DisplayMember = dtOUT.Columns[1].ColumnName;
                lbCargoOut.ValueMember = dtOUT.Columns[0].ColumnName;
                lbCargoOut.DataSource = dtOUT;

            }
            }





        private void CargarFormulario_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
            Cl_Funcionario_Cargo resultado = (Cl_Funcionario_Cargo)e.Argument;

            daoFuncionarioCargo dao = new daoFuncionarioCargo();

            if (this.numero == 1)
            {
                IniciarAplicacion.ReportProgress(1);
                dao.Agregar(resultado);
                IniciarAplicacion.ReportProgress(2);

            }
            if (this.numero == 2)
            {
                IniciarAplicacion.ReportProgress(1);
                dao.Eliminar(resultado);
                IniciarAplicacion.ReportProgress(2);

            }
        }

        private void CargarFormulario_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int porcentaje = e.ProgressPercentage;

                    switch (porcentaje)
                    {

                        case 1:
                    Modulo.Otros.Cargando load = new Modulo.Otros.Cargando();
                    load.CambiarMensaje("Cargando Cargo-Funcionario");
                    formulario.AbrirModuloExterno(load);
                    break;
                case 2:
                    CargarListas();
                    formulario.AbrirModuloExterno(this);
                    break;
                    }

        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;

            if(btn.Name == btnAgregar.Name)
            {
                if (lbCargoOut.SelectedValue != null)
                {


                    this.numero = 1;
                    int resultado = int.Parse(lbCargoOut.SelectedValue.ToString());
                    Cl_Funcionario_Cargo cargofun = new Cl_Funcionario_Cargo();
                    cargofun.cargo.id = resultado;
                    cargofun.funcionario.run = run;
                    CargarFormulario.RunWorkerAsync(cargofun);
                }
            }
            if(btn.Name == btnEliminar.Name)
            {
                if (lbCargoIn.SelectedValue != null)
                {

                    this.numero = 2;
                    int resultado = int.Parse(lbCargoIn.SelectedValue.ToString());
                    Cl_Funcionario_Cargo cargofun = new Cl_Funcionario_Cargo();
                    cargofun.cargo.id = resultado;
                    cargofun.funcionario.run = run;
                    CargarFormulario.RunWorkerAsync(cargofun);
                }
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            formulario.TerminarProceso(1.12);
        }

    }
}
