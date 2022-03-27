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
            
            Input inputText = new Input();
            Report report = new Report();
            Analyse analyse = new Analyse();
            while (true)
            {
                Console.Clear();
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
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, enter a number between 1 and 3:");
                    continue;
                }
            }

            int sentenceCounter = report.SentenceCounter(values);
            int vowelCounter = report.VowelCounter(values);
            int consonantCounter = report.ConsonantCounter(values);
            int upperCounter = report.UpperCounter(values);
            int lowerCounter = report.LowerCounter(values);

            Console.WriteLine("There are: "+ sentenceCounter + " sentences." );
            Console.WriteLine("There are: "+ vowelCounter + " vowels.");
            Console.WriteLine("There are: "+ consonantCounter + " consonants.");
            Console.WriteLine("There are: "+ upperCounter + " upper case characters.");
            Console.WriteLine("There are: "+ lowerCounter + " lower case characters");

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }




    }
}
