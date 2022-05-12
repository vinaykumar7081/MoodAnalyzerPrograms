using System.Text.RegularExpressions;

namespace UserRegistrationProblems
{
    public class Validation
    {
        public const string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3, }$";
        public const string EMAILADDRESS_REGEX = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([azA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public const string MOBILENUMBER_REGEX = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public bool Validate_FirstName(string name)
        {
            if (Regex.IsMatch(name, NAME_REGEX)) ;
            {
                Console.WriteLine("First Name is Valid for the user Account:" + name);
                return true;
            }
        }
        public bool Validate_LastName(string name)
        {
            if (Regex.IsMatch(name, NAME_REGEX)) ;
            {
                Console.WriteLine("Last Name is Valid for the user Account:" + name);
                return true;
            }
        }
        public bool Validate_EmailAddress(string emailAddress)
        {
            if (Regex.IsMatch(emailAddress, EMAILADDRESS_REGEX)) ;
            {
                Console.WriteLine("Email Address is Valid for the user Account:" + emailAddress);
                return true;
            }
        }
        public bool Validate_MobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, MOBILENUMBER_REGEX)) ;
            {
                Console.WriteLine("Mobile Number is Valid for the user Account:" + mobileNumber);
                return true;
            }
        }
    }
}