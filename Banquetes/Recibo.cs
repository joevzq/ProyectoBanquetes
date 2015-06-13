
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
            llenarMenuListView();
        }

        /*Constructor para llamar recibo desde ventana de admin*/
        public Recibo(int folio)
        {
            MenuClase menu = new MenuClase();
            menu.ObtenerMenuCliente(folio);
            deAdmin = false;
            InitializeComponent();
            llenarReciboDB(folio);
            llenarMenuListView();
            btnAnterior.Enabled = false;
            btnConfirmar.Enabled = false;
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
            MessageBox.Show("Evento agendado.");
            ReciboClase recibo = new ReciboClase();
            recibo.GuardarRecibo();
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Evento ev = new Evento();
            ev.Show();
            this.Close();
        }

        /*Llenar recibo con información directa de la base de datos*/
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
            lblDireccionEvento.Text = data.Rows[0]["calle"].ToString() + ", " + data.Rows[0]["numero"].ToString() +
                ", " + data.Rows[0]["colonia"].ToString() + ", " + data.Rows[0]["cp"].ToString();
            lblSubtotal.Text = "$" + Convert.ToInt32(data.Rows[0]["subtotal"]).ToString() + ".00";
            lblIva.Text = "$" + Convert.ToDouble(data.Rows[0]["iva"]).ToString();
            lblTotal.Text = "$" + Convert.ToDouble(data.Rows[0]["total"]).ToString();
        }

        /*Llenar recibo con estructuras de datos locales*/
        private void llenarReciboDS()
        {
            MenuClase menu = new MenuClase();

            ReciboClase.recibo.Subtotal = Convert.ToDouble(menu.CalcularPrecioMenu());
            ReciboClase.recibo.Subtotal *= InvitadoClase.lstInvitados.Count;
            ReciboClase.recibo.Iva = ReciboClase.recibo.Subtotal * 0.16;
            ReciboClase.recibo.Total = ReciboClase.recibo.Iva + ReciboClase.recibo.Subtotal;
            lblFolio.Text = EventoClase.Evento.FolioEvento.ToString();
            lblFechaRecibo.Text = DateTime.Today.ToShortDateString();
            lblNombreCliente.Text = ClienteClase.Cliente.Nombre + " " + ClienteClase.Cliente.ApPaterno + " " + ClienteClase.Cliente.ApMaterno;
            lblTelCliente.Text = ClienteClase.Cliente.Telefono;
            lblEmailCliente.Text = ClienteClase.Cliente.Email;
            lblNombreEvento.Text = EventoClase.Evento.NombreEvento;
            lblFechaEvento.Text = EventoClase.Evento.FechaEvento.ToShortDateString();
            lblHoraEvento.Text = EventoClase.Evento.HoraEvento;
            lblDireccionEvento.Text = EventoClase.Evento.Calle + ", " + EventoClase.Evento.Numero + ", " + EventoClase.Evento.Colonia
                + ", " + EventoClase.Evento.Cp;
            lblSubtotal.Text = "$" + ReciboClase.recibo.Subtotal.ToString();
            lblIva.Text = "$" + ReciboClase.recibo.Iva.ToString();
            lblTotal.Text = "$" + ReciboClase.recibo.Total.ToString();
        }

        private void llenarMenuListView()
        {
            List<MenuClase> menuCliente = MenuClase.llamarMenuCliente();
            List<MenuClase.Entrada> entradas = MenuClase.llamarEntradas();
            lstvMenu.Items.Clear();
            foreach (MenuClase item in menuCliente)
            {
                string[] row = { (item.Porciones.ToString()), "$" + ((int)entradas[item.IdEntrada - 1].precioUnit * item.Porciones).ToString() };
                lstvMenu.Items.Add(entradas[item.IdEntrada - 1].nombre).SubItems.AddRange(row);
            }
        }
        #endregion
    }
}
