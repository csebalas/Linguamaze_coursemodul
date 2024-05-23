using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Net.Mail;
using System.Net;
using Hotcakes.CommerceDTO.v1.Shipping;
using System.Threading;

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
        ApiResponse<ShippableItemDTO> szallitas;
        List<Kurzus> productNames = new List<Kurzus>();
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "Google Calendar API Example";
        private CalendarService calendarService;


        Api proxy;
        string bvin;
        Random random = new Random();
        string nyelvkategoria;
        string torlendoProductBvin="";
        string image;
        StreamWriter streamWriter = new StreamWriter("pythonhoz.txt");
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

            proxy = new Api(url, key);
            GoogleAPI();
        }

        private void GoogleAPI()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                //Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            calendarService = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        private void CreateEvent(DateTime eventDate)
        {
            Event newEvent = new Event()
            {
                Summary = tNev.Text,
                Location = "LinguaMaze Nyelviskola",
                Description = TLeiras.Text,
                Start = new EventDateTime()
                {
                    DateTime = eventDate,
                    TimeZone = "Europe/Budapest", // Set appropriate time zone
                },
                End = new EventDateTime()
                {
                    DateTime = eventDate.AddHours(1), // 1 hour event
                    TimeZone = "Europe/Budapest",
                },
                Recurrence = new String[] {"RRULE:FREQ=WEEKLY;COUNT=32"},
            };

            String calendarId = "primary";
            EventsResource.InsertRequest request = calendarService.Events.Insert(newEvent, calendarId);
            Event createdEvent = request.Execute();
            //Console.WriteLine("Event created: {0}", createdEvent.HtmlLink);
        }


        private void controlClear()
        {      
            foreach (Control control in this.Controls)
            {
                if (control is ListBox)
                {
                    ((ListBox)control).DataSource = null;
                    ((ListBox)control).Items.Clear();
                }
            }
            productNames.Clear();
            tNev.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtCost.Text = "";
            numQuantity.Value = 0;
            comboBoxNyelv.Items.Clear();
            comboBoxNyelv.SelectedIndex = -1;
            TLeiras.Text = "";
        }

        void ListaBetoltes(){
            controlClear();
            response = proxy.ProductsFindForCategory("C49FBC33-8761-4008-AD03-2981BBB6E220", 1, int.MaxValue);

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
                listBoxKurzusok.DataSource = productNames;
                listBoxKurzusok.DisplayMember = "Name";
            }
        }

        private void listBoxKurzusok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxKurzusok.SelectedItem != null)
            {
                Kurzus kivkurzus = listBoxKurzusok.SelectedItem as Kurzus;
                bvin = kivkurzus.Bvin.ToString();
                kivProductAdatok(bvin);
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

        public bool ValidateNewProductData()
        {
            decimal price, cost;

            // Ellenőrizzük, hogy a szükséges mezők ki vannak-e töltve
            if (string.IsNullOrEmpty(txtName.Text))
                return false;
            if (!decimal.TryParse(txtPrice.Text, out price))
                return false;
            if (!decimal.TryParse(txtCost.Text, out cost))
                return false;
            if (comboBoxNyelv.SelectedItem == null)
                return false;

            return true;
        }


        private void btnUj_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value is DateTime selectedDate)
            {
                CreateEvent(selectedDate);
            }

            if (!ValidateNewProductData())
            {
                MessageBox.Show("Hiányzó adatok! Kérem, töltse ki az összes szükséges mezőt.");
                return;
            }
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

            var szallitas = new ShippableItemDTO();
            szallitas.IsNonShipping = true;

            ujProduct.ShippingDetails = szallitas;

            szam = proxy.ProductsCountOfAll();
            ujProduct.Sku = (Convert.ToInt32(szam.Content) + 1).ToString();
            ujProduct.LongDescription = txtDescription.Text;
            
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

            NyelvKategoria();

            ujProduct.ImageFileSmall = image;
            ujProduct.ImageFileMedium = image;
            
            

            termek = proxy.ProductsCreate(ujProduct, null);

            streamWriter.WriteLine(@"C:\DNN\Portals\0\Hotcakes\Data\products\" + ujProduct.Bvin);
            streamWriter.WriteLine(image);

            // csoportos kategóriához hozzáadás
            var association = new CategoryProductAssociationDTO
            {
                CategoryId = "C49FBC33-8761-4008-AD03-2981BBB6E220",
                ProductId = randomGuid.ToString(),
            };

            ApiResponse<CategoryProductAssociationDTO> categoryassociation = proxy.CategoryProductAssociationsCreate(association);


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
            listBoxKurzusok.SelectedIndex = -1;
            ListaBetoltes();
        }

        private void NyelvKategoria()
        {
            // melyik nyelvcsoport
            string kivnyelv = comboBoxNyelv.SelectedItem.ToString();


            if (kivnyelv == "Angol")
            {
                nyelvkategoria = "6EBED072-E223-4430-A08B-E74187F0B21E";
                image = "english-course.jpg";

            }
            if (kivnyelv == "Német")
            {
                nyelvkategoria = "DA682DC7-60A7-41B7-BAD7-976042912AF4";
                image = "deutsch-kurs.jpg";
            }
            if (kivnyelv == "Olasz")
            {
                nyelvkategoria = "875914E0-61B0-427E-98D4-E36BE9FE53A2";
                image = "italiano_course.jpg";
            }
            if (kivnyelv == "Spanyol")
            {
                nyelvkategoria = "A4817D49-E702-4C9E-A911-976DC48FDF47";
                image = "spanish-course.jpg";
                ;
            }
            if (kivnyelv == "Orosz")
            {
                nyelvkategoria = "C9D51C0E-B6CE-45C4-A127-0D85C97E254D";
                image = "russian-course.jpg";
            }
            if (kivnyelv == "Kínai")
            {
                nyelvkategoria = "C837C97F-67CE-48CB-A215-09263FDD3C90";
                image = "chinese-course.jpg";
            }
            if (kivnyelv == "Szlovák")
            {
                nyelvkategoria = "D7657A5D-E529-4DE9-9CD1-1BD42F291FD6";
                image = "slovakian-course.jpg";
            }
            if (kivnyelv == "Portugál")
            {
                nyelvkategoria = "5227B8FC-3326-4ED7-9973-F94DA38E836E";
                image = "portuguese-course.jpg";
            }
            if (kivnyelv == "Francia")
            {
                nyelvkategoria = "DD660492-BA6D-4FC2-B504-B774930423D7";
                image = "french-course.jpg";
            }
            if (kivnyelv == "Horvát")
            {
                nyelvkategoria = "9542EFA0-F242-4535-AA6D-D6BC233F7992";
                image = "croatian-course.jpg";
            }
        }

        public void SendEmailWithAttachment(string filePath)
        {
            var fromAddress = new MailAddress("linguamazenyelviskola@gmail.com", "LinguaMaze");
            var toAddress = new MailAddress("linguamazenyelviskola@gmail.com", "LinguaMaze");
            const string fromPassword = "eadi xold xyoi mkjn";
            const string subject = "Fájl küldés";
            const string body = "Csatolmányban a legújabb kurzusok";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                message.Attachments.Add(new Attachment(filePath));
                smtp.Send(message);
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
            streamWriter.Close();

            SendEmailWithAttachment("pythonhoz.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaBetoltes();
        }
    }
}