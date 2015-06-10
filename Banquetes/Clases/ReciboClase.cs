using Banquetes.Class;
using Nivel_de_acceso.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Clases
{
    class ReciboClase
    {
        #region Variables
        public int NumeroFolio;
        #endregion
        #region Metodos
        public void GuardarRecibo()
        {
            EventoClase evento = EventoClase.Evento;
            Estructura objElementos = new Estructura();
            objElementos.Sentencia = "AddEvento";

            objElementos.Parametros = new SqlParameter[]{
                new SqlParameter("nombre", SqlDbType.NVarChar, 30),
                new SqlParameter("fecha", SqlDbType.Date),
                new SqlParameter("hora", SqlDbType.NVarChar, 5),
                new SqlParameter("calle", SqlDbType.NVarChar, 50),
                new SqlParameter("numero", SqlDbType.NVarChar, 5),
                new SqlParameter("colonia", SqlDbType.NVarChar, 50),
                new SqlParameter("cp", SqlDbType.NVarChar, 5),
                new SqlParameter("status", SqlDbType.Int),
                new SqlParameter("comentario", SqlDbType.Text)
            };
            objElementos.Valores = new List<object>() { evento.NombreEvento, evento.FechaEvento.ToShortDateString(), evento.HoraEvento, evento.Calle, evento.Numero, evento.Colonia, evento.Cp, 1, evento.Comentario};
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElementos;
            objOperaciones.AgregarInfo();


            ClienteClase cliente = ClienteClase.ObtenerCliente();
                objElementos.Sentencia = "AddCliente";

                objElementos.Parametros = new SqlParameter[]{
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("nombre", SqlDbType.NVarChar, 50),
                new SqlParameter("aPaterno", SqlDbType.NVarChar, 50),
                new SqlParameter("aMaterno", SqlDbType.NVarChar, 50),
                new SqlParameter("telefono", SqlDbType.NVarChar, 50),
                new SqlParameter("email", SqlDbType.NVarChar, 50)
            };
                objElementos.Valores = new List<object>() { EventoClase.Evento.FolioEvento, cliente.Nombre, cliente.ApPaterno, cliente.ApMaterno, cliente.Telefono, cliente.Email };


                objOperaciones.Elemento = objElementos;
                objOperaciones.AgregarInfo();

                List<InvitadoClase> inv = InvitadoClase.ObtenerInvitados();
                for (int i = 0; i < inv.Count; i++)
                {
                    objElementos.Sentencia = "AddInvitado";

                    objElementos.Parametros = new SqlParameter[]{
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("nombre", SqlDbType.NVarChar, 50),
                new SqlParameter("email", SqlDbType.NVarChar, 50)
                };
                    objElementos.Valores = new List<object>() { EventoClase.Evento.FolioEvento, inv[i].Nombre, inv[i].Email };

                    objOperaciones.Elemento = objElementos;
                    objOperaciones.AgregarInfo();
                }

                objElementos.Sentencia = "AddRecibo";

                objElementos.Parametros = new SqlParameter[]{
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("fecha", SqlDbType.NVarChar, 50),
                new SqlParameter("subtotal", SqlDbType.NVarChar, 50),
                new SqlParameter("total", SqlDbType.NVarChar, 50),
                new SqlParameter("iva", SqlDbType.NVarChar, 50)
            };
                objElementos.Valores = new List<object>() { EventoClase.Evento.FolioEvento, DateTime.Now.ToShortDateString() };


                objOperaciones.Elemento = objElementos;
                objOperaciones.AgregarInfo();


  
        }
        public DataTable ConsultarRecibo(int folio)
        {
            string tabla = "Eventos";
            Estructura objElements = new Estructura();
            objElements.Sentencia = "proc_getRecibo";
            objElements.Parametros = new SqlParameter[] { 
                new SqlParameter("folio", SqlDbType.Int)
            };
            objElements.Valores = new List<object>() { folio };
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElements;
            DataTable data = objOperaciones.ObtenerDataTable(tabla);
            return data;
        }
        public int ObtenerFolio() {
            Estructura objElementos = new Estructura();
            objElementos.Sentencia = "GetMaxFolio";

            objElementos.Parametros = new SqlParameter[]{};
            objElementos.Valores = new List<object>() { };
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElementos;
            int folio = (objOperaciones.ObtenerScalar());
            EventoClase.Evento.FolioEvento = folio;
            return folio;
        }
        #endregion
    }
}
