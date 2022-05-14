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
        [DataRow(" ", "message is Empty")]
        [DataRow(null, "message is null")]
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Null( string input,string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is null");
            }
        }
        [TestMethod]
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Empty(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is Empty");
            }
        }
        [TestMethod]
        public void  GivenMoodAnalysisClassName_ShouldReturnMoodAnalysisObject()
        {
            object expected = new MoodAnalyzer();
            object obj = MoodAnalyseFactory.CreateMoodAnalysis("MoodAnalyzerProblems.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
        [TestMethod]
        public void GivenMoodAnalysisClassName_ShouldReturnMoodAnalysisObject_UsingparameterizedConstructor()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblems.MoodAnalyzer", "MoodAnalyzer","HAPPY");
            expected.Equals(obj);
        }
    }
}