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
    public class EventoClase
    {
        public static EventoClase Evento = new EventoClase();
        private static List<EventoClase> lstEventos = new List<EventoClase>();

        #region Variables
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private int folioEvento;
        public int FolioEvento
        {
            get { return folioEvento; }
            set { folioEvento = value; }
        }

        private string nombreEvento;
        public string NombreEvento
        {
            get { return nombreEvento; }
            set { nombreEvento = value; }
        }

        private DateTime fechaEvento = DateTime.Today;
        public DateTime FechaEvento
        {
            get { return fechaEvento; }
            set { fechaEvento = value; }
        }

        private string horaEvento;
        public string HoraEvento
        {
            get { return horaEvento; }
            set { horaEvento = value; }
        }

        private string calle;
        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        private string colonia;
        public string Colonia
        {
            get { return colonia; }
            set { colonia = value; }
        }

        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string cp;
        public string Cp
        {
            get { return cp; }
            set { cp = value; }
        }

        private string comentario;
        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
        #endregion

        #region Métodos
        /*Guardar evento en la base de datos*/
        public void GuardarEvento()
        {
            if (ReciboClase.nuevo)
            {
                Estructura objElementos = new Estructura();
                objElementos.Sentencia = "proc_setEvento";
                objElementos.Parametros = new SqlParameter[]{
                    new SqlParameter("nombre", SqlDbType.NVarChar, 30),
                    new SqlParameter("fecha", SqlDbType.Date),
                    new SqlParameter("hora", SqlDbType.NVarChar, 5),
                    new SqlParameter("calle", SqlDbType.NVarChar, 50),
                    new SqlParameter("numero", SqlDbType.NVarChar, 20),
                    new SqlParameter("colonia", SqlDbType.NVarChar, 50),
                    new SqlParameter("cp", SqlDbType.NVarChar, 5),
                    new SqlParameter("comentario", SqlDbType.Text)
                };
                objElementos.Valores = new List<object>() {Evento.nombreEvento, Evento.fechaEvento, Evento.horaEvento, Evento.calle, Evento.numero, 
                Evento.colonia, Evento.cp, Evento.comentario};
                Operaciones objOperaciones = new Operaciones();
                objOperaciones.Elemento = objElementos;
                objOperaciones.AgregarInfo();
            }
            else
            {
                Estructura objElementos = new Estructura();
                objElementos.Sentencia = "proc_updateEvento";
                objElementos.Parametros = new SqlParameter[]{
                    new SqlParameter("folio", SqlDbType.Int),
                    new SqlParameter("nombre", SqlDbType.NVarChar, 30),
                    new SqlParameter("fecha", SqlDbType.Date),
                    new SqlParameter("hora", SqlDbType.NVarChar, 5),
                    new SqlParameter("calle", SqlDbType.NVarChar, 50),
                    new SqlParameter("numero", SqlDbType.NVarChar, 20),
                    new SqlParameter("colonia", SqlDbType.NVarChar, 50),
                    new SqlParameter("cp", SqlDbType.NVarChar, 5),
                    new SqlParameter("comentario", SqlDbType.Text)
                };
                objElementos.Valores = new List<object>() { Evento.folioEvento, Evento.nombreEvento, Evento.fechaEvento, Evento.horaEvento, Evento.calle, Evento.numero, 
                Evento.colonia, Evento.cp, Evento.comentario};
                Operaciones objOperaciones = new Operaciones();
                objOperaciones.Elemento = objElementos;
                objOperaciones.AgregarInfo();
            }
        }

        /*Actualizar status de evento*/
        public void ActualizarStatus(int folioEvento, int status, bool existeComentario, string comentario) 
        {
            if (existeComentario)
            {
                Estructura objElements = new Estructura();
                objElements.Sentencia = "proc_UpdateStatusWComentario";
                objElements.Parametros = new SqlParameter[] {
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("status", SqlDbType.Int),
                new SqlParameter("comentario", SqlDbType.Text)
            };
                objElements.Valores = new List<object>() { folioEvento, status, comentario };
                Operaciones objOperaciones = new Operaciones();
                objOperaciones.Elemento = objElements;
                objOperaciones.AgregarInfo();
            }

            else
            {
                Estructura objElements = new Estructura();
                objElements.Sentencia = "proc_UpdateStatus";
                objElements.Parametros = new SqlParameter[] {
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("status", SqlDbType.Int)
            };
                objElements.Valores = new List<object>() { folioEvento, status };
                Operaciones objOperaciones = new Operaciones();
                objOperaciones.Elemento = objElements;
                objOperaciones.AgregarInfo();
            }
        }

        /*Actualizar automáticamente status de eventos que ya han sido realizados*/
        public void ActualizarStatusPorFecha()
        {
            Estructura objElements = new Estructura();
            objElements.Sentencia = "proc_updateStatusPorFecha";
            objElements.Parametros = new SqlParameter[] { };
            objElements.Valores = new List<object>() { };
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElements;
            objOperaciones.AgregarInfo();
        }
        /*Llamar todos los eventos para la ventana de Admin*/
        public List<EventoClase> LlamarEventos()
        {
            string tabla = "Eventos";
            Estructura objElements = new Estructura();
            objElements.Sentencia = "proc_getEventos";
            objElements.Parametros = new SqlParameter[] { };
            objElements.Valores = new List<object>() { };
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElements;
            DataTable data = objOperaciones.ObtenerDataTable(tabla);
            lstEventos.Clear();

            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    EventoClase ev = new EventoClase();
                    ev.folioEvento = Convert.ToInt32(data.Rows[i]["folio"]);
                    ev.nombreEvento = data.Rows[i]["nombre"].ToString();
                    ev.fechaEvento = Convert.ToDateTime(data.Rows[i]["fechaEvento"]);
                    ev.horaEvento = data.Rows[i]["hora"].ToString();
                    ev.status = Convert.ToInt32(data.Rows[i]["status"]);
                    ev.comentario = data.Rows[i]["comentario"].ToString();
                    ev.calle = data.Rows[i]["calle"].ToString();
                    ev.colonia = data.Rows[i]["colonia"].ToString();
                    ev.numero = data.Rows[i]["numero"].ToString();
                    ev.cp = data.Rows[i]["cp"].ToString();
                    lstEventos.Add(ev);
                }
            }
            return lstEventos;
        }

        /*Obtener información de un evento de la base de datos*/
        public void ObtenerEvento(int folio)
        {
            string tabla = "Eventos";
            Estructura est = new Estructura();
            est.Sentencia = "proc_getEvento";
            est.Parametros = new SqlParameter[]{
                new SqlParameter("@folio", SqlDbType.Int)
            };
            est.Valores = new List<object>() { folio };
            Operaciones op = new Operaciones();
            op.Elemento = est;
            DataTable data = op.ObtenerDataTable(tabla);
            Evento.folioEvento = folio;
            Evento.nombreEvento = data.Rows[0]["nombre"].ToString();
            Evento.fechaEvento = Convert.ToDateTime(data.Rows[0]["fechaEvento"]);
            Evento.horaEvento = data.Rows[0]["hora"].ToString();
            Evento.calle = data.Rows[0]["calle"].ToString();
            Evento.colonia = data.Rows[0]["colonia"].ToString();
            Evento.numero = data.Rows[0]["numero"].ToString();
            Evento.cp = data.Rows[0]["cp"].ToString();
            Evento.comentario = data.Rows[0]["comentario"].ToString();
        }

        /*Actualizar fecha de un evento*/
        public void ActualizarFecha(int folioEvento, DateTime nuevaFecha) 
        {
            Estructura objElements = new Estructura();
            objElements.Sentencia = "proc_UpdateFecha";
            objElements.Parametros = new SqlParameter[] {
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("fecha", SqlDbType.Date) 
            };
            objElements.Valores = new List<object>() { folioEvento, nuevaFecha};
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElements;
            objOperaciones.AgregarInfo();
        }

        /*Verificar que el evento a modificar/cancelar se encuentra a más de tres de días de ser realizado*/
        public bool VerificarFecha(int folio) 
        {
            Estructura objElemento = new Estructura();
            string tabla = "Eventos";
            objElemento.Sentencia = "proc_getFechaEvento";
            objElemento.Parametros = new SqlParameter[]{
                new SqlParameter("folio", SqlDbType.Int)
            };
            objElemento.Valores = new List<object>(){folio};
            Operaciones objOperacion = new Operaciones();
            objOperacion.Elemento = objElemento;
            DataTable data = objOperacion.ObtenerDataTable(tabla);
            DateTime fechaEvento = Convert.ToDateTime(data.Rows[0]["fechaEvento"]);
            double dias = (fechaEvento - DateTime.Today).TotalDays;
            bool valido = dias > 3 ? true : false;
            return valido;
        }

        /*Limpiar objeto estático de evento*/
        public void BorrarEvento()
        {
            Evento.nombreEvento = null;
            Evento.fechaEvento = DateTime.Today;
            Evento.horaEvento = null;
            Evento.calle = null;
            Evento.colonia = null;
            Evento.numero = null;
            Evento.cp = null;
            Evento.comentario = null;
        }

        /*Checar que el folio existe en la base de datos y tiene status = 1 (Evento por realizar)*/
        public bool checarFolioEvento(int folio)
        {
            bool valido;

            Estructura objElements = new Estructura();
            Operaciones objOperaciones = new Operaciones();
            objElements.Sentencia = "proc_checkFolio";
            objElements.Parametros = new SqlParameter[]{
                new SqlParameter("folio", SqlDbType.Int)
            };
            objElements.Valores = new List<object>() { folio };
            objOperaciones.Elemento = objElements;
            int select = objOperaciones.ObtenerScalar();
            valido = select > 0 ? true : false;
            return valido;
        }
        #endregion
    }
}
