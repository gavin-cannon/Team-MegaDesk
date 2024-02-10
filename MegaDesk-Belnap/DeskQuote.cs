using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace MegaDesk_Belnap
{
    public class DeskQuote
    {
        private Desk desk;
        private int rushDays;
        private string customer;
        private DateTime date;
        private int quotePrice;
<<<<<<< HEAD
        private int[,] rushOrderPrices = new int[3,3];
=======
        public string display;
>>>>>>> marilee

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

        public string Display()
        {
            return $"{customer} {date.ToString("yyyy-MM-dd")}  Width:{ getWidth()}  Depth:{getDepth()}  Number of Drawers: {getDrawers()}  Desktop Material: {getMaterial()} Quote Price: {getQuotePrice()} ";
        }

        public DeskQuote()
        {
            rushDays = 0;
            customer = null;
            desk = null;
            date = new DateTime();
            quotePrice = 200;
            GetRushOrder();
        }

        public DeskQuote(Desk desk, int rushDays, string customer, DateTime date)
        {
            this.desk = desk;
            this.rushDays = rushDays;
            this.customer = customer;
            this.date = date;
            quotePrice = 200;
            GetRushOrder();
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

        private void GetRushOrder()
        {
            try
            {
                string[] pricesFromFile = File.ReadAllLines("C:\\Users\\kingl\\OneDrive\\Documents\\Team-MegaDesk\\MegaDesk-Belnap\\rushOrderPrices.txt");
                int pricesFromFileIndex = 0;

                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        rushOrderPrices[r, c] = int.Parse(pricesFromFile[pricesFromFileIndex]); 
                        pricesFromFileIndex++;
                    }
                }

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Rush Order file not found.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private int getRushCost(int a)
        {
            switch (rushDays)
            {
                case 3:
                    if (a > 2000)
                    {
                        return rushOrderPrices[0,2];
                    }
                    else if (a > 1000)
                    {
                        return rushOrderPrices[0,1];
                    }
                    else
                    {
                        return rushOrderPrices[0,0];
                    }
                case 5:
                    if (a > 2000)
                    {
                        return rushOrderPrices[1,2];
                    }
                    else if (a > 1000)
                    {
                        return rushOrderPrices[1,1];
                    }
                    else
                    {
                        return rushOrderPrices[1,0];
                    }
                case 7:
                    if (a > 2000)
                    {
                        return rushOrderPrices[2,2];
                    }
                    else if (a > 1000)
                    {
                        return rushOrderPrices[2,1];
                    }
                    else
                    {
                        return rushOrderPrices[2,0];
                    }
                default:
                    return 0;
            }
        }
    }
}
