using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProyectoTienda.Models;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System.Reflection.Metadata;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using Image = System.Drawing.Image;

namespace Tienda2
{
    public partial class carrito : Form
    {

        public carrito()
        {
            InitializeComponent();


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 anotherForm = zz.GetInstance();
            anotherForm.Show();
            this.Hide();
        }
        public void SetProductos(List<products> productos)
        {
            foreach (products producto in productos)
            {
                dataGridView1.Rows.Add(producto.productId, producto.productName, producto.unitprice);
            }
        }




        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("NO PUEDE GENERAR LA FACTURA DEJANDO ESPACIOS EN BLANCO");
            }
            else
            {

                iTextSharp.text.Document doc = new iTextSharp.text.Document();

                try
                {

                    string nombreArchivo = "factura.pdf";
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(nombreArchivo, FileMode.Create));

                    BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font fontTitulo = new iTextSharp.text.Font(baseFont, 20, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontSubtitulo = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);


                    doc.Open();


                    Paragraph titulo = new Paragraph("MobileShop", fontTitulo);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.SpacingAfter = 20;
                    doc.Add(titulo);


                    PdfPTable tablas = new PdfPTable(3);
                    tablas.WidthPercentage = 100;

                
                    PdfPCell celdaCliente = new PdfPCell();
                    celdaCliente.Border = PdfPCell.NO_BORDER;

                 
                    Paragraph datosCliente = new Paragraph();
                    datosCliente.SpacingAfter = 10;
                    datosCliente.Add(new Chunk("DATOS DEL CLIENTE:", fontSubtitulo));
                    datosCliente.Add(Chunk.NEWLINE);
                    datosCliente.Add(Chunk.NEWLINE);
                    datosCliente.Add(new Chunk("Nombre: ", fontSubtitulo));
                    datosCliente.Add(new Chunk(textBox1.Text, fontNormal));
                    datosCliente.Add(Chunk.NEWLINE);
                    datosCliente.Add(new Chunk("Apellido: ", fontSubtitulo));
                    datosCliente.Add(new Chunk(textBox5.Text, fontNormal));
                    datosCliente.Add(Chunk.NEWLINE);
                    datosCliente.Add(new Chunk("Cedula: ", fontSubtitulo));
                    datosCliente.Add(new Chunk(textBox2.Text, fontNormal));
                    datosCliente.Add(Chunk.NEWLINE);
                    datosCliente.Add(new Chunk("Dirección: ", fontSubtitulo));
                    datosCliente.Add(new Chunk(textBox3.Text, fontNormal));
                    datosCliente.Add(Chunk.NEWLINE);
                    datosCliente.Add(new Chunk("Telefono: ", fontSubtitulo));
                    datosCliente.Add(new Chunk(textBox4.Text, fontNormal));

                    celdaCliente.AddElement(datosCliente);
                    tablas.AddCell(celdaCliente);

                    
                    PdfPCell celdaEspacio = new PdfPCell();
                    celdaEspacio.Border = PdfPCell.NO_BORDER;
                    tablas.AddCell(celdaEspacio);

                   
                    PdfPCell celdaLogo = new PdfPCell();
                    celdaLogo.Border = PdfPCell.NO_BORDER;
                    celdaLogo.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celdaLogo.Padding = 5;
                    Image imagenLogo = pictureBox2.Image;
                    if (imagenLogo != null)
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagenLogo, System.Drawing.Imaging.ImageFormat.Png);
                        logo.ScaleToFit(100f, 100f); 
                        celdaLogo.AddElement(logo);
                    }
                    tablas.AddCell(celdaLogo);

                   
                    doc.Add(tablas);



                    PdfPTable tabla = new PdfPTable(dataGridView1.ColumnCount);
                    tabla.WidthPercentage = 100;


                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        PdfPCell celda = new PdfPCell(new Phrase(dataGridView1.Columns[i].HeaderText, fontSubtitulo));
                        celda.HorizontalAlignment = Element.ALIGN_CENTER;
                        celda.BackgroundColor = new BaseColor(Color.LightGray);
                        tabla.AddCell(celda);
                    }


                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (dataGridView1[j, i].Value != null)
                            {
                                PdfPCell celda = new PdfPCell(new Phrase(dataGridView1[j, i].Value.ToString(), fontNormal));
                                celda.HorizontalAlignment = Element.ALIGN_CENTER;
                                tabla.AddCell(celda);
                            }
                        }
                    }


                    doc.Add(tabla);


                    Paragraph total = new Paragraph();
                    double Total = 0;
                    total.Alignment = Element.ALIGN_RIGHT;
                    total.SpacingBefore = 20;
                    total.Add(new Chunk("Total: $", fontSubtitulo));
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        Total += Convert.ToDouble(row.Cells["unitprice"].Value);

                    }
                    total.Add(new Chunk(Total.ToString(), fontNormal));
                    doc.Add(total);
                    MessageBox.Show("Compra Exitosa");
                    MessageBox.Show("Factura Generada");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message);
                }
                finally
                {
                    
                    doc.Close();
                } 
            }

        }
            private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

            private void carrito_Load(object sender, EventArgs e)
            {
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string rutaFactura = "factura.pdf";
            if (File.Exists(rutaFactura))
            {
                try
                {
                    
                    string aplicacionPredeterminada = "explorer.exe";
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    {
                        aplicacionPredeterminada = "/Applications/Preview.app";
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        aplicacionPredeterminada = "/usr/bin/xdg-open";
                    }

                   
                    Process.Start(new ProcessStartInfo(aplicacionPredeterminada, rutaFactura));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir la factura: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("La factura no existe. Genera la factura primero.");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
               
                e.Handled = true;
            }
        }
    }
}

