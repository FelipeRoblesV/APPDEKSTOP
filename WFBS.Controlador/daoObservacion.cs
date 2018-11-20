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
   public class daoObservacion
    {

        public bool Agregar(Cl_Observacion obs)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_AGREGAR_OBSERVACION";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("O_MENSAJE", OracleDbType.Clob).Value = obs.mensaje;
                cmd.Parameters.Add("O_COM", OracleDbType.Int32).Value = obs.competencia.id;
                cmd.Parameters.Add("O_NIV_ALT", OracleDbType.Char).Value = obs.is_nivel_alto;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo agregarse obsrvacion correctamente.");
            }
        }

        public bool Modificar(Cl_Observacion obs)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_MODIFICAR_OBSERVACION";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("O_ID", OracleDbType.Int32).Value = obs.id;
                cmd.Parameters.Add("O_MENSAJE", OracleDbType.Long).Value = obs.mensaje;
                cmd.Parameters.Add("O_NIV_ALT", OracleDbType.Char).Value = obs.is_nivel_alto;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No modifico la observacion correctamente.");
            }
        }

        public DataSet Listar(int id)
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_LISTAR_OBSERVACION";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("c_id", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("c_obs", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
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
