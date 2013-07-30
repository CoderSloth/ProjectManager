using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProjectManager
{
    public class Pane
    {
        public bool loaded;
        public bool dirty;
        public string title;
        public string ext;
        public string filter;
        public string filelocation;
        public int wordcount = 0;

        // Properties for all Panes
            // Title of file
            // Whether it's been loaded
            // Whether changes have been made
            // File extension (assigned by Pane type)
            // Filter for saving (assigned by Pane type)
            // Location of file if it's been loaded

        public Pane()
        {
            title = "Untitled";
            loaded = false;
            dirty = false;
            ext = "";
            filter = "";
            filelocation = null;
        }

        // Set title of the Pane
        public void SetTitle(string newTitle)
        {
            title = newTitle;
        }

        public void SetFileLocation(string filename)
        {
            filelocation = filename;
        }

        // Set load status of the pane when document is imported or cleared
        public void Loaded(string status)
        {
            if (status == "yes")
            {
                loaded = true;
            }
            if (status == "no")
            {
                loaded = false;
            }
        }

        // Toggle dirty variable based on edit status
        public void Changed(bool dirt)
        {
            dirty = dirt;
            
        }

        // Set extension of the pane, determined by load type
        public void Extension(string extension)
        {
            ext = extension;
        }

        // Save file dialog method.
            // SAVE --> loaded documents
            // SAVE AS --> new documents
        public void SavePane(string contents)
        {
            // Document han't been loaded, edits have been made. Save as new file.
            if (loaded == false && dirty == true)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save " + title + "." + ext;
                save.Filter = filter;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(save.FileName, contents);
                }
            }

            // Document has been loaded, edits have been made. Save to existing file.
            if (loaded == true && dirty == true)
            {
                StreamWriter sw = new StreamWriter(filelocation);
                sw.WriteLine(contents);
                sw.Close();
            }

            // Changes have been saved.
            Changed(false);
        }

        // Save the focused pane as new document regardless of load state.
        public void SavePaneAs(string contents)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save " + title + "." + ext;
            save.Filter = filter;

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, contents);
            }

            // Changes have been saved.
            Changed(false);
        }

        // Check for unsaved changes, prompt user to save if necessary
        public void SaveCheck(string contents)
        {
            if (dirty == true)
            {
                DialogResult dr = MessageBox.Show("Save changes to " + title + "." + ext + " before closing?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    SavePane(contents);
                }
            }
        }

        // Word count method
        public void Count(string contents)
        {
                string text = contents.Trim();
                wordcount = 0; // always start counting from zero
                int index = 0;

                while (index < text.Length)
                {
                    // check if current char is part of a word
                    while (index < text.Length && Char.IsWhiteSpace(text[index]) == false)
                        index++; // move to next character

                    wordcount++; // increase the wordcount by one

                    // skip whitespace until next word
                    while (index < text.Length && Char.IsWhiteSpace(text[index]) == true)
                        index++; // move to next character
                }

                if (wordcount > 0)
                {
                    // if there are words, show the count
                    MessageBox.Show("Word Count for " + title + "\ris " + wordcount + ".", "Word Count");
                }

                else
                {
                    // if no words were counted, tell the user
                    MessageBox.Show("There are no words.");
                }
            
        }

    } // end of Pane assignments

        // Text pane specifics (extension and file saving filter)
        public class Text : Pane
        {
            public Text()
            {
                ext = "txt";
                filter = "Text Files (txt)|*.txt";
            }
        }
        
        // Rich text pane specifics (extension and file saving filter)
        public class Richtext : Pane
        {
            public Richtext()
            {
                ext = "rtf";
                filter = "Rich Text Files (rtf)|*.rtf";
            }
        }
}
