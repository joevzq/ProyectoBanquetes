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
            formGraphics.FillRectangle(myBrush, new Rectangle(265, 9, 200, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool existente = false;
            string InvitadoNom = null;
            string InvitadoEm = null;
            InvitadoNom = txtNombre.Text;
            try
            {
                if (!string.IsNullOrEmpty(txtEmail.Text))
                    InvitadoEm = new MailAddress(txtEmail.Text).ToString();
            }
            catch { MessageBox.Show("Por favor ingrese un E-mail con el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (string.IsNullOrEmpty(InvitadoNom) || string.IsNullOrEmpty(InvitadoEm))
                MessageBox.Show("Por favor ingrese el nombre y el Email del invitado para poder ser agregado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                InvitadoClase invitado = new InvitadoClase();
                invitado.Nombre = InvitadoNom;
                invitado.Email = InvitadoEm;
                InvitadoClase.lstInvitados.Add(invitado);

                string elemento = InvitadoNom + "  " + InvitadoEm;

                for (int i = 0; i < lstInvitados.Items.Count; i++)
                {
                    if (lstInvitados.Items[i].ToString() == elemento)
                        existente = true;
                }
                if (!string.IsNullOrEmpty(InvitadoEm))
                    if (existente != true)
                    {
                        lstInvitados.Items.Add(elemento);
                        txtNombre.Text = "";
                        txtEmail.Text = "";
                    }
                    else
                        MessageBox.Show("El Invitado ingresao ya existe en la lista de invitados.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstInvitados.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Esta seguro de eliminar al invitado " + lstInvitados.SelectedItem.ToString() + "?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int index = lstInvitados.SelectedIndex;
                    lstInvitados.Items.RemoveAt(lstInvitados.SelectedIndex);
                    InvitadoClase.EliminarInvitado(index);
                }
            }
            else
            {
                MessageBox.Show("Seleccione al invitado que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            {
                lstInvitados.Items.Add(item.Nombre + " " + item.Email);
            }
        }
    }
}
