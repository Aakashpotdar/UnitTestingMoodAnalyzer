using System;

namespace MoodAnalyzerProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string expected = "Happy";

            String mood = MoodAnalyzerReflector.InvokeCheckMood2("Happy", "CheckCurrentMood").ToString();

        }
    }
}
