using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Controlador;
using WFBS.Entidades;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Modulo.Otros.Funcionario
{
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();
            llenarCombobox();

        }


        private void llenarCombobox()
        {
            daoUtilidad dao = new daoUtilidad();

            DataSet perfil = dao.LlenarComboboxPrincipal();
            DataRow row = perfil.Tables[0].NewRow();
            row[1] = 0;
            row[0] = "<Seleccione un Perfil>";
            perfil.Tables[0].Rows.InsertAt(row, 0);
            cbPerfil.DisplayMember = "titulo";
            cbPerfil.ValueMember = "id";
            cbPerfil.DataSource = perfil.Tables[0];
        }

        public void limpiarFormulario()
        {
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtContraseña.Text = String.Empty;
            txtRepetirContraseña.Text = String.Empty;
            dtpFechaNacimiento.Value = DateTime.Now;
            cbPerfil.SelectedIndex = 0;

        }


        public Cl_Funcionario recuperarDatos()
        {
            Cl_Funcionario fun = new Cl_Funcionario();
            fun.nombre = txtNombre.Text;
            fun.apellido = txtApellido.Text;
            fun.correo = txtCorreo.Text;
            fun.telefono = int.Parse(txtTelefono.Text);
            fun.perfil.id = int.Parse(cbPerfil.SelectedValue.ToString());
            fun.fechaNacimiento = dtpFechaNacimiento.Value;
            fun.usuario.password = txtCorreo.Text;
            return fun;
        }

        public bool ValidarFormulario()
        {
            bool respuesta = false;
            int contador = 0;
            Utilidad util = new Utilidad();

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
            if(txtApellido.Text != String.Empty)
            {
                contador++;
                lblErrorApellido.Visible = false;
            }
            else
            {
                lblErrorApellido.Text = "Ingrese datos en el campo Apellido";
                lblErrorApellido.Visible = true;
            }
            if(util.CarlcularEdadPersona(dtpFechaNacimiento.Value) >= 18)
            {
                contador++;
                lblErrorFechaNacimiento.Visible = false;
            }
            else
            {
                lblErrorFechaNacimiento.Text = "No cumple con la edad minima (18 años).";
                lblErrorFechaNacimiento.Visible = true;
            }
            if(rbHombre.Checked == true || rbMujer.Checked == true)
            {
                contador++;
                lblErrorSexo.Visible = false;
            }
            else
            {
                lblErrorSexo.Text = "Seleccione un sexo.";
                lblErrorSexo.Visible = true;
            }
            if(txtCorreo.Text != String.Empty)
            {
                if (util.ValidarCorreo(txtCorreo.Text))
                {
                    contador++;
                    lblErrorCorreo.Visible = false;
                }
                else
                {
                    lblErrorCorreo.Text = "Correo ingresado no es valido.";
                    lblErrorCorreo.Visible = true;
                }
            }
            else
            {
                lblErrorCorreo.Text = "Ingrese datos al campo correo.";
                lblErrorCorreo.Visible = true;
            }
            if (txtTelefono.Text != String.Empty)
            {
                contador++;
                lblErrorTelefono.Visible = false;
            }
            else
            {
                lblErrorTelefono.Text = "Ingrese datos al campo telefono.";
                lblErrorTelefono.Visible = true;
            }
            if (lblContraseña.Text != String.Empty)
            {
                if(txtContraseña.Text.Length >= 6)
                {
                    if(txtContraseña.Text == txtRepetirContraseña.Text)
                    {
                        contador++;
                        lblErrorContraseña.Visible = false;
                        lblErrorRepetirContraseña.Visible = false;
                    }
                    else
                    {
                        lblErrorRepetirContraseña.Visible = true;
                        lblErrorRepetirContraseña.Text = "Contraseña no coincide.";
                    }

                }
                else
                {

                    lblErrorContraseña.Text = "contraseña debe tener un minimo de 6 caracteres.";
                    lblErrorContraseña.Visible = true;
                    lblErrorRepetirContraseña.Visible = false;
                }
            }
            else
            {
                lblErrorContraseña.Text = "Ingrese datos al campo contraseña.";
                lblErrorContraseña.Visible = true;
                lblErrorRepetirContraseña.Visible = false;
            }
            if (cbPerfil.SelectedIndex != 0)
            {
                contador++;
                lblErrorPerfil.Visible = false;
            }
            else
            {
                lblErrorPerfil.Text = "Seleccione un perfil";
                lblErrorPerfil.Visible = true;
            }

                if (contador == 8)
            {
                respuesta = true;
            }
            return respuesta;
        }

        private void txtGeneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox btn = sender as TextBox;

            if(btn.Name == txtTelefono.Name)
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                 if (Char.IsControl(e.KeyChar)) 
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }


            if (btn.Name == txtNombre.Name)
            {
                if (e.KeyChar == (char)Keys.Space )
                {
                    e.Handled = true;
                }

                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (btn.Name == txtApellido.Name)
            {
                if (e.KeyChar == (char)Keys.Space)
                {
                    e.Handled = true;
                }

                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if(txtContraseña.Text.Length >= 6)
            {
                lblRepetirContraseña.Visible = true;
                txtRepetirContraseña.Visible = true;

            }
            else
            {
                lblRepetirContraseña.Visible = false;
                txtRepetirContraseña.Visible = false;
            }
        }
    }
}
