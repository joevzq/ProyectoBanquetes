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
       private int telefono;

       public int Telefono
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
       //Método para crear Cliente
       public void Crear(Cliente cliente, int folioEvento) 
       {

       }
       //Método para editar Cliente
       public void Editar(int folioEvento) 
       {

       }
       #endregion
   }
}
