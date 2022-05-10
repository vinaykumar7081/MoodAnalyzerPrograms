namespace MoodAnalyzerProblems
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string message)
        {
            if (message.ToLower().Equals("happy"))
            {
                return "happy";
            }
            else 
            {
                return "sad";
            }
           
        }
    }
}