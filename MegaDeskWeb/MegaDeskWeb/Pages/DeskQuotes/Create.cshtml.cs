﻿using System;
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
        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }
        [BindProperty]
        public SelectList SurfaceMaterialList { get; set; }
        public SelectList ShippingList { get; set; }
        public SurfaceMaterial SurfaceMaterial { get; set; }
        public Shipping Shipping { get; set; }
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
        ViewData["DeskId"] = new SelectList(_context.Set<Desk>(), "DeskId", "DeskId");
        ViewData["ShippingId"] = new SelectList(_context.Set<Shipping>(), "ShippingId", "ShippingId");
            return Page();
        }

        
    public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DeskQuote.QuoteDate = DateTime.Now;
            decimal SurfaceArea = DeskQuote.Desk.surfaceArea();
            //decimal ShippingType = DeskQuote.Shipping.shippingPrice();

            string ShippingType = DeskQuote.Shipping.ShippingType;
            switch (ShippingType)
            {
                case "3Day":
                    deliveryCost = 3;
                    break;
                case "5Day":
                    deliveryCost = 5;
                    break;
                case "7Day":
                    deliveryCost = 7;
                    break;
                default:
                    deliveryCost = 14;
                    break;
            }

            decimal calculateShippingPrice(decimal pvSurfaceArea, decimal pvShippingType) {

                decimal ShippingCost = 0M;

                if(pvShippingType == 3)
                {
                    if(pvSurfaceArea < 1000)
                    {
                        ShippingCost = 60;
                    }
                    else if(pvSurfaceArea > 1000 && pvSurfaceArea < 2000)
                    {
                        ShippingCost = 70;
                    }
                    else if(pvSurfaceArea > 2000)
                    {
                        ShippingCost = 80;
                    }
                }
                else if(pvShippingType == 5)
                {
                    if (pvSurfaceArea < 1000)
                    {
                        ShippingCost = 40;
                    }
                    else if (pvSurfaceArea > 1000 && pvSurfaceArea < 2000)
                    {
                        ShippingCost = 50;
                    }
                    else if (pvSurfaceArea > 2000)
                    {
                        ShippingCost = 60;
                    }
                }
                else if(pvShippingType == 7)
                {
                    if (pvSurfaceArea < 1000)
                    {
                        ShippingCost = 30;
                    }
                    else if (pvSurfaceArea > 1000 && pvSurfaceArea < 2000)
                    {
                        ShippingCost = 35;
                    }
                    else if (pvSurfaceArea > 2000)
                    {
                        ShippingCost = 40;
                    }
                }
                else
                {
                    ShippingCost = 0;
                }
                return ShippingCost;
            }

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}