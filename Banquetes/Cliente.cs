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
        public Cliente()
        {
            

            InitializeComponent();
           
        }

        public Cliente(int folio)
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 283, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Banquetes.Inicio.menu.Show();
            this.Hide();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try {
                Cliente cli = new Cliente();
                string name = txtNombre.Text;
                string Apaterno = txtPaterno.Text;
                string Amaterno = txtMaterno.Text;
                string telefono = txtTel.Text;
                string mail = new MailAddress(txtMail.Text).ToString();

                if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(Apaterno) ||
                  String.IsNullOrWhiteSpace(Amaterno) ||
                  String.IsNullOrWhiteSpace(telefono) ||
                  String.IsNullOrWhiteSpace(mail))
                    MessageBox.Show("Lo sentimos, no se han completado todos los campos", "Información incompleta");
                else 
                {
                    bool phonenumber = telLengt(telefono);
                     //verificar que se ha ingresado correctamente
                    if (!phonenumber)
                        MessageBox.Show("numero de télefono incompleto.");
                    else 
                    {
                        cli.crearEmpleado(name, Apaterno, Amaterno, telefono, mail);
                        
                    }
                    

                }

            }
            catch(Exception ez)
            {

            }

            ///continuar con el siguiete formulario
            Banquetes.Inicio.invitados.Show();
            this.Hide();
        }

        private void crearEmpleado(string name, string Apaterno, string Amaterno, string telefono, string mail)
        {
            throw new NotImplementedException();
        }

        private void crearEmpleado()
        {
            throw new NotImplementedException();
        }

     
        //método para validar número de teléfono 
        public bool telLengt(string numeros) 
        {
            char[] num = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool flag;
            int count = 0;
            for (int i = 0; i < numeros.Length; i++)
                for (int j = 0; j < num.Length; j++)
                    if (numeros[i] == num[j])
                        count++;
            if (count < 10)
                flag = false;
            else
                flag = true;
            return flag;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }



        public bool crearEmpleado { get; set; }
    }
}
