using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoTienda.Models;

namespace Tienda2
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openh(new Samsung());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openh(new Xiaomi());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openh(new Realme());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openh(new Iphone());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btncerra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void openh(object hh)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = hh as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);  
            this.panelcontenedor.Tag = fh;
            fh.Show();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            openh(new inicio());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      //  private List<string> productosAgregados = new List<string>();

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            carrito v = new carrito();
            v.Show();
            this.Hide();
            /*carrito carrito = new carrito();
            carrito.SetProductos(productosAgregados);
            carrito.ShowDialog();*/

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
