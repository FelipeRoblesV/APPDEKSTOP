using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBS.Controlador;
using WFBS.Entidades;
using WFBS.WebService;

namespace WFBS.Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 1.1;
            decimal numero2 = Convert.ToDecimal(numero);

            daoUtilidad dao = new daoUtilidad();
            Cl_Cuestionario eva = new Cl_Cuestionario();

            eva.id = 23;




            Console.WriteLine(dao.recuperarFechaInicio(eva));
            Console.ReadLine();


        }
    }
}
