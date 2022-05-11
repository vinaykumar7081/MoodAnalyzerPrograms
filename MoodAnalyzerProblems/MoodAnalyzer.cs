namespace MoodAnalyzerProblems
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}