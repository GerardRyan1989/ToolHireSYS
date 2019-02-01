using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolHireSYS
{

    //instance variables
   

    class Validation
    {
        private string errorMessage = "";


        public Validation()
        {

        }

        public Boolean ValidateTool(Tools myTool, string txtPrice)
        {
            Boolean result = true;
           

            if (string.IsNullOrWhiteSpace(myTool.getModel()))
            {
                errorMessage += "Please enter a Valid Model\n\n";
                result = false;

            }

            if (string.IsNullOrWhiteSpace(myTool.getDescription()))
            {
                errorMessage += "Please enter a Valid Description \n\n";
                result = false;

            }


           
                try
                {
                    double price = Convert.ToDouble(txtPrice);
                }
                catch (FormatException)
                {
                   errorMessage += "please enter a valid Price";
                    result = false;
                }
            


            return result;

        }
        public string getErrorrMessage()
        {
            return errorMessage;
        }
    }


    
}
