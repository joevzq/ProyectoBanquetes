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
        int idEntrada;
        public bool agregado { get; set; } 
        List<MenuClase.Entrada> entradas = MenuClase.llamarEntradas();
        public Entrada(int id)
        {
            InitializeComponent();
            idEntrada = id;
            lblNombreEntrada.Text = entradas[id].nombre;
            picEntrada.ImageLocation = entradas[id].imagen;
            lblDescripcion.Text = entradas[id].descripcion;
            lblPrecio.Text = "$" + entradas[id].precioUnit.ToString();
            lstIngredientes.Items.Clear();
            foreach (string ing in entradas[id].ingredientes)
            {
                lstIngredientes.Items.Add("● " + ing);
            }
            agregado = false;
        }

        private void pnlNombre_Paint(object sender, PaintEventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.agregado = true;
            MessageBox.Show("Platillo agregado.");
        }
    }
}
