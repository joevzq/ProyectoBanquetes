
using BaseDatos.ConexionBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Nivel_de_acceso.Clases
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

        public dynamic ObjDatos
        {
            get { return objDatos; }
            set { objDatos = value; }
        }

        public Operaciones()
        {
            if (objDatos == null)
            {
                string cadena =
                System.Configuration.ConfigurationManager.ConnectionStrings["CadenaSqlSrv"].ConnectionString;
                objDatos = new Ejecucion(cadena);
            }
        }

        public bool AgregarCredencial()
        {
            bool valido = true;
            int n = objDatos.EjecutaComando(elemento.Parametros,
                elemento.Valores, elemento.Sentencia, CommandType.StoredProcedure);
            return valido;
        }
        public int ObtenerScalar()
        {

            int n = objDatos.EjecutaScalar(elemento.Parametros,
                elemento.Valores, elemento.Sentencia, CommandType.StoredProcedure);

            return n;
        }

        public DataTable ObtenerCredenciales()
        {
            DataTable datos = new DataTable();
            datos = objDatos.SeleccionaDatosDesconectado
                (elemento.Parametros, elemento.Valores, elemento.Sentencia,
            CommandType.StoredProcedure, "");
            return datos;
        }
    }
}
