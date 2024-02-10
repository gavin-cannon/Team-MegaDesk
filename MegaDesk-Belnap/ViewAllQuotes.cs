using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaDesk_Belnap.DeskQuote;

namespace MegaDesk_Belnap
{
    public partial class ViewAllQuotes : Form
    {
        public List<DeskQuote> deskQuotes = new List<DeskQuote>();
        public List<CombinedDeskQuote> combinedQuotes = new List<CombinedDeskQuote>();

        public ViewAllQuotes(List<DeskQuote> quotes)
        {
            deskQuotes = quotes;

            InitializeComponent();
            combinedQuotes = deskQuotes.Select(quote => quote.ToCombinedDeskQuote()).ToList();

            dataGridView1.DataSource = combinedQuotes;
            

            
        

    }


        private void button1_Click(object sender, EventArgs e)
        {
            
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
    }
}
