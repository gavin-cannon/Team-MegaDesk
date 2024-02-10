using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Belnap
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote dq;
        public DisplayQuote(DeskQuote d)
        {
            dq = d;
            InitializeComponent();

            date.Text = d.Date.ToString();
            customerName.Text = d.Customer;
            width.Text = $"{d.getWidth()} in.";
            depth.Text = $"{d.getDepth()} in.";

            surfaceArea.Text = $"{d.getDepth() * d.getWidth()} inches squared";
            numDrawers.Text = d.getDrawers().ToString();
            material.Text = d.getMaterial().ToString();
            rush.Text = $"{d.RushDays} days";

            d.calculateQuote();
            totalQuote.Text = $"${d.getQuotePrice()}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu(dq);
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }
    }
}
