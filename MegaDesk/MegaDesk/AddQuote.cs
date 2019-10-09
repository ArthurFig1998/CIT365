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

            var materials = new List<Desk.DesktopMaterial>();
            materials = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList();

            comSurfaceMaterial.DataSource = materials;

            comSurfaceMaterial.SelectedIndex = -1;

            var shipping = new List<DeskQuote.Shipping>();
            shipping = Enum.GetValues(typeof(DeskQuote.Shipping)).Cast<DeskQuote.Shipping>().ToList();

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

           // desk.Depth = numDepth.Value;

        }
    }
}
