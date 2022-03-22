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
            
            Input option = new Input();
            bool Menu = true;
            while (Menu)
            {
                Menu = MainMenu(option);
            }


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }

        private static bool MainMenu(Input option)
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("Type 1 to select keyboard input:\n Type 2 to read from text file:\n Type 3 to exit the program:");

            switch (Console.ReadLine())
            {
                case "1":
                    textList = option.ManualTextInput();
                    foreach (string s in textList)
                    {
                        Console.WriteLine(s);
                    }
                    break;
                case "2":
                    option.FileTextInput("Filename");
                    break;
                case "3":
                    break;
            }

        }



    }
}
