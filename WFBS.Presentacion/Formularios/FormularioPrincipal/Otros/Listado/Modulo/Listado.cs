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
using WFBS.WebService;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado.Modulo
{
    public partial class Listado : Form
    {
        private double numero = 0;

        public Listado()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            this.dt_Listar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        public bool isSelected()
        {
            if (dt_Listar.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void definirReporte(int numero, DataSet lista, bool estado)
        {
            switch (numero)
            {
                case 1:
                    if (estado == true)
                    {
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];
                            dt_Listar.Columns[0].Visible = false;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            try
                            {
                                dt_Listar.Visible = true;
                                lblMensaje.Visible = false;
                                dt_Listar.DataSource = lista.Tables[0];
                                dt_Listar.Columns[0].Visible = false;
                            }
                            catch (Exception)
                            {

                            }  
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if(lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            this.numero = numero;
                            dt_Listar.DataSource = lista.Tables[0];
                            dt_Listar.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            dt_Listar.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }


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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.DataSource = lista.Tables[0];
                        }

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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];
                            dt_Listar.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            dt_Listar.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];

                            dt_Listar.Columns[0].Visible = false;
                            dt_Listar.Columns[1].Visible = false;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];
                            dt_Listar.Columns[0].Visible = false;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];
                            dt_Listar.Columns[0].Visible = false;
                            dt_Listar.Columns[1].Visible = false;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];
                            dt_Listar.Columns[0].Visible = false;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];
                            dt_Listar.Columns[0].Visible = false;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.DataSource = lista.Tables[0];
                            dt_Listar.Columns[0].Visible = false;
                            dt_Listar.Columns[1].Visible = false;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];
                            dt_Listar.Columns[0].Visible = false;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];
                            dt_Listar.Columns[0].Visible = false;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.Visible = true;
                            lblMensaje.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];
                            dt_Listar.Columns[0].Visible = false;
                        }
                        else
                        {
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }
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
