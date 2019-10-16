using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        // path to the json file of deskQuotes
        const string PATH = @"quotes.json";

        public AddQuote()
        {
            InitializeComponent();
            DateTime date = DateTime.Now;
            dateLabel.Text = date.ToString("dd MMMM yyy");

            var materials = new List<DesktopMaterial>();
            materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

            comSurfaceMaterial.DataSource = materials;

            comSurfaceMaterial.SelectedIndex = -1;

            var shipping = new List<Shipping>();
            shipping = Enum.GetValues(typeof(Shipping)).Cast<Shipping>().ToList();

            comShippingType.DataSource = shipping;

            comShippingType.SelectedIndex = -1;
        }

        public void addToFile(DeskQuote deskQuote)
        {            
            List<DeskQuote> deskQuotes = new List<DeskQuote>();

            if (File.Exists(PATH))
            {
                using (StreamReader reader = new StreamReader(PATH))
                {
                    // Read all quotes on file
                    string quotes = reader.ReadToEnd();

                    if (quotes.Length > 0)
                    {
                        // Deserialize all quotes on file
                        deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                }
            }

            // add the new quote to the list of deskQuotes
            deskQuotes.Add(deskQuote);

            // save the list of deskQuotes to the file (overwrite old file)
            SaveQuotes(deskQuotes);
        }

        private void SaveQuotes(List<DeskQuote> quotes)
        {
            string deskQuotesJson = JsonConvert.SerializeObject(quotes, Formatting.Indented);

            using (StreamWriter writer = new StreamWriter(PATH, false))
            {
                writer.WriteLine(deskQuotesJson);
                writer.Close();
            }
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new MainMenu()).Show();
        }

        private void SendQuote_Click(object sender, EventArgs e)
        {
            // create new desk
            Desk desk = new Desk();
            desk.Depth = numDepth.Value;
            desk.Width = numWidth.Value;
            desk.NumberOfDrawers = (int)numDrawers.Value;
            desk.SurfaceMaterial = (DesktopMaterial)comSurfaceMaterial.SelectedItem;

            // create Desk quote
            DeskQuote quote = new DeskQuote();
            DateTime date = DateTime.Now;
            quote.ShippingType = (Shipping)comShippingType.SelectedItem;

            quote.CustomerName = customerName.Text;
            quote.QuoteDate = date;
            quote.Desk = desk;
            quote.QuotePrice = quote.getQuotePrice();

            addToFile(quote);

               // System.Windows.Forms.MessageBox.Show("Shipping price is: " + quote.QuotePrice);

            

        }
    }
}
