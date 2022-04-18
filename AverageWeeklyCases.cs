/* 
 
 Author: Angelica Kuik #100849912
 Date: February 22, 2022
 Last Modified: April 18, 2022
 Course: .NET
 Application: AverageWeeklyCases (prior UnitsShippedCalculator) - VERSION 3
 Description: AverageWeeklyCases VERSION 3 is a Windows Forms application that enables the user to
              enter the number of cases each day of the week for 3 different regions, validates the user input, 
              calculates the average cases per region and the overall average cases for all three regions.

              AverageWeeklyCases VERSION 3 is an updated version of the UnitsShippedCalculator - VERSION 2 application created for Lab 1 that has gained
              two more regions and incorporated the use of 2 dimensional arrays following the requirements of Lab 3. Later this application was adjusted 
              to be used on the final project Clinic Assistant. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClinicAssistant
{
    public partial class formAverageWeeklyCases : Form
    {
        //Variable Declarations:
        int rowIndexArray = 0;
        int columnIndexArray = 0;


        const int maxWeeklyCases = 5000;
        const int minWeeklyCases = 0;
        const int numberRows = 3;
        const int numberDays = 7;
        double averageWeeklyCases = 0.0;
        int sum = 0;

        //declare a global variable to hold the file path when its saved
        string openFile = "";

        //Create a two dimensional array to hold the units shipped from each region.
        int[,] averageWeeklyCasesArray = new int[numberRows, numberDays];

        //Create an array of controls for the regions and for the average labels
        TextBox[] outputTextboxesArray;
        Label[] outputRegionAverageArray;

        //Create an array to hold the average from each region
        double[] averageRegionArray = new double[numberRows];

        //Declare an instance of averageWeeklyCases form to be able to use Singleton Design (mening only one 
        //instance of this form can be open at time).
        private static formAverageWeeklyCases averageWeeklyCasesInstance;

        public formAverageWeeklyCases()
        {
            InitializeComponent();

            outputTextboxesArray = new TextBox[] { textBoxPastEntriesRegion1, textBoxPastEntriesRegion2, textBoxPastEntriesRegion3 };

            outputRegionAverageArray = new Label[] { labelRegion1Output, labelRegion2Output, labelRegion3Output };

        }
        #region Functions
        //Checks if there is an open instance of averageWeeklyCases form open and returns it or creates a new one.
        public static formAverageWeeklyCases Instance
        {
            get
            {
                //is there a contact tracer form instance open?
                if (averageWeeklyCasesInstance == null)
                {
                    //if no, create one
                    averageWeeklyCasesInstance = new formAverageWeeklyCases();
                }
                return averageWeeklyCasesInstance;
            }
        }
        /// <summary>
        /// Given an array of controls, this function clears their text.
        /// </summary>
        /// <param name="controlArray">An array of controls with a text property to clear</param>
        private void ClearControls(Control[] controlArray)
        {
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Text = String.Empty;
            }
        }

        /// <summary>
        /// Clears all controls and sets form to its default state.
        /// </summary>
        public void SetDefaults()
        {
            // Clear all input & output fields:
            ClearControls(outputRegionAverageArray);
            ClearControls(outputTextboxesArray);
            labelGeneralAverageOutput.Text = String.Empty;

            // Reset focus to the input textbox:
            textBoxCasesInput.Focus();

            // Reset the variable that holds the average of shipped units:
            averageWeeklyCases = 0.0;

            // Reset the variable that holds the count of each input entered by the user:
            rowIndexArray = 0;
            columnIndexArray = 0;

            // Reset the variable that holds the sum of inputs:
            sum = 0;

            // Reset buttonEnter to enable user to enter new set of inputs:
            buttonEnter.Enabled = true;

            // Disable textBoxUnitsInput from ReadOnly mode:
            textBoxCasesInput.ReadOnly = false;

            //Set labels background color to default
            foreach (Label label in outputRegionAverageArray)
            {
                label.BackColor = Color.LightGray;
            }
        }
        /// <summary>
        /// Saves the contents of the form to the current file path.
        /// </summary>
        public void SaveArray()
        {
            //if the variable openFile was set is an empty string, meaning it hasn't been saved yet
            //call "SaveListAs" instead!
            if (openFile == String.Empty)
            {
                SaveArrayAs();

                //Display a message informing the user that file was successfully saved.
                MessageBox.Show("Your work is saved to " + openFile, "Save Successful");
            }
            //If openFile has a value, just call the Save() function!
            else if (openFile != String.Empty)
            {
                Save();

                //Display a message informing the user that file was successfully saved.
                MessageBox.Show("Your work is saved to " + openFile, "Save Successful");
            }
        }

            /// <summary>
            /// Saves the contents of customerList to the selected file.
            /// </summary>
            public void SaveArrayAs()
        {
            //Declare, instantiate and configure a new SaveFileDialog
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt";

            //If the person picks a file and clicks "OK"
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                openFile = "List" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                //Set openFile equal to the File path 
                openFile = saveDialog.FileName;
                //Call the SaveFile function to write the contents of the textbox into the file.
                Save();

                //Display a message informing the user that file was successfully saved.
                MessageBox.Show("Your work is saved to " + openFile, "Save Successful");
            }
            else
            {
                //If user clicks cancel instead of ok on the dialog, display a warning informaming file was not saved.
                MessageBox.Show("Your work was not saved", "Warning");
            }

        }
        /// <summary>
        /// Saves the contents of customerList to current file location.
        /// </summary>
        private void Save()
        {
            //Create a System.IO object to make file access easier
            FileStream fileToAcess = new FileStream(openFile, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new
            StreamWriter(fileToAcess);

            //Write the contents of the array 
            for (int row = 0; row < numberRows; row++)
            {
                for (int column = 0; column < numberDays; column++)
                {
                    //Write the contents of the array on the file selected by the user.
                    writer.Write(averageWeeklyCasesArray[row, column].ToString() + " - ");
                }
            }
            //Close the write 
            writer.Close();
        }
        #endregion
        #region "Event Handlers"

        /// <summary>
        /// Clears the input and output fields and resets form to its default state.
        /// </summary>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
        /// <summary>
        /// Accepts inputs, calculate average and display output to the user.
        /// </summary>
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //Local Variable Declarations
            int weeklyCasesInput;


            //Validate user input:
            if (int.TryParse(textBoxCasesInput.Text, out weeklyCasesInput))
            {
                // Validate if user input is within range:
                if (weeklyCasesInput >= minWeeklyCases && weeklyCasesInput <= maxWeeklyCases)
                {
                    averageWeeklyCasesArray[rowIndexArray, columnIndexArray] = weeklyCasesInput;
                    outputTextboxesArray[rowIndexArray].Text += weeklyCasesInput + Environment.NewLine;


                    sum += averageWeeklyCasesArray[rowIndexArray, columnIndexArray];

                    columnIndexArray++;


                    // Clear textBoxUnitInput after each entry:
                    textBoxCasesInput.Clear();

                    labelGeneralAverageOutput.Text = String.Empty;


                    // Enables user to enter inputs for all 7 days of the week:
                    if (columnIndexArray == averageWeeklyCasesArray.GetLength(1))
                    {
                        // Calculate and display region average 
                        averageWeeklyCases = (double)sum / averageWeeklyCasesArray.GetLength(1);

                        // Display average shipped units for region the region.
                        outputRegionAverageArray[rowIndexArray].Text = string.Format("Average: {0}", Math.Round(averageWeeklyCases, 2, MidpointRounding.ToEven));

                        //Add value to the array with all region averages
                        averageRegionArray[rowIndexArray] = averageWeeklyCases;

                        //Increment row index
                        rowIndexArray++;

                        //Reset column index 
                        columnIndexArray = 0;

                        //Reset sum
                        sum = 0;

                        if (rowIndexArray == averageWeeklyCasesArray.GetLength(0))
                        {
                            //Calculate overall average
                            for (int row = 0; row < numberRows; row++)
                            {
                                for (int column = 0; column < numberDays; column++)
                                {
                                    sum += averageWeeklyCasesArray[row, column];
                                }
                            }

                            averageWeeklyCases = sum / averageWeeklyCasesArray.Length;

                            // Display overall average shipped units for all 3 regions.
                            labelGeneralAverageOutput.Text = string.Format("Average: {0}", Math.Round(averageWeeklyCases, 2, MidpointRounding.ToEven));


                            // Disable buttonEnter after inputs for all 7 days were entered.
                            buttonEnter.Enabled = false;

                            // Set input textbox to read only so the user can't enter new inputs:
                            textBoxCasesInput.ReadOnly = true;

                            //Set backgroung color of region average output to red if < than overall average.
                            for (int i = 0; i < numberRows; i++)
                            {
                                if (averageRegionArray[i] < averageWeeklyCases)
                                {
                                    outputRegionAverageArray[i].BackColor = Color.Red;
                                }

                                if (averageRegionArray[i] > averageWeeklyCases)
                                {
                                    outputRegionAverageArray[i].BackColor = Color.LightGreen;
                                }
                            }
                         
                        }

                    }
                }
                else
                {
                    // If range validation fails display the error message below:
                    labelGeneralAverageOutput.Text = "Please enter a number between " + minWeeklyCases + " and " + maxWeeklyCases;

                    // If validation fails reset focus on the input textbox so user can enter new input. 
                    textBoxCasesInput.SelectAll();
                    textBoxCasesInput.Focus();
                }
            }
            else
            {
                // If range validation fails display the error message below:
                labelGeneralAverageOutput.Text = "Please enter a whole number.";

                // If validation fails reset focus on the input textbox so user can enter new input.
                textBoxCasesInput.SelectAll();
                textBoxCasesInput.Focus();
            }

        }
        /// <summary>
        ///  When this form closes destroy the open instance of this form.
        /// </summary>
        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            averageWeeklyCasesInstance = null;
            //without this event handler the application will crash if you attempt to open a 
            //average weekly cases window again after having closed one once.
        }

        #endregion
    }

}

