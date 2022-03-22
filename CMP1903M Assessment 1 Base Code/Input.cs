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
        string text = " ";
        List<string> textInput = new List<string>();

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public List<string> ManualTextInput()
        {
            do
            {
                Console.WriteLine("Enter a sentence or press * to finish: ");
                text = Console.ReadLine();
                if (text == "")
                {
                    Console.WriteLine("You forgot to enter the sentence!");
                }
                else
                {
                    this.textInput.Add(text);
                }
            }
            while (text.EndsWith("*"));
            return textInput;
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
