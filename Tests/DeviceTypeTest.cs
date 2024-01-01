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

        [Fact]
        public void TestIOSDevice()
        {
            //Arrange
            Guid IOSId = new Guid("B5A648BA-262F-47BF-A0F5-4FDF68AC0C12");
            //Actual
            bool result = new Regex(ValidatePaterns.Guid).IsMatch(IOSId.ToString());
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIOSDeviceWith1UpperCaseLetter()
        {
            //Arrange
            Guid IOSId = new Guid("76Cb8c23-13a0-41e6-ad16-a2056ece43ba");
            //Actual
            bool result = new Regex(ValidatePaterns.Guid).IsMatch(IOSId.ToString());
            //Assert
            Assert.True(result);
        }
    }
}