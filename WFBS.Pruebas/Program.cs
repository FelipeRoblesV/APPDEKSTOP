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
            daoPerfil dao = new daoPerfil();

            Cl_Perfil per = new Cl_Perfil();
            per.id = 0;
            per.nombre = "test";
            per.abreviacion = "ho";

           bool resp =
                dao.Modificar(per);


            //string holi = "1234567";

            //int numero1 = (holi.Replace(".", "").Replace("-", "").Trim()).Length;
            //int numero2 = numero1 - 1;
            //string resp1= holi.Replace(".", "").Replace("-", "").Trim().Substring(holi.Replace(".", "").Replace("-", "").Trim().Length - 1, 1);
            //string resp = (holi.Replace(".", "").Replace("-", "").Trim()).Remove(numero2 ,  1);

            //Cl_Persona persona = dao.RecuperarPersona(per);
            //Console.WriteLine(persona.nombre);
            //Console.WriteLine(persona.apellido);

            
            Console.WriteLine(resp);
            Console.ReadLine();


        }
    }
}
