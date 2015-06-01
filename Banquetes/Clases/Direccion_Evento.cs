using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
    class Direccion_Evento
    {
        #region Variables
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
        #endregion
    }
}
