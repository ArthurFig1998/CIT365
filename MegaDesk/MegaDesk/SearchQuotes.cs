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
    public partial class SearchQuotes : Form
    {
        const string PATH = @"quotes.json";
        public SearchQuotes()
        {
            InitializeComponent();
            
            var materials = new List<DesktopMaterial>();
            materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();

            comSurfaceMaterialSearch.DataSource = materials;

            
            comSurfaceMaterialSearch.SelectedIndex = -1;
            var index = comSurfaceMaterialSearch.SelectedIndex;

            //makes sure the whole table is display upon loading
            if (index < 0)
            {
                loadGrid();
            }
            else
            {
                loadGridWithFilter();
            }
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new MainMenu()).Show();
        }

        public void loadGrid()
        {
            using (StreamReader reader = new StreamReader(PATH))
            {
                // Read all quotes on file
                string quotes = reader.ReadToEnd();

                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                //select all items of the table
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

        public void loadGridWithFilter()
        {
            var selectedIndex = (int)comSurfaceMaterialSearch.SelectedIndex;

            //if index is -1 (or the field is blank initially) just load the whole table
            if (selectedIndex < 0)
            {
                loadGrid();
                return;
            }
            else
            {
                using (StreamReader reader = new StreamReader(PATH))
                {
                    // Read all quotes on file
                    string quotes = reader.ReadToEnd();

                    List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                    // select items where the surface material is the same as the material on search bar
                    quotesDataGrid.DataSource = deskQuotes.Select(d => new
                    {
                        Date = d.QuoteDate,
                        Customer = d.CustomerName,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.NumberOfDrawers,
                        SurfaceMaterial = d.Desk.SurfaceMaterial,
                        QuoteAmount = d.QuotePrice.ToString("c")
                    }).Where(q =>
                        q.SurfaceMaterial == (DesktopMaterial)comSurfaceMaterialSearch.SelectedItem
                    ).ToList();
                }
            }
        }
        
        //display filtered list when a valid item is selected
        private void ComSurfaceMaterialSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGridWithFilter();
        }

        //if the field is cleared or text is changed to something not on the list, display the whole list
        private void ComSurfaceMaterialSearch_TextChanged(object sender, EventArgs e)
        {
            loadGrid();
        }
    }
}
