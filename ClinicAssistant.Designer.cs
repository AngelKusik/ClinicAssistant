
namespace ClinicAssistant
{
    partial class formParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formParent));
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSellectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowOpenContactTracer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowAverageUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp,
            this.menuWindow});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(1168, 38);
            this.menuTop.TabIndex = 1;
            this.menuTop.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileClose,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(62, 34);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "Click here for file options.";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
            this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(276, 40);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.ToolTipText = "Click here to open the text editor.";
            this.menuFileNew.Click += new System.EventHandler(this.NewTextFileClick);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(276, 40);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.ToolTipText = "Click here to open a new file.";
            this.menuFileOpen.Click += new System.EventHandler(this.buttonOpenClick);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(276, 40);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.ToolTipText = "Click here to save.";
            this.menuFileSave.Click += new System.EventHandler(this.buttonSaveClick);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuFileSaveAs.Size = new System.Drawing.Size(276, 40);
            this.menuFileSaveAs.Text = "Save &As";
            this.menuFileSaveAs.ToolTipText = "Click here to save to a choosen location.\r\n";
            this.menuFileSaveAs.Click += new System.EventHandler(this.buttonSaveAsClick);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileClose.Size = new System.Drawing.Size(276, 40);
            this.menuFileClose.Text = "&Close";
            this.menuFileClose.ToolTipText = "Click here to close window.";
            this.menuFileClose.Click += new System.EventHandler(this.buttonCloseClick);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuFileExit.Size = new System.Drawing.Size(276, 40);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.ToolTipText = "Click here to exit application.";
            this.menuFileExit.Click += new System.EventHandler(this.buttonExitClick);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.menuEditSellectAll});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(66, 34);
            this.menuEdit.Text = "&Edit";
            this.menuEdit.ToolTipText = "Click here for file edit options.";
            // 
            // menuEditCut
            // 
            this.menuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCut.Image")));
            this.menuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(289, 40);
            this.menuEditCut.Text = "Cu&t";
            this.menuEditCut.ToolTipText = "Click here to cut selected text.";
            this.menuEditCut.Click += new System.EventHandler(this.buttonCutClick);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCopy.Image")));
            this.menuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(289, 40);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.ToolTipText = "Click here to copy selected text.";
            this.menuEditCopy.Click += new System.EventHandler(this.buttonCopyClick);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("menuEditPaste.Image")));
            this.menuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(289, 40);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.ToolTipText = "Click here to paste from clipboard.";
            this.menuEditPaste.Click += new System.EventHandler(this.buttonPasteClick);
            // 
            // menuEditSellectAll
            // 
            this.menuEditSellectAll.Name = "menuEditSellectAll";
            this.menuEditSellectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuEditSellectAll.Size = new System.Drawing.Size(289, 40);
            this.menuEditSellectAll.Text = "Select &All";
            this.menuEditSellectAll.ToolTipText = "Click here to select all.";
            this.menuEditSellectAll.Click += new System.EventHandler(this.buttonSelectAllClick);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(74, 34);
            this.menuHelp.Text = "&Help";
            this.menuHelp.ToolTipText = "Click here for help options.";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuHelpAbout.Size = new System.Drawing.Size(274, 40);
            this.menuHelpAbout.Text = "&About...";
            this.menuHelpAbout.ToolTipText = "Click here for information about the application.";
            this.menuHelpAbout.Click += new System.EventHandler(this.buttonAboutClick);
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowCascade,
            this.menuWindowTileHorizontal,
            this.menuWindowTileVertical,
            this.menuWindowOpenContactTracer,
            this.menuWindowAverageUnits});
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(107, 34);
            this.menuWindow.Text = "&Window";
            this.menuWindow.ToolTipText = "Click here for window options.";
            // 
            // menuWindowCascade
            // 
            this.menuWindowCascade.Name = "menuWindowCascade";
            this.menuWindowCascade.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuWindowCascade.Size = new System.Drawing.Size(391, 40);
            this.menuWindowCascade.Text = "&Cascade";
            this.menuWindowCascade.ToolTipText = "Click here to display open windows in casacade.";
            this.menuWindowCascade.Click += new System.EventHandler(this.buttonCascadeClick);
            // 
            // menuWindowTileHorizontal
            // 
            this.menuWindowTileHorizontal.Name = "menuWindowTileHorizontal";
            this.menuWindowTileHorizontal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuWindowTileHorizontal.Size = new System.Drawing.Size(391, 40);
            this.menuWindowTileHorizontal.Text = "Tile &Horizontal";
            this.menuWindowTileHorizontal.ToolTipText = "Click here to display open windows in tile horizontal.";
            this.menuWindowTileHorizontal.Click += new System.EventHandler(this.buttonTileHorizontalClick);
            // 
            // menuWindowTileVertical
            // 
            this.menuWindowTileVertical.Name = "menuWindowTileVertical";
            this.menuWindowTileVertical.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuWindowTileVertical.Size = new System.Drawing.Size(391, 40);
            this.menuWindowTileVertical.Text = "Tile &Vertical";
            this.menuWindowTileVertical.ToolTipText = "Click here to display open windows in tile vertical";
            this.menuWindowTileVertical.Click += new System.EventHandler(this.buttonTileVerticalClick);
            // 
            // menuWindowOpenContactTracer
            // 
            this.menuWindowOpenContactTracer.Name = "menuWindowOpenContactTracer";
            this.menuWindowOpenContactTracer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menuWindowOpenContactTracer.Size = new System.Drawing.Size(391, 40);
            this.menuWindowOpenContactTracer.Text = "Open Contact &Tracer";
            this.menuWindowOpenContactTracer.ToolTipText = "Click here to open Contact Tracer window.";
            this.menuWindowOpenContactTracer.Click += new System.EventHandler(this.buttonOpenContactTracerClick);
            // 
            // menuWindowAverageUnits
            // 
            this.menuWindowAverageUnits.Name = "menuWindowAverageUnits";
            this.menuWindowAverageUnits.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menuWindowAverageUnits.Size = new System.Drawing.Size(391, 40);
            this.menuWindowAverageUnits.Text = "Open Average &Units";
            this.menuWindowAverageUnits.ToolTipText = "Click here to open Average Units window.";
            this.menuWindowAverageUnits.Click += new System.EventHandler(this.buttonOpenAverageUnitsClick);
            // 
            // formParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 707);
            this.Controls.Add(this.menuTop);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuTop;
            this.Name = "formParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alf Clinic Assistant";
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuEditSellectAll;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem menuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem menuWindowTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuWindowTileVertical;
        private System.Windows.Forms.ToolStripMenuItem menuWindowOpenContactTracer;
        private System.Windows.Forms.ToolStripMenuItem menuWindowAverageUnits;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

