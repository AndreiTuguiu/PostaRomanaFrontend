using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn.Pages.MainPageMock
{
    public partial class Uhh : Form
    {
        static HttpClient client = new HttpClient();
        public Uhh()
        {
            InitializeComponent();

            client.BaseAddress = new Uri("https://localhost:5001/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public class Product
        {
            public string UserId { get; set; }
            
        }
        /*static async Task<string> GetProductAsync(string path)
        {
            string product = null;
           // HttpResponseMessage response = await client.GetAsync(path);
            
             HttpResponseMessage response = await client.GetAsync("api/Home/GetHello");


            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<string>();
            }
            return product;


            
        }*/
        Product sesiune=null;
        static async Task<Uri> CreateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "/api/Account/CreateLogInSession", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
            //CreateProductAsync("/api/Account/CreateLogInSession", sesiune);

        }
    }
}
