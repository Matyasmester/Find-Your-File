using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindYourFile
{
    class ExceptionHandler
    {
        Label OutputLabel;
        public ExceptionHandler(Label OutputLabel)
        {
            this.OutputLabel = OutputLabel;
        }

        //We handle the GeneralException by catching it, 
        //and calling this function to write it out on a label
        public void HandleGeneral(string ErrorMessage)
        {
            OutputLabel.Visible = true;
            OutputLabel.Text = ErrorMessage;
        }
    }
}
