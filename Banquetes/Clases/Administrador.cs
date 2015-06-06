using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
   public class Administrador
   {
       #region Variables
       private string usuario;

       public string Usuario
       {
           get { return usuario; }
           set { usuario = value; }
       }
       private string password;

       public string Password
       {
           get { return password; }
           set { password = value; }
       }

       #endregion 
       #region Constructor de la clase
       public Administrador() 
       {

       }
       public void Dispose() 
       {
           GC.Collect();

       }
       #endregion 

       #region Métodos


       //Método para verificar existencia de credencial

       public Administrador(string usr, string pwd) 
       {
           usuario = usr;
           password = pwd;
       }
       
       #endregion
   }
}
