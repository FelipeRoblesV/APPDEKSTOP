using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Entidades;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo
{
    public partial class Competencia : Form
    {

        private double numeroFormulario = 3.1;
        private int id = 0;
        private FormularioPrincipal formulario;
        private int numero = 0;
        private Cl_Competencia competencia;

        public Competencia()
        {
            InitializeComponent();

        }
        public void PasarDatos(FormularioPrincipal form)
        {
            this.formulario = form;
        }

        public void PasarDatos(Cl_Competencia comp)
        {
            this.competencia = comp;
        }


        public void IniciarFormulario(int numero)
        {
            switch (numero)
            {
                case 1:
                    this.numero = numero;
                    btnAccion.Text = "Agregar Competencia";
                    lblNombreFormulario.Text = "Agregar Competencia";
                    break;
                case 2:
                    this.numero = numero;
                    btnAccion.Text = "Modificar Competencia";
                    lblNombreFormulario.Text = "Modificar Competencia";
                    llenarFormulario(competencia);
                    break;
            }

        }

        public void llenarFormulario(Cl_Competencia com)
        {
            txtNombre.Text = com.nombre;
            txtSiglas.Text = com.siglas;
            txtDescripcion.Text = com.descripcion;
            numNotaMinima.Value = Convert.ToDecimal(com.nota_minima);
            numNotaMaxima.Value = Convert.ToDecimal(com.nota_maxima);
            numNotaEsperada.Value = Convert.ToDecimal(com.nota_esperada);
            id = com.id;
        }


        public Cl_Competencia recuperarDatos()
        {
            Cl_Competencia com = new Cl_Competencia();
            com.nombre = txtNombre.Text;
            com.siglas = txtSiglas.Text;
            com.descripcion = txtDescripcion.Text;
            com.nota_minima = Convert.ToDouble(numNotaMinima.Value);
            com.nota_maxima = Convert.ToDouble(numNotaMaxima.Value);
            com.nota_esperada = Convert.ToDouble(numNotaEsperada.Value);
            com.id = this.id;

            return com;
        }


        public bool ValidarFormulario()
        {
            bool respuesta = false;
            int contador = 0;

            if (txtNombre.Text != String.Empty)
            {
                contador++;
                lblErrorNombre.Visible = false;
            }
            else
            {
                lblErrorNombre.Text = "Ingrese datos en el campo nombre";
                lblErrorNombre.Visible = true;
            }
            if (txtSiglas.Text != String.Empty)
            {
                contador++;
                lblErrorSiglas.Visible = false;
            }
            else
            {
                lblErrorSiglas.Text = "Ingrese datos en el campo Abreviacion";
                lblErrorSiglas.Visible = true;
            }

            if (numNotaMaxima.Maximum != 0)
            {
                contador++;
                lblErrorNotaMinima.Visible = false;
            }
            else
            {
                lblErrorNotaMinima.Text = "Ingrese datos en la nota minima";
                lblErrorNotaMinima.Visible = true;
            }

            if (numNotaEsperada.Maximum != 0)
            {
                contador++;
                lblErrorNotaMaxima.Visible = false;
            }
            else
            {
                lblErrorNotaMaxima.Text = "Ingrese datos en la nota Maxima";
                lblErrorNotaMaxima.Visible = true;
            }


            if (contador == 3)
            {
                respuesta = true;
            }
            return respuesta;
        }




        private void numNotaMinima_ValueChanged(object sender, EventArgs e)
        {
            if(numNotaMinima.Value != 0)
            {
                numNotaEsperada.Minimum = numNotaMinima.Value;
                numNotaMaxima.Minimum = numNotaMinima.Value;
                numNotaMaxima.Maximum = 30;
                numNotaMaxima.ReadOnly = false;
            }
        }

        private void numNotaMaxima_ValueChanged(object sender, EventArgs e)
        {
            if (numNotaMinima.Value != 0)
            {
                numNotaEsperada.Maximum = numNotaMaxima.Value;
            }
        }
    }



}
