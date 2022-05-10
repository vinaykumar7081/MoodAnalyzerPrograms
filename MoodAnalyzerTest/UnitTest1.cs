using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblems;

namespace MoodAnalyzerTest
{

    [TestClass]
    public class UnitTest1
    {
        private readonly MoodAnalyzer moodAnalyzer;
        public UnitTest1()
        {
            moodAnalyzer = new MoodAnalyzer();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var result = moodAnalyzer.AnalyzeMood("Happy");
            Assert.AreEqual(result,"happy");
        }
    }
}