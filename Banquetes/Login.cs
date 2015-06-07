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

            try
            {
                Administrador objAdmin = new Administrador(user, password); /// crea nueva credencial
                Estructura objElementos = new Estructura();///nueva estructura
                objElementos.Sentencia = "";
                



            }
            catch (Exception) 
            {
               
                MessageBox.Show("Lo sentimos, algo ha salido mal");

            }



            ///concder ingreso
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
            ///acceder... 
        }
    }
}
