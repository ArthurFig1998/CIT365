using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk
{
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

        public enum Shipping
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }
        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public string ShippingType { get; set; }

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
            //TO DO...




            return total;
        }


    }
}
