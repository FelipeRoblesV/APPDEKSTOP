using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBS.Controlador;
using WFBS.WebService;

namespace WFBS.Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            daoDashboard dao = new daoDashboard();
            int resp = dao.TotalFuncionario();


            //Cl_Persona persona = dao.RecuperarPersona(per);
            //Console.WriteLine(persona.nombre);
            //Console.WriteLine(persona.apellido);
           


                Console.WriteLine(resp);
                Console.ReadLine();

        }
    }
}
