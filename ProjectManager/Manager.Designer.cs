namespace ProjectManager
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.menuUniversal = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNewImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNewText = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNewSpreadsheet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveCurrentAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewChange = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlugins = new System.Windows.Forms.ToolStripMenuItem();
            this.wordCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbox = new System.Windows.Forms.RichTextBox();
            this.rtfbox = new System.Windows.Forms.RichTextBox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusbarChange = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbarWordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbltextpane = new System.Windows.Forms.Label();
            this.lblrtfpane = new System.Windows.Forms.Label();
            this.sizingtab = new System.Windows.Forms.PictureBox();
            this.menuUniversal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizingtab)).BeginInit();
            this.SuspendLayout();
            // 
            // menuUniversal
            // 
            this.menuUniversal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.MenuImport,
            this.menuView,
            this.menuPlugins,
            this.menuHelp});
            this.menuUniversal.Location = new System.Drawing.Point(0, 0);
            this.menuUniversal.Name = "menuUniversal";
            this.menuUniversal.Size = new System.Drawing.Size(826, 24);
            this.menuUniversal.TabIndex = 0;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileSaveCurrent,
            this.menuFileSaveCurrentAs,
            this.menuFileSaveAll,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNewProject,
            this.menuFileNewImage,
            this.menuFileNewText,
            this.richTextToolStripMenuItem,
            this.menuFileNewSpreadsheet});
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(213, 22);
            this.menuFileNew.Text = "New";
            // 
            // menuFileNewProject
            // 
            this.menuFileNewProject.Name = "menuFileNewProject";
            this.menuFileNewProject.Size = new System.Drawing.Size(138, 22);
            this.menuFileNewProject.Text = "Project";
            // 
            // menuFileNewImage
            // 
            this.menuFileNewImage.Name = "menuFileNewImage";
            this.menuFileNewImage.Size = new System.Drawing.Size(138, 22);
            this.menuFileNewImage.Text = "Image";
            // 
            // menuFileNewText
            // 
            this.menuFileNewText.Name = "menuFileNewText";
            this.menuFileNewText.Size = new System.Drawing.Size(138, 22);
            this.menuFileNewText.Text = "Text";
            // 
            // richTextToolStripMenuItem
            // 
            this.richTextToolStripMenuItem.Name = "richTextToolStripMenuItem";
            this.richTextToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.richTextToolStripMenuItem.Text = "Rich Text";
            // 
            // menuFileNewSpreadsheet
            // 
            this.menuFileNewSpreadsheet.Name = "menuFileNewSpreadsheet";
            this.menuFileNewSpreadsheet.Size = new System.Drawing.Size(138, 22);
            this.menuFileNewSpreadsheet.Text = "Spreadsheet";
            // 
            // menuFileSaveCurrent
            // 
            this.menuFileSaveCurrent.Name = "menuFileSaveCurrent";
            this.menuFileSaveCurrent.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSaveCurrent.Size = new System.Drawing.Size(213, 22);
            this.menuFileSaveCurrent.Text = "Save current";
            this.menuFileSaveCurrent.Click += new System.EventHandler(this.menuFileSaveCurrent_Click);
            // 
            // menuFileSaveCurrentAs
            // 
            this.menuFileSaveCurrentAs.Name = "menuFileSaveCurrentAs";
            this.menuFileSaveCurrentAs.Size = new System.Drawing.Size(213, 22);
            this.menuFileSaveCurrentAs.Text = "Save current as...";
            this.menuFileSaveCurrentAs.Click += new System.EventHandler(this.menuFileSaveCurrentAs_Click);
            // 
            // menuFileSaveAll
            // 
            this.menuFileSaveAll.Name = "menuFileSaveAll";
            this.menuFileSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuFileSaveAll.Size = new System.Drawing.Size(213, 22);
            this.menuFileSaveAll.Text = "Save all docs";
            this.menuFileSaveAll.Click += new System.EventHandler(this.menuFileSaveAll_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuFileExit.Size = new System.Drawing.Size(213, 22);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // MenuImport
            // 
            this.MenuImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImportProject,
            this.menuImportDocument});
            this.MenuImport.Name = "MenuImport";
            this.MenuImport.Size = new System.Drawing.Size(55, 20);
            this.MenuImport.Text = "Import";
            // 
            // menuImportProject
            // 
            this.menuImportProject.Name = "menuImportProject";
            this.menuImportProject.Size = new System.Drawing.Size(130, 22);
            this.menuImportProject.Text = "Project";
            // 
            // menuImportDocument
            // 
            this.menuImportDocument.Name = "menuImportDocument";
            this.menuImportDocument.Size = new System.Drawing.Size(130, 22);
            this.menuImportDocument.Text = "Document";
            this.menuImportDocument.Click += new System.EventHandler(this.menuImportDocument_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewChange});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "View";
            // 
            // menuViewChange
            // 
            this.menuViewChange.Name = "menuViewChange";
            this.menuViewChange.Size = new System.Drawing.Size(115, 22);
            this.menuViewChange.Text = "Change";
            // 
            // menuPlugins
            // 
            this.menuPlugins.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordCountToolStripMenuItem});
            this.menuPlugins.Name = "menuPlugins";
            this.menuPlugins.Size = new System.Drawing.Size(58, 20);
            this.menuPlugins.Text = "Plugins";
            // 
            // wordCountToolStripMenuItem
            // 
            this.wordCountToolStripMenuItem.Name = "wordCountToolStripMenuItem";
            this.wordCountToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.wordCountToolStripMenuItem.Text = "Word count...";
            this.wordCountToolStripMenuItem.Click += new System.EventHandler(this.wordCountToolStripMenuItem_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // txtbox
            // 
            this.txtbox.AcceptsTab = true;
            this.txtbox.Location = new System.Drawing.Point(10, 57);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(300, 384);
            this.txtbox.TabIndex = 1;
            this.txtbox.Text = "";
            this.txtbox.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            // 
            // rtfbox
            // 
            this.rtfbox.AcceptsTab = true;
            this.rtfbox.Location = new System.Drawing.Point(330, 57);
            this.rtfbox.Name = "rtfbox";
            this.rtfbox.Size = new System.Drawing.Size(300, 606);
            this.rtfbox.TabIndex = 2;
            this.rtfbox.Text = "";
            this.rtfbox.TextChanged += new System.EventHandler(this.rtfbox_TextChanged);
            this.rtfbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.rtfbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            this.rtfbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // picbox
            // 
            this.picbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox.Location = new System.Drawing.Point(10, 447);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(300, 216);
            this.picbox.TabIndex = 3;
            this.picbox.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusbarChange,
            this.statusbarWordCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 675);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 24);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusbarChange
            // 
            this.statusbarChange.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusbarChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusbarChange.Name = "statusbarChange";
            this.statusbarChange.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.statusbarChange.Size = new System.Drawing.Size(63, 19);
            this.statusbarChange.Text = "Ready";
            // 
            // statusbarWordCount
            // 
            this.statusbarWordCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusbarWordCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusbarWordCount.Name = "statusbarWordCount";
            this.statusbarWordCount.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.statusbarWordCount.Size = new System.Drawing.Size(37, 19);
            this.statusbarWordCount.Text = "0";
            // 
            // lbltextpane
            // 
            this.lbltextpane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltextpane.Location = new System.Drawing.Point(10, 31);
            this.lbltextpane.Name = "lbltextpane";
            this.lbltextpane.Size = new System.Drawing.Size(300, 23);
            this.lbltextpane.TabIndex = 5;
            this.lbltextpane.Text = "Untitled";
            this.lbltextpane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblrtfpane
            // 
            this.lblrtfpane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrtfpane.Location = new System.Drawing.Point(330, 31);
            this.lblrtfpane.Name = "lblrtfpane";
            this.lblrtfpane.Size = new System.Drawing.Size(300, 23);
            this.lblrtfpane.TabIndex = 6;
            this.lblrtfpane.Text = "Untitled";
            this.lblrtfpane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sizingtab
            // 
            this.sizingtab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sizingtab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sizingtab.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.sizingtab.Image = ((System.Drawing.Image)(resources.GetObject("sizingtab.Image")));
            this.sizingtab.Location = new System.Drawing.Point(298, 429);
            this.sizingtab.Name = "sizingtab";
            this.sizingtab.Size = new System.Drawing.Size(12, 12);
            this.sizingtab.TabIndex = 7;
            this.sizingtab.TabStop = false;
            this.sizingtab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizetab_MouseDown);
            this.sizingtab.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resizetab_MouseMove);
            this.sizingtab.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizetab_MouseUp);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 699);
            this.Controls.Add(this.sizingtab);
            this.Controls.Add(this.lblrtfpane);
            this.Controls.Add(this.lbltextpane);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.rtfbox);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.menuUniversal);
            this.MainMenuStrip = this.menuUniversal;
            this.Name = "ManagerForm";
            this.Text = "Alpha 1.0 Project Manager";
            this.menuUniversal.ResumeLayout(false);
            this.menuUniversal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizingtab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuUniversal;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileNewProject;
        private System.Windows.Forms.ToolStripMenuItem menuFileNewImage;
        private System.Windows.Forms.ToolStripMenuItem menuFileNewText;
        private System.Windows.Forms.ToolStripMenuItem menuFileNewSpreadsheet;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveCurrent;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAll;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem MenuImport;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuViewChange;
        private System.Windows.Forms.ToolStripMenuItem menuPlugins;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuImportProject;
        private System.Windows.Forms.ToolStripMenuItem menuImportDocument;
        private System.Windows.Forms.RichTextBox txtbox;
        private System.Windows.Forms.RichTextBox rtfbox;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.ToolStripMenuItem richTextToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusbarChange;
        private System.Windows.Forms.ToolStripStatusLabel statusbarWordCount;
        private System.Windows.Forms.Label lblrtfpane;
        private System.Windows.Forms.ToolStripMenuItem wordCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveCurrentAs;
        public System.Windows.Forms.Label lbltextpane;
        private System.Windows.Forms.PictureBox sizingtab;
    }
}

