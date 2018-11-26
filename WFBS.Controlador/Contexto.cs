using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Controlador
{
    public class Contexto
    {
        #region DEFINICION DE PARAMETROS
        private OracleConnection conn;
        public OracleDataReader ora_DataReader;
        private struct stConnDB
        {
            public string CadenaConexion;
            public string ErrorDesc;
            public int ErrorNum;
        }
        private stConnDB info;
        public byte ora_intentos = 0;
        public string ErrDesc
        {
            get { return this.info.ErrorDesc; }
        }
        public string ErrNum
        {
            get { return info.ErrorNum.ToString(); }
        }
        #endregion
        public Contexto()
        {
            info.CadenaConexion = ConfigurationManager.ConnectionStrings["ConexionWFBS"].ConnectionString;
            conn = new OracleConnection();
        }
        #region METODOS DE CONEXION
        public bool Desconectar()
        {
            try
            {
                // Cerramos la conexion
                if (conn != null)
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
                // Liberamos su memoria.
                conn.Dispose();
                return true;

            }
            catch (Exception ex)
            {
                AsignarError(ref ex);
                return false;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Liberamos objetos manejados.
            }
            try
            {
                // Liberamos los obtetos no manejados.
                if (ora_DataReader != null)
                {
                    ora_DataReader.Close();
                    ora_DataReader.Dispose();
                }
                // Cerramos la conexión a DB.
                if (!Desconectar())
                {
                    // Grabamos Log de Error...
                }
            }
            catch (Exception ex)
            {
                // Asignamos error.
                AsignarError(ref ex);
            }
        }
        ~Contexto()
        {
            Dispose(false);
        }
        public bool Conectar()
        {
            bool ok = false;

            try
            {
                if (conn != null)
                {
                    // Fijamos la cadena de conexión de la base de datos.
                    conn.ConnectionString = info.CadenaConexion;
                    conn.Open();
                    ok = true;
                }
            }
            catch (Exception ex)
            {
                // Desconectamos y liberamos memoria.
                Desconectar();
                // Asignamos error.
                AsignarError(ref ex);
                // Asignamos error de función
                ok = false;
            }
            return ok;

        }
        private void AsignarError(ref Exception ex)
        {
            // Si es una excepcion de Oracle.
            if (ex is OracleException)
            {
                info.ErrorNum = ((OracleException)ex).Number;
                info.ErrorDesc = ex.Message;
            }
            else
            {
                info.ErrorNum = 0;
                info.ErrorDesc = ex.Message;
            }
            // Grabamos Log de Error...
        }
        public bool IsConected()
        {
            bool ok = false;
            try
            {
                // Si el objeto conexion ha sido instanciado
                if (conn != null)
                {
                    // Segun el estado de la Base de Datos.
                    switch (conn.State)
                    {
                        case ConnectionState.Closed:
                        case ConnectionState.Broken:
                        case ConnectionState.Connecting:
                            ok = false;
                            break;
                        case ConnectionState.Open:
                        case ConnectionState.Fetching:
                        case ConnectionState.Executing:
                            ok = true;
                            break;
                    }
                }
                else
                {
                    ok = false;
                }

            }
            catch (Exception ex)
            {
                AsignarError(ref ex);
                ok = false;
            }

            return ok;
        }
        #endregion
        #region METODOS SQL
        //EJECUTAR SELECT <SOLO SELECT>
        public bool EjecutarSQL(string SqlQuery)
        {
            bool ok = true;
            OracleCommand cmd = new OracleCommand();
            try
            {
                // Si no esta conectado, se conecta.
                if (!IsConected())
                {
                    ok = Conectar();
                }

                if (ok)
                {
                    // Cerramos cursores abiertos, para evitar el error ORA-1000
                    if ((ora_DataReader != null))
                    {
                        ora_DataReader.Close();
                        ora_DataReader.Dispose();
                    }

                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = SqlQuery;

                    // Ejecutamos sql.
                    ora_DataReader = cmd.ExecuteReader();
                }

            }
            catch (Exception ex)
            {
                AsignarError(ref ex);
                ok = false;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

            return ok;

        }

        public DataTable EjecutarSPListar2(ref OracleCommand OraCommand, string SPNombre)
        {
            bool ok = true;
            DataTable datatable = new DataTable();

            try
            {
                // Si no esta conectado, se conecta.
                if (!IsConected())
                {
                    ok = Conectar();
                }

                if (ok)
                {
                    OraCommand.Connection = conn;
                    OraCommand.CommandText = SPNombre;
                    OraCommand.CommandType = CommandType.StoredProcedure;
                    OraCommand.ExecuteNonQuery();
                    OracleDataAdapter da = new OracleDataAdapter(OraCommand);
                    da.Fill(datatable);
                }
                return datatable;
            }

            catch (Exception ex)
            {
                AsignarError(ref ex);
                ok = false;
            }

            return datatable;
        }

        public DataSet EjecutarSPListar(ref OracleCommand OraCommand, string SPNombre)
        {
            bool ok = true;
            DataSet dataset = new DataSet();

            try
            {
                // Si no esta conectado, se conecta.
                if (!IsConected())
                {
                    ok = Conectar();
                }

                if (ok)
                {
                    OraCommand.Connection = conn;
                    OraCommand.CommandText = SPNombre;
                    OraCommand.CommandType = CommandType.StoredProcedure;
                    OraCommand.ExecuteNonQuery();
                    OracleDataAdapter da = new OracleDataAdapter(OraCommand);
                    da.Fill(dataset);
                }
                return dataset;
            }

            catch (Exception ex)
            {
                AsignarError(ref ex);
                ok = false;
            }

            return dataset;
        }

        public DataSet EjecutarSqlListar(string SqlQuery)
        {
            bool ok = true;
            DataSet dataset = new DataSet();
            OracleCommand cmd = new OracleCommand();
            try
            {
                // Si no esta conectado, se conecta.
                if (!IsConected())
                {
                    ok = Conectar();
                }

                if (ok)
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = SqlQuery;
                    cmd.ExecuteNonQuery();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dataset);
                }
                return dataset;
            }

            catch (Exception ex)
            {
                AsignarError(ref ex);
                ok = false;
            }

            return dataset;
        }

        public bool EjecutarSP(ref OracleCommand OraCommand, string SPNombre)
        {
            bool ok = true;

            try
            {
                // Si no esta conectado, se conecta.
                if (!IsConected())
                {
                    ok = Conectar();
                }

                if (ok)
                {
                    OraCommand.Connection = conn;
                    OraCommand.CommandText = SPNombre;
                    OraCommand.CommandType = CommandType.StoredProcedure;
                    OraCommand.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                AsignarError(ref ex);
                ok = false;
            }

            return ok;
        }
        #endregion
    }
}
