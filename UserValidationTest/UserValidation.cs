using NUnit.Framework;
using System;
using UserRegistrationProblems;

namespace UserValidationTest
{
    public class Tests
    {
        Validation input = new Validation();
        [Test]
        public void InputInString_CheckingValidationFor_FirstName()
        {
             bool result = input.Validate_FirstName("Vinay");
            Assert.IsTrue(result);
        }
        [Test]
        public void InputInString_CheckingValidationFor_LastName()
        {
            bool result = input.Validate_LastName("Kumer");
            Assert.IsTrue(result);
        }
        [Test]
        public void InputInString_CheckingValidationFor_EmailOfUser()
        {
            bool result = input.Validate_EmailAddress("abc.xyz@gmail.co.in");
            Assert.IsTrue(result);
        }
        [Test]
        public void InputInString_CheckingValidationFor_MobileNumber()
        {
            bool result = input.Validate_MobileNumber("+91 7081209335");
            Assert.IsTrue(result);
        }
        [Test]
        public void InputInString_CheckingValidationFor_EmailPassword()
        {
            string result = input.Validate_EmailAddressPassword_AtLeastOneUpperCase("AbvBabshsbchjcg");
            Assert.AreEqual("AbvBabshsbchjcg", result);
        }
    }
}