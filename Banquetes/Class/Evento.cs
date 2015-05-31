using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
    public class Evento
    {
        
       
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

    }
}
