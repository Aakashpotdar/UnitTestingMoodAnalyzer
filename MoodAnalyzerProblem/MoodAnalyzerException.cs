using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerException:Exception
    {
        public MoodAnalyzerException(string Mood):base(string.Format("Invalid Mood is enterd")) {  }
    
    
    
      //  public MoodAnalyzerException(string Mood) : base(string.Format("Invalid Mood is enterd")) { }
    }
}
