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
        ApiResponse<long> szam;
        ApiResponse<ProductDTO> update;
        List<Kurzus> productNames = new List<Kurzus>();
        Api proxy;
        string bvin;
        Random random = new Random();
        string nyelvkategoria;
        string torlendoProductBvin="";
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
            if (listBoxKurzusok.SelectedItem != null)
            {
                Kurzus kivkurzus = listBoxKurzusok.SelectedItem as Kurzus;
                bvin = kivkurzus.Bvin.ToString();
                kivProductAdatok(bvin);
            }
            else
            {
                MessageBox.Show("helló");
            }
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
                    if (product.IsAvailableForSale==false && product.Bvin!=torlendoProductBvin)
                    {
                        Kurzus k = new Kurzus();
                        k.Bvin = product.Bvin;
                        k.URL = product.UrlSlug;
                        k.Name = product.ProductName;
                        k.SitePrize = product.SitePrice;
                        k.SiteCost = product.SiteCost;
                        k.LongDescription = product.LongDescription;
                        k.MinimumQuantity = product.MinimumQty;
                        k.AllowReviews = product.AllowReviews;
                        k.TaxClass = product.TaxSchedule;
                        productNames.Add(k);
                    }

                }
                listBoxKurzusok.DataSource = null;
                listBoxKurzusok.DataSource = productNames;
                listBoxKurzusok.DisplayMember = "Name";
            }
        }

        void kivProductAdatok(string bvin)
        {
            p = proxy.ProductsFind(bvin);
            tNev.Text = p.Content.ProductName;
            TLeiras.Text = p.Content.LongDescription;
        }

        void KivAdatBetoltes()
        {
            Kurzus kivkurzus = listBoxKurzusok.SelectedItem as Kurzus;

            txtName.Text = kivkurzus.Name;
            txtDescription.Text = kivkurzus.LongDescription;
            txtPrice.Text = Math.Round(kivkurzus.SitePrize, 0).ToString();
            txtCost.Text = Math.Round(kivkurzus.SiteCost, 0).ToString();
            numQuantity.Value = kivkurzus.MinimumQuantity;
            comboBoxNyelv.Items.Add("Angol");
            comboBoxNyelv.Items.Add("Német");
            comboBoxNyelv.Items.Add("Spanyol");
            comboBoxNyelv.Items.Add("Olasz");
            comboBoxNyelv.Items.Add("Francia");
            comboBoxNyelv.Items.Add("Portugál");
            comboBoxNyelv.Items.Add("Szlovák");
            comboBoxNyelv.Items.Add("Horvát");
            comboBoxNyelv.Items.Add("Kínai");
            comboBoxNyelv.Items.Add("Orosz");
            string[] szavak = kivkurzus.Name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string elso_szo = szavak[0];
            for (int i = 0; i < comboBoxNyelv.Items.Count; i++)
            {
                string comboBox_elem = comboBoxNyelv.Items[i].ToString();

                // Ha az aktuális elem megegyezik a keresett szóval, jelöljük ki
                if (comboBox_elem == elso_szo)
                {
                    comboBoxNyelv.SelectedIndex = i;
                    break; // Ha megtaláltuk a keresett szót, nincs szükségünk további vizsgálatra
                }
            }

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
            public string Bvin { get; set; }
            public string Name { get; set; }
            public string LongDescription { get; set; }
            public int MinimumQuantity { get; set; } 
            public decimal SitePrize { get; set; }
            public decimal SiteCost { get; set; }
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

            // A kijelölt product eltüntetése az oldalról
            Kurzus kivkurzus = listBoxKurzusok.SelectedItem as Kurzus;
            torlendoProductBvin = kivkurzus.Bvin;

            var product = proxy.ProductsFind(torlendoProductBvin).Content;

            product.IsSearchable = false;
            product.Status = 0;

            update = proxy.ProductsUpdate(product);


            if (CbTax.Checked == true)
            {
                ujProduct.TaxSchedule = 1;
            }
            else
            {
                ujProduct.TaxSchedule = -1;
            }
            ujProduct.ProductName = txtName.Text;
            szam = proxy.ProductsCountOfAll();
            ujProduct.Sku = (Convert.ToInt32(szam.Content) + 1).ToString();
            if (decimal.TryParse(txtPrice.Text, out price))
            {
                ujProduct.SitePrice = price;
            }
            ujProduct.InventoryMode = ProductInventoryModeDTO.WhenOutOfStockShow;
            ujProduct.MinimumQty = Convert.ToInt32(numQuantity.Value);
            ujProduct.ManufacturerId = "DBF676FB-C850-44B8-B448-917DB871E0E9";
            if (CbReviews.Checked == true)
            {
                ujProduct.AllowReviews = true;
            }
            else
            {
                ujProduct.AllowReviews = false;
            }
            ujProduct.IsAvailableForSale = true;

            ujProduct.SitePrice = decimal.Parse(txtPrice.Text);
            ujProduct.SiteCost = decimal.Parse(txtCost.Text);

            // Véletlenszerű GUID generálása
            Guid randomGuid = Guid.NewGuid();

            ujProduct.Bvin = randomGuid.ToString();
            termek = proxy.ProductsCreate(ujProduct, null);

            // csoportos kategóriához hozzáadás
            var association = new CategoryProductAssociationDTO
            {
                CategoryId = "C49FBC33-8761-4008-AD03-2981BBB6E220",
                ProductId = randomGuid.ToString(),
            };

            ApiResponse<CategoryProductAssociationDTO> categoryassociation = proxy.CategoryProductAssociationsCreate(association);
            NyelvKategoria();

            var association2 = new CategoryProductAssociationDTO
            {
                CategoryId = nyelvkategoria,
                ProductId = randomGuid.ToString(),
            };

            categoryassociation = proxy.CategoryProductAssociationsCreate(association2);

            var association3 = new CategoryProductAssociationDTO
            {
                CategoryId = "B227792B-9960-47F0-9B76-7EAACA726F4B",
                ProductId = randomGuid.ToString(),
            };

            categoryassociation = proxy.CategoryProductAssociationsCreate(association3);

            // Optionök létrehozása
            ApiResponse<bool> response = proxy.ProductOptionsAssignToProduct("036AE3E0-C9D1-4D9D-AB4D-B04AE67E618D", randomGuid.ToString(), false);

            // Inventory feltöltése
            var inventoryadatok = new ProductInventoryDTO
            {
                ProductBvin = randomGuid.ToString(),
                QuantityOnHand = 10,
                LowStockPoint = 0,
                OutOfStockPoint = 0
            };

            inventory = proxy.ProductInventoryCreate(inventoryadatok);


            MessageBox.Show("Sikeresen hozzáadva!");
            listBoxKurzusok.SelectedItem = null;
            ListaBetoltes();
        }

        private void NyelvKategoria()
        {
            // melyik nyelvcsoport
            string kivnyelv = comboBoxNyelv.SelectedItem.ToString();


            if (kivnyelv == "Angol")
            {
                nyelvkategoria = "6EBED072-E223-4430-A08B-E74187F0B21E";
            }
            if (kivnyelv == "Német")
            {
                nyelvkategoria = "DA682DC7-60A7-41B7-BAD7-976042912AF4";
            }
            if (kivnyelv == "Olasz")
            {
                nyelvkategoria = "875914E0-61B0-427E-98D4-E36BE9FE53A2";
            }
            if (kivnyelv == "Spanyol")
            {
                nyelvkategoria = "A4817D49-E702-4C9E-A911-976DC48FDF47";
                ;
            }
            if (kivnyelv == "Orosz")
            {
                nyelvkategoria = "C9D51C0E-B6CE-45C4-A127-0D85C97E254D";
            }
            if (kivnyelv == "Kínai")
            {
                nyelvkategoria = "C837C97F-67CE-48CB-A215-09263FDD3C90";
            }
            if (kivnyelv == "Szlovák")
            {
                nyelvkategoria = "D7657A5D-E529-4DE9-9CD1-1BD42F291FD6";
            }
            if (kivnyelv == "Portugál")
            {
                nyelvkategoria = "5227B8FC-3326-4ED7-9973-F94DA38E836E";
            }
            if (kivnyelv == "Francia")
            {
                nyelvkategoria = "DD660492-BA6D-4FC2-B504-B774930423D7";
            }
            if (kivnyelv == "Horvát")
            {
                nyelvkategoria = "9542EFA0-F242-4535-AA6D-D6BC233F7992";
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan be szeretné zárni az ablakot?", "Bezárás megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                // Ha a felhasználó nem akarja bezárni az ablakot, akkor megállítjuk a bezárást
                e.Cancel = true;
            }
        }
    }
}


