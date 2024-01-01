using Validation.Services;

namespace Tests
{
    public class PassportTests
    {
        [Fact]
        public void TryGetPassportWithLatinLeters()
        {
            //Arrange
            //AA is latin letters
            string passport = "AA123456";

            //Actual
            bool result = new ValidateUserService().ValidatePassport(passport);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void TryGetPassportWithCyrillicLeters()
        {
            //Arrange
            //AA is cyrillic letters
            string passport = "АА123456";

            //Actual
            bool result = new ValidateUserService().ValidatePassport(passport);

            //Assert
            Assert.True(result);
        }
    }
}
