using Practica2_1.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquetes.Class
{
    public  class MenuClase
    {
        public class Entrada
        {
            public int idEntrada { set; get; }
            public string nombre { set; get; }
            public int precioUnit { set; get; }
            public int tipo { set; get; }
            public string descripcion { set; get; }
            public string imagen { set; get; }
            public List<string> ingredientes { set; get; }

        }
        public static List<Entrada> lstEntradas = new List<Entrada>();
        public static List<Entrada> lstMenuCliente = new List<Entrada>();

        #region Variables
        private int idEntrada;
        public int IdEntrada
        {
            get { return idEntrada; }
            set { idEntrada = value; }
        }

        private int porciones;
        public int Porciones
        {
            get { return porciones; }
            set { porciones = value; }
        }
        #endregion 

        #region Métodos
        //Método para Actualizar lista
        public void ActualizarLista() 
        {

        }
        //Método para Actualizar Menú
        public void ActualizarMenu() 
        {

        }
        //Método para Crear Menú 
        public void CrearMenu() 
        {

        }
        //Método para Calcular el Precio de los elementos del menú
        public void CalcularPrecioMenu() 
        {

        }
        //Método para mostrar elementos del menú
        public void MostrarMenu() 
        {
            string tabla = "Entradas";
            Estructura objElements = new Estructura();
            objElements.Sentencia = "proc_getMenu";
            objElements.Parametros = new SqlParameter[] { };
            objElements.Valores = new List<object>() { };
            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElements;
            DataTable data = objOperaciones.ObtenerDataTable(tabla);
            lstEntradas.Clear();

            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    MenuClase.Entrada ent = new MenuClase.Entrada();
                    ent.idEntrada = Convert.ToInt32(data.Rows[i]["idEntrada"]);
                    ent.nombre = data.Rows[i]["nombre"].ToString();
                    ent.precioUnit = Convert.ToInt32(data.Rows[i]["precioUnit"]);
                    ent.tipo = Convert.ToInt32(data.Rows[i]["tipo"]);
                    ent.descripcion = data.Rows[i]["descripcion"].ToString();
                    ent.imagen = data.Rows[i]["imagen"].ToString();
                    lstEntradas.Add(ent);
                }
            }
            for (int i = 0; i < lstEntradas.Count; i++)
            {
                tabla = "Ingredientes";
                objElements.Sentencia = "proc_getIngredientes";
                objElements.Parametros = new SqlParameter[] {
                    new SqlParameter("id", SqlDbType.Int)
                };
                objElements.Valores = new List<object>() { i+1 };
                objOperaciones.Elemento = objElements;
                data = objOperaciones.ObtenerDataTable(tabla);
                lstEntradas[i].ingredientes = new List<string>(); 

                for (int j = 0; j < data.Rows.Count; j++)
                {
                    lstEntradas[i].ingredientes.Add(data.Rows[j]["nombre"].ToString());
                }
            }
        }
        //Métosdo para Mostar más información del platillo
        public void MostrarPlatillo() 
        {

        }
        #endregion
    }
}
