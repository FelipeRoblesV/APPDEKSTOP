using Bunifu.Framework.UI;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFBS.Controlador;
using WFBS.Presentacion.Formularios.FormularioPrincipal.Clases;
using WFBS.Presentacion.Ventanas;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Otros.Listado
{
    public partial class ListadoReporte : Form
    {
        private Modulo.Listado listaReporte_Perfil;
        private Modulo.ListadoR listaReporte, listaReporte_Evaluacion;

        private Cargando cargarFormulario;
        private BackgroundWorker iniciarSubFormulario;
        private CargarReporte SubFormularioInicia;

        private int numero = 0;
        private int idPer = 0, idEva = 0;

        public FormularioPrincipal Formulario;


        public void PasarDatos(FormularioPrincipal form)
        {
            Formulario = form;
        }

        public ListadoReporte()
        {
            InitializeComponent();
        }


        public void RestablecerNumero(int numero)
        {
            switch (numero)
            {
                case 1:
                    InicializarMapaSitio();
                    this.numero = numero;
                    DefinirModulo(1);
                    AbrirFormulario(listaReporte_Perfil);
                    break;
            }


        }

        public bool isActive()
        {
            if (numero == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }




        private void InicializarListados()
        {
            if (listaReporte_Evaluacion != null)
            {
                listaReporte_Evaluacion.Close();
            }
            if (listaReporte != null)
            {
                listaReporte.Close();
            }
        }

        private void InicializarMapaSitio()
        {
            panelMapaSitio.Visible = false;

            lblMapaSitio_1.Visible = false;
            lblMapaSitio_2.Visible = false;
            lblMapaSitio_3.Visible = false;


            lblMapaSitio_1.ForeColor = Color.FromArgb(255, 196, 68);
            lblMapaSitio_2.ForeColor = Color.FromArgb(255, 196, 68);
            lblMapaSitio_3.ForeColor = Color.FromArgb(255, 196, 68);

            lblSeparacionMapa_1.ForeColor = Color.FromArgb(255, 196, 68);
            lblSeparacionMapa_2.ForeColor = Color.FromArgb(255, 196, 68);

            lblSeparacionMapa_1.Visible = false;
            lblSeparacionMapa_2.Visible = false;

            btnRegresar.Visible = false;

        }

        private void DefinirMapaDeSitio(double numero)
        {
            switch (numero)
            {
                case 2:
                    InicializarMapaSitio();
                    panelMapaSitio.Visible = true;
                    lblMapaSitio_1.Visible = true;
                    lblSeparacionMapa_1.Visible = true;
                    lblMapaSitio_2.Visible = true;

                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;
                    break;
                case 3:
                    InicializarMapaSitio();
                    panelMapaSitio.Visible = true;
                    lblMapaSitio_1.Visible = true;
                    lblSeparacionMapa_1.Visible = true;
                    lblMapaSitio_2.Visible = true;
                    lblSeparacionMapa_2.Visible = true;
                    lblMapaSitio_3.Visible = true;

                    lblSeparacionMapa_1.ForeColor = Color.Gray;
                    lblSeparacionMapa_2.ForeColor = Color.Gray;
                    lblMapaSitio_1.ForeColor = Color.Gray;
                    lblMapaSitio_2.ForeColor = Color.Gray;
                    break;
            }
        }

        #region DEFINIR FORMULARIO
        private void DefinirModulo(double numero)
        {
            switch (numero)
            {
                case 1:
                    InicializarMapaSitio();
                    lblTitulo.Text = "Perfil";
                    lblDescripcion.Text = "Seleccione el perfil del reporte";
                    panelBotones.Visible = false;
                    break;
                case 2:
                    lblTitulo.Text = "Evaluacion";
                    lblDescripcion.Text = "Seleccione la evaluacion del reporte";
                    panelBotones.Visible = false;
                    DefinirMapaDeSitio(numero);
                    break;

                case 3:
                    lblTitulo.Text = "Reporte General";
                    lblDescripcion.Text = "Reporte de la evaluacion, que contiene todos los datos importantes.";
                    panelBotones.Visible = true;
                    DefinirMapaDeSitio(numero);
                    break;

            }
        }
        public void DefinirFormulario(int numero, DataSet listar, bool estado)
        {
            switch (numero)
            {
                case 1:
                    InicializarListados();
                    this.numero = numero;
                    listaReporte_Perfil = new Modulo.Listado();
                    listaReporte_Perfil.definirReporte(numero, listar, estado);
                    listaReporte_Perfil.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);
                    AbrirFormulario(listaReporte_Perfil);
                    break;
                case 2:
                    this.numero = numero;
                    listaReporte_Evaluacion = new Modulo.ListadoR();
                    listaReporte_Evaluacion.definirFormulario(numero, listar, estado);
                    listaReporte_Evaluacion.dt_Listar.DoubleClick += new System.EventHandler(dt_Listar_DoubleClick);
                    DefinirModulo(numero);

                        AbrirFormulario(listaReporte_Evaluacion);
                  
                    break;
                case 3:
                    this.numero = numero;
                    listaReporte = new Modulo.ListadoR();
                    listaReporte.definirFormulario(numero,listar, estado);
                    DefinirModulo(numero);
                    AbrirFormulario(listaReporte);
                    break;
            }
        }
        #endregion


        public double saberNumero()
        {
            return numero;
        }

        private void dt_Listar_DoubleClick(object sender, EventArgs e)
        {
            BunifuCustomDataGrid btn = sender as BunifuCustomDataGrid;

            switch (this.numero)
            {
                case 1:

                    if (btn.SelectedRows.Count.Equals(1))
                    {
                        idPer = int.Parse(btn.CurrentRow.Cells[0].Value.ToString());
                        IniciarSubFormulario();
                    }
                    else
                    {
                        SystemSounds.Hand.Play();
                    }
                    break;


                case 2:
                    if (btn.SelectedRows.Count.Equals(1))
                    {
                        idEva = int.Parse(btn.CurrentRow.Cells[0].Value.ToString());
                        IniciarSubFormulario();
                    }
                    else
                    {
                        SystemSounds.Hand.Play();
                    }
                    break;
            }
        }

        private void IniciarSubFormulario_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker IniciarAplicacion = sender as BackgroundWorker;
            CargarReporte iniciar = (CargarReporte)e.Argument;
            switch (this.numero)
            {

                case 1:

                    iniciar.mensaje = "Cargando Evaluaciones";
                    IniciarAplicacion.ReportProgress(1, iniciar);
                    try
                    {
                        daoReporte dao = new daoReporte();

                        iniciar.lista = dao.listarEvaluacion(iniciar.id_Perfil);
                        IniciarAplicacion.ReportProgress(2, iniciar);
                    }
                    catch (Exception)
                    {

                        iniciar.lista = null;
                        IniciarAplicacion.ReportProgress(2, iniciar);
                    }

                    break;

                case 2:

                    iniciar.mensaje = "Cargando Reporte";
                    IniciarAplicacion.ReportProgress(1, iniciar);
                    try
                    {
                        daoReporte dao = new daoReporte();

                        iniciar.lista = dao.Listar(iniciar.id_Perfil, iniciar.id_Evaluacion);
                        IniciarAplicacion.ReportProgress(2, iniciar);
                    }
                    catch (Exception)
                    {

                        iniciar.lista = null;
                        IniciarAplicacion.ReportProgress(2, iniciar);
                    }

                    break;
            }
        }

        public void CargarFormulario(int estado, String mensaje)
        {
            switch (estado)
            {
                case 1:
                    cargarFormulario = new Cargando();
                    cargarFormulario.CambiarMensaje(mensaje);
                    AbrirFormulario(cargarFormulario);
                    break;
                case 2:
                    cargarFormulario.CerrarFormulario();
                    break;
            }
        }

        private void IniciarSubFormulario_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CargarReporte iniciar = (CargarReporte)e.UserState;
            int porcentaje = e.ProgressPercentage;

            switch (porcentaje)
            {
                case 1:
                    CargarFormulario(1, iniciar.mensaje);
                    break;
                case 2:
                    switch (this.numero)
                    {
                        case 1:
                            try
                            {
                                DataSet lista = iniciar.lista;
                                this.DefinirFormulario((numero + 1), lista, true);

                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                this.DefinirFormulario((numero + 1), lista, false);
                            }
                            break;
                        case 2:
                            try
                            {
                                DataSet lista = iniciar.lista;
                                this.DefinirFormulario((numero + 1), lista, true);
                            }
                            catch (Exception)
                            {
                                DataSet lista = null;
                                this.DefinirFormulario((numero + 1), lista, false);
                            }
                            break;
                    }
                    break;



            }
        }

        private void IniciarSubFormulario()
        {
            SubFormularioInicia = null;

            if (iniciarSubFormulario == null)
            {
                iniciarSubFormulario = new BackgroundWorker();
                iniciarSubFormulario.WorkerReportsProgress = true;
                iniciarSubFormulario.DoWork += new DoWorkEventHandler(IniciarSubFormulario_DoWork);
                iniciarSubFormulario.ProgressChanged += new ProgressChangedEventHandler(IniciarSubFormulario_ProgressChanged);
            }
            if (SubFormularioInicia == null)
            {
                SubFormularioInicia = new CargarReporte();
            }
            if (iniciarSubFormulario.IsBusy == false)
            {
                if (numero == 1)
                {
                    SubFormularioInicia.id_Perfil = idPer;
                }
                if (numero == 2)
                {
                    SubFormularioInicia.id_Perfil = idPer;
                    SubFormularioInicia.id_Evaluacion = idEva;
                }

                if(iniciarSubFormulario.IsBusy == false)
                {
                    iniciarSubFormulario.RunWorkerAsync(SubFormularioInicia);
                }
            }
        }

        #region GENERAR PDF
        private void generarPDF()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.InitialDirectory = @"C:";
            savefile.Title = "Guardar Reporte";
            savefile.DefaultExt = "pdf";
            savefile.Filter = "Archivo PDF (*.pdf)|*.pdf ";
            savefile.FilterIndex = 2;
            savefile.RestoreDirectory = true;
            string nombreDocumento = "";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                nombreDocumento = savefile.FileName;
            }
            if (nombreDocumento.Trim() != "")
            {
                FileStream file = new FileStream(nombreDocumento,
                    FileMode.OpenOrCreate,
                    FileAccess.ReadWrite,
                    FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                doc.Add(new Paragraph("REPORTE GENERAL", FontFactory.GetFont("Roboto", 20, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph(Chunk.SEPARATOR));
                generarDocumento(doc);
                doc.Close();
                Process.Start(nombreDocumento);
            }
        }
        private void generarDocumento(Document documento)
        {
            try
            {
                int i, j;
                PdfPTable datatable = new PdfPTable(listaReporte.dt_Listar.ColumnCount);
                datatable.DefaultCell.Padding = 3;
                float[] tamaño = RecuperarTamaño(listaReporte.dt_Listar);
                datatable.SetWidths(tamaño);
                datatable.WidthPercentage = 100;
                datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                for (i = 0; i < listaReporte.dt_Listar.ColumnCount; i++)
                {
                    datatable.AddCell(listaReporte.dt_Listar.Columns[i].HeaderText);
                }
                datatable.HeaderRows = 1;
                datatable.DefaultCell.BorderWidth = 1;
                for (i = 0; i < listaReporte.dt_Listar.Rows.Count; i++)
                {
                    for (j = 0; j < listaReporte.dt_Listar.Columns.Count; j++)
                    {

                        if (listaReporte.dt_Listar[j, i].Value != null) { datatable.AddCell(new Phrase(listaReporte.dt_Listar[j, i].Value.ToString())); }

                    }
                    datatable.CompleteRow();
                }
                documento.Add(datatable);
            }
            catch (Exception)
            {

                throw;
            }

        }


        private float[] RecuperarTamaño(BunifuCustomDataGrid dt)
        {
            float[] tamaño = new float[dt.ColumnCount];
            for (int i = 0; i < dt.ColumnCount; i++)
            {
                tamaño[i] = (float)dt.Columns[i].Width;

            }
            return tamaño;
        }


        private void btnImportarPDF_Click(object sender, EventArgs e)
        {
            generarPDF();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }


        #endregion

        #region GENERAR EXCEL

        public void ExportarExcel()
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "ArchivoExportado";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < listaReporte.dt_Listar.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < listaReporte.dt_Listar.Columns.Count; j++)
                        {
                            if ((listaReporte.dt_Listar.Rows[i].Cells[j].Value == null) == false)
                            {
                                hoja_trabajo.Cells[i + 1, j + 1] = listaReporte.dt_Listar.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }
        #endregion


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
