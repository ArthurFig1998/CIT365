using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk;
using MegaDeskWeb.Models;

namespace MegaDeskWeb.Models
{
    public class MegaDeskWebContext : DbContext
    {
        public MegaDeskWebContext (DbContextOptions<MegaDeskWebContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk.DeskQuote> DeskQuote { get; set; }

        public DbSet<MegaDesk.Desk> Desk { get; set; }

        public DbSet<MegaDeskWeb.Models.SurfaceMaterial> SurfaceMaterial { get; set; }

        public DbSet<MegaDeskWeb.Models.Shipping> Shipping { get; set; }
    }
}
