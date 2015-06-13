using Intro_POO.Classes;
using Nivel_de_acceso.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

       public int ChecarUsuario(string usr, string pwd) 
       {
           Credencial objCredential = new Credencial(usr, pwd); //Create new Credential object with override method and encapsulate password
           Estructura objElements = new Estructura(); //Create new Estructura object

           //Query to select user level, username and password from database
           objElements.Sentencia = "proc_getCountAdmin";

           //Create new SqlParameters
           objElements.Parametros = new SqlParameter[]{
                        new SqlParameter("usr", SqlDbType.VarChar, 50),
                        new SqlParameter("pwd", SqlDbType.VarChar, 50)
                    };

           //Don't really understand this line
           objElements.Valores = new List<object>() { objCredential.usuario, objCredential.Password };

           Operaciones objOperaciones = new Operaciones();
           objOperaciones.Elemento = objElements; 
           return objOperaciones.ObtenerScalar(); 
       }
       
       #endregion
   }
}
