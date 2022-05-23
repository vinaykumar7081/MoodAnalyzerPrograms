using NUnit.Framework;
using System;
using System.Collections.Generic;
using UserRegistrationProblems;

namespace UserValidationTest
{
    public class Tests
    {
        Validation input = new Validation();
        [Test]
        public void InputInString_CheckingValidationFor_FirstName()
        {
            try
            {
                string result = input.Validate_FirstName("Vinay");
                Assert.AreEqual(result, "Vinay");
            }
            catch (CustomException ex)
            { 
            Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputInString_CheckingValidationFor_LastName()
        {
            try
            {
                string result = input.Validate_LastName("Kumar");
                Assert.AreEqual(result, "Kumar");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputInString_CheckingValidationFor_EmailOfUser()
        {
            try
            {
                string result = input.Validate_EmailAddress("abc.xyz@gmail.co.in");
                Assert.AreEqual(result, "abc.xyz@gmail.co.in");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputInString_CheckingValidationFor_MobileNumber()
        {
            try
            {
                string result = input.Validate_MobileNumber("+91 7081209335");
                Assert.AreEqual(result, "+91 7081209335");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void InputInString_CheckingValidationFor_EmailPassword()
        {
            try
            {
                string result = input.Validate_EmailAddressPassword("vinay15785$#@&");
                Assert.AreEqual(result, "vinay15785$#@&");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}