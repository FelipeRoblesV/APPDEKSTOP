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
    public class daoFuncionario
    {
        public bool Agregar(Cl_Funcionario fun)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_AGREGAR_FUNCIONARIO";
                OracleCommand cmd = new OracleCommand();
                fun.usuario.rut = Convert.ToString(fun.run) + fun.dv;
                cmd.Parameters.Add("u_rut", OracleDbType.Varchar2).Value = fun.usuario.rut;
                cmd.Parameters.Add("u_password", OracleDbType.Varchar2).Value = fun.usuario.password;
                cmd.Parameters.Add("u_id_rol", OracleDbType.Int32).Value = 1;
                cmd.Parameters.Add("f_run", OracleDbType.Int32).Value = fun.run;
                cmd.Parameters.Add("f_dv", OracleDbType.Char).Value = fun.dv;
                cmd.Parameters.Add("f_nombre", OracleDbType.Varchar2).Value = fun.nombre;
                cmd.Parameters.Add("f_apellido", OracleDbType.Varchar2).Value = fun.apellido;
                cmd.Parameters.Add("f_sexo", OracleDbType.Char).Value = fun.sexo;
                cmd.Parameters.Add("f_nacimiento", OracleDbType.Date).Value = fun.fechaNacimiento;
                cmd.Parameters.Add("f_correo", OracleDbType.Varchar2).Value = fun.correo;
                cmd.Parameters.Add("f_telefono", OracleDbType.Int32).Value = fun.telefono;
                cmd.Parameters.Add("f_id_per", OracleDbType.Int32).Value = fun.perfil.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo agregarse funcionario correctamente.");
            }
        }

        public DataSet listar()
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from view_listar_funcionario";
                resultado = conn.EjecutarSqlListar(sql);

                return resultado;
            }
            catch (Exception)
            {
                throw new Exception("No hay datos para listar");
            }
        }
    }
}
