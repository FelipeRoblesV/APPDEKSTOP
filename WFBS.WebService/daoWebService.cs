using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.WebService
{
    public class daoWebService
    {

        public Cl_Persona RecuperarPersona(string run)
        {
            try
            {
                webService.MainWSClient WS = new webService.MainWSClient();
                webService.clPersona persona = new webService.clPersona();
                Cl_Persona personaFinal = new Cl_Persona();
                persona = WS.Recuperar_Persona(run);
                personaFinal.run = persona.run;
                personaFinal.dv = Convert.ToChar(persona.dv);
                personaFinal.nombre = persona.nombre;
                personaFinal.apellido = persona.apellido;
                personaFinal.fechaNacimiento = persona.fechaNacimiento;
                personaFinal.correo = persona.correo;
                personaFinal.telefono = int.Parse(persona.telefono);
                return personaFinal;
            }
            catch (Exception)
            {

                throw new Exception("Funcionario no tiene datos disponibles.");
            }
        }

        public List<Cl_Curso> listarCursos (Cl_Persona per)
        {
            try
            {
                webService.MainWSClient WS = new webService.MainWSClient();
                webService.clCurso curso = new webService.clCurso();
                DataSet ds = new DataSet();
                List<Cl_Curso> listar = new List<Cl_Curso>();
                webService.clCurso[] hola = WS.Listar_Curso(per.run);
                foreach (var item in hola)
                {
                    Cl_Curso curso2 = new Cl_Curso();
                    curso2.nombre = item.nombre;
                    curso2.sigla = item.siglas;
                    curso2.instituto = item.institucion;
                    curso2.fecha = item.fecha;
                    listar.Add(curso2);
                }
                return listar;
            
            }
            catch (Exception)
            {

                throw new Exception("Funcionario no tiene a cursado ningun curso.");
            }
        }

        public bool ValidarCursos(Cl_Persona per)
        {
            try
            {
                webService.MainWSClient WS = new webService.MainWSClient();
                bool respuesta = WS.Validar_Cursos(per.run);
                return respuesta;


            }
            catch (Exception)
            {

                return false;
            }
        }


    }
}
