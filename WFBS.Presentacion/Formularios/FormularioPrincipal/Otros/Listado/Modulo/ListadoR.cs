using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado.Modulo
{
    public partial class ListadoR : Form
    {
        public ListadoR()
        {
            InitializeComponent();
            this.dt_Listar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        public void definirFormulario(int numero, DataSet lista, bool estado)
        {
            switch (numero)
            {
                case 2:
                    if (estado == true)
                    {
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            panel7.Visible = false;
                            dt_Listar.DataSource = lista.Tables[0];

                        }
                        else
                        {
                            panel7.Visible = false;
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }


                    }
                    else
                    {
                        panel7.Visible = false;
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }
                    break;
                case 3:
                    if (estado == true)
                    {
                        if (lista.Tables[0].Rows.Count >= 1)
                        {
                            dt_Listar.DataSource = lista.Tables[0];

                            lblNombreEvaluacion.Text = dt_Listar.Rows[0].Cells[0].Value.ToString();
                            lblNombrePerfil.Text = dt_Listar.Rows[0].Cells[1].Value.ToString();
                            lblRutEvaluador.Text = dt_Listar.Rows[0].Cells[7].Value.ToString();
                            lblNombreEvaluador.Text = dt_Listar.Rows[0].Cells[6].Value.ToString();

                            dt_Listar.Columns[0].Visible = false;
                            dt_Listar.Columns[1].Visible = false;
                            dt_Listar.Columns[6].Visible = false;
                            dt_Listar.Columns[7].Visible = false;

                            dt_Listar.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dt_Listar.Columns[12].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        else
                        {
                            panel7.Visible = false;
                            dt_Listar.Visible = false;
                            lblMensaje.Visible = true;

                        }


                    }
                    else
                    {
                        panel7.Visible = false;
                        dt_Listar.Visible = false;
                        lblMensaje.Visible = true;

                    }
                    break;
            }



        }
    }
}