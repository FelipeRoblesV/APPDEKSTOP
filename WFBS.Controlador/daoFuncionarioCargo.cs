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
    public class daoFuncionarioCargo
    {
        public bool Agregar(Cl_Funcionario_Cargo FuncionarioCargo)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_AGREGAR_FUNCIONARIO_CARGO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("F_RUN", OracleDbType.Int32).Value = FuncionarioCargo.funcionario.run;
                cmd.Parameters.Add("C_ID", OracleDbType.Int32).Value = FuncionarioCargo.cargo.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo agregarse el CARGOFUNCIONARIO correctamente");
            }
        }

        public bool Eliminar(Cl_Funcionario_Cargo FuncionarioCargo)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_ELIMINAR_FUNCIONARIO_CARGO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("F_RUN", OracleDbType.Int32).Value = FuncionarioCargo.funcionario.run;
                cmd.Parameters.Add("C_ID", OracleDbType.Int32).Value = FuncionarioCargo.cargo.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo Eliminar el CARGOFUNCIONARIO correctamente");
            }
        }


        public DataSet Verificar_Cargos_IN(Cl_Funcionario_Cargo FuncionarioCargo)
        {

            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_VISUALIZAR_CARGO_IN";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("RUN", OracleDbType.Int32).Value = FuncionarioCargo.funcionario.run;
                cmd.Parameters.Add("C_OCUPADO", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                resultado = conn.EjecutarSPListar(ref cmd, sql);
                return resultado;
            }
            catch (Exception)
            {
                return resultado;
                throw new Exception("No hay nada en la lista");
            }
        }


        public DataSet Verificar_Cargos_OUT(Cl_Funcionario_Cargo FuncionarioCargo)
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_VISUALIZAR_CARGO_OUT";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("RUN", OracleDbType.Int32).Value = FuncionarioCargo.funcionario.run;
                cmd.Parameters.Add("C_DISPONIBLE", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
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
