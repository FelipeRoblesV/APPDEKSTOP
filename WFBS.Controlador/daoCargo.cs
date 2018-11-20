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
    public class daoCargo
    {
        public bool Agregar(Cl_Cargo cargo)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_AGREGAR_CARGO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("C_NOMBRE", OracleDbType.Varchar2).Value = cargo.nombre;
                cmd.Parameters.Add("C_ABREVIACION", OracleDbType.Varchar2).Value = cargo.abreviacion;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No pudo agregarse cargo correctamente.");
            }
        }

        public bool Eliminar(Cl_Cargo cargo)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_ELIMINAR_CARGO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("C_ID", OracleDbType.Int32).Value = cargo.id;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No elimino el cargo correctamente.");
            }
        }

        public bool Modificar(Cl_Cargo cargo)
        {
            bool respuesta = false;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_MODIFICAR_CARGO";
                OracleCommand cmd = new OracleCommand();
                cmd.Parameters.Add("C_ID", OracleDbType.Int32).Value = cargo.id;
                cmd.Parameters.Add("C_NOMBRE", OracleDbType.Varchar2).Value = cargo.nombre;
                cmd.Parameters.Add("C_ABREVIACION", OracleDbType.Varchar2).Value = cargo.abreviacion;
                respuesta = conn.EjecutarSP(ref cmd, sql);
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
                throw new Exception("No modifico el cargo correctamente.");
            }
        }

        public DataSet listar()
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_LISTAR_CARGO";
                resultado = conn.EjecutarSqlListar(sql);


                return resultado;
            }
            catch (Exception)
            {

                throw new Exception("No hay datos para listar");
            }
        }

        public Cl_Cargo RecuperarDatos(int id)
        {
            Cl_Cargo car;
            DataSet dat;
            try
            {
                Contexto conn = new Contexto();
                String sql = "SP_RECUPERAR_CARGO";
                OracleCommand cmd = new OracleCommand();
                car = new Cl_Cargo();
                cmd.Parameters.Add("C_ID", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("C_CAR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                dat = conn.EjecutarSPListar(ref cmd, sql);
                foreach (DataRow item in dat.Tables[0].Rows)
                {

                    car.id = int.Parse(item[0].ToString()); 
                    car.nombre = item[1].ToString();
                    car.abreviacion = item[2].ToString();
     
                }

                return car;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
