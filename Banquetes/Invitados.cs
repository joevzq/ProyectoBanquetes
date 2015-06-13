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
    public partial class Invitados : Form
    {
        public Invitados()
        {
            InitializeComponent();
            llenarLista();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 255, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(270, 9, 262, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string email = new MailAddress(txtEmail.Text).ToString();

                if (String.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Favor de llenar todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < InvitadoClase.lstInvitados.Count; i++)
                    if (email == InvitadoClase.lstInvitados[i].Email)
                    {
                        MessageBox.Show("El correo del invitado ya existe en la lista de invitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                InvitadoClase invitado = new InvitadoClase();
                invitado.Nombre = nombre;
                invitado.Email = email;
                InvitadoClase.lstInvitados.Add(invitado);

                string elemento = nombre + " - " + email;
                lstInvitados.Items.Add(elemento);

                txtEmail.Text = String.Empty;
                txtNombre.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("Email no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstInvitados.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar al invitado " + lstInvitados.SelectedItem.ToString() + "?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int index = lstInvitados.SelectedIndex;
                    lstInvitados.Items.RemoveAt(lstInvitados.SelectedIndex);
                    InvitadoClase.EliminarInvitado(index);
                }
            }
            else
            {
                MessageBox.Show("Selecciona al invitado que deseas eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de eliminar toda la lista de invitados?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                lstInvitados.Items.Clear();
                InvitadoClase.EliminarInvitados();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (InvitadoClase.lstInvitados.Count == 0)
            {
                MessageBox.Show("No has ingresado ningún invitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Evento evento = new Evento();
            evento.Show();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void llenarLista()
        {
            foreach (InvitadoClase item in InvitadoClase.lstInvitados)
                lstInvitados.Items.Add(item.Nombre + " - " + item.Email);
        }
    }
}
