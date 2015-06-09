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
            EventoClase evento = new EventoClase();
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
            objElementos.Valores = new List<object>() { evento.NombreEvento, evento.FechaEvento, evento.HoraEvento, evento.Calle, evento.Numero, evento.Colonia, evento.Cp, evento.Status, evento.Comentario};
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElementos;
            objOperaciones.AgregarInfo();


            ClienteClase cliente = new ClienteClase();
                objElementos.Sentencia = "AddCliente";

                objElementos.Parametros = new SqlParameter[]{
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("nombre", SqlDbType.NVarChar, 50),
                new SqlParameter("aPaterno", SqlDbType.NVarChar, 50),
                new SqlParameter("aMaterno", SqlDbType.NVarChar, 50),
                new SqlParameter("telefono", SqlDbType.NVarChar, 50),
                new SqlParameter("email", SqlDbType.NVarChar, 50)
            };
                objElementos.Valores = new List<object>() {NumeroFolio, cliente.Nombre, cliente.ApPaterno, cliente.ApMaterno, cliente.Telefono, cliente.Email };


                objOperaciones.Elemento = objElementos;
                objOperaciones.AgregarInfo();

                InvitadoClase invitado = new InvitadoClase();
                //for (int i = 0; i < invitado.lstInvitado.Count; i++)
                //{
                //    objElementos.Sentencia = "AddInvitado";

                //    objElementos.Parametros = new SqlParameter[]{
                //    new SqlParameter("folio", SqlDbType.Int),
                //    new SqlParameter("nombre", SqlDbType.NVarChar, 50),
                //    new SqlParameter("email", SqlDbType.NVarChar, 50)
                //    };
                //    objElementos.Valores = new List<object>() { NumeroFolio, invitado.lstInvitado[i] };

                //    objOperaciones.Elemento = objElementos;
                //    objOperaciones.AgregarInfo();
                //}



  
        }
        public void ConsultarRecibo()
        {

        }
        public int GenerarRecibo()
        {

            return NumeroFolio;
        }
        #endregion
    }
}
