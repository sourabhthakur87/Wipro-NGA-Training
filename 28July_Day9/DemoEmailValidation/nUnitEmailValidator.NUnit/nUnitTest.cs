using DemoEmailValidation;
namespace nUnitEmailValidator.NUnit
{
    public class Tests
    {
        private EmailValidatorClass emailValidator;
        [SetUp]
        public void Setup()
        {
            emailValidator = new EmailValidatorClass();
        }

        [Test]
        public void ISInvalid()
        {
            string input = "invalid-email.com";
            bool result = emailValidator.IsEmailValid(input);
            Assert.False(result, "Expected false for invalid email format.");
        }

        [Test]
        public void ISValid()
        {
            string input = "invalidemail@examplr.com";
            bool result = emailValidator.IsEmailValid(input);
            Assert.True(result, "Expected true for valid email format.");

        }
    }
}