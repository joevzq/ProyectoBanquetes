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
        public static int folio;
        public static Menu menuFolio = new Menu(folio);
        public static Menu menu = new Menu();
        public static Cliente clienteFolio = new Cliente(folio);
        public static Cliente cliente = new Cliente();
        public static Invitados invitadosFolio = new Invitados(folio);
        public static Invitados invitados = new Invitados();
        public static Evento eventoFolio = new Evento(folio);
        public static Evento evento = new Evento();

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
            menu.Show();
            this.Hide();
        }

        private void picModificar_Click(object sender, EventArgs e)
        {
            folio = int.Parse(txtModificar.Text);
            menuFolio.Show();
            this.Hide();
        }

        private void picCancelar_Click(object sender, EventArgs e)
        {
            int folio = int.Parse(txtCancelar.Text);
            CancelarEvento cancelar = new CancelarEvento(folio, 'i');
            cancelar.Show();
            this.Hide();
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

    }
}
