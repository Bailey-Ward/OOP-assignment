//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> values = null;


            //Create 'Input' object
            //Get either manually entered text, or text from a file

            // New Objects created below
            Input inputText = new Input();
            Report report = new Report();
            Analyse analyse = new Analyse();

            //Main menu
            //Takes user input to determine which type of analysis is required
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("Type 1 to select keyboard input:\n Type 2 to read from text file:\n Type 3 to exit the program:");
                string choice = Console.ReadLine();
                List<string> emptyString;
                if (choice == "1")
                {
                    Console.WriteLine("Enter the text to be analysed:");
                    emptyString = inputText.ManualTextInput();
                    values = analyse.AnalyseText(emptyString);
                    break;
                }
                else if (choice == "2")
                {
                    emptyString = inputText.FileTextInput();
                    values = analyse.AnalyseText(emptyString);
                    break;
                }
                else if (choice == "3")
                {
                    //environment change here was added based on code review suggestion 
                    Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, enter a number between 1 and 3:");
                    continue;
                }
            }
            //methods from the report class are called here to report the analysis data
            report.SentenceCounter(values);
            report.VowelCounter(values);
            report.ConsonantCounter(values);
            report.UpperCounter(values);
            report.LowerCounter(values);
        }
    }
}

