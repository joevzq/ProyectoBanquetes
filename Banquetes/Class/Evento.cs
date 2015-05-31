using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
    public class Evento
    {
        #region variables
        private enum status { por_realizar, realizado, cancelado };

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

        internal Direccion_Evento Direccion
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

        #region metodos
        //Crear evento
        public void Crear() { }
        //Actualizar status de evento
        public void ActualizarStatus() { }
        //Cancelar evento
        public void Cancelar() { }
        //Mostrar eventos en la ventana de admin, dividos dependiendo de su status
        public void MostrarEventos() { }
        //Actualizar fecha de un evento
        public void ActualizarFecha() { }
        //Verificar que el evento a modificar/cancelar se encuentra a más de tres de días de ser realizado
        public bool VerificarFecha() { return true; }
        #endregion
    }
}
