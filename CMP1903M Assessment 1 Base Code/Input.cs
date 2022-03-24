using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {

        //Handles the text input for Assessment 1
        string text = "nothing";
        Report textReport = new Report();

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public List<string> ManualTextInput()
        {

            Console.WriteLine("Enter a sentence or press * to finish: ");
            text = Console.ReadLine();
            Console.WriteLine("\n");
            return text;

        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string FileTextInput(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                textInput = reader.ReadToEnd();
            }
            return textInput;
        }

    }
}
