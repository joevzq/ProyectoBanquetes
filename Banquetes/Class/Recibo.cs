using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
   public class Recibo
   {

       #region variable
       private int total;

       public int Total
       {
           get { return total; }
           set { total = value; }
       }
       private int iva;

       public int Iva
       {
           get { return iva; }
           set { iva = value; }
       } 

       #endregion 
       //Método para Calcular total monetario
       public void CalcularTotal() 
       {

       }
       //Método para imprimir recibo
       public void ImprimirRecibo() 
       {

       }
       //Método para guardar datos del recibo
       public void GuardarRecibo() 
       {

       }
    }
}
