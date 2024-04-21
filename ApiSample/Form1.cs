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

            List<string> list = new List<string>();

            var categoryId = "6AD3CD1D-A4F3-47B2-AC7E-63565CA4DB51";
            var page = 1;
            var pageSize = int.MaxValue;

            Api proxy = new Api(url, key);

            //var snaps = proxy.CategoriesFindAll();
            //var product = proxy.ProductsFindAll();
            ApiResponse<PageOfProducts> response = proxy.ProductsFindForCategory(categoryId, page, pageSize);
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
                List<string> productNames = new List<string>();
                foreach (var product in response.Content.Products)
                {
                    Console.WriteLine(product.ProductName);
                    productNames.Add(product.ProductName);
                }
                listBoxKurzusok.DataSource = productNames;
            }

            void TeltBetoltes()
            {
                //var eredmen
            }
        }
    }
}
