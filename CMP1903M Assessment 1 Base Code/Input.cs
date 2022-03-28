using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        
        //Handles the text input for Assessment 1
        List<string> textList = new List<string>();
        string text = "";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public List<string> ManualTextInput()
        {
            
            //Do While loop to keep taking input until an "*" is entered
            do
            {
                Console.WriteLine("Enter a sentence or press * to finish: ");
                text = Console.ReadLine();
                Console.WriteLine("\n");
                this.textList.Add(text);
                
            }
            while (!text.EndsWith("*"));
            return textList;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        
        public List<string> FileTextInput()
        {
            //Try Catch to handle any errors relating to file location
            try
            {
                string text = File.ReadAllText("textAnalysis.txt");
                this.textList.Add(text);
                return textList;
            }
            catch
            {
                Console.WriteLine("File could not be found");
                Environment.Exit(0);
                return null;
            }
        }

    }
}
