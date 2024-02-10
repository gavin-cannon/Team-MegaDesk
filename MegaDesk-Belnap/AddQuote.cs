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
                CustomerInputBox.Focus();
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
                
                DeskWidthInputBox.ForeColor = Color.Green;
            }
            else
            {
                DeskWidthInputBox.Focus();
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
                DeskDepthInputBox.ForeColor = Color.Green;
            }
            else
            {
                DeskDepthInputBox.Focus();
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
                DrawersInput.ForeColor = Color.Green;
            }
            else
            {
                DrawersInput.Focus();
                DrawersInput.ForeColor = Color.Red;
            }
        }

        /*************************************************************
         * MATERIAL VALIDATING
         * If the material is not selected, change color to red
         ************************************************************/
        private void material_Validating(Object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(material.Text))
            {
                material.Focus();
                e.Cancel = true;
                material.BackColor = Color.Red;
            }
            else
            {
                material.BackColor = Color.White;
                material.ForeColor = Color.Green;
            }
        }


        /*************************************************************
         * RUSH VALIDATING
         * if rush days is not selected, change color to red
        ************************************************************/
        private void rushDays_Validating(Object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rushDays.Text))
            {
                rushDays.Focus();
                e.Cancel = true;
                rushDays.BackColor = Color.Red;
            }
            else
            {
                rushDays.BackColor = Color.White;
                rushDays.ForeColor = Color.Green;
            }
        }




    }
}
