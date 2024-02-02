﻿using System;
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
    public partial class MainMenu : Form
    {
        private List<DeskQuote> deskQuoteList = new List<DeskQuote>();
        public MainMenu(DeskQuote deskQuote)
        {
            deskQuoteList.Add(deskQuote);
            InitializeComponent();
        }

        public MainMenu()
        {

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
            ViewAllQuotes viewViewQuotes = new ViewAllQuotes();
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
