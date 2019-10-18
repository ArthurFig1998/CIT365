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
    public partial class DisplayQuote : Form
    {
        const string PATH = @"quotes.json";
        public DisplayQuote()
        {
            InitializeComponent();
            getAllQuotes();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new MainMenu()).Show();
        }

        public void getAllQuotes()
        {
            
            using (StreamReader reader = new StreamReader(PATH))
            {
                // Read all quotes on file
                string quotes = reader.ReadToEnd();

                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                quotesDataGrid.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.NumberOfDrawers,
                    SurfaceMaterial = d.Desk.SurfaceMaterial,
                    QuoteAmount = d.QuotePrice.ToString("c")
                }).ToList();
            }
        }
    }
}
