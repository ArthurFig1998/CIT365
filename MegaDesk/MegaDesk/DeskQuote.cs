using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk
{
    public enum Shipping
    {
        Rush3Days,
        Rush5Days,
        Rush7Days,
        Normal14Days
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

            decimal total = 0;

            //adding base price
            total = BASE_DESK_PRICE;

            //add surface area price

            var surfaceArea = this.Desk.Width * this.Desk.Depth;

            var surfaceAreaPrice = 0M;

            if(surfaceArea > 1000)
            {
                surfaceAreaPrice = (surfaceArea - 1000) * PRICE_PER_INCH;
            }
            total += surfaceAreaPrice;

            //add drawers cost

            var drawerCost = this.Desk.NumberOfDrawers * DRAWER_COST;

            total += drawerCost;

            //add surface material cost

            var surfaceMaterial = this.Desk.SurfaceMaterial;
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

            total = +surfaceMaterialCost;

            //add shipping cost

            var shippingCostTotal = 0M;

            //check if any extra shipping cost is needed
            if (ShippingType != Shipping.Normal14Days)
            {
                const int SMALL_DESK = 0;
                const int MEDIUM_DESK = 1;
                const int LARGE_DESK = 2;
                const int THREE_DAYS = 0;
                const int FIVE_DAYS = 1;
                const int SEVEN_DAYS = 2;

                //determine array index for shipping type
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

                //determine array index for desk size
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

                //read file into 2D array
                const int NUM_SHIPPING_TYPES =3;
                const int NUM_DESK_SIZES = 3;
                decimal[,] shippingCosts = new decimal[NUM_SHIPPING_TYPES, NUM_DESK_SIZES];
                StreamReader file = new StreamReader("../shippingCost.txt");
                
                for (int j = 0; j < NUM_SHIPPING_TYPES; j++)
                {
                    shippingCosts[0,j] = decimal.Parse(file.ReadLine());
                    for (int i = 1; i < NUM_DESK_SIZES; i++)
                    {
                        
                        shippingCosts[i, j] = decimal.Parse(file.ReadLine());
                    }
                }
                shippingCostTotal = shippingCosts[iShipping, iDeskSize];

                // add the shipping cost to the total cost
                total += shippingCostTotal;
            }

            return total;
        }


    }
}
