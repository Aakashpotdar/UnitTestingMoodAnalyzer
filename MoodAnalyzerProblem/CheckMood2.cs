using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class CheckMood2
    {
        public string Mood;
        public CheckMood2(string Mood)
        {
            this.Mood= Mood;
        }
        public string CheckCurrentMood()
        {
            try
            {
                if (Mood != "")
                {
                    if (Mood.Equals("null"))
                    {

                        throw new MoodAnalyzerNullMoodException("Enter Mood");
                        
                    }
                    else if (Mood.Equals("I am in good mood"))
                    {
                        return "Happy Mood";
                    }
                    else if (Mood.Equals("I am in sad mood"))
                    {
                        return "Sad Mood";
                    }
                    else
                    {
                        return "No such Mood";
                    }
                }
                else
                {
                    throw new MoodAnalyzerException(Mood);
                }
            }
            catch (MoodAnalyzerException)
            {
                return "Happy";
            }
        }
    }
}
