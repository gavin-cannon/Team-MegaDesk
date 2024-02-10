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

        private void CustomerInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        /********************************************************************
         * NAME INPUT
         * If the input is valid change color to Green! Otherwise, Red
         *******************************************************************/
        private void customerInputBox_Validating(object sender, CancelEventArgs e) 
        {
            if (string.IsNullOrEmpty(CustomerInputBox.Text))
            {
                //CustomerInputBox.Focus();
                e.Cancel = true;
                CustomerInputBox.ForeColor = Color.Red;
            }
            else
            {
                CustomerInputBox.ForeColor = Color.Green;
            }
        }
        /**********************************************************************
         * WIDTH VALIDATING 
         * If the width is Valid change color to Green! Otherwise, Red
         *********************************************************************/
        private void deskWidthInputBox_Validating(Object sender, CancelEventArgs e) 
        {

            int value;
            if (Int32.TryParse(DeskWidthInputBox.Text, out value) && 24 <= value && value <= 96 )
            {
                //DeskWidthInputBox.Focus();
                DeskWidthInputBox.ForeColor = Color.Green;
            }
            else
            {
                DeskWidthInputBox.ForeColor= Color.Red;
            }
        }

        /**********************************************************************
         * DEPTH VALIDATING 
         * If the Depth is Valid change color to Green! Otherwise, Red
         *********************************************************************/
        private void deskDepthInputBox_Validating(Object sender, CancelEventArgs e)
        {

            int value;
            if (Int32.TryParse(DeskDepthInputBox.Text, out value) && 12 <= value && value <= 48 )
            {
                //DeskDepthInputBox.Focus();
                DeskDepthInputBox.ForeColor = Color.Green;
            }
            else
            {
                DeskDepthInputBox.ForeColor = Color.Red;
            }
        }

        /**********************************************************************
         * DRAWERS VALIDATING 
         * If the Drawer is Valid change color to Green! Otherwise, Red
         *********************************************************************/
        private void drawersInput_Validating(Object sender, CancelEventArgs e)
        {
            int value;
            if (Int32.TryParse(DrawersInput.Text, out value) && 0 <= value && value <= 7)
            {
                //DrawersInput.Focus();
                DrawersInput.ForeColor = Color.Green;
            }
            else
            {
                DrawersInput.ForeColor = Color.Red;
            }
        }

        /*************************************************************
         * MATERIAL VALIDATING
         * NOT COMPLETED
         ************************************************************/
        //private void material_Validating(Object sender, CancelEventArgs e)
        //{
        //    HashSet<string> materials = new HashSet<string>()
        //    {
        //        "Oak",
        //        "Laminate",
        //        "Pine",
        //        "Rosewood",
        //        "Venner"
        //    };
        //    string material = material.Text;
        //    if (string.IsNullOrEmpty(material.Text) || !materials.Contains(material) )
        //    {
        //        //CustomerInputBox.Focus();
        //        e.Cancel = true;
        //        CustomerInputBox.ForeColor = Color.Red;
        //    }
        //    else
        //    {
        //        CustomerInputBox.ForeColor = Color.Green;
        //    }
        //}
    }
}
