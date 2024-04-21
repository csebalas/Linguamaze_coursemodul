using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApiSample
{
    public partial class Form1 : Form
    {
        ApiResponse<ProductDTO> p;
        ApiResponse<ProductInventoryDTO> inventory;
        ApiResponse<PageOfProducts> response;
        List<Kurzus> productNames = new List<Kurzus>();
        Api proxy;
        string slug;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var url = string.Empty;
            var key = string.Empty;

            if (url == string.Empty) url = "http://20.234.113.211:8101/";
            if (key == string.Empty) key = "1-64869949-9801-4b5c-bd4b-326377c14130";

            

            var categoryId = "C49FBC33-8761-4008-AD03-2981BBB6E220";
            var page = 1;
            var pageSize = int.MaxValue;
            var inventoryId = "00cf3c59-5bca-4221-95ca-944233cb1efa";


            proxy = new Api(url, key);
            //p = proxy.ProductsBySlug(slug);
            //Console.WriteLine(p.Content.ProductName);
            inventory = proxy.ProductInventoryFind(inventoryId);

            response = proxy.ProductsFindForCategory(categoryId, page, pageSize);
            //kivProductAdatok();

            ListaBetoltes();

        }


        private void listBoxKurzusok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kurzus kivkurzus = listBoxKurzusok.SelectedItem as Kurzus;
            slug = kivkurzus.URL.ToString();
            
            kivProductAdatok(slug);
        }

        void ListaBetoltes(){

            if (response.Errors.Count > 0)
            {
                foreach (var err in response.Errors)
                {
                    Console.WriteLine("ERROR: " + err.Code + " " + err.Description);
                }
            }
            else if (response.Content == null)
            {
                Console.WriteLine("No content returned from the API call.");
            }
            else
            {
                productNames.Clear();
                foreach (var product in response.Content.Products)
                {
                    if (true)
                    {
                        Kurzus k = new Kurzus();
                        k.URL = product.UrlSlug;
                        k.Name = product.ProductName;
                        productNames.Add(k);
                    }

                }
                listBoxKurzusok.DataSource = productNames;
                listBoxKurzusok.DisplayMember = "Name";
            }
        }

        void kivProductAdatok(string slug)
        {
            p = proxy.ProductsBySlug(slug);
            tNev.Text = p.Content.ProductName;
            TLeiras.Text = p.Content.LongDescription;
        }

        public class Kurzus
        {
            public string URL { get; set; }
            public string Name { get; set; }
        }
    }

}
