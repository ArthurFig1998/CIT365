using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
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

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new MainMenu()).Show();
        }

        private void SendQuote_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();
            desk.Depth = numDepth.Value;
            desk.Width = numWidth.Value;
            desk.NumberOfDrawers = numDrawers.Value;
            DeskQuote quote = new DeskQuote();
            DateTime date = DateTime.Now;

            quote.CustomerName = customerName.Text;
            quote.QuoteDate = date;
            quote.Desk = desk;
            quote.QuotePrice = quote.getQuotePrice();

                System.Windows.Forms.MessageBox.Show("Quote price is: " + quote.QuotePrice);



            // desk.Depth = numDepth.Value;

        }
    }
}
