using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblems
{
    public class MoodAnalysisException:Exception
    {
        public enum ExceptionType
        { 
        INVALID_MOOD
        }
        public ExceptionType exceptionType;
        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        { 
        this.exceptionType = type;
        }
    }
}
