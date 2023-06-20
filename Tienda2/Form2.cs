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

namespace Tienda2
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*Form2 form2 = new Form2();
            form2.ShowDialog();*/
            openh(new inicio());
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openh(new Realme());
        }

        private void btncerra_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
