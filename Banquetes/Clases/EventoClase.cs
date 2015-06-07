using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
    public class EventoClase
    {
        public static List<EventoClase> lstEventos;
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
        public List<EventoClase> LlamarEventos() 
        {
            return lstEventos;
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
