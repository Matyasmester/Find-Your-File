using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FindYourFile
{
    class Master
    {
        public Master()
        {
            //constructor
        }

        public string[] GetAllDrives()
        {
            return Directory.GetLogicalDrives();
        }

        public string SearchForFile(DirectoryInfo root, string FileName)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;
            String NotFoundMsg = "File not found.";

            // First, process all the files directly under this folder 
            try
            {
                files = root.GetFiles("*.*");
            }
  
            catch (UnauthorizedAccessException)
            {
                //This is so we dont exit early
            }

            catch (DirectoryNotFoundException)
            {
                //Catch these so we dont have to terminate process
            }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    if(fi.Name.Trim().Equals(FileName))
                        //Ignore whitespaces
                    {
                        return fi.FullName;
                    }
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    // Recursive call for each subdirectory.
                    string result = SearchForFile(dirInfo, FileName);

                    //If we did get the file, return the path and stop
                    if (result.Equals(NotFoundMsg) == false)
                    {
                        return result;
                    }
                }
            }  
            return NotFoundMsg;
        }

        public void CheckForFileNameErrors(RichTextBox InputBox, Label ErrorLabel, Button StartButton)
        {
            //If its empty, or has a doublequote in it, disable the button
            if (InputBox.Text == "" || InputBox.Text.Contains('"'))
            {
                ErrorLabel.Visible = true;
                StartButton.Enabled = false;
                return;
            }

            //These characters arent allowed to be in filenames
            char[] ForbiddenChars = @"\/:*?<>|".ToCharArray();
            byte errorflag = 0x00000000;

            //Check for them in the input
            foreach (char c in InputBox.Text)
            {
                if (Array.IndexOf(ForbiddenChars, c) != -1)
                {
                    errorflag = 0x00000001;
                    break;
                }
            }

            //If there were errors, reveal the label
            if (errorflag != 0x00000000) ErrorLabel.Visible = true;
            else { ErrorLabel.Visible = false; }

            //If the label is visible, then disable the button
            if (ErrorLabel.Visible) StartButton.Enabled = false;
            else { StartButton.Enabled = true; }
        }

        public void CheckForDriveInputErrors(ComboBox SelectBox, Label ErrorLabel)
        {

            //We cast the DataSource of the SelectBox to a string array
            string[] source = ((IEnumerable)SelectBox.DataSource).Cast<object>().Select(x => x.ToString()).ToArray();

            //If its empty, obviously we dont go further
            if (SelectBox.Text == "")
            {
                ErrorLabel.Visible = true;
                return;
            }

            //If the user tries to input something other than what is in the selectBox,
            //we dont go further
            if (source.Contains(SelectBox.Text) == false)
            {
                ErrorLabel.Visible = true;
                return;
            }

            //Get information about the given drive
            DriveInfo Drive = new DriveInfo(SelectBox.Text);

            //If the drive is not a valid one (for example, a DVD Drive),
            //then we dont allow it to run 
            if (Drive.IsReady == false || Drive.TotalSize == 0)
            {
                ErrorLabel.Visible = true;
                return;
            }
        }

        public void OpenInExplorer(string path)
        {
            Process.Start(path);
        }
    }
}
