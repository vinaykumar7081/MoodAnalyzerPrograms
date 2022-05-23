using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblems
{
    public class CustomException:Exception
    {
        public enum ExceptionType
        {
            FIRST_NAME, LAST_NAME, EMAIL_ADDRESS, MOBILE_NUMBER,PASSWORD
        }
        public ExceptionType exceptionType;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }

    }
}
