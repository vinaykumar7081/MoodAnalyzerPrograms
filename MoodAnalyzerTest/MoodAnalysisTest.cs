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
            moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
        }
        [TestMethod]
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Sad()
        {
            var result = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(result,"Sad");
        }
    }
}