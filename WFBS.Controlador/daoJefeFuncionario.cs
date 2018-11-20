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
    public class daoJefeFuncionario
    {

        public bool Agregar(Cl_Jefe_Funcionario jefe)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_AGREGAR_JEFE_FUNCIONARIO";
                OracleCommand cmd = new OracleCommand();
                jefe.usuario.rut = Convert.ToString(jefe.run) + jefe.dv;
                cmd.Parameters.Add("u_rut", OracleDbType.Varchar2).Value = jefe.usuario.rut;
                cmd.Parameters.Add("u_password", OracleDbType.Varchar2).Value = jefe.usuario.password;
                cmd.Parameters.Add("j_run", OracleDbType.Int32).Value = jefe.run;
                cmd.Parameters.Add("j_dv", OracleDbType.Char).Value = jefe.dv;
                cmd.Parameters.Add("j_nombre", OracleDbType.Varchar2).Value = jefe.nombre;
                cmd.Parameters.Add("j_apellido", OracleDbType.Varchar2).Value = jefe.apellido;
                cmd.Parameters.Add("j_sexo", OracleDbType.Char).Value = jefe.sexo;
                cmd.Parameters.Add("j_nacimiento", OracleDbType.Date).Value = jefe.fechaNacimiento;
                cmd.Parameters.Add("j_correo", OracleDbType.Varchar2).Value = jefe.correo;
                cmd.Parameters.Add("J_TELEFONO", OracleDbType.Int32).Value = jefe.telefono;

                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo agregarse el jefe de funcionario correctamente.");
            }
        }


        public bool Modificar(Cl_Jefe_Funcionario jefe)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_MODIFICAR_JEFE_FUNCIONARIO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("U_PASSWORD", OracleDbType.Varchar2).Value = jefe.usuario.password;
                cmd.Parameters.Add("F_RUN", OracleDbType.Int32).Value = jefe.run;
                cmd.Parameters.Add("f_nombre", OracleDbType.Varchar2).Value = jefe.nombre;
                cmd.Parameters.Add("f_apellido", OracleDbType.Varchar2).Value = jefe.apellido;
                cmd.Parameters.Add("f_sexo", OracleDbType.Char).Value = jefe.sexo;
                cmd.Parameters.Add("f_nacimiento", OracleDbType.Date).Value = jefe.fechaNacimiento;
                cmd.Parameters.Add("f_correo", OracleDbType.Varchar2).Value = jefe.correo;
                cmd.Parameters.Add("f_telefono", OracleDbType.Int32).Value = jefe.telefono;

                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No modifico el jefe de funcionario correctamente.");
            }
        }

        
        public bool Eliminar(Cl_Jefe_Funcionario jefe)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_ELIMINAR_JEFE_FUNCIONARIO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("f_run", OracleDbType.Int32).Value = jefe.run;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No elimino el jefe de funcionario correctamente.");
            }
        }

        public DataSet listar()
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from view_listar_jefe_funcionario";
                resultado = conn.EjecutarSqlListar(sql);


                return resultado;
            }
            catch (Exception)
            {

                throw new Exception("No hay datos para listar");
            }
        }

        public Cl_Jefe_Funcionario RecuperarDatos(int run)
        {
            Cl_Jefe_Funcionario jefe;
            DataSet dat;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_RECUPERAR_DATOS_JEFE";
                OracleCommand cmd = new OracleCommand();
                jefe = new Cl_Jefe_Funcionario();
                cmd.Parameters.Add("RUN", OracleDbType.Int32).Value = run;
                cmd.Parameters.Add("C_JEFE_FUN", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                dat = conn.EjecutarSPListar(ref cmd, sql);
                string resultado = string.Empty;
                foreach (DataRow item in dat.Tables[0].Rows)
                {

                    string rut = item[0].ToString();
                    rut = rut.ToUpper();
                    rut = rut.Replace(".", "");
                    rut = rut.Replace("-", "");
                    string dv = rut.Substring(rut.Length - 1, 1);
                    jefe.run = run;
                    jefe.dv = dv;
                    jefe.nombre = item[1].ToString();
                    jefe.apellido = item[2].ToString();
                    jefe.fechaNacimiento = Convert.ToDateTime(item[3].ToString());
                    jefe.sexo = Convert.ToChar(item[4].ToString());
                    jefe.correo = item[5].ToString();
                    jefe.telefono = int.Parse(item[6].ToString());
                    jefe.usuario.id = int.Parse(item[7].ToString());


                }

                return jefe;

            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool CambiarEstadoObsoleto(Cl_Jefe_Funcionario pe)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_CAMBIAR_OBSOLETO_PERFIL";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("RUN", OracleDbType.Int32).Value = pe.run;

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
