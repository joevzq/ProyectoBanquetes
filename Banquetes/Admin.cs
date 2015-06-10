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
    public partial class Admin : Form
    {
        EventoClase evCl = new EventoClase();
        List<EventoClase> lstEventos = new List<EventoClase>();

        private int folio;
        private bool lstBool = true;
        public Admin()
        {
            InitializeComponent();
            
            lstEventos = evCl.LlamarEventos();
            llenarListas(lstEventos);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 518, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarEvento cancelar = new CancelarEvento(folio, 'a');
            cancelar.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstEventos.Count; i++)
            {
                if (lstEventos[i].FolioEvento == folio)
                {
                    dtpFechaEvento.Value = lstEventos[i].FechaEvento;
                    break;
                }
            }
            grpFecha.Visible = true;
        }

        /*TODO... Validaciones*/
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaNueva = dtpFechaEvento.Value;
            evCl.ActualizarFecha(folio, fechaNueva);
            cleanLists();
            lstEventos = evCl.LlamarEventos();
            llenarListas(lstEventos);
            grpFecha.Visible = false;
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            Recibo recibo = new Recibo(folio);
            recibo.ShowDialog();
        }

        private void llenarListas(List<EventoClase> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Status == 1)
                    lstPorRealizar.Items.Add(lista[i].FolioEvento + " - " + lista[i].FechaEvento.ToShortDateString());

                else if (lista[i].Status == 2)
                    lstRealizados.Items.Add(lista[i].FolioEvento + " - " + lista[i].FechaEvento.ToShortDateString());

                else if (lista[i].Status == 3)
                    lstCancelados.Items.Add(lista[i].FolioEvento + " - " + lista[i].FechaEvento.ToShortDateString());
            }
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex;
            string evento;
            if (lstBool)
            {
                lstBool = false;
                if (((ListBox)sender).Name == "lstPorRealizar")
                {
                    lstCancelados.ClearSelected();
                    lstRealizados.ClearSelected();
                    evento = lstPorRealizar.Items[index].ToString();
                }
                else if (((ListBox)sender).Name == "lstRealizados")
                {
                    lstCancelados.ClearSelected();
                    lstPorRealizar.ClearSelected();
                    evento = lstRealizados.Items[index].ToString();
                }
                else
                {
                    lstPorRealizar.ClearSelected();
                    lstRealizados.ClearSelected();
                    evento = lstCancelados.Items[index].ToString();
                }
                getFolio(evento);
                lstBool = true;
            }
        }

        private void getFolio(string evento)
        {
            evento = evento.Substring(0, 4);
            folio = int.Parse(evento);
        }

        private void cleanLists()
        {
            lstCancelados.Items.Clear();
            lstRealizados.Items.Clear();
            lstPorRealizar.Items.Clear();
        }
    }
}