using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProjectManager
{
    public partial class ManagerForm : Form
    {

        public ManagerForm()
        {
            InitializeComponent();
            lbltextpane.Text = "Untitled";
            lblrtfpane.Text = "Untitled";
        }

        // Create instances of panes to correspond with document objects.
        // NEVER use a blank pane or it'll be unable to play nice with a document.
        Pane textpane = new Text();
        Pane rtfpane = new Richtext();

       // Exit button
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Import single document
        private void menuImportDocument_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog object.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the filter to look for text files, image files, or all project-eligible files.
            openFile1.Filter = "Project Files (text, image)|*.txt;*.rtf;*.jpg;*.jpeg;*.bmp;*.gif;*.png|"
                                + "Text Files (txt, rtf)|*.txt;*.rtf|"
                                + "Image Files (jpg, jpeg, bmp, gif, png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";


            // If the user selected a file, load its contents into the corresponding box.
            if (openFile1.ShowDialog() == DialogResult.OK)
            {
                // Get file extension and set instance elements
                // Trip the Dirty change and loaded switch upon load
                string ext = Path.GetExtension(openFile1.FileName);
                string title = Path.GetFileNameWithoutExtension(openFile1.FileName);

                // txt files
                if (ext == ".txt")
                {
                    if (textpane.dirty == true)
                    {
                        DialogResult dr3 = MessageBox.Show("Save changes to current TXT before\nimporting new document?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr3 == DialogResult.Yes)
                        {
                            textpane.SavePane(txtbox.Text);
                        }
                    }

                    txtbox.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
                    textpane.Loaded("yes");
                    textpane.SetTitle(title);
                    textpane.Changed(false);
                    textpane.SetFileLocation(openFile1.FileName);
                }

                // rtf files
                if (ext == ".rtf")
                {
                    if (rtfpane.dirty == true)
                    {
                        DialogResult dr2 = MessageBox.Show("Save changes to current RTF before\nimporting new document?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr2 == DialogResult.Yes)
                        {
                            rtfpane.SavePane(rtfbox.Rtf);
                        }
                    }

                    rtfbox.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);
                    rtfpane.Loaded("yes");
                    rtfpane.SetTitle(title);
                    rtfpane.Changed(false);
                    rtfpane.SetFileLocation(openFile1.FileName);
                }

                // picture files
                if (ext == ".jpg" ||
                    ext == ".jpeg" ||
                    ext == ".bmp" ||
                    ext == ".gif" ||
                    ext == ".png")
                {
                    picbox.Image = Image.FromFile(openFile1.FileName);

                    // Scale larger images to fit the picture box, display smaller images normally
                    if (Image.FromFile(openFile1.FileName).Width < picbox.Width && Image.FromFile(openFile1.FileName).Height < picbox.Height)
                    { picbox.SizeMode = PictureBoxSizeMode.Normal; }
                    else { picbox.SizeMode = PictureBoxSizeMode.Zoom; }
                }
            }


        }

        // Save focused document (NOT images)
        private void menuFileSaveCurrent_Click(object sender, EventArgs e)
        {
            // Saving the text box.
            if (txtbox.Focused)
            {
                textpane.SavePane(txtbox.Text);
            }

            // Saving the rich text box.
            if (rtfbox.Focused)
            {
                rtfpane.SavePane(rtfbox.Rtf);
            }
        }

        // Save all documents (NOT images)
        private void menuFileSaveAll_Click(object sender, EventArgs e)
        {
            if (textpane.dirty == true)
            {
                textpane.SavePane(txtbox.Text);
            }

            if (rtfpane.dirty == true)
            {
                rtfpane.SavePane(rtfbox.Rtf);
            }

            MessageBox.Show("All documents are saved.");
        }

        // Detect changes in the textbox via dirty command
        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            textpane.Changed(true);
        }

        // Detect changes in the rtfbox via dirty command
        private void rtfbox_TextChanged(object sender, EventArgs e)
        {
            rtfpane.Changed(true);
        }

        // PLUGIN for word count
        private void wordCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtbox.Focused)
            {
                textpane.Count(txtbox.Text);
            }

            if (rtfbox.Focused)
            {
                rtfpane.Count(rtfbox.Text);
            }
        }

        // Closing event to check for unsaved changes before closing
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Check for changes
            textpane.SaveCheck(txtbox.Text);
            rtfpane.SaveCheck(rtfbox.Rtf);
        }

        // Save focused document as new file.
        private void menuFileSaveCurrentAs_Click(object sender, EventArgs e)
        {
            if (txtbox.Focused)
            {
                textpane.SavePaneAs(txtbox.Text);
            }

            if (rtfbox.Focused)
            {
                rtfpane.SavePaneAs(rtfbox.Rtf);
            }
        }
    }
}