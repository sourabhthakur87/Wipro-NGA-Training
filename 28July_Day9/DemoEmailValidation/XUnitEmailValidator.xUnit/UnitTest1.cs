using Xunit;
using DemoEmailValidation;
namespace XUnitEmailValidator.xUnit
{
    public class UnitTest1
    {
        private readonly EmailValidatorClass emailValidator = new EmailValidatorClass();
        [Fact]
        public void ISInvalid()
        {
            string input = "invalid-email.com";
            bool result = emailValidator.IsEmailValid(input);
            Assert.False(result, "Expected false for invalid email format.");
        }

        [Fact]
        public void ISValid()
        {
            string input = "invalidemail@examplr.com";
            bool result  = emailValidator.IsEmailValid(input);
            Assert.True(result, "Expected true for valid email format.");

        }
    }
}