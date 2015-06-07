using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
    
   public class Cliente
   {
       #region Variables
       private string nombre;

       public string Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }
       private string apPaterno;

       public string ApPaterno
       {
           get { return apPaterno; }
           set { apPaterno = value; }
       }
       private string apMaterno;

       public string ApMaterno
       {
           get { return apMaterno; }
           set { apMaterno = value; }
       }
       private string telefono;

       public string Telefono
       {
           get { return telefono; }
           set { telefono = value; }
       }

       private string email;

       public string Email
       {
           get { return email; }
           set { email = value; }
       }

       #endregion 

       #region Métodos
       public static List<Cliente> lstCli = new List<Cliente>();
  


       
       //Método para crear Cliente
       public void crearEmpleado(string nombre, string Apaterno, string Amaterno, string telefono, string email)
       {
           bool exist = false;
           Cliente newCli = new Cliente();
           newCli.nombre = nombre;
           newCli.apPaterno = Apaterno;
           newCli.apMaterno = Amaterno;
           newCli.telefono = telefono;
           newCli.email = email;

           //for (int i = 0; i < lstCli.Count; i++)
           //{
           //    if (newCli.nombre == lstCli[i].nombre && newCli.apPaterno == lstCli[i].apPaterno && newCli.ApMaterno == lstCli[i].apMaterno && newCli.telefono == lstCli[i].telefono && newCli.email == lstCli[i].email)
           //        exist = true;
           //}
         
       }
          
       //Método para editar Cliente
       public void Editar(int folioEvento) 
       {

       }
       #endregion
   }
}
