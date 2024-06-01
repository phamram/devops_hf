using NUnit.Framework;
using NUnit.Framework;
using StringApp;

namespace StringApp.StringAppTests
{
    public class StringTests
    {
        [Test]
        public void RemoveFirstChar_Test()
        {
            // Arrange
            string input = "Hello IT maintainance class !";
            string expectedOutput = "ello T aintainance lass";

            // Act
            string result = Methods.RemoveFirstChar(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
