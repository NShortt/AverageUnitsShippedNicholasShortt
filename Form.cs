// Programmer: Nicholas Shortt
// Date:       January 21, 2021
// Description:
//  This application is design to record number of units shipped over 7 days
//  and display the average units shipped per day.  The value entered will be 
//  whole numeric numebrs in range of 0 and 5000

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AverageUnitsShippedNicholasShortt
{
    public partial class formAverageUnitsShippedByEmployee : Form
    {
        public formAverageUnitsShippedByEmployee()
        {
            InitializeComponent();
        }

        #region "Variable Declaration"

        // Declare variables
        double totalUnitsShipped;
        int currentDay = 1;

        

        #endregion

        #region "Event Handlers"




        /// <summary>
        /// For an entered unit, check if it is an interager, and whether it is in range of 0 to 5000.  If so add it to the
        /// running total and display it on the form.  Else dispaly message inform user of the requred entry.  Then determine 
        /// if the current day is seven or greate.  If so calculate the average total value and display it to the form.  
        /// If not seven or greater then increment day and udpate current day on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declare variable
            int unitsShipped;
            double averageUnitsShipped;

            // Declare constants
            const int minUnitsShipped = 0;
            const int maxUnitsShipped = 5000;
            const int maxDaysRecorded = 7;

            // Check if entered value is an interager
            if (int.TryParse(textBoxUnitsInput.Text, out unitsShipped))
            {
                // Check if the value entered is within range of 0 to 5000
                if (minUnitsShipped <= unitsShipped && unitsShipped <= maxUnitsShipped)
                {
                    // Add enter value to current total
                    totalUnitsShipped += unitsShipped;

                    // Record and display units shipped to the form
                    textBoxEmployee1Entries.Text += textBoxUnitsInput.Text + "\r\n";

                    // Clear the unit entry box
                    textBoxUnitsInput.Clear();
                        
                    // Check if the value entered was for the seventh day
                    if (currentDay >= maxDaysRecorded)
                    {
                        // Prevent user from entering more data by disabling enter button and changing entry box to read only
                        buttonEnter.Enabled = false;
                        textBoxUnitsInput.ReadOnly = true;


                        // Calculate the average units shipped
                        averageUnitsShipped = totalUnitsShipped / currentDay;

                        // Display the average units shipped to the form rounded to two decimals
                        labelTotalAverageOutput.Text = "Average per day: " + Math.Round(averageUnitsShipped, 2);
                    }
                    else
                    {
                        // Increment the current day
                        currentDay++;

                        // Change label displaying the day
                        labelDay.Text = "Day " + currentDay;
                    }
                }
                else
                {
                    // Display error message explaining what was wrong
                    MessageBox.Show("Units shipped must be in range of " + minUnitsShipped + " to " + maxUnitsShipped + ".  Please enter a new value.");

                    // Set focus to unit entry text box
                    textBoxUnitsInput.Focus();
                }
            }
            else
            {
                // Display error message explaining what was wrong
                MessageBox.Show("Units shipped a whole number in numeric form.  Please enter a new value.");

                // Set focus to unit entry text box
                textBoxUnitsInput.Focus();
            }

        }

        /// <summary>
        /// Rest the form to its default state by clearing inputs and outputs, and change focus back to first input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterReset(object sender, EventArgs e)
        {
            // Clear input and output fields
            textBoxUnitsInput.Clear();
            textBoxEmployee1Entries.Clear();
            labelTotalAverageOutput.Text = String.Empty;

            // Set back to first day
            currentDay = 1;
            labelDay.Text = "Day " + currentDay;

            // Set the total units to 0
            totalUnitsShipped = 0;
            
            // Enable entry and set focus for units input field
            textBoxUnitsInput.ReadOnly = false;
            textBoxUnitsInput.Focus();

            // Enable the unit entry button
            buttonEnter.Enabled = true;


        }

        /// <summary>
        /// Close the program when exit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
