using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBS.Entidades;

namespace WFBS.Controlador
{
    public class daoUsuario
    {
        public bool Login(Cl_Usuario usu)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_LOGIN";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("rut", OracleDbType.Varchar2).Value = usu.rut;
                cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = usu.password;

                if (conn.EjecutarSP(ref cmd, sql))
                {
                    try
                    {
                        sql = "SP_RECUPERAR_ROL";
                        OracleCommand cmd2 = new OracleCommand();
                        cmd2.Parameters.Add("r_rut", OracleDbType.Varchar2).Value = usu.rut;
                        cmd2.Parameters.Add("r_id", OracleDbType.Int32).Value = 3;
                        if (conn.EjecutarSP(ref cmd2, sql)) { respuesta = true; }
                    }
                    catch (Exception)
                    {
                        throw new Exception("Usuario sin permisos para ingresar.");
                    }
                }
                else
                {
                    throw new Exception();
                }

                return respuesta;
            }
            catch (Exception)
            {
                throw new Exception("Credenciales Incorrectas.");

            }
        }
    }
}
