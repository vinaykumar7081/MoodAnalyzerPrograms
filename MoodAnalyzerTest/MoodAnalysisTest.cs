using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblems;

namespace MoodAnalyzerTest
{

    [TestClass]
    public class MoodAnalysisTest
    {
        private readonly MoodAnalyzer moodAnalyzer;
        public MoodAnalysisTest()
        {
            moodAnalyzer = new MoodAnalyzer("I am in Happy Mood");
        }
        [TestMethod]
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Happy()
        {
            var result = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(result,"Happy");
        }
    }
}