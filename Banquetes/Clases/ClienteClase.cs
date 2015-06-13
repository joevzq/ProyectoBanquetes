using Banquetes.Clases;
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
    
   public class ClienteClase
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

       public static ClienteClase Cliente = new ClienteClase();

       #region Métodos

       /*Método para guardar cliente en base de datos*/
       public void GuardarCliente()
       {
           string proc;
           proc = ReciboClase.nuevo ? "proc_setCliente" : "proc_updateCliente";

           Estructura objElementos = new Estructura();
           objElementos.Sentencia = proc;
           objElementos.Parametros = new SqlParameter[]{
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("nombre", SqlDbType.NVarChar, 50),
                new SqlParameter("aPaterno", SqlDbType.NVarChar, 50),
                new SqlParameter("aMaterno", SqlDbType.NVarChar, 50),
                new SqlParameter("telefono", SqlDbType.NVarChar, 50),
                new SqlParameter("email", SqlDbType.NVarChar, 50)
           };
           objElementos.Valores = new List<object>() { EventoClase.Evento.FolioEvento, Cliente.nombre, Cliente.apPaterno, Cliente.apMaterno, Cliente.telefono, Cliente.email };
           Operaciones objOperaciones = new Operaciones();
           objOperaciones.Elemento = objElementos;
           objOperaciones.AgregarInfo();
       }
          
       //Método para editar Cliente
       public void Editar(int folioEvento) 
       {

       }

       /*Llamar cliente de base de datos*/
       public void ObtenerCliente(int folio)
       {
           string tabla = "Clientes";
           Estructura objElements = new Estructura();
           objElements.Sentencia = "proc_getCliente";
           objElements.Parametros = new SqlParameter[] {
                new SqlParameter("@folio", SqlDbType.Int) 
           };
           objElements.Valores = new List<object>() {folio};
           Operaciones objOperaciones = new Operaciones();
           objOperaciones.Elemento = objElements;
           DataTable data = objOperaciones.ObtenerDataTable(tabla);

           Cliente.nombre = data.Rows[0]["nombre"].ToString();
           Cliente.apPaterno = data.Rows[0]["apPaterno"].ToString();
           Cliente.apMaterno = data.Rows[0]["apMaterno"].ToString();
           Cliente.telefono = data.Rows[0]["telefono"].ToString();
           Cliente.email = data.Rows[0]["email"].ToString();
       }

       public void BorrarCliente()
       {
           Cliente.nombre = null;
           Cliente.apPaterno = null;
           Cliente.apMaterno = null;
           Cliente.telefono = null;
           Cliente.email = null;
       }
       #endregion
   }
}
