
using Nivel_de_acceso.Clases;
using Practica2_1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banquetes
{
    public partial class Recibo : Form
    {
        public Recibo()
        {
            InitializeComponent();
        }
        public Recibo(int folio)
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 500, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 100, 250, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(260, 100, 245, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 220, 500, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Estructura objElementos = new Estructura();
            objElementos.Sentencia = "AddCliente";

            objElementos.Parametros = new SqlParameter[]{
                new SqlParameter("folio", SqlDbType.Int),
                new SqlParameter("nombre", SqlDbType.NVarChar, 50),
                new SqlParameter("apaterno", SqlDbType.NVarChar, 50),
                new SqlParameter("amaterno", SqlDbType.NVarChar, 50),
                new SqlParameter("telefono", SqlDbType.NVarChar, 10),
                new SqlParameter("email", SqlDbType.NVarChar, 50),
            };
            objElementos.Valores = new List<object>() {5,"erick", "garcia", "sevilla", "234567891", "sfafer@sfesf.afe" };

            Operaciones objOperaciones = new Operaciones();
            objOperaciones.Elemento = objElementos;
            if (objOperaciones.AgregarCredencial())
                {
                    MessageBox.Show("El empleado se agregó correctamente");
                    Inicio inicio = new Inicio();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Algo salio mal:\n  -Verifique que todos los campos se hayan completado.");
                }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Banquetes.Inicio.evento.Show();
            this.Hide();
        }
    }
}
