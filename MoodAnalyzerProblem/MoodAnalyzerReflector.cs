using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using MoodAnalyzerProblem;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerReflector
    {
        
        public static object CreatMoodAnalyzer(string className,string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try 
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type MoodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(MoodAnalyseType);
                } catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerClassException("Class not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerClassException("Class not Found");
            }
        }
        public static object CreatMoodAnalyzerParametrized(string className, string constructorName,string massage)
        {
            Type type = typeof(CheckMood2);

            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo C = type.GetConstructor(new[] { typeof(string) });
                    object instance = C.Invoke(new object[] { massage });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzerMethodException("constructor not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerClassException("Class not Found");
            }
        }

        public static object InvokeCheckMood2(string message,string methodName)
        {
            try
            {
                Type type1 = Type.GetType("MoodAnalyzerProblem.CheckMood2");
                object obj = MoodAnalyzerReflector.CreatMoodAnalyzerParametrized("MoodAnalyzerProblem.CheckMood2", "CheckMood2", message);
                MethodInfo MoodInfo = type1.GetMethod(methodName);
                object mood = MoodInfo.Invoke(obj, null);
                return mood.ToString();
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyzerMethodException("no such method");
            }
        }

    }
}
