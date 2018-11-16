using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado
{
    public partial class ListadoReporte : Form
    {
        private Modulo.Listado listarReporte_Perfil, listarReporteCompetencia;
        public ListadoReporte()
        {
            InitializeComponent();
        }


        public void DefinirFormulario(double numero, DataSet listar, bool estado)
        {
            switch (numero)
            {
                case 5:
                    listarReporte_Perfil = new Modulo.Listado();
                    listarReporte_Perfil.definirFormularioReporte(1, listar, estado);
                    AbrirFormulario(listarReporte_Perfil);
                    MessageBox.Show("asdas");
                    break;
            }
        }




        private void AbrirFormulario(object formHijo)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();
        }
    }
}
