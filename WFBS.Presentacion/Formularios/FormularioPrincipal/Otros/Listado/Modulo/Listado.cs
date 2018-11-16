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


        public void definirFormularioReporte(double numero, DataSet lista, bool estado)
        {
            switch (numero)
            {
                case 1:
                    if (estado == true)
                    {
                        dt_Listar.DataSource = lista.Tables[0];
                        //     dt_Listar.double = true;
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }
                    break;
            }
        }
            public void definirFormulario(double numero, DataSet lista, bool estado)
        {

            switch (numero)
            {
                case 1.11:
                    if (estado == true)
                    {
                        dt_Listar.DataSource = lista.Tables[0];
                        dt_Listar.DataSource = lista.Tables[0];
                        dt_Listar.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dt_Listar.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dt_Listar.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dt_Listar.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dt_Listar.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dt_Listar.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dt_Listar.DoubleBuffered = true;
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }
                    break;
                case 1.12:
                    if (estado == true)
                    {
                        dt_Listar.DataSource = lista.Tables[0];
                        //     dt_Listar.double = true;
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }
                    break;

                case 1.21:
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
                case 1.22:
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
                case 2.11:
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
                case 2.21:
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
                        this.numero = numero;
                    }
                    else
                    {
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }

                    break;
                case 3.1:
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
                case 3.2:
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
                case 4.1:
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
                case 4.2:
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
                case 4.3:
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
