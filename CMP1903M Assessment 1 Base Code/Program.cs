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
            List<int> parameters = new List<int>();
            List<string> textList;

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            
            Input input = new Input();
            Report report = new Report();
            Analyse analyse = new Analyse();
            string emptyString ="";

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("Type 1 to select keyboard input:\n Type 2 to read from text file:\n Type 3 to exit the program:");
                string choice = Console.ReadLine();
                if(choice == "1")
                {
                    Console.WriteLine("Enter the text to be analysed:");
                    Input.manualTextInput();
                }
                else if(choice == "2")
                {
                    Console.WriteLine("Enter the file path here:");
                    emptyString = Input.FileTextInput(Console.ReadLine());
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, enter a number between 1 and 3:")
                    continue;
                }
            }


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }




    }
}
