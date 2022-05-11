﻿namespace MoodAnalyzerProblems
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
                if(message == null)
                { 
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "Message is Empty");
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
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD, "Message is Empty");
            }
           
        }
    }
}