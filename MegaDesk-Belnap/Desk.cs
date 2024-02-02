using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Belnap
{
    public class Desk
    {
        //get user input of Width for desk (min 24 in - max 96 in)
        public int Width { get; set; }
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;

        //get user input of Depth for desk (min 12 in - max 48 in)
        public int Depth { get; set; }
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        //get user input of Number of Drawers for desk (min 0 - max 7)
        public int NumberDrawers { get; set; }
        public const int MINDRAWER = 0;
        public const int MAXDRAWER = 7;

        // Changed the data type to the enum DektopMaterial - Emilio
        public DesktopMaterial Material { get; set; }

        // added a custom and default constructor for the class - Emilio
        public Desk()
        {
            Width = 0;
            Depth = 0;
            NumberDrawers = 0;
            Material = new DesktopMaterial();
        }

        public Desk(int width, int depth, int numberDrawers, DesktopMaterial material)
        {
            Width = width;
            Depth = depth;
            NumberDrawers = numberDrawers;
            Material = material;
        }

    }
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
