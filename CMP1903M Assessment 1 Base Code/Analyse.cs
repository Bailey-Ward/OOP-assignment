using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text
        //encapsulation used here
        private void LongWordChecker(List<String> sentences)
        {
            List<String> longWords = new List<string>();
            foreach (string sentence in sentences)
            {
                string cleanSentences = Regex.Replace(sentence, "[^A-Za-z0-9 ]", "");
                string[] words = cleanSentences.Split(' ');
                foreach (string word in words) { if (word.Count() >= 7) { longWords.Add(word); } }
            }
            string fileName = System.AppContext.BaseDirectory + "long_words.txt";

            //error handling used below
            try
            {
                // Performs a check to see if the file containing long words already exists, if it does it deletes it    
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Creates the new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Adds the long words to the created file
                    foreach (string longWord in longWords)
                    {
                        Byte[] title = new UTF8Encoding(true).GetBytes(longWord + ", ");
                        fs.Write(title, 0, title.Length);
                    }
                }
                Console.WriteLine($"{fileName} has been created.");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> AnalyseText(List<string> input)
        {
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            string words = "";

            foreach(string s in input)
            {
                words+= s;
            }

            // Sentence checker
            int sentence = 0;
            var sentenceSeparater = new List<char> { '!', ',', '?', '.' };
            for (int i = 0; i < words.Length; i++)
            {
                if (sentenceSeparater.Contains(words[i]))
                {
                    sentence++;
                }
            }
            values[0] = sentence;

            // Vowel checker
            int vowel = 0;
            var vowelList = new List<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
            for (int i = 0; i < words.Length; i++)
            {
                if (vowelList.Contains(words[i]))
                    {
                    vowel++;
                    }
            }
            values[1] = vowel;

            // Consonants checker
            int consonant = 0;
            var consonantList = new List<char> {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z', 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
            for(int i = 0; i< words.Length; i++)
            {
                if (consonantList.Contains(words[i]))
                {
                    consonant++;
                }
            }
            values[2] = consonant;

            // Upper case checker
            int upper = 0;
            for(int i = 0; i<words.Length; i++)
            {
                if(char.IsUpper(words[i]))
                {
                    upper++;
                }
            }
            values[3] = upper;

            // Lower case checker
            int lower = 0;
            for (int i = 0; i<words.Length; i++)
            {
                if(char.IsLower(words[i]))
                {
                    lower++;
                }
            }
            values[4] = lower;
            LongWordChecker(input);
            return values;

            
            

        }
            
        
    }
}
