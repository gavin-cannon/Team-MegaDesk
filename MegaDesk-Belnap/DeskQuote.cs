using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Belnap
{
    public class DeskQuote
    {
        private Desk desk;
        private int rushDays;
        private string customer;
        private DateTime date;
        private int quotePrice;

        public Desk Desk
        {
            get { return desk; }
            set { desk = value; }
        }

        public int RushDays
        {
            get { return rushDays; }
            set { rushDays = value; }
        }

        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int QuotePrice
        {
            get { return quotePrice; }
            set { quotePrice = value; }
        }

        public int getWidth()
        {
            return desk.Width;
        }

        public int getDepth()
        {
            return desk.Depth;
        }

        public int getDrawers()
        {
            return desk.NumberDrawers;
        }

        public string getMaterial()
        {
            return desk.Material.ToString();
        }

        public DeskQuote()
        {
            rushDays = 0;
            customer = null;
            desk = null;
            date = new DateTime();
            quotePrice = 200;
        }

        public DeskQuote(Desk desk, int rushDays, string customer, DateTime date)
        {
            this.desk = desk;
            this.rushDays = rushDays;
            this.customer = customer;
            this.date = date;
            quotePrice = 200;
        }

        public struct CombinedDeskQuote
        {
            public int DeskWidth { get; set; }
            public int DeskDepth { get; set; }
            public int DeskNumberDrawers { get; set; }
            public DesktopMaterial DeskMaterial { get; set; }

            public int QuoteRushDays { get; set; }
            public string QuoteCustomer { get; set; }
            public DateTime QuoteDate { get; set; }
            public int QuotePrice { get; set; }
        }

        public CombinedDeskQuote ToCombinedDeskQuote()
        {
            return new CombinedDeskQuote
            {
                DeskWidth = desk.Width,
                DeskDepth = desk.Depth,
                DeskNumberDrawers = desk.NumberDrawers,
                DeskMaterial = desk.Material,
                QuoteRushDays = rushDays,
                QuoteCustomer = customer,
                QuoteDate = date,
                QuotePrice = quotePrice
            };
        }
    

    public void calculateQuote()
        {
            int surfaceArea = desk.Width * desk.Depth;

            if (surfaceArea > 1000)
            {
                quotePrice += surfaceArea;
            }

            quotePrice += desk.NumberDrawers * 50;
            quotePrice += getSurfaceMaterialPrice();
            quotePrice += getRushCost(surfaceArea);
        }

        public int getQuotePrice() { return quotePrice; }

        private int getSurfaceMaterialPrice()
        {
            switch (desk.Material)
            {
                case DesktopMaterial.Oak:
                    return 200;
                case DesktopMaterial.Laminate:
                    return 100;
                case DesktopMaterial.Pine:
                    return 50;
                case DesktopMaterial.Rosewood:
                    return 300;
                case DesktopMaterial.Veneer:
                    return 125;
                default:
                    return 0;
            }
        }

        public string FormattedDate
        {
            get { return date.ToString("MM/dd/yyyy"); }
        }


        public string FormattedQuotePrice
        {
            get { return quotePrice.ToString("C"); }
        }

        private int getRushCost(int a)
        {
            switch (rushDays)
            {
                case 3:
                    if (a > 2000)
                    {
                        return 80;
                    }
                    else if (a > 1000)
                    {
                        return 70;
                    }
                    else
                    {
                        return 60;
                    }
                case 5:
                    if (a > 2000)
                    {
                        return 60;
                    }
                    else if (a > 1000)
                    {
                        return 50;
                    }
                    else
                    {
                        return 40;
                    }
                case 7:
                    if (a > 2000)
                    {
                        return 40;
                    }
                    else if (a > 1000)
                    {
                        return 35;
                    }
                    else
                    {
                        return 30;
                    }
                default:
                    return 0;
            }
        }
    }

}
