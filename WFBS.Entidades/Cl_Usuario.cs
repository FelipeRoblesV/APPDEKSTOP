using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBS.Entidades
{
   public class Cl_Usuario
    {
        #region DEFINICION DE PARAMENTROS
        Utilidad util = new Utilidad();
        public int id { get; set; }
        public string rut { get; set; }
        #endregion
        #region GET/SET PARAMETROS
        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = util.GetMD5(value); }
        }
        public int id_rol { get; set; }
        #endregion
        #region CONSTRUCTORES
        public Cl_Usuario()
        {

        }

        public Cl_Usuario(int id, string rut, string password, int id_rol)
        {
            this.id = id;
            this.rut = rut;
            this.password = password;
            this.id_rol = id_rol;
        }
        #endregion
    }
}
