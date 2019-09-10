using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Information_Center
{
    public partial class TestForm : Form
    {
        //variables for date shifting.
        int fourtyFive = 45;
        int fourtySeven = 47;

        //date time variable for comparisons
        DateTime dateValue;
        string day;


        public TestForm()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //sets the selected date from dateTimePicker1 value (application 1) to a variable. 
            dateValue = dateTimePicker1.Value.AddDays(fourtyFive);

            //turns the dateValue into a string composed of a 3 letter format signifying what day of the
            //week the adjusted date is.
            day = dateValue.ToString("ddd");

            dateLabel.Text = dateValue.ToString("ddd");

            //if statement to check to see if the adjusted day will fall on a weekend.  If it does,
            //the new date for "application 2" will be shifted 2 more days forward to make sure that 
            //the date falls within the work week.
            if (day == "Sat" || day == "Sun") 
            {
                dateTimePicker2.Value = dateTimePicker1.Value.AddDays(fourtySeven);
            }
            else
            {
                dateTimePicker2.Value = dateTimePicker1.Value.AddDays(fourtyFive);
            }
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //sets the selected date from dateTimePicker2 value (application 2) to a variable. 
            dateValue = dateTimePicker2.Value.AddDays(fourtyFive);

            //turns the dateValue into a string composed of a 3 letter format signifying what day of the
            //week the adjusted date is.
            day = dateValue.ToString("ddd");

            //if statement to check to see if the adjusted day will fall on a weekend.  If it does,
            //the new date for "application 3" will be shifted 2 more days forward to make sure that 
            //the date falls within the work week.
            if (day == "Sat" || day == "Sun")
            {
                dateTimePicker3.Value = dateTimePicker2.Value.AddDays(fourtySeven);
            }
            else
            {
                dateTimePicker3.Value = dateTimePicker2.Value.AddDays(fourtyFive);
            }
        }

        private void DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            //sets the selected date from dateTimePicker3 value (application 3) to a variable. 
            dateValue = dateTimePicker3.Value.AddDays(fourtyFive);

            //turns the dateValue into a string composed of a 3 letter format signifying what day of the
            //week the adjusted date is.
            day = dateValue.ToString("ddd");

             //if statement to check to see if the adjusted day will fall on a weekend.  If it does,
            //the new date for "application 4" will be shifted 2 more days forward to make sure that 
            //the date falls within the work week.
            if (day == "Sat" || day == "Sun")
            {
                dateTimePicker4.Value = dateTimePicker3.Value.AddDays(fourtySeven);
            }
            else
            {
                dateTimePicker4.Value = dateTimePicker3.Value.AddDays(fourtyFive);
            }
        }

        private void DateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            
        }

    }
}
