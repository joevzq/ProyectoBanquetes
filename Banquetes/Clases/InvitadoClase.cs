using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
    public class InvitadoClase 
    {
        public static List<InvitadoClase> lstInvitados = new List<InvitadoClase>();
        public static InvitadoClase invitado = new InvitadoClase();

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
        public static void AgregarInvitado(string nombre, string email){
            invitado.Nombre = nombre;
            invitado.Email = email;
            lstInvitados.Add(invitado);
        }
        public static void EliminarInvitado(int index) {
            lstInvitados.RemoveAt(index);
        }
        public static void EliminarInvitados()
        {
            lstInvitados.Clear();
        }
        public static List<InvitadoClase> ObtenerInvitados() {
            return lstInvitados;
        }
        //Borrar todos los invitados de cierto folio en la base de datos y agregar la nueva lista de invitados
        public void ActualizarInvitados(List<InvitadoClase> lstInv, int folioEvento) { }
        #endregion
    }
}