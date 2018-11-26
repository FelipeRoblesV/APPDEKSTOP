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

        public bool Modificar(Cl_Funcionario fun)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_MODIFICAR_FUNCIONARIO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("f_run", OracleDbType.Int32).Value = fun.run;
                cmd.Parameters.Add("u_password", OracleDbType.Varchar2).Value = fun.usuario.password;
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
                throw new Exception("No modifico funcionario correctamente.");
            }
        }

        public bool Eliminar(Cl_Funcionario fun)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_ELIMINAR_FUNCIONARIO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("f_run", OracleDbType.Int32).Value = fun.run;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No elimino funcionario correctamente.");
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

        public Cl_Funcionario RecuperarDatos(int run)
        {
            Cl_Funcionario fun;
            DataSet dat;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_RECUPERAR_DATOS_FUNCIONARIO";
                OracleCommand cmd = new OracleCommand();
                fun = new Cl_Funcionario();
                cmd.Parameters.Add("RUN", OracleDbType.Int32).Value = run;
                cmd.Parameters.Add("C_FUN", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                dat = conn.EjecutarSPListar(ref cmd, sql);
                string resultado = string.Empty;
                foreach (DataRow item in dat.Tables[0].Rows)
                {

                    string rut = item[0].ToString();
                    rut = rut.ToUpper();
                    rut = rut.Replace(".", "");
                    rut = rut.Replace("-", "");
                    string dv = rut.Substring(rut.Length - 1, 1);

                    fun.run = run;
                    fun.dv = dv;
                    fun.nombre = item[1].ToString();
                    fun.apellido = item[2].ToString();
                    fun.fechaNacimiento = Convert.ToDateTime(item[3].ToString());
                    fun.sexo = Convert.ToChar(item[4].ToString());
                    fun.correo = item[5].ToString();
                    fun.telefono = int.Parse(item[6].ToString());
                    fun.perfil.id = int.Parse(item[7].ToString());
                    fun.usuario.id = int.Parse(item[8].ToString());
                }

                return fun;

            }
            catch (Exception)
            {

                throw;
            }
        }



        public bool ExisteRut(string rut)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_EXISTE_RUN";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("RUT", OracleDbType.Varchar2).Value = rut;


                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {

                throw new Exception("No se puede verificar run.");

            }
        }

    }
}
