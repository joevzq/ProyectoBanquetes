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
            int folio;
            bool folioValido = Int32.TryParse(txtModificar.Text, out folio);
            EventoClase ev = new EventoClase();
            bool statusValido = ev.checarFolioEvento(folio);
            if (folioValido && statusValido)
            {
                if (ev.VerificarFecha(folio))
                {
                    ReciboClase.nuevo = false;
                    ClienteClase cli = new ClienteClase();
                    InvitadoClase invitado = new InvitadoClase();
                    Menu menu = new Menu(folio);
                    cli.ObtenerCliente(folio);
                    invitado.ObtenerInvitados(folio);
                    ev.ObtenerEvento(folio);
                    menu.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("El evento se realizará en 3 días o menos.\nYa no puede ser modificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ingresa un folio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void picCancelar_Click(object sender, EventArgs e)
        {
            int folio;
            bool folioValido = Int32.TryParse(txtCancelar.Text, out folio);
            EventoClase ev = new EventoClase();
            bool statusValido = ev.checarFolioEvento(folio);
            if (folioValido && statusValido)
            {
                if (ev.VerificarFecha(folio))
                {
                    CancelarEvento cancelar = new CancelarEvento(folio, 'i');
                    cancelar.ShowDialog();
                }
                else
                    MessageBox.Show("El evento se realizará en 3 días o menos.\nYa no puede ser cancelado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ingresa un folio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            EventoClase eventoCl = new EventoClase();
            MenuClase menuCl = new MenuClase();
            menuCl.ObtenerMenuCompleto();
            eventoCl.ActualizarStatusPorFecha();
        }

    }
}
