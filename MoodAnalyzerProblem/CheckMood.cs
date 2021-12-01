using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class CheckMood
    {


        public string Mood=null;
        public CheckMood(string Mood)
        {
            this.Mood = Mood;
        }
        public string CheckCurrentMood()
        {
            try
            {
                if (Mood.Equals("I am in good mood"))
                {
                    return "Happy Mood";
                }
                else if (Mood.Equals("I am in sad mood"))
                {
                    return "Sad Mood";
                }
            }
            catch (Exception e)
            {
                return "Happy";
            }
            return "";
        }
    }
    }