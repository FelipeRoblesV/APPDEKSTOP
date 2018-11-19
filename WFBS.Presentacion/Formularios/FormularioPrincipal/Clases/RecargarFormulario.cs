﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Presentacion.Formularios.FormularioPrincipal.Clases
{
    class RecargarFormulario
    {
        public string mensaje { get; set; }
        public double numero { get; set; }

        public DataSet listarFuncionario { get; set; }
        public DataSet listarJefeFuncionario { get; set; }
        public DataSet listarPerfil { get; set; }
        public DataSet listarCargo { get; set; }
        public DataSet listarCompetencia { get; set; }
        public DataSet listarEvaluacion { get; set; }
        public DataSet listarReporte { get; set; }

        public RecargarFormulario()
        {

        }
    }
}
