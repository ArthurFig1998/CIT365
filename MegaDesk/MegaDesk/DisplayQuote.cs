﻿using Newtonsoft.Json;
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
        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();

            numWidth.Value = quote.Desk.Width;
            numDepth.Value = quote.Desk.Depth;
            comSurfaceMaterial.SelectedItem = quote.Desk.SurfaceMaterial;
            comShippingType.SelectedItem = quote.ShippingType;
            numDrawers.Value = quote.Desk.NumberOfDrawers;

            quotePriceBox.Text = Convert.ToString(quote.QuotePrice);
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new MainMenu()).Show();
        }

        
    }
}
