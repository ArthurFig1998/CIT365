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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        SearchQuotes search = new SearchQuotes();
        AddQuote add = new AddQuote();
        DisplayQuote display = new DisplayQuote();
        ViewAllQuotes viewAll = new ViewAllQuotes();
        

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            this.search.Show();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            this.add.Show();
            Hide();
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            this.viewAll.Show();
            Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
