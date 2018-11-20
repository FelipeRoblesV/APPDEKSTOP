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
        public bool Agregar(Cl_Competencia com)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_AGREGAR_COMPETENCIA";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("C_NOMBRE", OracleDbType.Varchar2).Value = com.nombre;
                cmd.Parameters.Add("C_DESCRIPCION", OracleDbType.Varchar2).Value = com.descripcion;
                cmd.Parameters.Add("C_SIGLA", OracleDbType.Char).Value = com.siglas;
                cmd.Parameters.Add("C_PERFIL", OracleDbType.Int32).Value = com.perfil.id;
                cmd.Parameters.Add("N_NOTA_MINIMA", OracleDbType.Double).Value = com.nota_minima;
                cmd.Parameters.Add("N_NOTA_MAXIMA", OracleDbType.Double).Value = com.nota_maxima;
                cmd.Parameters.Add("N_NOTA_ESPERADA", OracleDbType.Double).Value = com.nota_esperada;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo agregarse la competencia correctamente.");
            }
        }



        public bool Modificar(Cl_Competencia com)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_MODIFICAR_COMPETENCIA";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("C_ID", OracleDbType.Int32).Value = com.id;
                cmd.Parameters.Add("C_NOMBRE", OracleDbType.Varchar2).Value = com.nombre;
                cmd.Parameters.Add("C_DESCRIPCION", OracleDbType.Varchar2).Value = com.descripcion;
                cmd.Parameters.Add("C_SIGLA", OracleDbType.Char).Value = com.siglas;
                cmd.Parameters.Add("N_NOTA_MINIMA", OracleDbType.Double).Value = com.nota_minima;
                cmd.Parameters.Add("N_NOTA_MAXIMA", OracleDbType.Double).Value = com.nota_maxima;
                cmd.Parameters.Add("N_NOTA_ESPERADA", OracleDbType.Double).Value = com.nota_esperada;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No modifico la competencia correctamente.");
            }
        }

        public bool Eliminar(Cl_Competencia com)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_ELIMINAR_COMPETENCIA";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("C_ID", OracleDbType.Int32).Value = com.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No elimino la competencia correctamente.");
            }
        }


        public Cl_Competencia RecuperarDatos(int run)
        {
            Cl_Competencia com;
            DataSet dat;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_RECUPERAR_COMPETENCIA";
                OracleCommand cmd = new OracleCommand();
                com = new Cl_Competencia();
                cmd.Parameters.Add("C_ID", OracleDbType.Int32).Value = run;
                cmd.Parameters.Add("C_COMP", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                dat = conn.EjecutarSPListar(ref cmd, sql);
                foreach (DataRow item in dat.Tables[0].Rows)
                {
                    com.id = int.Parse(item[0].ToString());
                    com.nombre = item[1].ToString();
                    com.descripcion = item[2].ToString();
                    com.siglas = item[3].ToString();
                    com.nota_minima = Convert.ToDouble(item[4].ToString());
                    com.nota_maxima = Convert.ToDouble(item[5].ToString());
                    com.nota_esperada = Convert.ToDouble(item[6].ToString());

                }
                return com;
            }
            catch (Exception)
            {

                throw;
            }
        }




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
