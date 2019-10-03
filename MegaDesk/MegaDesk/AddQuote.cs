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
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new MainMenu()).Show();
        }

    }
}
