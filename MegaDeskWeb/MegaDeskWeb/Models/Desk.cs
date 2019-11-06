using MegaDeskWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    {
        public int DeskId { get; set; }
        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public int SurfaceMaterialId { get; set; }

        [Display(Name = "Number of Drawers")]
        public int NumberOfDrawers { get; set; }

        public SurfaceMaterial SurfaceMaterial { get; set; }
    }
}
