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
   public class daoPreguntas
    {

        public bool Agregar(Cl_Preguntas pre)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_AGREGAR_PREGUNTA";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("P_CUERPO", OracleDbType.Clob).Value = pre.cuerpo;
                cmd.Parameters.Add("P_CUE", OracleDbType.Int32).Value = pre.cuestionario.id;
                cmd.Parameters.Add("P_COM", OracleDbType.Int32).Value = pre.competencia.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo agregarse pregunta correctamente.");
            }
        }


        public bool Modificar(Cl_Preguntas pre)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_MODIFICAR_COMPETENCIA";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("P_ID", OracleDbType.Int32).Value = pre.id;
                cmd.Parameters.Add("P_CUERPO", OracleDbType.Clob).Value = pre.cuerpo;
                cmd.Parameters.Add("P_COM", OracleDbType.Int32).Value = pre.competencia.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No modifico el cargo correctamente.");
            }
        }

        public bool Eliminar(Cl_Preguntas pre)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_ELIMINAR_PREGUNTA";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("P_ID", OracleDbType.Int32).Value = pre.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No elimino el cargo correctamente.");
            }
        }



        public DataSet Listar(int id)
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_LISTAR_PREGUNTAS_DK";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("(pre_ID", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("c_pre", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
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
