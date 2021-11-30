using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class CheckMood1
    {
        public string Mood;
        public CheckMood1(string Mood)
        {
            this.Mood = Mood;
        }

        public string CheckCurrentMood()
        {
            try
            {
                if (Mood == null)
                {
                    throw new MoodAnalyzerException(Mood);
                }
                else if (Mood.Equals("I am in good mood"))
                {
                    return "Happy Mood";
                }
                else if (Mood.Equals("I am in sad mood"))
                {
                    return "Sad Mood";
                }
            }
            catch(MoodAnalyzerException e)
            {
                return "Happy";
            }
            return "";
        }
    }
}
