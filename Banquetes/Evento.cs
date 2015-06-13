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
    public partial class Evento : Form
    {
        public Evento()
        {
            InitializeComponent();
            llenarCampos();
            ReciboClase recibo = new ReciboClase();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 460, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuClase menu = new MenuClase();
            EventoClase ev = new EventoClase();
            ClienteClase cli = new ClienteClase();
            InvitadoClase inv = new InvitadoClase();
            cli.BorrarCliente();
            ev.BorrarEvento();
            inv.BorrarInvitados();
            menu.BorrarMenucliente();

            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFecha.Value;
            string hora = txtHora.Text;
            string calle = txtCalle.Text;
            string colonia = txtColonia.Text;
           string cp = txtCP.Text;
            string numero = txtNumero.Text;
            string comentario = txtComent.Text;

            GuardarEvento(nombre, fecha, hora, calle, colonia, cp, numero, comentario);

            Invitados inv = new Invitados();
            inv.Show();
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFecha.Value;
            string hora = txtHora.Text;
            string calle = txtCalle.Text;
            string colonia = txtColonia.Text;
            string cp = txtCP.Text;
            string numero = txtNumero.Text;
            string comentario = txtComent.Text;

            if (String.IsNullOrWhiteSpace(nombre) || String.IsNullOrWhiteSpace(hora) || String.IsNullOrWhiteSpace(calle) ||
                String.IsNullOrWhiteSpace(colonia) || String.IsNullOrWhiteSpace(cp) || String.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Favor de llenar todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime hoy = DateTime.Now;
            hoy = hoy.AddDays(3);
            int result = DateTime.Compare(fecha, hoy);

            if (result < 0)
            {
                MessageBox.Show("Fecha no válida.\nLa fecha debe estar a mínimo 3 días de la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!evaluarHora(hora))
            {
                MessageBox.Show("Hora no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            GuardarEvento(nombre, fecha, hora, calle, colonia, cp, numero, comentario);
                
            Recibo recibo = new Recibo();
            recibo.Show();
            this.Hide();
        }

        private void llenarCampos()
        {
            txtNombre.Text = EventoClase.Evento.NombreEvento;
            dtpFecha.Value = EventoClase.Evento.FechaEvento;
            txtHora.Text = EventoClase.Evento.HoraEvento;
            txtCalle.Text = EventoClase.Evento.Calle;
            txtColonia.Text = EventoClase.Evento.Colonia;
            txtCP.Text = EventoClase.Evento.Cp;
            txtNumero.Text = EventoClase.Evento.Numero;
            txtComent.Text = EventoClase.Evento.Comentario;
        }

        private void GuardarEvento(string nom, DateTime date, string hora, string calle, string col, string cp, string num, string com)
        {
            EventoClase.Evento.NombreEvento = nom;
            EventoClase.Evento.FechaEvento = date;
            EventoClase.Evento.HoraEvento = hora;
            EventoClase.Evento.Calle = calle;
            EventoClase.Evento.Colonia = col;
            EventoClase.Evento.Cp = cp;
            EventoClase.Evento.Numero = num;
            EventoClase.Evento.Comentario = com;
        }

        private bool evaluarHora(string hora)
        {
            string horaNumeros = String.Empty;

            for (int i = 0; i < hora.Length; i++)
                if (Char.IsNumber(hora[i]))
                    horaNumeros += hora[i];

            if (horaNumeros.Length < 4)
                return false;

            string horas = horaNumeros.Substring(0, 2);
            string minutos = horaNumeros.Substring(2, 2);
            int horaInt = int.Parse(horas);
            int minutosInt = int.Parse(minutos);

            if (horaInt > 24)
                return false;

            if (minutosInt > 60)
                return false;

            return true;
        }
    }
}
