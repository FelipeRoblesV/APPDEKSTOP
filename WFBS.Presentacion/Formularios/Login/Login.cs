using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Presentacion.Formularios.Login.Modulo;

namespace WFBS.Presentacion.Formularios.Login
{
    public partial class Login : Form
    {
        private Imagenes Imagenes = new Imagenes();
        private Cargando preloader;
        private IniciarSesion IniciarSesion = new IniciarSesion();
        private Aplicacion aplicacion;

        public Login()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            IniciarLogin(1);
        }

        public void pasarDatos(Aplicacion app)
        {
            aplicacion = app;
            IniciarSesion.pasarDatos(aplicacion, this);
        }


        public void IniciarLogin(int numero)
        {
            switch (numero)
            {
                case 1:

                    AbrirModulo(IniciarSesion);
                    AbrirImagen(Imagenes);
                    break;
                case 2:
                    if (preloader == null)
                    {
                        preloader = new Cargando();
                        AbrirModulo(preloader);
                    }
                    break;
                case 3:
                    preloader.Close();
                    Imagenes.Close();
                    IniciarSesion.Close();

                    break;
            }

        }

        public void IniciarVerificacion()
        {
            preloader = new Cargando();
            AbrirModulo(preloader);
            preloader.IniciarVerificacion();
        }



        public void VerificacionCorrecta(string mensaje)
        {
            preloader.CambiarMensaje(mensaje);
        }
        public void VerificacionIncorrecta()
        {
            AbrirModulo(IniciarSesion);
            preloader.Close();

        }


        private void AbrirImagen(object formHijo)
        {
            if (this.panelImagen.Controls.Count > 0)
                this.panelImagen.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelImagen.Controls.Add(fh);
            this.panelImagen.Tag = fh;
            fh.Show();
        }

        private void AbrirModulo(object formHijo)
        {
            if (this.panelModulo.Controls.Count > 0)
                this.panelModulo.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelModulo.Controls.Add(fh);
            this.panelModulo.Tag = fh;
            fh.Show();
        }

        private void btn_cerrarFormulario_Click(object sender, EventArgs e)
        {
                Ventanas.Cerrar cerrar = new Ventanas.Cerrar();
                cerrar.ventanaCerrarLogin(this);
                cerrar.ShowDialog();
            

        }

        public void CerrarFormulario()
        {
            Application.Exit();
        }

        public FormularioPrincipal.FormularioPrincipal recuperarDatos()
        {
            return IniciarSesion.recuperarFormulario();
        }
    }
}
