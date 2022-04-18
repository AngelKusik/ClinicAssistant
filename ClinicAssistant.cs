// Author:        Angelica Kusik
// Date:          April 18, 2022
// Description:   A multi-form application that incorporates some of the applications created for the .netd course in one final project.
//                This project is meant to provide a small company with a multi-tool application that includes a text editor, a customer tracing 
//                feature, an average units shipped calculator, and a weekly temperature average calculator. 
//
//                I included the weekly temperature average calculator to this project because the way I see it, this company could maybe operate
//                in the ice cream sales business, so temperature affects their sales, or maybe its a pharmaceutical company that wants to look at
//                the relationship between temperature and the drugs they sold the most.
//


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

        #region "Menu File Options"
        /// <summary>
        /// Opens a New instance of Alf Text Editor using the appropriate function.
        /// </summary>
        private void NewTextFileClick(object sender, EventArgs e)
        {
            //creates a new MDI Child form (an instance of Alf Text Editor) using the NewTextEditor() function.
            NewTextEditor();
        }
        /// <summary>
        /// Opens the file dialog so the user can select a file and open its content on a new instance of Alf Text Editor.
        /// </summary>
        private void buttonOpenClick(object sender, EventArgs e)
        {
            //if there is a Mdi child form open...
            if (this.MdiChildren.Length > 0)
            {
                //Check if the active form is an Alf text editor   
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    //Force the active form to be treated as a text editor instance
                    var activeForm = (formTextEditor)this.ActiveMdiChild;
                    //call the text editor's open event handler.
                    activeForm.OpenClick(sender, e);
                }//if the active form is a contactTracer window, AverageWeeklyeCases window, or WeeklyTemperatureform call the general open functionality.
                 //(these are the applications that didn't include its own open functionality)
                else if (this.ActiveMdiChild.GetType() == typeof(formContactTracer) || this.ActiveMdiChild.GetType() == typeof(formAverageWeeklyCases) || this.ActiveMdiChild.GetType() == typeof(formWeeklyTemperature))
                {
                    //Call OpenFile() function
                    OpenFile();

                }
            }else //if user is clicking open from parent form (no Mdi window is open), also call the general open function.
            {
                //call the function!
                OpenFile();
            }

        }
        /// <summary>
        /// Saves the contents of the active form to the current file location or call save as if there is no file location determined yet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveClick(object sender, EventArgs e)
        {
            //if there is a Mdi child form open...
            if (this.MdiChildren.Length > 0)
            {
                //Check if the active form is an Alf text editor   
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    //Force the active form to be treated as a text editor instance
                    var activeForm = (formTextEditor)this.ActiveMdiChild;
                    //call the text editor's save event handler.
                    activeForm.SaveClick(sender, e);
                }//if active form is a contactTracer form
                else if (this.ActiveMdiChild.GetType() == typeof(formContactTracer))
                {
                    //Force the active form to be treated as a contact tracer form
                    var activeForm = (formContactTracer)this.ActiveMdiChild;
                    //call the contact tracer's save event handler.
                    activeForm.SaveList();
                }//if active form is a averageWeekly form
                else if (this.ActiveMdiChild.GetType() == typeof(formAverageWeeklyCases))
                {
                    //Force the active form to be treated as an AverageWeekly form
                    var activeForm = (formAverageWeeklyCases)this.ActiveMdiChild;
                    //call the averageWeekly's save event handler.
                    activeForm.SaveArray();
                }
                else
                {
                    //Display an error message
                    MessageBox.Show("The current application does not support the 'save' option", "Save Failed");
                }
            }
            else //if there is no Mdi child window open
            {
                //Display an error message
                MessageBox.Show("There is no work to be saved", "Save Failed");
            }
        }
        /// <summary>
        /// Saves the contents of the active form to the selected file.
        /// </summary>
        private void buttonSaveAsClick(object sender, EventArgs e)
        {
            //if there is a Mdi child form open...
            if (this.MdiChildren.Length > 0)
            {
                //Check if the active form is an Alf text editor   
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    //Force the active form to be treated as a text editor instance
                    var activeForm = (formTextEditor)this.ActiveMdiChild;
                    //call the text editor's saveAs event handler.
                    activeForm.SaveAsClick(sender, e);
                }//or if active form is a contactTracer form
                else if (this.ActiveMdiChild.GetType() == typeof(formContactTracer))
                {
                    //Force the active form to be treated as a contact tracer form
                    var activeForm = (formContactTracer)this.ActiveMdiChild;
                    //call the contact tracer's saveAs event handler.
                    activeForm.SaveListAs();
                }//or if active form is a averageWeekly form
                else if (this.ActiveMdiChild.GetType() == typeof(formAverageWeeklyCases))
                {
                    //Force the active form to be treated as an AverageWeeklyCases form
                    var activeForm = (formAverageWeeklyCases)this.ActiveMdiChild;
                    //call the average weekly's saveAs event handler.
                    activeForm.SaveArrayAs();
                }
                else //if it's weeklyTemperature which has no save functionality coded
                {
                    //Display an error message
                    MessageBox.Show("The current application does not support the 'Save As' option", "Save As Failed");
                }
            }
            else //if there is no Mdi child window open
            {
                //Display an error message
                MessageBox.Show("There is no work to be saved", "Save As Failed");

            } 
        }
        /// <summary>
        /// Closes the Mdi child form in focus, if there is no Mdi child form open closes the entire application.
        /// </summary>
        private void buttonCloseClick(object sender, EventArgs e)
        {
            //if there is a Mdi child form open, close it
            if (this.MdiChildren.Length > 0)
            {
                this.ActiveMdiChild.Close();
            }
            //otherwise close the entire application.
            else
            {
                Close();
            }
        }
        /// <summary>
        /// Closes the entire application including child windows.
        /// </summary>
        private void buttonExitClick(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region "Menu Edit Options"
        /// <summary>
        /// Cuts selected text or selected customer from the application and copy it to the clipboard.
        /// </summary>
        private void buttonCutClick(object sender, EventArgs e)
        {
            //if there is a Mdi child form open...
            if (this.MdiChildren.Length > 0)
            {
                //Check if the active form is an Alf text editor   
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    //Force the active form to be treated as a text editor instance
                    var activeForm = (formTextEditor)this.ActiveMdiChild;
                    //call the text editor's cut event handler.
                    activeForm.CutClick(sender, e); 
                }
                //Check if the active form is a contact tracer   
                else if (this.ActiveMdiChild.GetType() == typeof(formContactTracer))
                {
                    //Force the active form to be treated as a contact tracer instance
                    var activeForm = (formContactTracer)this.ActiveMdiChild;
                    //call the contact tracer's cut event handler.
                    activeForm.CutListView(sender, e);
                }
                else //if its not a text editor or contact tracer...
                {
                    //Display an error message
                    MessageBox.Show("The current application does not support the 'cut' option", "Cut Failed");
                }
            }
            else //if there is no Mdi child window open
            {
                //Display an error message
                MessageBox.Show("You must open a window in order to use the 'cut' option.", "Cut Failed");
            }
        }

  
        /// <summary>
        /// Copies selected text or selected customer from the application to the clipboard.
        /// </summary>
        private void buttonCopyClick(object sender, EventArgs e)
        {
            //if there is a Mdi child form open...
            if (this.MdiChildren.Length > 0)
            {
                //Check if the active form is an Alf text editor   
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    //Force the active form to be treated as a text editor instance
                    var activeForm = (formTextEditor)this.ActiveMdiChild;
                    //call the text editor's copy event handler.
                    activeForm.CopyClick(sender, e);
                }
                //Check if the active form is a Contact Tracer   
                else if (this.ActiveMdiChild.GetType() == typeof(formContactTracer))
                {
                    //Force the active form to be treated as a contact tracer instance
                    var activeForm = (formContactTracer)this.ActiveMdiChild;
                    //call the contact tracer's copy event handler.
                    activeForm.CopyListView(sender, e);
                }
                else //if its not a text editor or contact tracer..
                {
                    //Display an error message
                    MessageBox.Show("The current application does not support the 'copy' option", "Copy Failed");
                }
            }
            else //if there is no Mdi child window open
            {
                //Display an error message
                MessageBox.Show("You must open a window in order to use the 'copy' option", "Copy Failed");
            }

        }
        /// <summary>
        /// Pastes text from clipboard to the text editor.
        /// </summary>
        private void buttonPasteClick(object sender, EventArgs e)
        {
            //if there is a Mdi child form open...
            if (this.MdiChildren.Length > 0)
            {
                //Check if the active form is an Alf text editor   
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    //Force the active form to be treated as a text editor instance
                    var activeForm = (formTextEditor)this.ActiveMdiChild;
                    //call the text editor's open event handler.
                    activeForm.PasteClick(sender, e);
                }
                else //if its not a text editor...
                {
                    //Display an error message
                    MessageBox.Show("The current application does not support the 'paste' option", "Paste Failed");
                }
            }
            else //if there is no Mdi child window open
            {
                //Display an error message
                MessageBox.Show("You must open a window in order to use the 'paste' option.", "Paste Failed");
            }
        }
        /// <summary>
        /// Selects all text in the text editor.
        /// </summary>
        private void buttonSelectAllClick(object sender, EventArgs e)
        {
            //if there is a Mdi child form open...
            if (this.MdiChildren.Length > 0)
            {
                //Check if the active form is an Alf text editor   
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    //Force the active form to be treated as a text editor instance
                    var activeForm = (formTextEditor)this.ActiveMdiChild;
                    //call the text editor's open event handler.
                    activeForm.SelectAllClick(sender, e);
                }
                else //if its not a text editor...
                {
                    //Display an error message
                    MessageBox.Show("The current application does not support the 'select all' option", "Select All Failed");
                }
            }
            else //if there is no Mdi child window open
            {
                //Display an error message
                MessageBox.Show("You must open a window in order to use the 'selct all; option.", "Select All Failed");
            }

        }
        #endregion
        #region "Menu Help Options"
        /// <summary>
        /// Displays the copyright information, author name, and a brief description of what this application is.
        /// </summary>
        private void buttonAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Clinic Assistant" + Environment.NewLine +
            "By Angelica Kusik in partnership with Alf Corporations" + Environment.NewLine +
            "A multi-form application designed to facilitate the daily operations of a small company." + Environment.NewLine +
            "\u00a9 2022 Angelica Kusik CO. All rights reserved.");
        }
        #endregion
        #region "Menu Window Options"
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
        /// Creates a new AverageWeeklyCases form instance if there is none open, or shows the one already open.
        /// </summary>
        private void buttonOpenAverageUnitsClick(object sender, EventArgs e)
        {
            //if there is no AverageWeeklyCases form window open, make a new instance.
            formAverageWeeklyCases newAverageWeeklyCasesForm = formAverageWeeklyCases.Instance;
            newAverageWeeklyCasesForm.MdiParent = this;
            //Open the new instance if it's not open already.
            newAverageWeeklyCasesForm.Show();
            //Puts the cursor focus on the window.
            newAverageWeeklyCasesForm.Focus();
        }
        /// <summary>
        /// Creates a new WeeklyTemperature form instance if there is none open, or shows the one already open.
        /// </summary>
        private void buttonOpenWeeklyTemperatureClick(object sender, EventArgs e)
        {
            //if there is no WeeklyTemperature form window open, make a new instance.
            formWeeklyTemperature newWeeklyTemperatureForm = formWeeklyTemperature.Instance;
            newWeeklyTemperatureForm.MdiParent = this;
            //Open the new instance if it's not open already.
            newWeeklyTemperatureForm.Show();
            //Puts the cursor focus on the window.
            newWeeklyTemperatureForm.Focus();
        }
        #endregion
        #endregion
        #region "Functions"
        /// <summary>
        /// Opens a new instance of Alf Text Editor
        /// </summary>
        private formTextEditor NewTextEditor()
        {
            var editor = new formTextEditor();
            //set this form (Clinic Assistant) as the parent of the text editor instance we just created.
            editor.MdiParent = this;
            //open the new text editor window.
            editor.Show();
            //Return the newly created instance.
            return editor;
        }

        private void OpenFile()
        {
            //Open a new file Dialog window
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            //creates a new MDI Child form (an instance of Alf Text Editor) using the OpenNewTextEditor() function.
            var newTextEditorWindow = NewTextEditor();

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
        }
        #endregion
    }
}
