using System.Text.RegularExpressions;

namespace UserRegistrationProblems
{
    public class Validation
    {
        public const string NAME_REGEX = @"^[A-Z]{1}[A-Za-z]{3, }$";
        public const string EMAILADDRESS_REGEX = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([azA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public const string MOBILENUMBER_REGEX =@"^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public const string EMAILPASSWORD_REGEXX = "[A-Za-z]{8, }$";
        public const string EMAILPASSWORD_MINIMUMONEUPPWRCASE_REGEXX = "[A-Z]{1, }[A-Za-z]{8, }$";
        public const string EMAILPASSWORD_MINIMUMONEUPPWRCASE_AtLEastOneNumeric_REGEXX = "[A-Z]{1, }[A-Za-z]{8, }[0-1]{1, }$";
        public const string EMAILPASSWORD_MINIMUMONEUPPWRCASE_AtLEastOneNumeric_OneSpecialCharcter_REGEXX = "[A-Z]{1, }[A-Za-z]{8, }[0-1]{1, }[!@#$%^&.]{1}$";
        public string Validate_FirstName(string firstName)
        {
            try
            {
                if ((Regex.IsMatch(firstName, NAME_REGEX))==false) ;
                {
                    throw new CustomException(CustomException.ExceptionType.FIRST_NAME, "Please Enter valid Name number of Character minimum three");
                }
                if ((Regex.IsMatch(firstName, NAME_REGEX))==true) ;
                {
                    Console.WriteLine("First Name is Valid for the user Account:" + firstName);
                    return firstName;
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.FIRST_NAME, "Please Enter valid Name number of Character minimum three");
            }
        }
        public string Validate_LastName(string lastName)
        {
            try
            {
                if ((Regex.IsMatch(lastName, NAME_REGEX)) == false) ;
                {
                    throw new CustomException(CustomException.ExceptionType.LAST_NAME, "Please Enter valid Name number of Character minimum three");
                }
                if ((Regex.IsMatch(lastName, NAME_REGEX))==true) ;
                {
                    Console.WriteLine("Last Name is Valid for the user Account:" + lastName);
                    return lastName;
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.LAST_NAME, "Please Enter valid Name number of Character minimum three");
            }
        }
        public string Validate_EmailAddress(string emailAddress)
        {
            try
            {
                if((Regex.IsMatch(emailAddress, NAME_REGEX))==false) ;
                {
                    throw new CustomException(CustomException.ExceptionType.EMAIL_ADDRESS, "Please Enter the Vailid Email Address");
                }
                if ((Regex.IsMatch(emailAddress, EMAILADDRESS_REGEX))==true) ;
                {
                    Console.WriteLine("Email Address is Valid for the user Account:" + emailAddress);
                    return emailAddress;
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.EMAIL_ADDRESS, "Please Enter the Vailid Email Address");
            }
        }
        public string Validate_MobileNumber(string mobileNumber)
        {
            try
            {
                if ((Regex.IsMatch(mobileNumber, MOBILENUMBER_REGEX)) == false) ;
                {
                    throw new CustomException(CustomException.ExceptionType.MOBILE_NUMBER, "Please Enter the Vailid Mobile Number");
                }
                if ((Regex.IsMatch(mobileNumber, MOBILENUMBER_REGEX))==true) ;
                {
                    Console.WriteLine("Mobile Number is Valid for the user Account:" + mobileNumber);
                    return mobileNumber;
                }
            }
            catch (CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.MOBILE_NUMBER, "Please Enter the Vailid Mobile Number");
            }
           
        }
        public string Validate_EmailAddressPassword(string password)
        {
            try
            {
                if ((Regex.IsMatch(password, EMAILADDRESS_REGEX)) == false) ;
                {
                    throw new CustomException(CustomException.ExceptionType.PASSWORD, "Please Enter the Vailid Password");
                }
                if ((Regex.IsMatch(password, EMAILADDRESS_REGEX))==true) ;
                {
                    Console.WriteLine("Email Address Password is Valid for the user Account:" + password);
                    return password;
                }
            }
           catch(CustomException)
            {
                throw new CustomException(CustomException.ExceptionType.PASSWORD, "Please Enter the Vailid Password");
            }
        }
    }
}