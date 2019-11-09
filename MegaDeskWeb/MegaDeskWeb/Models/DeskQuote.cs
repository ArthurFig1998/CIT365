using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Newtonsoft.Json;
using MegaDeskWeb.Models;
using System.ComponentModel.DataAnnotations;

namespace MegaDesk
{
    public class DeskQuote
    {
        const decimal BASE_DESK_PRICE = 200.00M;
        const decimal PRICE_PER_INCH = 1.00M;
        const decimal DRAWER_COST = 50.00M;

        public int DeskQuoteId { get; set; }

        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Date")]
        public DateTime QuoteDate { get; set; }

        public int ShippingId { get; set; }

        [Display(Name = "Price")]
        public decimal QuotePrice { get; set; }

        public int DeskId { get; set; }

        /*NAV  prop*/
        public Desk Desk { get; set; }
        public Shipping Shipping { get; set; }


        public decimal getQuotePrice(Desk Desk, DeskQuote DeskQuote)
        {
            //Sets base price to order
            decimal total = BASE_DESK_PRICE;

            //Get the surface area
            decimal SurfaceArea = Desk.surfaceArea();

            //Initializes the surface area price
            decimal SurfaceAreaPrice = 0M;

            //Add the price of the table if it is a certain size
            if(SurfaceArea > 1000)
            {
                SurfaceAreaPrice = (SurfaceArea - 1000) * PRICE_PER_INCH;
            }

            //Add to the total
            total += SurfaceAreaPrice;

            //Get price for the drawers
            decimal NumberOfDrawersPrice = Desk.NumberOfDrawers * DRAWER_COST;

            //Add to the total
            total += NumberOfDrawersPrice;

            //Calculate shipping price pulling from database
            //TO-DO

            //Initialize shipping cost with default value
            decimal ShippingCost = 0;

            if(Shipping.ShippingId == 1)
            {
                if(SurfaceArea < 1000)
                {
                    
                }
                else if(SurfaceArea > 1000 && SurfaceArea < 2000)
                {

                }
                else if(SurfaceArea > 2000)
                {

                }
            }
            else if(Shipping.ShippingId == 2)
            {
                if (SurfaceArea < 1000)
                {

                }
                else if (SurfaceArea > 1000 && SurfaceArea < 2000)
                {

                }
                else if (SurfaceArea > 2000)
                {

                }
            }

            else if(Shipping.ShippingId == 3)
            {
                if (SurfaceArea < 1000)
                {

                }
                else if (SurfaceArea > 1000 && SurfaceArea < 2000)
                {

                }
                else if (SurfaceArea > 2000)
                {

                }
            }

            //Calculate the surface material price pulling from database
            //TO-DO

            //Calculate the final price of the order
            //TO-DO






            //Previous code

            //var shippingOptions = from m in MegaDeskWeb.Models.MegaDeskWebContext
            //                      select m;

            //shippingOptions = shippingOptions.Where(s => s.Sh);

            //decimal ShippingType = ShippingId;

            //switch (ShippingType)
            //{
            //    case 1:
            //        deliveryCost = 3;
            //        break;
            //    case 2:
            //        deliveryCost = 5;
            //        break;
            //    case 3:
            //        deliveryCost = 7;
            //        break;
            //    default:
            //        deliveryCost = 0;
            //        break;
            //}
            return total;
        }

        //public decimal getQuotePrice()
        //{

        //    // start the total at the base price
        //    decimal total = BASE_DESK_PRICE;

        //    // SURFACE AREA
        //    // initiatilze the price for desk surface area
        //    var surfaceAreaPrice = 0M;

        //    // calculate desk surface area
        //    var surfaceArea = this.Desk.Width * this.Desk.Depth;

        //    if (surfaceArea > 1000)
        //    {
        //        surfaceAreaPrice = (surfaceArea - 1000) * PRICE_PER_INCH;
        //    }

        //    // add it to the total
        //    total += surfaceAreaPrice;

        //    // DRAWERS
        //    // calculate cost of drawers
        //    var drawerCost = this.Desk.NumberOfDrawers * DRAWER_COST;

        //    // add it to the total
        //    total += drawerCost;

        //    // SURFACE MATERIAL

        //    // get the surface material
        //    int surfaceMaterial = DeskQuote.Desk.SurfaceMaterial;

        //    // initialize surface material cost
        //    var surfaceMaterialCost = 0M;

        //    switch (surfaceMaterial)
        //    {
        //        case 1:
        //            surfaceMaterialCost = Desk.SurfaceMaterial.Cost;
        //            break;

        //        case 2:
        //            surfaceMaterialCost = LAMINATE_COST;
        //            break;

        //        case 3:
        //            surfaceMaterialCost = PINE_COST;
        //            break;

        //        case 4:
        //            surfaceMaterialCost = ROSEWOOD_COST;
        //            break;

        //        case 5:
        //            surfaceMaterialCost = VENEER_COST;
        //            break;
        //    }

        //    // add it to the total
        //    total += surfaceMaterialCost;

        //    // SHIPPING
        //    // initialize the shipping cost
        //    var shippingCostTotal = 0M;

        //    // check if any extra shipping cost is needed
        //    if (ShippingType != Shipping.Normal14Days)
        //    {
        //        const int SMALL_DESK = 0;
        //        const int MEDIUM_DESK = 1;
        //        const int LARGE_DESK = 2;
        //        const int THREE_DAYS = 0;
        //        const int FIVE_DAYS = 1;
        //        const int SEVEN_DAYS = 2;

        //        //set array index for shipping type
        //        int iShipping = 0;
        //        switch (ShippingType)
        //        {
        //            case Shipping.Rush3Days:
        //                iShipping = THREE_DAYS;
        //                break;
        //            case Shipping.Rush5Days:
        //                iShipping = FIVE_DAYS;
        //                break;
        //            case Shipping.Rush7Days:
        //                iShipping = SEVEN_DAYS;
        //                break;
        //        }

        //        // set array index for desk size
        //        var deskArea = this.Desk.Depth * this.Desk.Width;
        //        int iDeskSize;

        //        if (deskArea < 1000)
        //        {
        //            iDeskSize = SMALL_DESK;
        //        }
        //        else if (deskArea >= 1000 && deskArea < 2000)
        //        {
        //            iDeskSize = MEDIUM_DESK;
        //        }
        //        else
        //        {
        //            iDeskSize = LARGE_DESK;
        //        }

        //        // read file into 2D array
        //        const int NUM_SHIPPING_TYPES = 3;
        //        const int NUM_DESK_SIZES = 3;
        //        decimal[,] shippingCosts = new decimal[NUM_SHIPPING_TYPES, NUM_DESK_SIZES];

        //        try
        //        {
        //            string[] prices = File.ReadAllLines(@"shippingCost.txt");
        //            int i = 0, j = 0;
        //            foreach (string price in prices)
        //            {
        //                shippingCosts[i, j] = decimal.Parse(price);
        //                if (j == 2)
        //                {
        //                    j = 0;
        //                    i++;
        //                }
        //                else
        //                {
        //                    j++;
        //                }
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            throw;
        //        }

        //        // get the shipping cost from the array
        //        shippingCostTotal = shippingCosts[iShipping, iDeskSize];
        //    }

        //    // add shipping cost to the total
        //    total += shippingCostTotal;

        //    // RETURN TOTAL PRICE
        //    return total;
        //}


    }
}
