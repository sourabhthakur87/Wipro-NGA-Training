using System.ComponentModel.DataAnnotations;
using DemoEmailValidation;
namespace EmailValidatorMSTest.MsTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestClass]
        public class UnitTest1
        {
            private EmailValidatorClass EmailValidator;
            [TestInitialize]
            public void TestInitialize()
            {
                EmailValidator = new EmailValidatorClass();
            }

            [TestMethod]
            public void EmailInValidOrNot()
            {
                string input = "InvalidEmail.com";
                bool result = EmailValidator.IsEmailValid(input);
                Assert.IsFalse(result, "Expected false for invalid email format.");
            }

            [TestMethod]
            public void ValidEmail()
            {
                string input = "ValidEmail@example.com";
                bool result = EmailValidator.IsEmailValid(input);
                Assert.IsTrue(result, "Expected true for valid email format.");
            }
        }
    }
}
