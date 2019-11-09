using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk;
using MegaDeskWeb.Models;

namespace MegaDeskWeb.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        const decimal BASE_PRICE = 200M;
        const decimal PRICE_PER_DRAWER = 50M;
        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }
        public SelectList SurfaceMaterialList { get; set; }
        public SelectList ShippingList { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }
        public Shipping Shipping { get; set; }
        [BindProperty]
        public Desk Desk { get; set; }
        public int deliveryCost { get; set; }

        public CreateModel(MegaDeskWeb.Models.MegaDeskWebContext context)
        {
            _context = context;

            IQueryable<string> surfaceMaterialQuery = from m in _context.SurfaceMaterial
                                                      orderby m.SurfaceMaterialName
                                                      select m.SurfaceMaterialName;

            IQueryable<string> shippingTypeQuery = from m in _context.Shipping
                                                   orderby m.ShippingType
                                                   select m.ShippingType;

            SurfaceMaterialList = new SelectList(surfaceMaterialQuery.Distinct().ToList());
            ShippingList = new SelectList(shippingTypeQuery.Distinct().ToList());
        }

        public IActionResult OnGet()
        {
            ViewData["SurfaceMaterialId"] = new SelectList(_context.Set<SurfaceMaterial>(), "SurfaceMaterialId", "SurfaceMaterialName");
            ViewData["ShippingId"] = new SelectList(_context.Set<Shipping>(), "ShippingId", "ShippingType");
            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Desk.Add(Desk);
            await _context.SaveChangesAsync();

            DeskQuote.DeskId = Desk.DeskId;
            DeskQuote.QuoteDate = DateTime.Now;

            ///copy from here to m
            //decimal SurfaceArea = Desk.surfaceArea();

            //decimal ShippingType = DeskQuote.ShippingId;

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

            //decimal calculateShippingPrice(decimal pvSurfaceArea, decimal pvShippingType)
            //{

            //    decimal ShippingCost = 0M;

            //    if (pvShippingType == 3)
            //    {
            //        if (pvSurfaceArea < 1000)
            //        {
            //            ShippingCost = 60;
            //        }
            //        else if (pvSurfaceArea > 1000 && pvSurfaceArea < 2000)
            //        {
            //            ShippingCost = 70;
            //        }
            //        else if (pvSurfaceArea > 2000)
            //        {
            //            ShippingCost = 80;
            //        }
            //    }
            //    else if (pvShippingType == 5)
            //    {
            //        if (pvSurfaceArea < 1000)
            //        {
            //            ShippingCost = 40;
            //        }
            //        else if (pvSurfaceArea > 1000 && pvSurfaceArea < 2000)
            //        {
            //            ShippingCost = 50;
            //        }
            //        else if (pvSurfaceArea > 2000)
            //        {
            //            ShippingCost = 60;
            //        }
            //    }
            //    else if (pvShippingType == 7)
            //    {
            //        if (pvSurfaceArea < 1000)
            //        {
            //            ShippingCost = 30;
            //        }
            //        else if (pvSurfaceArea > 1000 && pvSurfaceArea < 2000)
            //        {
            //            ShippingCost = 35;
            //        }
            //        else if (pvSurfaceArea > 2000)
            //        {
            //            ShippingCost = 40;
            //        }
            //    }
            //    else
            //    {
            //        ShippingCost = 0;
            //    }
            //    return ShippingCost;
            //}

            //decimal ShippingPrice = calculateShippingPrice(SurfaceArea, deliveryCost);

            //decimal calculateSurfaceAreaPrice(decimal pvSurfaceArea)
            //{
            //    decimal SurfaceAreaAddedCost = 0M;
            //    if (pvSurfaceArea > 1000)
            //    {
            //        SurfaceAreaAddedCost = pvSurfaceArea - 1000;
            //    }
            //    return SurfaceAreaAddedCost;
            //}

            //decimal SurfaceAreaPrice = calculateSurfaceAreaPrice(SurfaceArea);


            //decimal SurfaceMaterial = Desk.SurfaceMaterialId;
            //decimal SurfaceMaterialCost = 50;
            //switch (SurfaceMaterial)
            //{
            //    case 1:
            //        SurfaceMaterialCost = 200;
            //        break;
            //    case 2:
            //        SurfaceMaterialCost = 100;
            //        break;
            //    case 3:
            //        SurfaceMaterialCost = 50;
            //        break;
            //    case 4:
            //        SurfaceMaterialCost = 300;
            //        break;
            //    case 5:
            //        SurfaceMaterialCost = 125;
            //        break;
            //    default:
            //        break;
            //}

            //decimal calculatePrice(decimal pvShippingPrice, decimal pvSurfaceMaterialPrice, decimal pvSurfaceAreaPrice, int pvNumberOfDrawers)
            //{
            //    decimal finalPrice = 200M;

            //    finalPrice += pvShippingPrice + pvSurfaceMaterialPrice + pvSurfaceAreaPrice + (pvNumberOfDrawers * PRICE_PER_DRAWER);


            //    return finalPrice;
            //}

            DeskQuote.QuotePrice = DeskQuote.getQuotePrice(Desk, DeskQuote);

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}