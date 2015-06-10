
using Banquetes.Clases;
using Banquetes.Class;
using Nivel_de_acceso.Clases;
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
        private bool deAdmin;
        public Recibo()
        {
            InitializeComponent();
            deAdmin = true;
            llenarReciboDS();
        }
        public Recibo(int folio)
        {
            deAdmin = false;
            InitializeComponent();
            llenarReciboDB(folio);

        }
        private void rellenarCampos() { 
            ClienteClase cli = ClienteClase.ObtenerCliente();
            lblTelCliente.Text = cli.Telefono;
            lblNombreCliente.Text = cli.Nombre + " " + cli.ApPaterno + " " + cli.ApMaterno;
            lblEmailCliente.Text = cli.Email;
            EventoClase eve = EventoClase.Evento;
            lblNombreEvento.Text = eve.NombreEvento;
            lblFechaEvento.Text = eve.FechaEvento.ToShortDateString();
            lblHoraEvento.Text = eve.HoraEvento.ToString();
            ReciboClase rec = new ReciboClase();
            lblFolio.Text = rec.ObtenerFolio().ToString();
            lblDireccionEvento.Text = eve.Calle + " " + eve.Numero +" Colonia " + eve.Colonia+" Cp: "+ eve.Cp;
            lblFechaRecibo.Text = DateTime.Now.ToShortDateString();

            
        }

        #region PaintPanels
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
        #endregion

        #region Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (deAdmin)
            {
            Inicio inicio = new Inicio();
            inicio.Show();
                this.Dispose();
        }
            else
                this.Dispose();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            ReciboClase recibo = new ReciboClase();
                    recibo.GuardarRecibo();
                    Inicio inicio = new Inicio();
                    inicio.Show();
                    this.Hide();
                }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Banquetes.Inicio.evento.Show();
            this.Hide();
        }

        private void llenarReciboDB(int folio)
        {
            ReciboClase recCl = new ReciboClase();
            DataTable data = recCl.ConsultarRecibo(folio);
            lblFolio.Text = folio.ToString();
            lblFechaRecibo.Text = Convert.ToDateTime(data.Rows[0]["fechaRecibo"]).ToShortDateString();
            lblNombreCliente.Text = data.Rows[0]["nombrecliente"].ToString();
            lblTelCliente.Text = data.Rows[0]["telefono"].ToString();
            lblEmailCliente.Text = data.Rows[0]["email"].ToString();
            lblNombreEvento.Text = data.Rows[0]["nombre"].ToString();
            lblFechaEvento.Text = Convert.ToDateTime(data.Rows[0]["fechaEvento"]).ToShortDateString();
            lblHoraEvento.Text = data.Rows[0]["hora"].ToString();
            lblDireccionEvento.Text = data.Rows[0]["calle"].ToString() + " " + data.Rows[0]["numero"].ToString() +
                " " + data.Rows[0]["colonia"].ToString() + " " + data.Rows[0]["cp"].ToString();
            lblSubtotal.Text = "$" + Convert.ToInt32(data.Rows[0]["subtotal"]).ToString();
            lblIva.Text = "$" + Convert.ToInt32(data.Rows[0]["iva"]).ToString();
            lblTotal.Text = "$" + Convert.ToInt32(data.Rows[0]["total"]).ToString();
        }

        private void llenarReciboDS()
        {
            ClienteClase cli = ClienteClase.ObtenerCliente();
            lblTelCliente.Text = cli.Telefono;
            lblNombreCliente.Text = cli.Nombre + " " + cli.ApPaterno + " " + cli.ApMaterno;
            lblEmailCliente.Text = cli.Email;
            EventoClase eve = EventoClase.LlamarEvento();
            lblNombreEvento.Text = eve.NombreEvento;
            lblFechaEvento.Text = eve.FechaEvento.ToShortDateString();
            lblHoraEvento.Text = eve.HoraEvento.ToString();
            ReciboClase rec = new ReciboClase();
            lblFolio.Text = rec.ObtenerFolio().ToString();
            lblDireccionEvento.Text = eve.Calle + " " + eve.Numero + " Colonia " + eve.Colonia + " Cp: " + eve.Cp;
            lblFechaRecibo.Text = DateTime.Now.ToShortDateString();
        }
#endregion
    }
}
