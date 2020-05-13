using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindYourFile
{
    class GeneralException : Exception
    {
        public string FullErrorMessage;

        //This class is for later, when we add more functionalities,
        //and therefore more opportunities for exceptions

        public GeneralException(string ErrorMessage, string type)
        {
            string FullErrorMessage = "A GeneralException of type " + type + " occurred with message: " + ErrorMessage;
            this.FullErrorMessage = FullErrorMessage;
        }

    }
}
