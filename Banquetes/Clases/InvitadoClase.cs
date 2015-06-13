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
    public class InvitadoClase 
    {
        public static List<InvitadoClase> lstInvitados = new List<InvitadoClase>();

        #region Variables
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion
        #region Métodos
        //Llamar invitados
        public void GuardarInvitados()
        {
            Estructura objElementos = new Estructura();
            Operaciones objOperaciones = new Operaciones();

            if (!ReciboClase.nuevo)
            {
                objElementos.Sentencia = "proc_deleteInvitados";
                objElementos.Parametros = new SqlParameter[]{
                    new SqlParameter("folio", SqlDbType.Int)
                };
                objElementos.Valores = new List<object>(){EventoClase.Evento.FolioEvento};
                objOperaciones.Elemento = objElementos;
                objOperaciones.AgregarInfo();
            }
            for (int i = 0; i < lstInvitados.Count; i++)
            {
                objElementos.Sentencia = "proc_setInvitados";
                objElementos.Parametros = new SqlParameter[]{
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("nombre", SqlDbType.NVarChar, 50),
                new SqlParameter("email", SqlDbType.NVarChar, 50)
                };
                objElementos.Valores = new List<object>() { EventoClase.Evento.FolioEvento, lstInvitados[i].Nombre, lstInvitados[i].Email };

                objOperaciones.Elemento = objElementos;
                objOperaciones.AgregarInfo();
            }
        }
        public static void EliminarInvitado(int index) 
        {
            lstInvitados.RemoveAt(index);
        }
        public static void EliminarInvitados()
        {
            lstInvitados.Clear();
        }
        public void ObtenerInvitados(int folio) 
        {
            string tabla = "Invitados";
            Estructura objElements = new Estructura();
            objElements.Sentencia = "proc_getInvitados";
            objElements.Parametros = new SqlParameter[] {
                new SqlParameter("@folio", SqlDbType.Int) 
           };
            objElements.Valores = new List<object>() { folio };
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElements;
            DataTable data = objOperaciones.ObtenerDataTable(tabla);
            lstInvitados.Clear();
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    InvitadoClase invitado = new InvitadoClase();
                    invitado.nombre = data.Rows[i]["nombre"].ToString();
                    invitado.email = data.Rows[i]["email"].ToString();
                    lstInvitados.Add(invitado);
                }
            }

        }

        //Borrar todos los invitados de cierto folio en la base de datos y agregar la nueva lista de invitados
        public void ActualizarInvitados(List<InvitadoClase> lstInv, int folioEvento) { }

        public void BorrarInvitados()
        {
            lstInvitados.Clear();
        }
        #endregion
    }
}