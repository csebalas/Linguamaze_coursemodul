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

            // Kezdőértékek beállítása vagy parancssori argumentumokból olvasás
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 2)
            {
                url = args[1];
                key = args[2];
            }

            if (url == string.Empty) url = "http://20.234.113.211:8101/";
            if (key == string.Empty) key = "1-64869949-9801-4b5c-bd4b-326377c14130";

            List<string> list = new List<string>();

            var categoryId = "6AD3CD1D-A4F3-47B2-AC7E-63565CA4DB51";
            var page = 1;
            var pageSize = int.MaxValue;

            

            Api proxy = new Api(url, key);

            var snaps = proxy.CategoriesFindAll();
            var product = proxy.ProductsFindAll();
            ApiResponse<PageOfProducts> response = proxy.ProductsFindForCategory(categoryId, page, pageSize);
            Console.WriteLine(response.Content.ToString());
            if (snaps.Content != null)
            {
                Console.WriteLine(response.Content.ToString());
                //Console.WriteLine("Found " + snaps.Content.Count + " categories");
                //Console.WriteLine("-- First 5 --");
                for (var i = 0; i < 5; i++)
                {
                    //if (i < snaps.Content.Count)
                    //{
                       // Console.WriteLine(i + ") " + snaps.Content[i].Name + " [" + snaps.Content[i].Bvin + "]");
                        list.Add(snaps.Content[i].Name);
                        var cat = proxy.CategoriesFind(snaps.Content[i].Bvin);
                        if (cat.Errors.Count > 0)
                        {
                            foreach (var err in cat.Errors)

                            {
                                //Console.WriteLine("ERROR: " + err.Code + " " + err.Description);
                            }
                        }
                        else
                        {
                            //Console.WriteLine("By Bvin: " + cat.Content.Name + " | " + cat.Content.Description);
                        }

                        var catSlug = proxy.CategoriesFindBySlug(snaps.Content[i].RewriteUrl);
                        if (catSlug.Errors.Count > 0)
                        {
                            foreach (var err in catSlug.Errors)
                            {
                                //Console.WriteLine("ERROR: " + err.Code + " " + err.Description);
                            }
                        }
                        else
                        {
                            //Console.WriteLine("By Slug: " + cat.Content.Name + " | " + cat.Content.Description);
                        }
                    //}
                }
            }

            //Console.WriteLine("Done - Press a key to continue");
            //Console.ReadKey();

            listBoxKurzusok.DataSource = list;
        }

        void TeltBetoltes()
        {
            //var eredmen
        }
    }
}
