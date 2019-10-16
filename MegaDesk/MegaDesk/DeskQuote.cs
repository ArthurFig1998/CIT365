using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk
{
    public enum Shipping
    {
        Normal14Days,
        Rush3Days,
        Rush5Days,
        Rush7Days
    }
    public class DeskQuote
    {
        const decimal BASE_DESK_PRICE = 200.00M;
        const decimal PRICE_PER_INCH = 1.00M;
        const decimal DRAWER_COST = 50.00M;
        const decimal OAK_COST = 200.00M;
        const decimal LAMINATE_COST = 100.00M;
        const decimal PINE_COST = 50.00M;
        const decimal ROSEWOOD_COST = 300.00M;
        const decimal VENEER_COST = 125.00M;
        

        
        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public Shipping ShippingType { get; set; }

        public decimal QuotePrice { get; set; }

        public Desk Desk { get; set; }

        public decimal getQuotePrice() {

            // start the total at the base price
            decimal total = BASE_DESK_PRICE;

            // SURFACE AREA
            // initiatilze the price for desk surface area
            var surfaceAreaPrice = 0M;

            // calculate desk surface area
            var surfaceArea = this.Desk.Width * this.Desk.Depth;

            if (surfaceArea > 1000)
            {
                surfaceAreaPrice = (surfaceArea - 1000) * PRICE_PER_INCH;
            }

            // add it to the total
            total += surfaceAreaPrice;

            // DRAWERS
            // calculate cost of drawers
            var drawerCost = this.Desk.NumberOfDrawers * DRAWER_COST;

            // add it to the total
            total += drawerCost;

            // SURFACE MATERIAL
            
            // get the surface material
            var surfaceMaterial = this.Desk.SurfaceMaterial;
            
            // initialize surface material cost
            var surfaceMaterialCost = 0M;

            switch (surfaceMaterial)
            {
                case DesktopMaterial.Oak:
                    surfaceMaterialCost = OAK_COST;
                    break;

                case DesktopMaterial.Laminate:
                    surfaceMaterialCost = LAMINATE_COST;
                    break;

                case DesktopMaterial.Pine:
                    surfaceMaterialCost = PINE_COST;
                    break;

                case DesktopMaterial.Rosewood:
                    surfaceMaterialCost = ROSEWOOD_COST;
                    break;

                case DesktopMaterial.Veneer:
                    surfaceMaterialCost = VENEER_COST;
                    break;
            }

            // add it to the total
            total += surfaceMaterialCost;

            // SHIPPING
            // initialize the shipping cost
            var shippingCostTotal = 0M;

            // check if any extra shipping cost is needed
            if (ShippingType != Shipping.Normal14Days)
            {
                const int SMALL_DESK = 0;
                const int MEDIUM_DESK = 1;
                const int LARGE_DESK = 2;
                const int THREE_DAYS = 0;
                const int FIVE_DAYS = 1;
                const int SEVEN_DAYS = 2;

                //set array index for shipping type
                int iShipping = 0;
                switch (ShippingType)
                {
                    case Shipping.Rush3Days:
                        iShipping = THREE_DAYS;
                        break;
                    case Shipping.Rush5Days:
                        iShipping = FIVE_DAYS;
                        break;
                    case Shipping.Rush7Days:
                        iShipping = SEVEN_DAYS;
                        break;
                }

                // set array index for desk size
                var deskArea = this.Desk.Depth * this.Desk.Width;
                int iDeskSize;

                if (deskArea < 1000)
                {
                    iDeskSize = SMALL_DESK;
                }
                else if (deskArea >= 1000 && deskArea < 2000)
                {
                    iDeskSize = MEDIUM_DESK;
                }
                else
                {
                    iDeskSize = LARGE_DESK;
                }

                // read file into 2D array
                const int NUM_SHIPPING_TYPES =3;
                const int NUM_DESK_SIZES = 3;
                decimal[,] shippingCosts = new decimal[NUM_SHIPPING_TYPES, NUM_DESK_SIZES];
                
                try
                {
                    string[] prices = File.ReadAllLines(@"shippingCost.txt");
                    int i = 0, j = 0;
                    foreach(string price in prices)
                    {
                        shippingCosts[i, j] = decimal.Parse(price);
                        if (j == 2)
                        {
                            j = 0;
                            i++;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
                catch(Exception e)
                {
                    throw;
                }

                // get the shipping cost from the array
                shippingCostTotal = shippingCosts[iShipping, iDeskSize];
            }

            // add shipping cost to the total
            total += shippingCostTotal;

            // RETURN TOTAL PRICE
            return total;
        }

        
    }
}
