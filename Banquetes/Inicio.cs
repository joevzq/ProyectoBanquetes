using Banquetes.Clases;
using Banquetes.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banquetes
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 263, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void picCrear_Click(object sender, EventArgs e)
        {
            ReciboClase recibo = new ReciboClase();
            EventoClase.Evento.FolioEvento = recibo.ObtenerFolio();
            ReciboClase.nuevo = true;
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void picModificar_Click(object sender, EventArgs e)
        {
            ReciboClase.nuevo = false;
            ClienteClase cli = new ClienteClase();
            InvitadoClase invitado = new InvitadoClase();
            EventoClase ev = new EventoClase();
            int folio = int.Parse(txtModificar.Text);
            Menu menu = new Menu(folio);
            cli.ObtenerCliente(folio);
            invitado.ObtenerInvitados(folio);
            ev.ObtenerEvento(folio);
            menu.Show();
            this.Hide();
        }

        private void picCancelar_Click(object sender, EventArgs e)
        {
            int folio = int.Parse(txtCancelar.Text);
            CancelarEvento cancelar = new CancelarEvento(folio, 'i');
            cancelar.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            MenuClase menuCl = new MenuClase();
            menuCl.ObtenerMenuCompleto();
        }

    }
}
