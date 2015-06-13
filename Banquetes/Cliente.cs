using Banquetes.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banquetes
{
    public partial class Cliente : Form
    {
        ClienteClase cli = new ClienteClase();
        public Cliente()
        {
            InitializeComponent();
            actualizarControles();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 318, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text;
            string Apaterno = txtPaterno.Text;
            string Amaterno = txtMaterno.Text;
            string telefono = txtTel.Text;
            string email = txtMail.Text;

            GuardarCliente(name, Apaterno, Amaterno, telefono, email);
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string Apaterno = txtPaterno.Text;
                string Amaterno = txtMaterno.Text;
                string telefono = txtTel.Text;
                string email = new MailAddress(txtMail.Text).ToString();

                if (String.IsNullOrWhiteSpace(nombre) || String.IsNullOrWhiteSpace(Apaterno) || String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(telefono))
                {
                    MessageBox.Show("Favor de llenar todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!telLengt(telefono))
                {
                    MessageBox.Show("Teléfono no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GuardarCliente(nombre, Apaterno, Amaterno, telefono, email);
                Invitados inv = new Invitados();
                inv.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Email no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        //método para validar número de teléfono 
        public bool telLengt(string numeros) 
        {
            char[] num = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int count = 0;
            for (int i = 0; i < numeros.Length; i++)
                for (int j = 0; j < num.Length; j++)
                    if (numeros[i] == num[j])
                        count++;
            if (count == 10)
                return true;
            else
                return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuClase menu = new MenuClase();
            EventoClase ev = new EventoClase();
            InvitadoClase inv = new InvitadoClase();
            cli.BorrarCliente();
            ev.BorrarEvento();
            inv.BorrarInvitados();
            menu.BorrarMenucliente();
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void actualizarControles()
        {
            txtNombre.Text = ClienteClase.Cliente.Nombre;
            txtPaterno.Text = ClienteClase.Cliente.ApPaterno;
            txtMaterno.Text = ClienteClase.Cliente.ApMaterno;
            txtTel.Text = ClienteClase.Cliente.Telefono;
            txtMail.Text = ClienteClase.Cliente.Email;
        }

        public void GuardarCliente(string nom, string pat, string mat, string tel, string email)
        {
            ClienteClase.Cliente.Nombre = nom;
            ClienteClase.Cliente.ApPaterno = pat;
            ClienteClase.Cliente.ApMaterno = mat;
            ClienteClase.Cliente.Telefono = tel;
            ClienteClase.Cliente.Email = email;
        }
    }
}
