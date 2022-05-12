using NUnit.Framework;
using System;
using UserRegistrationProblems;

namespace UserValidationTest
{
    public class Tests
    {
        
        [Test]
        public void InputInString_CheckingValidationFor_FirstName()
        {
            Validation input = new Validation();
             bool result = input.Validate_FirstName("Vinay");
            Assert.IsTrue(result);
        }
        [Test]
        public void InputInString_CheckingValidationFor_LastName()
        {
            Validation input = new Validation();
            bool result = input.Validate_LastName("Kumer");
            Assert.IsTrue(result);
        }
    }
}