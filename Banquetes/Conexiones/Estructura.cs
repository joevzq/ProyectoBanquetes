using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_1.Clases
{
   public class Estructura
    {
        SqlParameter[] parametros;
        public SqlParameter[] Parametros
        {
            get { return parametros; }
            set { parametros = value; }
        }
        List<object> valores;

        public List<object> Valores
        {
            get { return valores; }
            set { valores = value; }
        }
        string sentencia;

        public string Sentencia
        {
            get { return sentencia; }
            set { sentencia = value; }
        }
        string tabla;

        public string Tabla
        {
            get { return tabla; }
            set { tabla = value; }
        }
        public Estructura()
        {
            valores = new List<object>();
        }
    }
}