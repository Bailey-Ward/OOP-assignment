using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            List<int> analysis = new list<int>();
            //1. Number of sentences
            
            //2. Number of vowels

            //3. Number of consonants

            //4. Number of upper case letters

            //5. Number of lower case letters

            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            // Sentence checker
            string[] sentence = input.Split(".","?","!");
            Console.WriteLine("There are" + (sentence.Length-1) + "sentences in the text");
            values[0] = (sentence.Length-1);

            // Vowel checker
            int vowel = 0;
            var vowelList = new List<char> {"a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            for (int i = 0; i < input.Length; i++)
            {
                if (vowelList.Contains(input[i])
                    {
                    vowel++;
                    }
            }
            // Consonants checker
            int consonant = 0;
            var consonantList = new List<char>();
            // Upper case checker
            int upper = 0;
            // Lower case checker
            int lower = 0;

            return values;
        }
    }
}
