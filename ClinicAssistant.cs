// Author:        Angelica Kusik
// Date:          April 14, 2022
// Description:   A multi-form application that incorporates some of the applications created for the .netd course in one final project.
//                This project is meant to provide a small company with a multi-tool application that includes a text editor, a customer tracing 
//                feature, an average units shipped calculator, and a weekly temperature average calculator. 
//
//                I included the weekly temperature average calculator to this project because the way I see it, this company could maybe operate
//                in the ice cream sales business, so temperature affects their sales, or maybe its a pharmaceutical company that wants to trace
//                the relationship between temperature and the drugs they sold the most.
//



//TODO: working on the save functionality. Need to figure it out how to save the contents of a list on a text file, which property I need to access to do so.

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
    public partial class formParent : Form
    {
        //Declare a "global" variable to hold the file path and set it
        //equal to an empty string until the user selects where the file must be saved.
        string openFile = String.Empty;
        public formParent()
        {
            InitializeComponent();
        }
        #region "Event Handlers"
        /// <summary>
        /// Opens a New instance of Alf Text Editor using the appropriate function.
        /// </summary>
        private void NewTextFileClick(object sender, EventArgs e)
        {
            //creates a new MDI Child form (an instance of Alf Text Editor) using the OpenNewTextEditor() function.
            OpenNewTextEditor();
        }
        /// <summary>
        /// Opens the file dialog so the user can select a file and open its content on a new instance of Alf Text Editor.
        /// </summary>
        private void buttonOpenClick(object sender, EventArgs e)
        {
            //Check if the active form is an Alf text editor   
            if(this.ActiveMdiChild.GetType() == typeof(formTextEditor))
            {
                //Force the active form to be treated as a text editor instance
                var activeForm = (formTextEditor)this.ActiveMdiChild;
                //call the text editor's open event handler.
                activeForm.OpenClick(sender, e);
            }//if the active form is a contactTracer window or AverageWeeklyeCases window, create new fileDialog and open the file in a text editor window.
             //(these are the applications that didn't include an open functionality)
            else if (this.ActiveMdiChild.GetType() == typeof(formContactTracer) || this.ActiveMdiChild.GetType() == typeof(formAverageWeeklyCases))
            {
                //Open a new file Dialog window
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

                //creates a new MDI Child form (an instance of Alf Text Editor) using the OpenNewTextEditor() function.
                var newTextEditorWindow = OpenNewTextEditor();

                //If user selects a file through the file Dialog window and click ok
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    //Declare a FileStream object to read the contents of the selected file
                    FileStream fileToAcess = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader read = new StreamReader(fileToAcess);

                    //Set file path equal to the path of the file that the user is opening. openFile is a global variable that will be used by other event handlers 
                    openFile = openDialog.FileName;

                    //Read all the content of the file being opened and store it in a variable
                    string openFileContent = read.ReadToEnd();

                    //Close the reader 
                    read.Close();

                    //Display the contents of the opened file on the new instance of Alf Text Editor.
                    newTextEditorWindow.textBoxBody.Text = openFileContent;
                }

            }//if the active form is a weekly temperature window, display an error message saying that open is not supported for this window.
            //(I decided to not include this form type on the previous else if statement to use a broader range of options in this project).
            else 
            {
                //Force the active form to be treated as a contact tracer instance
                MessageBox.Show("The current application does not support the 'open' option", "Warning");

            }
            
        }
        private void buttonSaveClick(object sender, EventArgs e)
        {
            //Check if the active form is an Alf text editor   
            if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
            {
                //Force the active form to be treated as a text editor instance
                var activeForm = (formTextEditor)this.ActiveMdiChild;
                //call the text editor's open event handler.
                activeForm.SaveClick(sender, e);
            }//if active form is a contactTracer form
            else if (this.ActiveMdiChild.GetType() == typeof(formContactTracer)) 
            {
                //check if the variable  openFile was set is an empty string, meaning it hasn't been saved yet
                if (openFile == String.Empty)
                {
                    //Declare, instantiate and configure a new SaveFileDialog
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Text Files (*.txt)|*.txt";

                    //If the person picks a file and clicks "OK"
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = "List" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                        //Set openFile equal to the File path 
                        filePath = saveDialog.FileName;
                        //Call the SaveFile function to write the contents of the textbox into the file.
                        SaveList(filePath, CustomerList ???);

                        //Display a message informing the user that file was successfully saved.
                        MessageBox.Show("Your work is saved to " + filePath, "Save Successful");
                    }
                    else
                    {
                        //If user clicks cancel instead of ok on the dialog, display a warning informaming file was not saved.
                        MessageBox.Show("Your work was not saved", "Warning");
                    }
                }
                //If openFile has a value, just call the SaveFile() function!
                else if (openFile != String.Empty)
                {
                    //Call the saveList()
                    SaveList(openFile, CustomerList ???);

                }

            }

        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonSaveAsClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonCloseClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Closes the entire application including child windows.
        /// </summary>
        private void buttonExitClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonCutClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonCopyClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonPasteClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonSelectAllClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Displays the copyright information, author name, and a brief description of what this application is.
        /// </summary>
        private void buttonAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Clinic Assistant" + Environment.NewLine +
            "By Angelica Kusik" + Environment.NewLine +
            "A multi-form application designed to facilitate the daily operations of a small company." + Environment.NewLine +
            "\u00a9 2022 Angelica Kusik CO. All rights reserved.");
        }
        /// <summary>
        /// Displays the open child forms in cascade style.
        /// </summary>
        private void buttonCascadeClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        /// <summary>
        /// Displays the child forms open in tile horizontal style.
        /// </summary>
        private void buttonTileHorizontalClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        /// <summary>
        /// Displays the child forms open in tile horizontal style.
        /// </summary>
        private void buttonTileVerticalClick(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        /// <summary>
        /// Creates a new contactTracer form instance if there is none open, or shows the one already open. 
        /// </summary>
        private void buttonOpenContactTracerClick(object sender, EventArgs e)
        {
            //if there is no contact tracer form window open, make a new instance.
            formContactTracer newContactTracerForm = formContactTracer.Instance;
            newContactTracerForm.MdiParent = this;
            //Open the new instance if it's not open already.
            newContactTracerForm.Show();
            //Puts the cursor focus on the window.
            newContactTracerForm.Focus();
            
        }
        /// <summary>
        /// 
        /// </summary>
        private void buttonOpenAverageUnitsClick(object sender, EventArgs e)
        {

        }

        #endregion
        #region "Functions"
        /// <summary>
        /// Opens a new instance of Alf Text Editor
        /// </summary>
        private formTextEditor OpenNewTextEditor()
        {
            var editor = new formTextEditor();
            //set this form (Clinic Assistant) as the parent of the text editor instance we just created.
            editor.MdiParent = this;
            //open the new text editor window.
            editor.Show();
            //Return the newly created instance.
            return editor;
        }

        #endregion
        #region "Functions"
        private void SaveList(string filePath, List listType)
        {
            //Create a System.IO object to make file access easier
            FileStream fileToAcess = new FileStream(openFile, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new
            StreamWriter(fileToAcess);

            for (int index = 0; index < customerList.Count; index++) //here instead of customer list it gotta be list type
            {
                //Write the contents of the list on the file selected by the user.
                writer.Write(customerList[index].ToString() + "\n");
            }
            //Close the write 
            writer.Close();
        }

        #endregion
    }
}
