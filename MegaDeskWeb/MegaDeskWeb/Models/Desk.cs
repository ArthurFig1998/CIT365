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
        [Range(24, 96)]
        [Required]
        public decimal Width { get; set; }

        [Required]
        [Range(12, 48)]
        public decimal Depth { get; set; }

        [Required]
        [Display(Name = "Material")]
        public int SurfaceMaterialId { get; set; }

        [Required]
        [Display(Name = "Number of Drawers")]
        [Range(0, 7)]
        public int NumberOfDrawers { get; set; }

        [Required]
        /*Navigation  property*/
        [Display(Name = "Material")]
        public SurfaceMaterial SurfaceMaterial { get; set; }

        public decimal surfaceArea()
        {
            return Width * Depth;
        }
    }
}
