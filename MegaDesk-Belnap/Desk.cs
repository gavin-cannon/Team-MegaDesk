using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Belnap
{
    public class Desk
    {
        //get user input of Width for desk (min 24 in - max 96 in)
        public int Width { get; set; }
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;

        //get user input of Depth for desk (min 12 in - max 48 in)
        public int Height { get; set; }
        public const int MINHEIGHT = 12;
        public const int MAXHEIGHT = 48;

        //get user input of Number of Drawers for desk (min 0 - max 7)
        public int NumberDrawers { get; set; }
        public const int MINDRAWER = 0;
        public const int MAXDRAWER = 7;

        //get user input for DesktopMaterial (Oak, Laminate, Rosewood, Veneer, Pine)
        public string DesktopMaterial { get; set; }

        //validate Width using Validating event that checks for valid minimum and maximum values.
        //validate Depth using KeyPress event that checks for valid integer input using a compound statement and the char data type with IsControl and IsDigit methods
        //validate
    }
    enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
}
