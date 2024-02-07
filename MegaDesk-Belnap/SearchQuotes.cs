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
    public partial class SearchQuotes : Form
    {
        private List<DeskQuote> deskQuotes = new List<DeskQuote>();
        public SearchQuotes(List<DeskQuote> deskQuote, List<DeskQuote> deskQuotes)
        {
            InitializeComponent();
            this.deskQuotes = deskQuotes;
        }


        private void searchQuoteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchQuoteComboBox.SelectedItem = searchQuoteComboBox.SelectedItem.ToString();
            string material = searchQuoteComboBox.Text;
            List<DeskQuote> quoresThatMatch =new List<DeskQuote>();

            foreach

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //List<Desk> list = new List<Desk>();
           
          // List<DeskQuote> deskQuoteList = maple_list.FindAll(o=>o.desk.material == deskQuote.DestopMaterial.maple);
        }

        private void SearchQuotesCloseButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

    }
}
