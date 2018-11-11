﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Controlador
{
    public class daoJefeFuncionario
    {
        public DataSet listar()
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from view_listar_jefe_funcionario";
                resultado = conn.EjecutarSqlListar(sql);


                return resultado;
            }
            catch (Exception)
            {

                throw new Exception("No hay datos para listar");
            }
        }
    }
}
