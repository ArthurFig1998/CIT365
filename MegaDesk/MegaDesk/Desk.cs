using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
    public class Desk
    {
        
        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public DesktopMaterial SurfaceMaterial { get; set; }

        public int NumberOfDrawers { get; set; }
    }
}
