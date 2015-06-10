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

        private DateTime fechaEvento;
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

        private int cp;
        public int Cp
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
        //Crear evento
        public void Crear(string nombre,string calle,string colonia,int cp,string numero,string hora,string comentario,DateTime fecha) {

            Evento.NombreEvento = nombre;
            Evento.Calle = calle;
            Evento.Colonia = colonia;
            Evento.Cp = cp;
            Evento.Numero = numero;
            Evento.HoraEvento = hora;
            Evento.FechaEvento = fecha;
            Evento.Comentario = comentario;
        }

        //Actualizar status de evento
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

        //Cancelar evento
        public void Cancelar(int folioEvento) { }

        //Llamar todos los eventos
        public static EventoClase ObtenerEvento() 
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
                    ev.cp = Convert.ToInt32(data.Rows[i]["cp"]);
                    lstEventos.Add(ev);
                }
            }
            return lstEventos;
        }

        //Llamar un evento
        public Evento LlamarEvento(int folioEvento)
        {
            Evento ev = new Evento();
            return ev;
        }

        //Actualizar fecha de un evento
        public void ActualizarFecha(int folioEvento, DateTime nuevaFecha) 
        {
            string tabla = "Eventos";
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

        //Verificar que el evento a modificar/cancelar se encuentra a más de tres de días de ser realizado
        public bool VerificarFecha(int folioEvento) 
        { 
            return true; 
        }
        #endregion
    }
}
