using NUnit.Framework;
using System;
using System.Collections.Generic;
using UserRegistrationProblems;

namespace UserValidationTest
{
    public class Tests
    {
        List<string> list=new List<string>();
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
        [Test]
        public void InputInString_CheckingValidationFor_EmailPassword_MinimumOneUpperCase_MinimumoneNumeric()
        {
            string result = input.Validate_EmailAddressPassword_AtLeastOneUpperCase_AtLEastOneNumeric("AbvBabshsbchjcg451");
            Assert.AreEqual("AbvBabshsbchjcg451", result);
        }
        [Test]
        public void InputInString_CheckingValidationFor_EmailPassword_MinimumOneUpperCase_MinimumoneNumeric_OneSpecialCharacter()
        {
            string result = input.Validate_EmailAddressPassword_AtLeastOneUpperCase_AtLEastOneNumeric_ExactlyOneSpecialCharcter("AbvBabshsbchjcg451&");
            Assert.AreEqual("AbvBabshsbchjcg451&", result);
        }
        [Test]
        public void InputInString_CheckingValidationFor_EmailAddress()
        {
            string result = input.Validate_EmailAddress_PossiblesEmails("abc-100@yahoo.com,");
            Assert.AreEqual("abc-100@yahoo.com,", result);
        }
        [Test]
        [TestCase("ajay123@gmail.com")]
        [TestCase("vijay155@gmail.com")]
        [TestCase("arun1454@gmail.com")]
        [TestCase("ajay123@gmail")]
        public void InputInString_CheckingValidationFor_EmailAddress_ParameterizedTest(string emailAddress)
        {
            
               string result = input.Validate_EmailAddress_PossiblesEmails(emailAddress);
                Assert.AreEqual(emailAddress, result);
           
        }
    }
}