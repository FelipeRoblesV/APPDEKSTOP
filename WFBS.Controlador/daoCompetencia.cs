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
   public class daoCompetencia
    {

        public DataSet ListarPerfil()
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_LISTAR_PERFIL_COMPETENCIA";
                resultado = conn.EjecutarSqlListar(sql);

                return resultado;
            }
            catch (Exception)
            {
                throw new Exception("No hay datos para listar");
            }
        }

        public DataSet Listar(int id)
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_LISTAR_COMPETENCIA";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("p_id", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("c_comp", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
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
