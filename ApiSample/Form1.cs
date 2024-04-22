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
using System.Data.SqlTypes;
using System.Diagnostics;

namespace ApiSample
{
    public partial class Form1 : Form
    {
        ApiResponse<ProductDTO> p;
        ApiResponse<ProductInventoryDTO> inventory;
        ApiResponse<PageOfProducts> response;
        ApiResponse<ProductDTO> termek;
        List<Kurzus> productNames = new List<Kurzus>();
        Api proxy;
        string slug;
        Random random = new Random();
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


            proxy = new Api(url, key);
            //p = proxy.ProductsBySlug(slug);
            //Console.WriteLine(p.Content.ProductName);
            //inventory = proxy.ProductInventoryFind(inventoryId);

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
                    if (product.IsAvailableForSale==false)
                    {
                        Kurzus k = new Kurzus();
                        k.URL = product.UrlSlug;
                        k.Name = product.ProductName;
                        k.LongDescription = product.LongDescription;
                        k.MinimumQuantity = product.MinimumQty;
                        k.AllowReviews = product.AllowReviews;
                        k.TaxClass = product.TaxSchedule;
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

        void KivAdatBetoltes()
        {
            Kurzus kivkurzus = listBoxKurzusok.SelectedItem as Kurzus;
            txtName.Text = kivkurzus.Name;
            txtDescription.Text = kivkurzus.LongDescription;
            txtPrice.Text = kivkurzus.SitePrize.ToString(); //????????????????????????????????
            txtCost.Text = kivkurzus.SiteCost.ToString();   //????????????????????????????????
            numQuantity.Value = kivkurzus.MinimumQuantity;
            CbReviews.Checked = Convert.ToBoolean(kivkurzus.AllowReviews);
            if (kivkurzus.TaxClass==1)
            {
                CbTax.Checked = true;
            }
            else
            {
                CbTax.Checked = false;
            }
        }
        public class Kurzus
        {
            public string URL { get; set; }
            public string Name { get; set; }
            public string LongDescription { get; set; }
            public int MinimumQuantity { get; set; } 
            public int SitePrize { get; set; } //???????????????????????????????
            public int SiteCost { get; set; } //???????????????????????????????????
            public long TaxClass { get; set; }
            public bool? AllowReviews { get; set; }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            KivAdatBetoltes();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            decimal price;
            var ujProduct = new ProductDTO();
            ujProduct.ProductName = txtName.Text;
            ujProduct.Sku = "380";
            if (decimal.TryParse(txtPrice.Text, out price))
            {
                ujProduct.SitePrice = price;
            }
            ujProduct.InventoryMode = ProductInventoryModeDTO.WhenOutOfStockShow;
            termek = proxy.ProductsCreate(ujProduct, null);
            MessageBox.Show("Sikeresen hozzáadva!");
        }

        static string GenerateRandomSKU(Random random)
        {
            // A SKU hossza
            int length = 8;

            // Lehetséges karakterek az SKU-ban
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Az SKU inicializálása
            char[] sku = new char[length];

            // Véletlenszerű karakterek hozzáadása az SKU-hoz
            for (int i = 0; i < length; i++)
            {
                sku[i] = chars[random.Next(chars.Length)];
            }

            // Az SKU stringként való visszaadása
            return new string(sku);
        }
    }
}


