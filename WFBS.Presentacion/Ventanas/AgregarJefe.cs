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

namespace WFBS.Presentacion.Ventanas
{
    public partial class AgregarJefe : Form
    {
        private Cl_JefePerfil jefe;

        public AgregarJefe()
        {
            InitializeComponent();
        }

        public void pasarDatos(Cl_JefePerfil jefecito)
        {
            this.jefe = jefecito;
            llenarCombobox();
        }


        private void llenarCombobox()
        {
            daoUtilidad dao = new daoUtilidad();

            DataSet perfil = dao.LlenarComboboxJefeSinPerfil();
            DataRow row = perfil.Tables[0].NewRow();
            row[1] = 0;
            row[0] = "<Seleccione un Jefe>";
            perfil.Tables[0].Rows.InsertAt(row, 0);
            cbJefeFuncionario.DisplayMember = "Nombre";
            cbJefeFuncionario.ValueMember = "RUN";
            cbJefeFuncionario.DataSource = perfil.Tables[0];
        }


        public bool ValidarFormulario()
        {
            bool respuesta = false;

            int contador = 0;

            if (cbJefeFuncionario.SelectedIndex != 0)
            {
                contador++;
                lblErrorJefe.Visible = false;
            }
            else
            {
                lblErrorJefe.Text = "Seleccione un jefe";
                lblErrorJefe.Visible = true;
            }

            if(contador == 1)
            {
                respuesta = true;
            }
            return respuesta;
        }

        private void btn_Accion2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Accion1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarFormulario())
                {
                    daoJefePerfil dao = new daoJefePerfil();
                    jefe.funcionario.run = int.Parse(cbJefeFuncionario.SelectedValue.ToString());
                    dao.Agregar(jefe);
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
