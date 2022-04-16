// Author: Angelica Kusik
// Date: April 11, 2022
// Description: 
// A simple text editor application created as Lab 5 requirement for the NETD course that provides the user with some
//basic text edition features such as save, save as, copy, paste, cut, and more.
//In other words: Its a simplified Notepad application named after the beloved TV character Alf.

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
    public partial class formTextEditor : Form
    {
        //Declare a "global" variable to hold the file path and set it
        //equal to an empty string until the user selects where the file must be saved.
        string openFile = String.Empty;

        public formTextEditor()
        {
            InitializeComponent();
        }
        #region "Event Handlers"
        /// <summary>
        /// Saves the file to the selected location.
        /// </summary>
        public void SaveClick(object sender, EventArgs e)
        {
            //if openFile (the file that is currently open) has no value,
            //call "Save As" instead!
            if (openFile == String.Empty)
            {
                SaveAsClick(sender, e);
            }
            //If openFile has a value, just call the SaveFile() function!
            else if (openFile != String.Empty)
            {
                SaveFile(openFile);
            }
        }
        /// <summary>
        /// Allows the user to select the location where the file must be saved.
        /// </summary>
        public void SaveAsClick(object sender, EventArgs e)
        {
            //Declare, instantiate and configure a new SaveFileDialog
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.alf)|*.alf";

            //If the person picks a file and clicks "OK"
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                //Set openFile equal to the File path 
                openFile = saveDialog.FileName;
                //Call the SaveFile function to write the contents of the textbox into the file.
                SaveFile(openFile);

                //Display a message informing the user that file was successfully saved.
                MessageBox.Show("Your work is saved to " + openFile, "Save Successful");
            }else
            {
                //If user clicks cancel instead of ok on the dialog, display a warning informaming file was not saved.
                MessageBox.Show("Your work was not saved", "Warning");
            }
        }
        /// <summary>
        /// Closes the application.
        /// </summary>
        public void ExitClick(object sender, EventArgs e)
        {
            //Call the function ConfirmClose() to check if user wants to save
            //changes to the file before closing the application
            ConfirmClose(sender, e);

            //Closes the file
            Close();
        }
        /// <summary>
        /// Creates a new document by reseating the textbox to default values.
        /// </summary>
        public void NewClick(object sender, EventArgs e)
        {
            //Call the function ConfirmClose() to check if user wants to save file before proceding.
            ConfirmClose(sender, e);

            //clear the textbox and reseat the file path variable to create a new document.
            textBoxBody.Text = String.Empty;
            openFile = String.Empty;

        }
        /// <summary>
        /// Opens the openFileDialog so user can select an existing file and displays the content of the selected file on the textbox.
        /// </summary>
        public void OpenClick(object sender, EventArgs e)
        {
            //Call ConfirmClose() to check if user wants to save the file before proceding.
            ConfirmClose(sender, e);

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text Files (*.alf)|*.alf";

            //If user selects a file to open
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Declare a FileStream object to write to th
                FileStream fileToAcess = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(fileToAcess);

                //Set file path equal to the path of the file that the user is openening. This is a global variable that can be used by the save button 
                openFile = openDialog.FileName;

                //Read all the content of the file being opened and store it in a variable
                string openFileContent = read.ReadToEnd();

                //Close the reader 
                read.Close();

                //Display the content of the file that was opened on the textbox.
                textBoxBody.Text = openFileContent;

                //Update application title
                UpdateTitle();
            }            
        }
        /// <summary>
        /// Cuts a selected section of text from the textbox and pastes it to the clipboard.
        /// </summary>
        public void CutClick(object sender, EventArgs e)
        {
            //Ensure the user selected some text to cut.
            if (textBoxBody.SelectedText != String.Empty)
            {
                //Cut the selected text in the control and add it to the clipboard using its own method.
                textBoxBody.Cut();
            }
            //If the user didn't select any text
            else
            {
                //Display an error message informing that Cut failed.
                MessageBox.Show("Please select some text to cut.","Cut Failed");
            }
        }
        /// <summary>
        /// Copies all the text or a selected part of the text on the textbox. If there is no text to be copied, issues an error message.
        /// </summary>
        public void CopyClick(object sender, EventArgs e)
        {
            //if user selected some text.
            if (textBoxBody.SelectionLength > 0)
            {
                //Copy the selected text to the clipboard.
                textBoxBody.Copy();
            }
            else
            {
                //Display an error message informing that Cut failed.
                MessageBox.Show("Please select some text to copy.", "Copy Failed");
            }
        }
        /// <summary>
        /// Pastes text from the clipboard over a selected text section of the textbox or after the last
        /// text character.
        /// </summary>
        public void PasteClick(object sender, EventArgs e)
        {
            //First check if is there any text in the Clipboard to be pasted in the textbox.
            if (Clipboard.ContainsText())
            {
                //Next check if is there any text selected on the textbox
                if(textBoxBody.SelectionLength > 0)
                {
                    //if so, confirm with user if they want to overwrite the selected text.
                    if(MessageBox.Show("Do you want to paste over selected text?", "Warning", MessageBoxButtons.YesNo) == DialogResult.OK)
                    {
                        //If user clicks ok, determine the part of the text that must be overwritten 
                        textBoxBody.SelectionStart = textBoxBody.SelectionStart + textBoxBody.SelectionLength;
                    }
                }
                //Paste the text on textBox 
                textBoxBody.Paste();
            }
        }
        /// <summary>
        /// Dislays information about the application.
        /// </summary>
        private void AboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Alf Text Editor" + Environment.NewLine +
            "By Angelica Kusik in partnership with Professor Kyle Chapman" + Environment.NewLine + 
            "\u00a9 2022 Angelica Kusik CO. All rights reserved.");
        }
        #endregion
        #region "Functions"
        /// <summary>
        /// Creates a new file and writes the contents of the textbox on it.
        /// </summary>
        /// <param name="fileName">File Name/Path </param>
        private void SaveFile(string fileName)
        {
            //Create a System.IO object to make file access easier
            FileStream fileToAcess = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter write = new StreamWriter(fileToAcess);

            //Write the current text in the textbox into the file.
            write.Write(textBoxBody.Text);

            //Close the write 
            write.Close();

            //Update file name
            UpdateTitle();
        }
        /// <summary>
        /// Updates the title of the application adding the file path to the standard name.
        /// </summary>
        private void UpdateTitle()
        {
            this.Text = "AlfTextEditor";
            if(openFile != String.Empty)
            {
                this.Text += " - " + openFile;
            }
        }

        /// <summary>
        /// Bonus Feature: Displays a message asking the user if they want to save their work
        /// before creating a new file, opening a new file or exiting the application.
        /// </summary>
        private void ConfirmClose(object sender, EventArgs e)
        {
            //If texBoxBody has some text in it or if its a saved file ...
            if(!(textBoxBody.Text == String.Empty && openFile == String.Empty))
            {
                //ask user if they would like to save their work before opening another file, creating a new file or exiting the application.
                {
                    //If user clicks yes, call the SaveClick event handler.
                    if (MessageBox.Show("Do you want to save changes to Alf?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SaveClick(sender, e);
                    }
                 }
            }
        }
        #endregion

    }
}
