using Microsoft.Data.SqlClient;

namespace Tienda2
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=DESKTOP-AUEEIES\\SQLSERVER2019;Database=Tienda2DB;Trusted_Connection=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
            txtContrase�a.UseSystemPasswordChar = true;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox1.Text;
            string contrase�a = txtContrase�a.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    string query = "SELECT COUNT(*) FROM logings WHERE usuario = @usuario AND contrase�a = @contrase�a";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@usuario", nombreUsuario);
                        command.Parameters.AddWithValue("@contrase�a", contrase�a);

                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Inicio de sesi�n exitoso");
                            Form2 form2 = new Form2();

                           
                            form2.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Contrase�a inv�lida Vuelva a Intentar");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }



          
           
        }
      /*  private void openh(object hh)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = hh as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtContrase�a.UseSystemPasswordChar)
            {
                // Mostrar la contrase�a
                txtContrase�a.UseSystemPasswordChar = false;
                button2.Text = "Ocultar";
            }
            else
            {
                // Ocultar la contrase�a
                txtContrase�a.UseSystemPasswordChar = true;
                button2.Text = "Mostrar";
            }
        }
    }
}