using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_POO.Classes
{
    public class Credencial : IDisposable
    {
        #region Propiedades
        public string usuario { get; set; }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

        #region Constructores de la clase
        public Credencial()
        {

        }

        public void Dispose()
        {
            GC.Collect();
        }
        public Credencial(string datoUsuario, string datoPassword)
        {
            usuario = datoUsuario;
            password = datoPassword;
        }
        #endregion
    }
}
