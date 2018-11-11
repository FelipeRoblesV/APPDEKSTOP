using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBS.WebService;

namespace WFBS.Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            daoWebService dao = new daoWebService();
            Cl_Persona per = new Cl_Persona();
            per.run = "1";

            //Cl_Persona persona = dao.RecuperarPersona(per);
            //Console.WriteLine(persona.nombre);
            //Console.WriteLine(persona.apellido);
            List<Cl_Curso> listar = dao.listarCursos(per);

            foreach (var item in listar)
            {
                Console.WriteLine(item.nombre);
                Console.ReadLine();

            }
         

        }
    }
}
