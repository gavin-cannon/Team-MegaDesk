using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Belnap
{
    public partial class MainMenu : Form
    {
        private static List<DeskQuote> deskQuoteList;
        public MainMenu(DeskQuote deskQuote)
        {
            deskQuoteList.Add(deskQuote);
            string filePath = "../../quotes.json";
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
            };
            string json = JsonConvert.SerializeObject(deskQuoteList, settings);
            File.WriteAllText(filePath, json );
            InitializeComponent();
        }
      
        public MainMenu()
        {
            if (deskQuoteList == null)
            {
                string filePath = "../../quotes.json";
                try
                {
                    string json = File.ReadAllText(filePath);
                    if (json.Length > 10)
                    {
                        deskQuoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                    }
                    else
                    {
                        deskQuoteList = new List<DeskQuote>();
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File Not Found");
                }
                }
            Console.WriteLine(deskQuoteList);
            InitializeComponent();
        }

        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            AddQuotes viewAddQuote = new AddQuotes();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            this.Hide();
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewViewQuotes = new ViewAllQuotes(deskQuoteList);
            viewViewQuotes.Tag = this;
            viewViewQuotes.Show(this);
            this.Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
