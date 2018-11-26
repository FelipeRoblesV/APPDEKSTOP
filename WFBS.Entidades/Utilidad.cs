using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
    public class Utilidad
    {
        #region ENCRIPTACION
        public string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        #endregion
        #region VALIDACION DEL RUT
        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }
        #endregion
        #region VALIDAR CORREO
        public Boolean ValidarCorreo(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region CALCULAR EDAD
        public int CarlcularEdadPersona(DateTime pFechaNacimientoPersona)
        {
            int resultado = 0;
            int anioNacimiento = pFechaNacimientoPersona.Year;
            int anioActual = DateTime.Today.Year;

            int aniosDiferencia = anioActual - anioNacimiento;

            DateTime fechaNacimientoCalculo = new DateTime(DateTime.Today.Year, pFechaNacimientoPersona.Month, pFechaNacimientoPersona.Day);

            TimeSpan diasFechaNacimiento = new DateTime(DateTime.Today.Year, 1, 1).Subtract(fechaNacimientoCalculo);
            TimeSpan diasFechaActual = new DateTime(DateTime.Today.Year, 1, 1).Subtract(DateTime.Today);

            if (Math.Abs(diasFechaNacimiento.Days) >= Math.Abs(diasFechaActual.Days))
            {
                resultado = aniosDiferencia;
            }
            else
            {
                resultado = (aniosDiferencia - 1);
            }

            return resultado;
        }

        #endregion
    }
}
