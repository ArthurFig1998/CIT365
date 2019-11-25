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

        //[BindProperty]
        //public Desk Desk { get; set; }
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

        //[BindProperty]
        //public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var DeskQuote = await _context.DeskQuote
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
        //[Bind("CustomerName, Desk, QuotePrice, Shipping")] DeskQuote deskQuote
        //
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Where(x => x.Value.Errors.Count > 0)
                    .Select(x => new { x.Key, x.Value.Errors })
                    .ToArray();
                //return Page();
            }



            //DeskQuote.Desk = Desk;
            //DeskQuote.DeskId = Desk.DeskId;

            //var deskQuoteQuery = _context.DeskQuote
            //    .SelectMany(dq => dq.CustomerName, dq => dq.Desk, dq => dq.Shipping, dq => dq.QuotePrice)
            //    .Where(dq => dq.DeskQuoteId == this.DeskQuote.DeskQuoteId);

            //IQueryable<string> deskQuoteEditQuery = from dq in _context.DeskQuote
            //                                        select dq.CustomerName;



            //DeskQuote.QuotePrice = DeskQuote.getQuotePrice(_context);
            //_context.Attach(DeskQuote).State = EntityState.Modified;


            var quoteToUpdate = await _context.DeskQuote.FirstOrDefaultAsync(dq => dq.DeskQuoteId == id);
            var deskToUpdate = await _context.Desk.FirstOrDefaultAsync(d => d.DeskId == quoteToUpdate.DeskId);

            if (await TryUpdateModelAsync<DeskQuote>(
                quoteToUpdate,
                "",
                dq => dq.CustomerName, dq => dq.QuotePrice, dq => dq.ShippingId))
            {

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeskQuoteExists(quoteToUpdate.DeskQuoteId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            if (await TryUpdateModelAsync<Desk>(
                deskToUpdate,
                "",
                d => d.Width, d => d.Depth, d => d.SurfaceMaterialId, d => d.NumberOfDrawers))
            {

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeskQuoteExists(quoteToUpdate.DeskQuoteId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            quoteToUpdate.Desk = deskToUpdate;

            quoteToUpdate.QuotePrice = quoteToUpdate.getQuotePrice(_context);
            

            return RedirectToPage("./Index");
        }

        private bool DeskQuoteExists(int id)
        {
            return _context.DeskQuote.Any(e => e.DeskQuoteId == id);
        }
    }
}
