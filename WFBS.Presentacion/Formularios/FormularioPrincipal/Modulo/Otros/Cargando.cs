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
    public partial class Cargando : Form
    {
        private List<Color> colors = new List<Color>();
        private int colores = 0;

        public Cargando()
        {
            InitializeComponent();
            DefinirColores();
        }

        public void CambiarMensaje(string mensaje)
        {
            this.lblMensaje.Text = mensaje;
            barraProgreso.Visible = true;


        }

        private void DefinirColores()
        {
            colors.Add(Color.FromArgb(237, 208, 146));
            colors.Add(Color.FromArgb(238, 212, 155));
            colors.Add(Color.FromArgb(170, 107, 101));
            colors.Add(Color.FromArgb(161, 91, 84));
            colors.Add(Color.FromArgb(55, 68, 91));
            colors.Add(Color.FromArgb(75, 87, 107));
            barraProgreso.ProgressColor = colors[colores];
        }

        int dir = 1;
        private void timerPreloader_Tick(object sender, EventArgs e)
        {
            if (barraProgreso.Value == 90)

            {
                dir = -1;
                barraProgreso.animationIterval = 10;
                cambiarColor();
            }
            else if (barraProgreso.Value == 10)
            {

                dir = +1;
                barraProgreso.animationIterval = 5;
                cambiarColor();
            }

            barraProgreso.Value += dir;
        }
        void cambiarColor()
        {
            colorTransicion.Color1 = colors[colores];
            colorTransicion.Color2 = colors[colores];

            if (colores < colors.Count - 1)
            {
                colores++;
            }
            else
            {
                colores = 0;

            }
            colorTransicion.Color1 = colors[colores];
            timerColor.Start();
        }

        private void colorTransicion_OnValueChange(object sender, EventArgs e)
        {
            if (colorTransicion.ProgessValue < 100)
            {
                colorTransicion.ProgessValue++;
                barraProgreso.ProgressColor = colorTransicion.Value;
            }
            else
            {
                timerColor.Stop();
                colorTransicion.Color1 = colorTransicion.Color2;
                colorTransicion.ProgessValue = 0;
            }
        }
    }
}
