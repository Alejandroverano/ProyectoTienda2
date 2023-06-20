using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using ProyectoTienda.Models;

namespace Tienda2
{
    public partial class Iphone : Form
    {
        private List<products> productosAgregados = new List<products>();

        public Iphone()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            carrito carrito = new carrito();
            carrito.SetProductos(productosAgregados);
            carrito.ShowDialog();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/31";
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        products product = ParseProductFromJson(json);

                        if (product != null)
                        {
                            productosAgregados.Add(product);
                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no fue encontrado en la API.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos del producto de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }
        private products ParseProductFromJson(string json)
        {
            products product = JsonConvert.DeserializeObject<products>(json);
            return product;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/30";
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        products product = ParseProductFromJson(json);

                        if (product != null)
                        {
                            productosAgregados.Add(product);
                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no fue encontrado en la API.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos del producto de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/27";
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        products product = ParseProductFromJson(json);

                        if (product != null)
                        {
                            productosAgregados.Add(product);
                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no fue encontrado en la API.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos del producto de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/29";
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        products product = ParseProductFromJson(json);

                        if (product != null)
                        {
                            productosAgregados.Add(product);
                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no fue encontrado en la API.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos del producto de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/28";
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        products product = ParseProductFromJson(json);

                        if (product != null)
                        {
                            productosAgregados.Add(product);
                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no fue encontrado en la API.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos del producto de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/26";
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        products product = ParseProductFromJson(json);

                        if (product != null)
                        {
                            productosAgregados.Add(product);
                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no fue encontrado en la API.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos del producto de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/25";
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        products product = ParseProductFromJson(json);

                        if (product != null)
                        {
                            productosAgregados.Add(product);
                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no fue encontrado en la API.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos del producto de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/24";
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        products product = ParseProductFromJson(json);

                        if (product != null)
                        {
                            productosAgregados.Add(product);
                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no fue encontrado en la API.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos del producto de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/23";
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        products product = ParseProductFromJson(json);

                        if (product != null)
                        {
                            productosAgregados.Add(product);
                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no fue encontrado en la API.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos del producto de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/22";
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        products product = ParseProductFromJson(json);

                        if (product != null)
                        {
                            productosAgregados.Add(product);
                            MessageBox.Show("Producto agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no fue encontrado en la API.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos del producto de la API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private void label58_Click(object sender, EventArgs e)
        {

        }
    }
}
