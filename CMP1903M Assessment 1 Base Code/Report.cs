using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        //Assigns the value from the specified index of the values list to a variable, and then reports the variable to the console
        public int SentenceCounter(List<int>values)
        {
            int sentences =  values[0];
            Console.WriteLine("There are: "+ sentences+ " sentences.");   
            return sentences;

        }

        public int VowelCounter(List<int>values)
        {
            int vowel = values[1];
            Console.WriteLine("There are: " + vowel + " vowels");
            return vowel;
        }

        public int ConsonantCounter(List<int>values)
        {
            int consonant = values[2];
            Console.WriteLine("There are: " + consonant + " consonants");
            return consonant;
        }

        public int UpperCounter(List<int>values)
        {
            int upper = values[3];
            Console.WriteLine("There are: " + upper + " upper case characters."); 
            return upper;
        }

        public int LowerCounter(List<int>values)
        {
            int lower = values[4];
            Console.WriteLine("There are: " + lower + "lower case characters");
            return lower;
        }

    }
}
