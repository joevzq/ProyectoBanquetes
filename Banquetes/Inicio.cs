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
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void picModificar_Click(object sender, EventArgs e)
        {
            int folio = int.Parse(txtModificar.Text);
            Menu menu = new Menu(folio);
            menu.Show();
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
