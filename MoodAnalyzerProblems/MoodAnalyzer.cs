namespace MoodAnalyzerProblems
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)
        { 
        this.message = message;
        }
        public string AnalyzeMood()
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