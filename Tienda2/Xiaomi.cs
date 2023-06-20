using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using ProyectoTienda.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Tienda2
{
    public partial class Xiaomi : Form

    {
        private List<products> productosAgregados = new List<products>();
        public Xiaomi()
        {
            InitializeComponent();
        }
        private void Xiaomi_Load(object sender, EventArgs e)
        {
           

        }

        private  async void button1_Click(object sender, EventArgs e)
        {
            try
            {


                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7135/api/TiendaControllers/14";
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

        private void pictureBox44_Click(object sender, EventArgs e)
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
                    string url = $"https://localhost:7135/api/TiendaControllers/13";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/12";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/17";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/16";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/15";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/21";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/20";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/19";
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
                    string url = $"https://localhost:7135/api/TiendaControllers/18";
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

