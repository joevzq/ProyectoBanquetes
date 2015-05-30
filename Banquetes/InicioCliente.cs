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
    public partial class InicioCliente : Form
    {
        public InicioCliente()
        {
            InitializeComponent();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            btnEditarE.Visible = true;
            btnNuevo.Visible = true;
            btnCancelarE.Visible = true;
            gbEditar.Visible = false;
            gbCancelar.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnEditarE.Visible = false;
            btnNuevo.Visible = false;
            btnCancelarE.Visible = false;
            gbEditar.Visible = true;
            gbCancelar.Visible = false;
        }

        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            btnEditarE.Visible = false;
            btnNuevo.Visible = false;
            btnCancelarE.Visible = false;
            gbEditar.Visible = false;
            gbCancelar.Visible = true;
        }

        private void btnRegresarC_Click(object sender, EventArgs e)
        {
            btnEditarE.Visible = true;
            btnNuevo.Visible = true;
            btnCancelarE.Visible = true;
            gbEditar.Visible = false;
            gbCancelar.Visible = false;
        }
    }
}
