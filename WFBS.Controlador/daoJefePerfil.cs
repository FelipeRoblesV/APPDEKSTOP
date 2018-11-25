using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBS.Entidades;

namespace WFBS.Controlador
{
    public class daoJefePerfil
    {
        public bool Agregar(Cl_JefePerfil jefePerfil)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_AGREGAR_JEFE_PERFIL";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("F_RUN", OracleDbType.Int32).Value = jefePerfil.funcionario.run;
                cmd.Parameters.Add("P_ID", OracleDbType.Int32).Value = jefePerfil.perfil.id;

                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo agregarse obsrvacion correctamente.");
            }
        }
        public bool Eliminar(Cl_JefePerfil jefe)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_ELIMINAR_JEFE_PERFIL";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("F_RUN", OracleDbType.Int32).Value = jefe.funcionario.run;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No elimino el jefe del perfil correctamente.");
            }
        }

    }
}
