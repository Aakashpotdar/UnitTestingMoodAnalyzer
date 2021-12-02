using Intuit.Ipp.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using static MoodAnalyzerProblem.MoodAnalyzerException;
using System;
using System.Reflection;

namespace CheckUnitTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckTheMood()
        {
            CheckMood obj = new CheckMood("I am in good mood");

            string check=obj.CheckCurrentMood();

            string expected = "Happy Mood";

            Assert.AreEqual(expected, check);
            
        }
        [TestMethod]
        public void CheckMoodSad()
        {
            CheckMood obj = new CheckMood("I am in sad mood");

            string check = obj.CheckCurrentMood();

            string unexpected = "Sad Mood";

            Assert.AreEqual(unexpected, check);
        }
        [TestMethod]
        public void CheckMoodHappy()
        {
            CheckMood obj = new CheckMood(null);

            string check = obj.CheckCurrentMood();

            string expected = "Happy";

            Assert.AreEqual(expected, check);

        }
        [TestMethod]
        public void CheckMoodThrowNullMoodException()
        {
            CheckMood1 obj = new CheckMood1(null);

            string check = obj.CheckCurrentMood();
            if (check == null)
            {
                throw new MoodAnalyzerException(check);
            }
            string expected = "Happy";
            Assert.AreEqual(expected, check);
        }
        [TestMethod]
        public void CheckMoodCostomizedException()
        {
            CheckMood2 obj = new CheckMood2("");

            string check = obj.CheckCurrentMood();
            if (check == "")
            {
                throw new MoodAnalyzerException(check);
            }
            string expected = "Happy";
            Assert.AreEqual(expected, check);

        }
        [TestMethod]
        public void InvokeClassObject()
        {  
            object expected = new CheckMood1();

            object obj = MoodAnalyzerReflector.CreatMoodAnalyzer("MoodAnalyzerProblem.CheckMood1","CheckMood1");
            expected.Equals(obj);
        }
        [TestMethod]
        public void InvokeParametrisedConstructorClass()
        {
            object expected = new CheckMood1("Happy");

            object obj = MoodAnalyzerReflector.CreatMoodAnalyzerParametrized("MoodAnalyzerProblem.CheckMood2", "CheckMood2","Happy");
            expected.Equals(obj);
        }

        [TestMethod]
        public void InvokeTheMethodUsingReflection()
        {
            string expected ="Happy Mood";

            String mood = MoodAnalyzerReflector.InvokeCheckMood2("I am in good mood", "CheckCurrentMood").ToString();

            Assert.AreEqual(expected,mood);
        }

        [TestMethod]
        public void ChekingInvalidMoodUsingReflection()
        {
            string expected = "No such Mood";

            String mood = MoodAnalyzerReflector.InvokeCheckMood2("Good", "CheckCurrentMood").ToString();

            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void ChekingNullMoodUsingReflection()
        {
            string expected = "No such Mood";

            var mood = Assert.ThrowsException<MoodAnalyzerNullMoodException>(()=> MoodAnalyzerReflector.InvokeCheckMood2("null", "CheckCurrentMood").ToString());
            Assert.AreEqual(mood.Message, "Mood Null Exception");
        }
    }
}
