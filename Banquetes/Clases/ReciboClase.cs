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
        public static bool nuevo; //Si es true, se inserta un nuevo evento a la base de datos, si es false, se modifica un evento existente.
        public static ReciboClase recibo = new ReciboClase();

        #region Variables

        private double subtotal;
        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        
        private double iva;
        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        private double total;
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        #endregion

        #region Metodos
        public void GuardarRecibo()
        {
            EventoClase evento = new EventoClase();
            evento.GuardarEvento();
            MenuClase menu = new MenuClase();
            menu.GuardarMenu();
            InvitadoClase inv = new InvitadoClase();
            inv.GuardarInvitados();
            ClienteClase cli = new ClienteClase();
            cli.GuardarCliente();

            string proc;
            proc = nuevo ? "proc_setRecibo" : "proc_updateRecibo";

            Estructura objElementos = new Estructura();
            objElementos.Sentencia = proc;

            objElementos.Parametros = new SqlParameter[]{
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("fecha", SqlDbType.NVarChar, 50),
                new SqlParameter("subtotal", SqlDbType.NVarChar, 50),
                new SqlParameter("total", SqlDbType.NVarChar, 50),
                new SqlParameter("iva", SqlDbType.NVarChar, 50)
            };
            objElementos.Valores = new List<object>() { EventoClase.Evento.FolioEvento, DateTime.Now.ToShortDateString(), recibo.subtotal, recibo.iva, recibo.total};

            Operaciones objOperaciones = new Operaciones();

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
        
        /*Obtener último folio de la base de datos para ponerlo en el recibo*/
        public int ObtenerFolio() {
            Estructura objElementos = new Estructura();
            objElementos.Sentencia = "proc_getMaxFolio";

            objElementos.Parametros = new SqlParameter[]{};
            objElementos.Valores = new List<object>() { };
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElementos;
            int folio = (objOperaciones.ObtenerScalar()) + 1;
            return folio;
        }
        #endregion
    }
}
