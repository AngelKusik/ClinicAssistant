
namespace ClinicAssistant
{
    partial class formTextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTextEditor));
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(965, 38);
            this.menuTop.TabIndex = 0;
            this.menuTop.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSeparator1,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileSeparator2,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(62, 34);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "Click to access file saving options.\r\n";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
            this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(276, 40);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.ToolTipText = "Click to create a new file.";
            this.menuFileNew.Click += new System.EventHandler(this.NewClick);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(276, 40);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.ToolTipText = "Click to open a file.";
            this.menuFileOpen.Click += new System.EventHandler(this.OpenClick);
            // 
            // menuFileSeparator1
            // 
            this.menuFileSeparator1.Name = "menuFileSeparator1";
            this.menuFileSeparator1.Size = new System.Drawing.Size(273, 6);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(276, 40);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.ToolTipText = "Click to save file.";
            this.menuFileSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuFileSaveAs.Size = new System.Drawing.Size(276, 40);
            this.menuFileSaveAs.Text = "Save &As";
            this.menuFileSaveAs.ToolTipText = "Click to select where the file must be saved.\r\n";
            this.menuFileSaveAs.Click += new System.EventHandler(this.SaveAsClick);
            // 
            // menuFileSeparator2
            // 
            this.menuFileSeparator2.Name = "menuFileSeparator2";
            this.menuFileSeparator2.Size = new System.Drawing.Size(273, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuFileExit.Size = new System.Drawing.Size(276, 40);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.ToolTipText = "Click to exit Alf Text Editor";
            this.menuFileExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditSeparator1,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.menuEditSeparator2});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(66, 34);
            this.menuEdit.Text = "&Edit";
            this.menuEdit.ToolTipText = "Click to access file edition options.";
            // 
            // menuEditSeparator1
            // 
            this.menuEditSeparator1.Name = "menuEditSeparator1";
            this.menuEditSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCut.Image")));
            this.menuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menuEditCut.Size = new System.Drawing.Size(252, 40);
            this.menuEditCut.Text = "Cu&t";
            this.menuEditCut.ToolTipText = "Click to cut selected text from the text editor.";
            this.menuEditCut.Click += new System.EventHandler(this.CutClick);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCopy.Image")));
            this.menuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(252, 40);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.ToolTipText = "Click to copy selected text from the text editor.";
            this.menuEditCopy.Click += new System.EventHandler(this.CopyClick);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("menuEditPaste.Image")));
            this.menuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(252, 40);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.ToolTipText = "Click to paste text from the clipboard to the text editor.";
            this.menuEditPaste.Click += new System.EventHandler(this.PasteClick);
            // 
            // menuEditSeparator2
            // 
            this.menuEditSeparator2.Name = "menuEditSeparator2";
            this.menuEditSeparator2.Size = new System.Drawing.Size(249, 6);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(74, 34);
            this.menuHelp.Text = "&Help";
            this.menuHelp.ToolTipText = "Click to access help options.";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuHelpAbout.Size = new System.Drawing.Size(274, 40);
            this.menuHelpAbout.Text = "&About...";
            this.menuHelpAbout.ToolTipText = "Click to access information about Alf Text Editor.";
            this.menuHelpAbout.Click += new System.EventHandler(this.AboutClick);
            // 
            // textBoxBody
            // 
            this.textBoxBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBody.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBody.Location = new System.Drawing.Point(0, 38);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxBody.Size = new System.Drawing.Size(965, 469);
            this.textBoxBody.TabIndex = 1;
            // 
            // formTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 507);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.menuTop);
            this.MainMenuStrip = this.menuTop;
            this.Name = "formTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alf Text Editor";
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTop;
        public System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator menuFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator menuFileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripSeparator menuEditSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripSeparator menuEditSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
    }
}

