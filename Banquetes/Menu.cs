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
    public partial class Menu : Form
    {
        public static controls[] arrControles = new controls[12];
        List<MenuClase.Entrada> entradas = MenuClase.llamarEntradas();
        List<MenuClase> menuCliente = MenuClase.llamarMenuCliente();
        MenuClase menuCl = new MenuClase();

        public bool evitarActualizacion = false;

        public class controls
        {
            public PictureBox picture { get; set; }
            public CheckBox checkbox { get; set; }
            public Label ingredientes { get; set; }
            public Label precio { get; set; }
            public NumericUpDown num { get; set; }
        }
        
        public Menu()
        {
            InitializeComponent();
            crearArray();
            llenarControles();
            actualizarListView();
            actualizarControles();
        }
        
        public Menu(int folio)
        {
            InitializeComponent();
            crearArray();
            llenarControles();
            menuCl.ObtenerMenuCliente(folio);
            actualizarListView();
            actualizarControles();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(5, 9, 305, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml("#D85846"));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(315, 9, 216, 22));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            menuCliente.Clear();
            ClienteClase cli = new ClienteClase();
            EventoClase ev = new EventoClase();
            InvitadoClase inv = new InvitadoClase();
            cli.BorrarCliente();
            ev.BorrarEvento();
            inv.BorrarInvitados();
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (menuCliente.Count > 0)
            {
                Cliente cliente = new Cliente();
                cliente.Show();
                this.Close();
            }
            else
                MessageBox.Show("No has seleccionado ningún platillo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void crearArray()
        {
            controls Ent1 = new controls();
            Ent1.checkbox = checkEnt1;
            Ent1.picture = imgEnt1;
            Ent1.precio = lblPrecioEnt1;
            Ent1.ingredientes = lblIngEnt1;
            Ent1.num = numEnt1;
            arrControles[0] = Ent1;

            controls Fue1 = new controls();
            Fue1.checkbox = checkFue1;
            Fue1.picture = imgFue1;
            Fue1.precio = lblPrecioFue1;
            Fue1.ingredientes = lblIngFue1;
            Fue1.num = numFue1;
            arrControles[1] = Fue1;

            controls Pos1 = new controls();
            Pos1.checkbox = checkPos1;
            Pos1.picture = imgPos1;
            Pos1.precio = lblPrecioPos1;
            Pos1.ingredientes = lblIngPos1;
            Pos1.num = numPos1;
            arrControles[2] = Pos1;

            controls Fue2 = new controls();
            Fue2.checkbox = checkFue2;
            Fue2.picture = imgFue2;
            Fue2.precio = lblPrecioFue2;
            Fue2.ingredientes = lblIngFue2;
            Fue2.num = numFue2;
            arrControles[3] = Fue2;

            controls Pos2 = new controls();
            Pos2.checkbox = checkPos2;
            Pos2.picture = imgPos2;
            Pos2.precio = lblPrecioPos2;
            Pos2.ingredientes = lblIngPos2;
            Pos2.num = numPos2;
            arrControles[4] = Pos2;

            controls Ent2 = new controls();
            Ent2.checkbox = checkEnt2;
            Ent2.picture = imgEnt2;
            Ent2.precio = lblPrecioEnt2;
            Ent2.ingredientes = lblIngEnt2;
            Ent2.num = numEnt2;
            arrControles[5] = Ent2;

            controls Fue3 = new controls();
            Fue3.checkbox = checkFue3;
            Fue3.picture = imgFue3;
            Fue3.precio = lblPrecioFue3;
            Fue3.ingredientes = lblIngFue3;
            Fue3.num = numFue3;
            arrControles[6] = Fue3;

            controls Pos3 = new controls();
            Pos3.checkbox = checkPos3;
            Pos3.picture = imgPos3;
            Pos3.precio = lblPrecioPos3;
            Pos3.ingredientes = lblIngPos3;
            Pos3.num = numPos3;
            arrControles[7] = Pos3;

            controls Fue4 = new controls();
            Fue4.checkbox = checkFue4;
            Fue4.picture = imgFue4;
            Fue4.precio = lblPrecioFue4;
            Fue4.ingredientes = lblIngFue4;
            Fue4.num = numFue4;
            arrControles[8] = Fue4;

            controls Pos4 = new controls();
            Pos4.checkbox = checkPos4;
            Pos4.picture = imgPos4;
            Pos4.precio = lblPrecioPos4;
            Pos4.ingredientes = lblIngPos4;
            Pos4.num = numPos4;
            arrControles[9] = Pos4;

            controls Ent3 = new controls();
            Ent3.checkbox = checkEnt3;
            Ent3.picture = imgEnt3;
            Ent3.precio = lblPrecioEnt3;
            Ent3.ingredientes = lblIngEnt3;
            Ent3.num = numEnt3;
            arrControles[10] = Ent3;

            controls Ent4 = new controls();
            Ent4.checkbox = checkEnt4;
            Ent4.picture = imgEnt4;
            Ent4.precio = lblPrecioEnt4;
            Ent4.ingredientes = lblIngEnt4;
            Ent4.num = numEnt4;
            arrControles[11] = Ent4;
            
        }

        private void llenarControles()
        {
            for (int i = 0; i < 12; i++)
            {
                arrControles[i].checkbox.Text = entradas[i].nombre;
                arrControles[i].picture.ImageLocation = entradas[i].imagen;
                arrControles[i].ingredientes.Text = entradas[i].ingredientes[0] + ", " + entradas[i].ingredientes[1];
                arrControles[i].precio.Text = "$" + entradas[i].precioUnit.ToString() + ".00";
            }
        }

        private void img_Click(object sender, EventArgs e)
        {
            int i = 0;
            int id = 0;
            while (i < 12)
            {
                if (arrControles[i].picture.Name == ((PictureBox)sender).Name)
                {
                    id = i;
                    break;
                }
                i++;
            }
            Entrada entrada = new Entrada(id);
            entrada.ShowDialog();
            if (entrada.agregado)
                arrControles[id].checkbox.Checked = true;
            
        }

        private void check_Changed(object sender, EventArgs e)
        {
            if (!evitarActualizacion)
            {
                int i = 0;
                while (i < 12)
                {
                    if (arrControles[i].checkbox.Name == ((CheckBox)sender).Name)
                    {
                        menuCl.ActualizarLista(i);
                        actualizarListView();
                        break;
                    }
                    i++;
                }
            }
        }

        private void num_Changed(object sender, EventArgs e)
        {
            if (!evitarActualizacion)
            {
                int i = 0;
                while (i < 12)
                {
                    if (arrControles[i].num.Name == ((NumericUpDown)sender).Name)
                        for (int j = 0; j < menuCliente.Count; j++)
                            if (menuCliente[j].IdEntrada == entradas[i].idEntrada)
                            {
                                menuCliente[j].Porciones = (int)arrControles[i].num.Value;
                                actualizarListView();
                            }
                    i++;
                }
            }
        }
        
        public void actualizarListView()
        {
            lstvMenu.Items.Clear();
            foreach (MenuClase item in menuCliente)
            {
                string[] row = { (item.Porciones.ToString()), "$" + ((int)entradas[item.IdEntrada - 1].precioUnit * item.Porciones).ToString() };
                lstvMenu.Items.Add(entradas[item.IdEntrada - 1].nombre).SubItems.AddRange(row);
            }
            lblTotal.Text = "Total x invitado: $" + menuCl.CalcularPrecioMenu();
        }

        private void actualizarControles()
        {
            evitarActualizacion = true;
            for (int i = 0; i < menuCliente.Count; i++)
                for (int j = 0; j < entradas.Count; j++)
                    if (menuCliente[i].IdEntrada == entradas[j].idEntrada)
                    {
                        arrControles[j].num.Value = menuCliente[i].Porciones;
                        arrControles[j].checkbox.Checked = true;
                        break;
                    }
            evitarActualizacion = false;
        }
    }
}
