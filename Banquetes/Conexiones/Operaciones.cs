using BaseDatos.ConexionBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_1.Clases
{
    class Operaciones
    {
        private Estructura elemento;

        public Estructura Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }

        private Ejecucion objDatos;

        public Ejecucion ObjDatos
        {
            get { return objDatos; }
            set { objDatos = value; }
        }

        public Operaciones()
        {
            if (objDatos == null)
            {
                string cadena = System.Configuration.ConfigurationManager.ConnectionStrings["CadenaSqlSrv"].ConnectionString;

                objDatos = new Ejecucion(cadena);
            }
        }
        public bool AgregarCredencial()
        {
            bool valido = false;
            int n = objDatos.EjecutaComando(elemento.Parametros, elemento.Valores, elemento.Sentencia, CommandType.StoredProcedure);
            if (n > 0)
                valido = true;

            return valido;
        }
        public int ObtenerScalar()
        {
            int n = objDatos.EjecutaScalar(elemento.Parametros, elemento.Valores, elemento.Sentencia, CommandType.Text);
            return n;
        }
        public DataTable ObtenerCredenciales()
        {
            DataTable datos = new DataTable();
            datos = objDatos.SeleccionaDatosDesconectado(elemento.Parametros, elemento.Valores, elemento.Sentencia, CommandType.Text, "tbl_Credencial");
            return datos;
        }
    }
}