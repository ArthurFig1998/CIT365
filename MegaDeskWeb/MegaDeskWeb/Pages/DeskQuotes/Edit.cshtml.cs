using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDesk;
using MegaDeskWeb.Models;

namespace MegaDeskWeb.Pages.DeskQuotes
{
    public class EditModel : PageModel
    {
        private readonly MegaDeskWeb.Models.MegaDeskWebContext _context;

        
        public SelectList SurfaceMaterialList { get; set; }
        public SelectList ShippingList { get; set; }

        [BindProperty]
        public Desk Desk { get; set; }
        public EditModel(MegaDeskWeb.Models.MegaDeskWebContext context)
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

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote
                .Include(d => d.Desk)
                .Include(d => d.Shipping).FirstOrDefaultAsync(m => m.DeskQuoteId == id);

            if (DeskQuote == null)
            {
                return NotFound();
            }
            ViewData["SurfaceMaterialId"] = new SelectList(_context.Set<SurfaceMaterial>(), "SurfaceMaterialId", "SurfaceMaterialName");
            ViewData["ShippingId"] = new SelectList(_context.Set<Shipping>(), "ShippingId", "ShippingType");
         
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Where(x => x.Value.Errors.Count > 0)
                    .Select(x => new { x.Key, x.Value.Errors })
                    .ToArray();
            }



            DeskQuote.Desk = Desk;
            DeskQuote.DeskId = Desk.DeskId;
            //DeskQuote.QuoteDate = DateTime.Now;



            DeskQuote.QuotePrice = DeskQuote.getQuotePrice(_context);
            _context.Attach(DeskQuote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeskQuoteExists(DeskQuote.DeskQuoteId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DeskQuoteExists(int id)
        {
            return _context.DeskQuote.Any(e => e.DeskQuoteId == id);
        }
    }
}
