using System.Text.RegularExpressions;

using Validation.Constants;

namespace Tests
{
    public class DeviceTypeTest
    {
        [Fact]
        public void TestAnroidDevice()
        {
            //Arrange
            Guid andriodId = new Guid("3614435a-8b46-42de-a7b5-bf1d72c4b913");
            //Actual
            bool result = new Regex(ValidatePaterns.Guid).IsMatch(andriodId.ToString());
            //Assert
            Assert.True(result);
        }
    }
}