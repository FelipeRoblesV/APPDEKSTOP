using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBS.Entidades;

namespace WFBS.Controlador
{
    public class daoUtilidad
    {
        public DataSet LlenarComboboxPrincipal()
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_RECUPERAR_PERFIL";
                resultado = conn.EjecutarSqlListar(sql);


                return resultado;
            }
            catch (Exception)
            {

                throw new Exception("No hay datos para listar");
            }
        }

        public DataSet llenarComboboxCompetenciasDelPerfil(int id)
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_RECUPERAR_COMPETENCIAPERFIL";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("p_id", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("c_com", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                resultado = conn.EjecutarSPListar(ref cmd, sql);
                return resultado;
            }
            catch (Exception)
            {

                throw new Exception("No hay datos para listar");
            }
        }


        public DataSet llenarMaximoMinimoNota(int id)
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_RECUPERAR_NIVEL";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("P_ID", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("C_NIV", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                resultado = conn.EjecutarSPListar(ref cmd, sql);
                return resultado;
            }
            catch (Exception)
            {
                throw new Exception("No hay datos para listar");
            }
        }


        public DataSet LlenarComboboxJefeSinPerfil()
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_RECUPERAR_JEFE_SIN_PERFIL";
                resultado = conn.EjecutarSqlListar(sql);


                return resultado;
            }
            catch (Exception)
            {

                throw new Exception("No hay datos para listar");
            }
        }


        public bool recuperarFechaInicio(Cl_Cuestionario eva)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_RECUPERAR_FECHA_INICIO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("c_id", OracleDbType.Int32).Value = eva.id;
                cmd.Parameters.Add("C_FECHA", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                DataSet res = new DataSet();
                res = conn.EjecutarSPListar(ref cmd, sql);


                foreach (DataRow item in res.Tables[0].Rows)
                {
                 int comparacion =   DateTime.Compare(DateTime.Today.Date, Convert.ToDateTime(item[0].ToString()));

                    if (comparacion < 0)
                    {
                        respuesta = false;
                    }
                    else if (comparacion == 0)
                    {
                        respuesta = true;
                    }
                    else
                    {
                        respuesta = true;
                    }
                }
               return respuesta;
            }
            catch (Exception)
            {
                
                throw new Exception("No hay datos para listar");
            }

        }




        public bool recuperarPerfilConPerfil(Cl_Perfil per)
        {
            bool resultado = false;
            try
            {

                Contexto conn = new Contexto();
                String sql = "SP_PERFIL_CON_EVALUACION";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("p_id", OracleDbType.Int32).Value = per.id;
                cmd.Parameters.Add("C_EVALUACION", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                DataSet res = new DataSet();
                res = conn.EjecutarSPListar(ref cmd, sql);


                foreach (DataRow item in res.Tables[0].Rows)
                {
                    
                    if(item[0].ToString() != "0")
                    {
                        return true;
                    }

                }
                return resultado;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
