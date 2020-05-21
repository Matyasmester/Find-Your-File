using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FindYourFile
{
    public partial class MainForm : Form
    {
        readonly Master master = new Master();
        DirectoryInfo root;

        public MainForm()
        {
            InitializeComponent();
            StartButton.Enabled = false;
            DriveSelectBox.DataSource = master.GetAllDrives();
        }
        
        private void Label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            //Check if the filename is valid
            //If it isnt, why search?
            master.CheckForFileNameErrors(InputBox, ErrorLabel, StartButton);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string filename = InputBox.Text;
            //Check if the given drive is valid
            master.CheckForDriveInputErrors(DriveSelectBox, DriveErrorLabel);

            //If there were errors, dont go further
            if (DriveErrorLabel.Visible) return;

            //Set up some controls 
            label3.Visible = true;
            ResultBox.Visible = true;
            CopyButton.Visible = true;
            PathOpenButton.Visible = true;

            //We set the directory to the selected drive's root
            root = new DirectoryInfo(DriveSelectBox.Text);

            //And we begin the search
            string result = master.SearchForFile(root, filename);
            ResultBox.Text = result;

            //If the file was not found, we disable the "Open in Explorer" button
            if (result.Equals("File not found.")) PathOpenButton.Enabled = false;

            //If the user ticked the "Auto open in File Explorer", we do it
            if (AutoOpenBox.Checked) OpenPath(result, filename);
        }

        private void DriveSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear the error message
            DriveErrorLabel.Visible = false;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            //Copy the result to the clipboard
            Clipboard.SetText(ResultBox.Text);
            label4.Visible = true;
        }

        private void AutoOpenBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PathOpenButton_Click(object sender, EventArgs e)
        {
            OpenPath(ResultBox.Text, InputBox.Text);
        }

        private void OpenPath(string path, string fname)
        {
            //We dont go further if the search gave no results
            if (path.Equals("File not found.")) return;
            int index = path.IndexOf(fname);
            int len = fname.Length;

            //We remove the filename because otherwise it will run/open the file itself
            string PathWithoutFilename = path.Remove(index, len);
            master.OpenInExplorer(PathWithoutFilename);
        }
    }
}
