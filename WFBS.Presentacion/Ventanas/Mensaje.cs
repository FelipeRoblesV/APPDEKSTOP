using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBS.Presentacion.Ventanas
{
    public partial class Mensaje : Form
    {
        public Mensaje()
        {
            InitializeComponent();
        }

        private void btn_Accion1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void mensajeCursosFuncionario()
        {
            lblMensaje.Text = "Funcionario no tiene cursos realizados";
            btn_Accion1.ButtonText = "Salir";
        }


        public void cambiarMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;
            btn_Accion1.ButtonText = "Salir";
        }
    }


}
