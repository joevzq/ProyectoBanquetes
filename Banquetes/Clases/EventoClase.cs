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
        private static List<EventoClase> lstEventos = new List<EventoClase>();

        public static List<EventoClase> llamarlstEventos()
        {
            return lstEventos;
        }
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

        private Direccion_Evento direccion;
        public Direccion_Evento Direccion
        {
            get { return direccion; }
            set { direccion = value; }
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
        public void Crear(Evento evento) { 

        }
        //Actualizar status de evento
        public void ActualizarStatus(int folioEvento) { }
        //Cancelar evento
        public void Cancelar(int folioEvento) { }
        //Llamar todos los eventos
        public void LlamarEventos() 
        {
            string tabla = "Eventos";
            Estructura objElements = new Estructura();
            objElements.Sentencia = "proc_getEventos";
            objElements.Parametros = new SqlParameter[]{};
            objElements.Valores = new List<object>() {};
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElements;
            DataTable data = objOperaciones.ObtenerDataTable(tabla);
            lstEventos.Clear();
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    EventoClase evento = new EventoClase();
                    evento.folioEvento = Convert.ToInt32(data.Rows[i]["folio"]);
                    evento.nombreEvento = data.Rows[i]["nombre"].ToString();
                    evento.fechaEvento = Convert.ToDateTime(data.Rows[i]["fechaEvento"]);
                    evento.horaEvento = data.Rows[i]["hora"].ToString();
                    evento.status = Convert.ToInt32(data.Rows[i]["status"]);
                    evento.comentario = data.Rows[i]["comentario"].ToString();
                    evento.direccion.Calle = data.Rows[i]["calle"].ToString();
                    evento.direccion.Colonia = data.Rows[i]["colonia"].ToString();
                    evento.direccion.Numero = data.Rows[i]["numero"].ToString();
                    evento.direccion.Cp = Convert.ToInt32(data.Rows[i]["cp"]);
                    lstEventos.Add(evento);
                }
            }

        }
        //Llamar un evento
        public Evento LlamarEvento(int folioEvento)
        {
            Evento ev = new Evento();
            return ev;
        }
        //Actualizar fecha de un evento
        public void ActualizarFecha(int folioEvento, DateTime nuevaFecha) { }
        //Verificar que el evento a modificar/cancelar se encuentra a más de tres de días de ser realizado
        public bool VerificarFecha(int folioEvento) 
        { 
            return true; 
        }
        #endregion
    }
}
