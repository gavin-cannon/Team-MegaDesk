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

        private void CustomerInputBox_TextChanged(object sender, EventArgs e)
        {
            string userInput = (string)CustomerInputBox.Text;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
               
        }

        //private void DeskWidthInputBox_TextChanged(object sender, EventArgs e)
        //{
        //    int widthInput = (int)DeskWidthInputBox.;

        //}



    }
}
