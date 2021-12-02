using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerException:Exception
    {
        public MoodAnalyzerException(string Mood):base(string.Format("Invalid Mood is enterd")) {  }
    
    }
    public class MoodAnalyzerClassException : Exception
    {
        public MoodAnalyzerClassException(string Massage) : base(string.Format("Class not found Exception")) { }

    }
    public class MoodAnalyzerMethodException : Exception
    {
        public MoodAnalyzerMethodException(string Massage) : base(string.Format("no such Constructor or method not found Exception")) { }

    }
    public class MoodAnalyzerNullMoodException : Exception
    {
        public MoodAnalyzerNullMoodException(string Massage) : base(string.Format("Mood Null Exception")) { }

    }

}
