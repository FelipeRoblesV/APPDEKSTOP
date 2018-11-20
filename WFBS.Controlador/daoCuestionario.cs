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
   public class daoCuestionario
    {
        public bool Agregar(Cl_Cuestionario cue)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_AGREGAR_CUESTIONARIO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("C_NOMBRE", OracleDbType.Varchar2).Value = cue.nombre;
                cmd.Parameters.Add("C_PERFIL", OracleDbType.Int32).Value = cue.perfil.id;
                cmd.Parameters.Add("P_FECHA_INICIO", OracleDbType.Date).Value = cue.fecha_inicio;
                cmd.Parameters.Add("P_DIAS", OracleDbType.Int32).Value = cue.dias;
                cmd.Parameters.Add("P_PONDERACION_EVA", OracleDbType.Int32).Value = cue.ponderacion_evaluacion;
                cmd.Parameters.Add("P_PONDERACION_AUTOEVA", OracleDbType.Int32).Value = cue.ponderacion_autoevaluacion;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo agregarse cuestionario correctamente.");
            }
        }

        public bool Modificar(Cl_Cuestionario cue)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_MODIFICAR_CUESTIONARIO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("C_ID", OracleDbType.Int32).Value = cue.id;
                cmd.Parameters.Add("C_NOMBRE", OracleDbType.Varchar2).Value = cue.nombre;
                cmd.Parameters.Add("P_FECHA_INICIO", OracleDbType.Date).Value = cue.fecha_inicio;
                cmd.Parameters.Add("P_DIAS", OracleDbType.Int32).Value = cue.dias;
                cmd.Parameters.Add("P_PONDERACION_EVALUACION", OracleDbType.Int32).Value = cue.ponderacion_evaluacion;
                cmd.Parameters.Add("P_PONDERACION_AUTOEVALUACION", OracleDbType.Int32).Value = cue.ponderacion_autoevaluacion;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No modifico el cuestionario correctamente.");
            }
        }

        public bool Eliminar(Cl_Cuestionario cue)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_ELIMINAR_CUESTIONARIO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("C_ID", OracleDbType.Int32).Value = cue.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No elimino el cuestionario correctamente.");
            }
        }


        public DataSet ListarPerfil()
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_LISTAR_PERFIL_EVALUACION";
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
                String sql = "SP_LISTAR_EVALUACIONES_DK";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("P_ID", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("C_CUE", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
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
