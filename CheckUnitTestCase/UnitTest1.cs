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
        public void TestMethod1()
        {
            CheckMood obj = new CheckMood("I am in good mood");

            string check=obj.CheckCurrentMood();

            string expected = "Happy Mood";

            Assert.AreEqual(expected, check);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            CheckMood obj = new CheckMood("I am in sad mood");

            string check = obj.CheckCurrentMood();

            string unexpected = "Sad Mood";

            Assert.AreEqual(unexpected, check);
        }
        [TestMethod]
        public void TestMethod3()
        {
            CheckMood obj = new CheckMood(null);

            string check = obj.CheckCurrentMood();

            string expected = "Happy";

            Assert.AreEqual(expected, check);

        }
        [TestMethod]
        public void TestMethod4()
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
        public void TestMethod5()
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
    }
}
