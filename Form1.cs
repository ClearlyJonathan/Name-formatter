using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_formatter
{
    public partial class Form1 : Form
    {
        private String name = "";
        private String first, last, middle, title;
        private int format;
        
        private bool hasChosenTitle = false;
        private bool hasSelectedFormat = false;
        public Form1()
        {
            InitializeComponent();
            listBox1.SetSelected(6, true);
            hasSelectedFormat = false;
        }

        private void firstNameLabelPrompt_Click(object sender, EventArgs e)
        {

        }

        

        private void firstNameTextControl_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void middleNameTextControl_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextControl_TextChanged(object sender, EventArgs e)
        {

        }


        private void mrCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasChosenTitle == false )
            {
                hasChosenTitle = true;
                title = "Mr.";
            }
            
        }

        private void mrsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasChosenTitle == false)
            {
                hasChosenTitle = true;
                title = "Mrs.";
            } 
            
        }

        private void msCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hasChosenTitle == false)
            {
                hasChosenTitle = true;
                title = "Ms.";
            } 
            
        }

        private void displayButtonControl_Click(object sender, EventArgs e)
        {

            fetchNames();
            if (first.Length == 0 || last.Length == 0)
            {
                MessageBox.Show("Missing first or last name.");
                return;
            }
            if (!hasSelectedFormat)
            {
                MessageBox.Show("You must select a format");
                return;
            }
            formatName(format);
            MessageBox.Show($"Your formatted name is {name}");
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hasChosenTitle = false;
            firstNameTextControl.Text = "";
            middleNameTextControl.Text = "";
            lastNameTextControl.Text = "";
            first = "";
            middle = "";
            last = "";
            msCheckBox.Checked = false;
            mrsCheckBox.Checked = false;
            mrCheckBox.Checked = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fetchNames()
        {
            try
            {
                
                first = firstNameTextControl.Text;
                last = lastNameTextControl.Text;
                middle = middleNameTextControl.Text;
                
            }
            catch
            {
                MessageBox.Show("There was an error fetching the names");
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasSelectedFormat = true;
            format = listBox1.SelectedIndex;
            formatName(format);
           
            
        }
        private void formatName(int format)
        {
            switch (format)
            {
                case 0:
                    name = $"{title} {first} {middle} {last}";
                    break;
                case 1:
                    name = $"{first} {middle} {last} ";
                    break;
                case 2:
                    name = $"{first} {last}";
                    break;
                case 3:
                    name = $"{last}, {first} {middle}, {title}";
                    break;
                case 4:
                    name = $"{last}, {first} {middle}";
                    break;
                case 5:
                    name = $"{last}, {first}";
                    break;
                default:
                    hasSelectedFormat = false;
                    break;
            }
        }
    }
}
