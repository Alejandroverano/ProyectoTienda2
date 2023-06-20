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
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using ProyectoTienda.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tienda2
{
    public partial class Realme : Form
    {
        private List<products> productosAgregados = new List<products>();
        public Realme()
        {
            InitializeComponent();
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/36";
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            carrito carrito = new carrito();
            carrito.SetProductos(productosAgregados);
            carrito.ShowDialog();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/32";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/37";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/38";
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

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/33";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/35";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/39";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/41";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/40";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/42";
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
    }
}
