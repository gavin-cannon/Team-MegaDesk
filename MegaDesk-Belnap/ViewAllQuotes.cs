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
    public partial class ViewAllQuotes : Form
    {
        public List<DeskQuote> deskQuotes = new List<DeskQuote>();
        public ViewAllQuotes(List<DeskQuote> quotes)
        {
            deskQuotes = quotes;
            InitializeComponent();
            
            dataGridView1.DataSource = deskQuotes;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
    }
}
