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
    public class daoPerfil
    {
        public bool Agregar(Cl_Perfil pe)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_AGREGAR_PERFIL";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = pe.nombre;
                cmd.Parameters.Add("P_ABREVIACION", OracleDbType.Char).Value = pe.abreviacion;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo agregarse perfil correctamente.");
            }
        }

        public bool Modificar(Cl_Perfil pe)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_MODIFICAR_PERFIL";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("P_ID", OracleDbType.Int32).Value = pe.id;
                cmd.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = pe.nombre;
                cmd.Parameters.Add("P_ABREVIACION", OracleDbType.Char).Value = pe.abreviacion;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No modifico el perfil correctamente.");
            }
        }

        public bool Eliminar(Cl_Perfil pe)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_ELIMINAR_PERFIL";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("P_ID", OracleDbType.Int32).Value = pe.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No elimino el perfil correctamente.");
            }
        }




        public DataSet listar()
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_LISTAR_PERFIL";
                resultado = conn.EjecutarSqlListar(sql);


                return resultado;
            }
            catch (Exception)
            {

                throw new Exception("No hay datos para listar");
            }
        }


        public Cl_Perfil RecuperarDatos(int id)
        {
            Cl_Perfil perfil;
            DataSet dat;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_RECUPERAR_DATOS_PERFIL";
                OracleCommand cmd = new OracleCommand();
                perfil = new Cl_Perfil();
                cmd.Parameters.Add("p_id", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("c_per", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                dat = conn.EjecutarSPListar(ref cmd, sql);
                string resultado = string.Empty;
                foreach (DataRow item in dat.Tables[0].Rows)
                {
                    perfil.id = int.Parse(item[0].ToString());
                    perfil.nombre = item[1].ToString();
                    perfil.abreviacion = item[2].ToString();

                }

                return perfil;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool CambiarEstadoObsoleto(Cl_Perfil pe)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_CAMBIAR_OBSOLETO_PERFIL";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("P_ID", OracleDbType.Int32).Value = pe.id;

                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No modifico el estado correctamente.");
            }
        }
    }
}
