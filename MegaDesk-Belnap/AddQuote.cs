using MegaDesk_Belnap;
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
    public partial class AddQuotes : Form
    {
        public AddQuotes()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DesktopMaterial deskMaterial = new DesktopMaterial();

            switch (material.Text)
            {
                case "Oak":
                    deskMaterial = DesktopMaterial.Oak;
                    break;
                case "Laminate":
                    deskMaterial = DesktopMaterial.Laminate;
                    break;
                case "Pine":
                    deskMaterial = DesktopMaterial.Pine;
                    break;
                case "RoseWood":
                    deskMaterial = DesktopMaterial.Rosewood;
                    break;
                case "Veneer":
                    deskMaterial = DesktopMaterial.Veneer;
                    break;
            }

            Desk d = new Desk(int.Parse(DeskWidthInputBox.Text), int.Parse(DeskDepthInputBox.Text), int.Parse(DrawersInput.Text), deskMaterial);
            DateTime date = DateTime.Now;
            DeskQuote quote = new DeskQuote(d, int.Parse(rushDays.Text), CustomerInputBox.Text, date);

            DisplayQuote viewDisplayQuote = new DisplayQuote(quote);
            viewDisplayQuote.Tag = this;
            viewDisplayQuote.Show(this);
            Hide();
        }
    }
}
