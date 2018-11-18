using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Controlador
{
   public class daoReporte
    {

        public DataSet listarPerfil()
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_LISTAR_PERFIL_REPORTE";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("c_reporte", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                resultado = conn.EjecutarSPListar(ref cmd, sql);
                return resultado;
            }
            catch (Exception)
            {
                return resultado;
                throw new Exception("No hay nada en la lista");
            }
        }
        public DataSet listarEvaluacion(int idPer)
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_LISTAR_EVALUACION_REPORTE";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("p_id", OracleDbType.Int32).Value = idPer;
                cmd.Parameters.Add("c_reporte", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                resultado = conn.EjecutarSPListar(ref cmd, sql);
                return resultado;
            }
            catch (Exception)
            {
                return resultado;
                throw new Exception("No hay nada en la lista");
            }
        }

        public DataSet Listar(int idPer,int idEva)
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_LISTAR_REPORTE_DK";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("p_id", OracleDbType.Int32).Value = idPer;
                cmd.Parameters.Add("e_id", OracleDbType.Int32).Value = idEva;
                cmd.Parameters.Add("c_reporte", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                resultado = conn.EjecutarSPListar(ref cmd, sql);
                return resultado;
            }
            catch (Exception)
            {
                return resultado;
                throw new Exception("No hay nada en la lista");
            }
        }
    }
}
