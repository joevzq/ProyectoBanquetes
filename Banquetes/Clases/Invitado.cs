using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
    public class Invitado
    {
        #region variables
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
        #region metodos
        //Crear invitado
        public void Crear() { }
        //Borrar invitado
        public void Eliminar() { }
        //Borrar todos los invitados
        public void EliminarTodos() { }
        #endregion
    }
}