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
    public partial class Entrada : Form
    {
        public Entrada(int id)
        {
            InitializeComponent();
            lblNombreEntrada.Text = MenuClase.lstEntradas[id].nombre;
            picEntrada.ImageLocation = MenuClase.lstEntradas[id].imagen;
            lblDescripcion.Text = MenuClase.lstEntradas[id].descripcion;
            lblPrecio.Text = "$" + MenuClase.lstEntradas[id].precioUnit.ToString();
            lstIngredientes.Items.Clear();
            foreach (string ing in MenuClase.lstEntradas[id].ingredientes)
            {
                lstIngredientes.Items.Add(ing);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 543, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
