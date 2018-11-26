using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Otros
{
    public partial class Estado : Form
    {
        public Estado()
        {
            InitializeComponent();
        }

        private void estadoCorrecto(int numero)
        {
            switch (numero)
            {
                case 1:
                    panelEstado.BackColor = Color.FromArgb(73, 152, 67);
                    lblMensaje.Text = "Se agrego correctamente.";
                    imagenEstado.Image = Properties.Resources.Correcto;
                    break;
                case 2:
                    panelEstado.BackColor = Color.FromArgb(73, 152, 67);
                    lblMensaje.Text = "Se Modifico correctamente.";
                    imagenEstado.Image = Properties.Resources.Incorrecto;

                    break;
            }
        }

        private void estadoIncorrecto(int numero)
        {
            switch (numero)
            {
                case 1:
                    panelEstado.BackColor = Color.FromArgb(237, 83, 66);
                    lblMensaje.Text = "No se agrego correctamente.";
                    imagenEstado.Image = Properties.Resources.Correcto;
                    break;
                case 2:
                    panelEstado.BackColor = Color.FromArgb(237, 83, 66);
                    lblMensaje.Text = "No se modifico correctamente.";
                    imagenEstado.Image = Properties.Resources.Incorrecto;

                    break;
            }
        }


        public void estado(bool respuesta, int numero)
        {
            switch (numero)
            {
                case 1:
                    if (respuesta)
                    {
                        estadoCorrecto(numero);
                    }
                    else
                    {
                        estadoIncorrecto(numero);
                    }
                    break;
                case 2:
                    if (respuesta)
                    {
                        estadoCorrecto(numero);
                    }
                    else
                    {
                        estadoIncorrecto(numero);
                    }
                    break;
            }

        }
    }
}
