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
            moodAnalyzer = new MoodAnalyzer("");
        }
        [TestMethod]
        [DataRow("", "message is Empty")]
        [DataRow(null, "message is null")]
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Happy( string input,string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(ex.Message, "message is Empty");
            }
            
        }
    }
}