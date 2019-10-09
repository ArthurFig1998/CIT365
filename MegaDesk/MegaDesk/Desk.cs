using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{

    public class Desk
    {
        public enum DesktopMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }
        public int Width { get; set; }

        public int Depth { get; set; }

        public DesktopMaterial SurfaceMaterial { get; set; }

        public int NumberOfDrawers { get; set; }
    }
}
