// Programmer: Nicholas Shortt
// Date:       February 25, 2021
// Description:
//  This application is design to record number of units shipped over 7 days
//  for 3 employees and display the average units shipped per day for each as well as
//  the total average.  The value entered will be whole numeric numebrs in range of 0 and 5000

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
        int currentDay = 1;
        int currentEmployee = 1;

        // Declare constants
        const int NumberOfEmployees = 3;
        const int NumberOfDays = 7;

        // Declare array to contain form controlls
        TextBox[] entryTextBoxArray;
        Label[] employeeLabelArray;
        Label[] employeeAverageLabelArray;

        // Declare 2D array to contain entry values
        int[,] entryValueArray = new int[NumberOfEmployees, NumberOfDays];
        

        #endregion

        #region "Event Handlers"

        /// <summary>
        /// Assigns the controls to the correct arrays on form load and makes sure it is in it's default state
        /// </summary>
        private void FormLoad(object sender, EventArgs e)
        { 
            entryTextBoxArray = new TextBox[] { textBoxEmployee1Entries, textBoxEmployee2Entries, textBoxEmployee3Entries };
            employeeLabelArray = new Label[] { labelEmployee1, labelEmployee2, labelEmployee3 };
            employeeAverageLabelArray = new Label[] { labelEmployee1AverageOutput, labelEmployee2AverageOutput, labelEmployee3AverageOutput };
            ResetForm();
        }


        /// <summary>
        /// For an entered unit, check if it is an interager, and whether it is in range of 0 to 5000.  
        /// If so a display it under the correct employee entry box.  Else dispaly message inform user 
        /// of the requred entry.  Then determine if the current day is seven or greater.  If so calculate 
        /// the average total value and display it to the form then reset day and increment current employee.  
        /// If not seven or greater then increment day and udpate current day on the form.  After all employees
        /// are handled stop user from entering more data and calculate and display overall average.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declare constants
            const int minUnitsShipped = 0;
            const int maxUnitsShipped = 5000;

            // Check if entered value is an interager
            if (int.TryParse(textBoxUnitsInput.Text, out entryValueArray[currentEmployee - 1, currentDay - 1]))
            {
                // Check if the value entered is within range of 0 to 5000
                if (minUnitsShipped <= entryValueArray[currentEmployee - 1, currentDay - 1] 
                    && entryValueArray[currentEmployee - 1, currentDay - 1] <= maxUnitsShipped)
                {
                    // Display value in the entry textbox
                    entryTextBoxArray[currentEmployee - 1].Text += entryValueArray[currentEmployee - 1, currentDay - 1] + "\r\n";
                    
                    // Clear the unit entry box
                    textBoxUnitsInput.Clear();

                    // Check if the value entered was for the seventh day
                    if (currentDay++ >= NumberOfDays)
                    {
                        int employeeTotal = 0;

                        // Get the total number of units shipped for the employee
                        for (int day = 0; day < NumberOfDays; day++)
                        {
                            employeeTotal += entryValueArray[currentEmployee - 1, day];
                        }

                        // Calculate and display the average units shipped
                        employeeAverageLabelArray[currentEmployee - 1].Text = "Average: " + Math.Round((double)employeeTotal / NumberOfDays, 2);

                        // Unbold current employee
                        employeeLabelArray[currentEmployee - 1].Font = new Font(this.Font, FontStyle.Regular);

                        // Reset days and increment employee
                        currentDay = 1;
                        currentEmployee++;
                    }

                    // Change label displaying the day
                    labelDay.Text = "Day " + currentDay;

                    // Check if we have entered all employees.
                    if (currentEmployee > NumberOfEmployees)
                    {
                        // Prevent user from entering more data by disabling enter button and changing entry box to read only
                        buttonEnter.Enabled = false;
                        textBoxUnitsInput.ReadOnly = true;

                        // Set focus to reset button
                        buttonReset.Focus();

                        int total = 0;
                        // Get the total number of units shipped overall
                        for (int employee = 0; employee < NumberOfEmployees; employee++)
                        {
                            for (int day = 0; day < NumberOfDays; day++)
                            {
                                total += entryValueArray[employee, day];
                            }
                        }

                        // Calculate and display the average units shipped overall
                        labelTotalAverageOutput.Text = "Average per day: " + Math.Round((double)total / entryValueArray.Length, 2);

                        // Change day label text to done
                        labelDay.Text = "Done";
                    }
                    else
                    {
                        // Bold current employee
                        employeeLabelArray[currentEmployee - 1].Font = new Font(this.Font, FontStyle.Bold);                    
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
        /// Call the function to reset the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterReset(object sender, EventArgs e)
        {
            ResetForm();

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

        #region "Functions"

        /// <summary>
        /// Rest the form to its default state by clearing inputs and outputs, and change focus back to first input
        /// </summary>
        private void ResetForm()
        {
            // Clear input and output fields
            textBoxUnitsInput.Clear();
            textBoxEmployee1Entries.Clear();
            textBoxEmployee2Entries.Clear();
            textBoxEmployee3Entries.Clear();
            labelEmployee1AverageOutput.Text = String.Empty;
            labelEmployee2AverageOutput.Text = String.Empty;
            labelEmployee3AverageOutput.Text = String.Empty;
            labelTotalAverageOutput.Text = String.Empty;

            // Set back to first day and employee
            currentDay = 1;
            currentEmployee = 1;
            labelDay.Text = "Day " + currentDay;

            // Return employee labels to initial fonts
            labelEmployee1.Font = new Font(this.Font, FontStyle.Bold);
            labelEmployee2.Font = new Font(this.Font, FontStyle.Regular);
            labelEmployee3.Font = new Font(this.Font, FontStyle.Regular);

            // Enable entry and set focus for units input field
            textBoxUnitsInput.ReadOnly = false;
            textBoxUnitsInput.Focus();

            // Enable the unit entry button
            buttonEnter.Enabled = true;
        }

        #endregion
    }
}

