using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banquetes.Class;
using Nivel_de_acceso.Clases;



namespace Banquetes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 220, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtContra.Text;
            Administrador admin = new Administrador();
            int checarUsuario = admin.ChecarUsuario(user, password);

            if (checarUsuario > 0)
            {
                Admin adm = new Admin();
                adm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Usuario y/o contraseña incorrectos.");
            
        }
    }
}
