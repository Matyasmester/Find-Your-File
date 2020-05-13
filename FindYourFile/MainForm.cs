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
            //Check if the given drive is valid
            master.CheckForDriveInputErrors(DriveSelectBox, DriveErrorLabel);

            //If there were errors, dont go further
            if (DriveErrorLabel.Visible) return;    

            //Set up some controls 
            label3.Visible = true;
            ResultBox.Visible = true;
            CopyButton.Visible = true;

            //We set the directory to the selected drive's root
            root = new DirectoryInfo(DriveSelectBox.Text);

            //And we begin the search
            ResultBox.Text = master.SearchForFile(root, InputBox.Text);
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

    }
}
