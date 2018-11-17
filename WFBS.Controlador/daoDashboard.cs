using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Controlador
{
    public class daoDashboard
    {

        public int TotalFuncionario()
        {
            DataSet resultado = new DataSet();
            int total = 0;
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_TOTAL_FUNCIONARIO";
                resultado = conn.EjecutarSqlListar(sql);
                DataRow dr = resultado.Tables[0].Rows[0];
                total = int.Parse(dr[0].ToString());
                return total;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int totalJefeFuncionario()
        {
            DataSet resultado = new DataSet();
            int total = 0;
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_TOTAL_JEFE_FUNCIONARIO";
                resultado = conn.EjecutarSqlListar(sql);
                DataRow dr = resultado.Tables[0].Rows[0];
                total = int.Parse(dr[0].ToString());
                return total;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int totalPerfil()
        {
            DataSet resultado = new DataSet();
            int total = 0;
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_TOTAL_PERFIL";
                resultado = conn.EjecutarSqlListar(sql);
                DataRow dr = resultado.Tables[0].Rows[0];
                total = int.Parse(dr[0].ToString());
                return total;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int totalCargo()
        {
            DataSet resultado = new DataSet();
            int total = 0;
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_TOTAL_CARGO";
                resultado = conn.EjecutarSqlListar(sql);
                DataRow dr = resultado.Tables[0].Rows[0];
                total = int.Parse(dr[0].ToString());
                return total;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int totalEvaluacion()
        {
            DataSet resultado = new DataSet();
            int total = 0;
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_TOTAL_EVALUACION";
                resultado = conn.EjecutarSqlListar(sql);
                DataRow dr = resultado.Tables[0].Rows[0];
                total = int.Parse(dr[0].ToString());
                return total;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int totalPreguntas()
        {
            DataSet resultado = new DataSet();
            int total = 0;
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_TOTAL_PREGUNTA";
                resultado = conn.EjecutarSqlListar(sql);
                DataRow dr = resultado.Tables[0].Rows[0];
                total = int.Parse(dr[0].ToString());
                return total;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int totalAlternativas()
        {
            DataSet resultado = new DataSet();
            int total = 0;
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_TOTAL_ALTERNATIVA";
                resultado = conn.EjecutarSqlListar(sql);
                DataRow dr = resultado.Tables[0].Rows[0];
                total = int.Parse(dr[0].ToString());
                return total;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int totalCompetencia()
        {
            DataSet resultado = new DataSet();
            int total = 0;
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_TOTAL_COMPETENCIA";
                resultado = conn.EjecutarSqlListar(sql);
                DataRow dr = resultado.Tables[0].Rows[0];
                total = int.Parse(dr[0].ToString());
                return total;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataSet listar()
        {
            DataSet resultado = new DataSet();
            try
            {
                Contexto conn = new Contexto();
                String sql = "Select * from VIEW_LISTAR_AUDITORIAS";
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
