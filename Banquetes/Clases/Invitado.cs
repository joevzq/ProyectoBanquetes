using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
    public class Invitado
    {
        public List<Invitado> lstInvitados;

        #region Variables
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion
        #region Métodos
        //Llamar invitados
        public List<Invitado> LlamarInvitados(int folioEvento)
        {
            return lstInvitados;
        }
        //Borrar todos los invitados de cierto folio en la base de datos y agregar la nueva lista de invitados
        public void ActualizarInvitados(List<Invitado> lstInv, int folioEvento) { }
        #endregion
    }
}