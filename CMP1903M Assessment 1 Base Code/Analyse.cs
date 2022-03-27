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
        public List<int> AnalyseText(string input)
        {
            //List of integers to hold the first five measurements:

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
            int sentence = 0;
            var sentenceSeparater = new List<char> { '!', ',', '?', '.' };
            for (int i = 0; i < input.Length; i++)
            {
                if (sentenceSeparater.Contains(input[i]))
                {
                    sentence++;
                }
            }
            values[0] = sentence;
            // Vowel checker
            int vowel = 0;
            var vowelList = new List<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
            for (int i = 0; i < input.Length; i++)
            {
                if (vowelList.Contains(input[i]))
                    {
                    vowel++;
                    }
            }
            values[1] = vowel;

            // Consonants checker
            int consonant = 0;
            var consonantList = new List<char> {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z', 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
            for(int i = 0; i< input.Length; i++)
            {
                if (consonantList.Contains(input[i]))
                {
                    consonant++;
                }
            }
            values[2] = consonant;

            // Upper case checker
            int upper = 0;
            for(int i = 0; i<input.Length; i++)
            {
                if(char.IsUpper(input[i]))
                {
                    upper++;
                }
            }
            values[3] = upper;

            // Lower case checker
            int lower = 0;
            for (int i = 0; i<input.Length; i++)
            {
                if(char.IsLower(input[i]))
                {
                    lower++;
                }
            }
            values[4] = lower;
            return values;

            //Long word checker

        }
            
        
    }
}
