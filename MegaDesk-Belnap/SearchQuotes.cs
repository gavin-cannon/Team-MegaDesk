using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Belnap
{
    public partial class SearchQuotes : Form
    {
        private List<DeskQuote> deskQuotes = new List<DeskQuote>();
        public SearchQuotes(List<DeskQuote> deskQuotes)
        {
            InitializeComponent();
            this.deskQuotes = deskQuotes;
        }


        public void searchQuoteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {          
            listBox1.Items.Clear();
            List<DeskQuote> quotesThatMatch =new List<DeskQuote>();
            string material = searchQuoteComboBox.Text;      
            foreach (DeskQuote quote in deskQuotes)
            {
                if (quote.getMaterial() == material)
                {
                    listBox1.Items.Add(quote.Display());
                }
            }   
        }

        private void SearchQuotesCloseButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

    }
}
