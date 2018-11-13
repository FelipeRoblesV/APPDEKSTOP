using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado.Modulo
{
    public partial class Listado : Form
    {
        private double numero = 0;

        public Listado()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

        public void definirFormulario(double numero, DataSet lista, bool estado)
        {

            switch (numero)
            {
                case 1:
                    if (estado == true)
                    {
                        dt_Listar.DataSource = lista.Tables[0];
                        dt_Listar.DoubleBuffered = true;
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }

                    break;

                case 2:
                    if (estado == true)
                    {
                        dt_Listar.DataSource = lista.Tables[0];
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }

                    break;
                case 3:
                    if (estado == true)
                    {
                        dt_Listar.DataSource = lista.Tables[0];
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }

                    break;
                case 4:
                    if (estado == true)
                    {
                        dt_Listar.DataSource = lista.Tables[0];
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }

                    break;
                case 5:
                    if (estado == true)
                    {
                        dt_Listar.DataSource = lista.Tables[0];
                        dt_Listar.Columns[0].Visible = false;
                        dt_Listar.Columns[1].Visible = false;
                        this.numero = numero;
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }

                    break;
                case 5.1:
                    if (estado == true)
                    {
                        dt_Listar.DataSource = lista.Tables[0];
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;
                    }
                    break;
                case 6:
                    if (estado == true)
                    {
                        dt_Listar.DataSource = lista.Tables[0];
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }

                    break;
                case 7:
                    if (estado == true)
                    {
                        dt_Listar.DataSource = lista.Tables[0];
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }

                    break;
            }
        }
    }
}
