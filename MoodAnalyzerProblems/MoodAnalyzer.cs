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
           
            try
            {
                if (message == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.INVALID_MOOD, "message is Null");
                }
                if (message.ToLower().Contains("happy"))
                {
                    return "Happy";
                }
                else
                {
                    return "Sad";
                }
            }
            catch (Exception)
            { 
            throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.INVALID_MOOD,"message is Null");
            }
           
        }
    }
}