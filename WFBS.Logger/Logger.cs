using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Logger
{
    public class Logger
    {

        private static string _log_ruta_documento = @"c:\logfile_wfbs.txt";

        public static string rutaArchivo
        {
            get { return Logger._log_ruta_documento; }
            set { if (value.Length > 0) Logger._log_ruta_documento = value; }
        }


        public static void flush()
        {
            File.WriteAllText(Logger._log_ruta_documento, string.Empty);
        }


        public static void log(string msg)
        {
            if (msg.Length > 0)
            {
                using (StreamWriter sw = File.AppendText(Logger._log_ruta_documento))
                {
                    sw.WriteLine("{0} {1}: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), msg);
                    sw.Flush();
                }
            }
        }
    }
}
