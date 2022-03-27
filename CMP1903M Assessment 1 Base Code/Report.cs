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
        public int SentenceCounter(List<int>values)
        {
            int sentences =  values[0];
            return sentences;
        }

        public int VowelCounter(List<int>values)
        {
            int vowel = values[1];
            return vowel;
        }

        public int ConsonantCounter(List<int>values)
        {
            int consonant = values[2];
            return consonant;
        }

        public int UpperCounter(List<int>values)
        {
            int upper = values[3];
            return upper;
        }

        public int LowerCounter(List<int>values)
        {
            int lower = values[4];
            return lower;
        }
    }
}
