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
        MegaDeskWebContext _context;

        const decimal BASE_DESK_PRICE = 200.00M;
        const decimal PRICE_PER_INCH = 1.00M;
        const decimal DRAWER_COST = 50.00M;

        public int DeskQuoteId { get; set; }

        [Display(Name = "Customer Name")]
        [Required]
        public string CustomerName { get; set; }

        [Display(Name = "Date")]
        public DateTime QuoteDate { get; set; }

        [Required]
        [Display(Name = "Shipping Type")]
        public int ShippingId { get; set; }

        [Display(Name = "Price")]
        public decimal QuotePrice { get; set; }

        public int DeskId { get; set; }

        /*NAV  prop*/
        public Desk Desk { get; set; }

        public Shipping Shipping { get; set; }

        public DeskQuote()
        {

        }


        public decimal getQuotePrice(MegaDeskWebContext context) //DeskQuote deskQuote
        {
            _context = context;
   
            //Sets base price to order
            decimal total = BASE_DESK_PRICE;

            //Get the surface area
            decimal surfaceArea = this.Desk.Width * this.Desk.Depth;

            //Initializes the surface area price
            decimal surfaceAreaPrice = 0M;

            //Add the price of the table if it is a certain size
            if(surfaceArea > 1000)
            {
                surfaceAreaPrice = (surfaceArea - 1000) * PRICE_PER_INCH;
            }

            //Add to the total
            total += surfaceAreaPrice;

            //Get price for the drawers
            decimal numberOfDrawersPrice = this.Desk.NumberOfDrawers * DRAWER_COST;

            //Add to the total
            total += numberOfDrawersPrice;



            //Calculate shipping price pulling from database

            var shippingOptions = from m in _context.Shipping
                                  select m;


            //Initialize shipping cost with default value
            decimal shippingCost = 0;

          
            shippingOptions = shippingOptions.Where(s => s.ShippingId == this.ShippingId);

            var shipping = shippingOptions.FirstOrDefault();
            
            if (surfaceArea < 1000)
            {
                shippingCost = shipping.Under1000;
            }
            else if(surfaceArea > 1000 && surfaceArea < 2000)
            {
                shippingCost = shipping.Between1000And2000;
            }
            else if(surfaceArea > 2000)
            {
                shippingCost = shipping.Over2000;
            }

            //Add to the total
            total += shippingCost;

            //Calculate the surface material price pulling from database
            var surfaceMaterialOptions = from m in _context.SurfaceMaterial
                                  select m;
            //There isn't a default value for this variable
            decimal surfaceMaterialCost;


            surfaceMaterialOptions = surfaceMaterialOptions.Where(s => s.SurfaceMaterialId == this.Desk.SurfaceMaterialId);

            var material = surfaceMaterialOptions.FirstOrDefault();
            surfaceMaterialCost = material.Cost;

            //Add to the total
            total += surfaceMaterialCost;

            //Calculate the final price of the order
            //TO-DO
            return total;
        }
    }
}
