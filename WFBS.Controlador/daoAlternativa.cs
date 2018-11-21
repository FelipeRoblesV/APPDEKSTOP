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
   public class daoAlternativa
    {

        public bool Agregar(Cl_Alternativa alt)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_AGREGAR_ALTERNATIVA";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("A_CUERPO", OracleDbType.Clob).Value = alt.cuerpo;
                cmd.Parameters.Add("A_NOTA", OracleDbType.Double).Value = alt.nota;
                cmd.Parameters.Add("A_PRE", OracleDbType.Int32).Value = alt.pregunta.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo agregarse alternativa correctamente.");
            }
        }



        public bool Modificar(Cl_Alternativa alt)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_MODIFICAR_ALTERNATIVA";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("A_ID", OracleDbType.Int32).Value = alt.id;
                cmd.Parameters.Add("A_CUERPO", OracleDbType.Clob).Value = alt.cuerpo;
                cmd.Parameters.Add("A_NOTA", OracleDbType.Double).Value = alt.nota;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No modifico el cargo correctamente.");
            }
        }


        public bool Eliminar(Cl_Alternativa alt)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_ELIMINAR_ALTERNATIVA";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("A_ID", OracleDbType.Int32).Value = alt.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No elimino la alternativa correctamente.");
            }
        }


        public DataSet Listar(int id)
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_LISTAR_ALTERNATIVA_DK";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("(a_id", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("c_alt", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
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
