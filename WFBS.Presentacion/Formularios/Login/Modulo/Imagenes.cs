using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Presentacion.Properties;

namespace WFBS.Presentacion.Formularios.Login.Modulo
{
    public partial class Imagenes : Form
    {
        private BackgroundWorker CargarAplicacion;
        private int numero = 0;
        private int numeroLocal = 0;
        private int estado = 0;



        public Imagenes()
        {
            InitializeComponent();
            CambiarImagen();
        }

        public void cambiarEstado()
        {
            if (estado == 0)
            {
                estado = 1;
            }
            else if (estado == 1)
            {
                estado = 0;
            }
        }
        public void cambiarImagen(int numero)
        {
            switch (numero)
            {
                case 1:
                    Background.Image = Resources.Background_1;
                    break;
                case 2:
                    Background.Image = Resources.Background_2;
                    break;
                case 3:
                    Background.Image = Resources.Background_3;
                    break;
                case 4:
                    Background.Image = Resources.Background_4;
                    break;
            }
        }
        #region CAMBIO DE IMAGEN
        private void CambiarImagen()
        {
            if (CargarAplicacion == null)
            {
                CargarAplicacion = new BackgroundWorker();
                CargarAplicacion.WorkerReportsProgress = true;
                CargarAplicacion.DoWork += new DoWorkEventHandler(CambioImagen_DoWork);
                CargarAplicacion.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CambioImagen_RunWorkerCompleted);
                CargarAplicacion.ProgressChanged += new ProgressChangedEventHandler(CambioImagen_ProgressChanged);
            }
            CargarAplicacion.RunWorkerAsync();
        }

        private void CambioImagen_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (estado == 0)
            {
                this.numero = 0;
                CambiarImagen();
            }
            else
            if (estado == 1)
            {
                CargarAplicacion.WorkerReportsProgress = false;
            }



        }

        public void Activar()
        {
            CargarAplicacion.WorkerReportsProgress = true;
            CambiarImagen();
        }

        private void CambioImagen_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            switch (this.numeroLocal)
            {
                case 1:
                    cambiarImagen(this.numeroLocal);
                    break;
                case 2:
                    cambiarImagen(this.numeroLocal);
                    break;
                case 3:
                    cambiarImagen(this.numeroLocal);
                    break;
                case 4:
                    cambiarImagen(this.numeroLocal);
                    break;
            }
        }

        private void CambioImagen_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;

            try
            {
                for (int i = this.numero; i < 5; i++)
                {
                    switch (i)
                    {
                        case 1:
                            this.numeroLocal = i;
                            System.Threading.Thread.Sleep(15000);
                            break;
                        case 2:
                            this.numeroLocal = i;
                            System.Threading.Thread.Sleep(15000);
                            break;
                        case 3:
                            this.numeroLocal = i;
                            System.Threading.Thread.Sleep(15000);
                            break;
                        case 4:
                            this.numeroLocal = i;
                            System.Threading.Thread.Sleep(15000);
                            break;

                    }

                    IniciarAplicacion.ReportProgress((i + 1));
                }
            }
            catch (Exception)
            {

                throw new Exception("No se pudo cambiar imagen correctamente.");
            }

        }
        #endregion
    }
}
