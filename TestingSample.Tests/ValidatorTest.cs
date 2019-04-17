using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingSample.Tests
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        [DataRow("myfile.txt")]
        [DataRow("myfile.TXT")]
        [DataRow("myfile.tXt")]
        public void IsTestFile_ValidExtension_ReturnsTrue(string validExt)
        {
            //Arrange
            //string validExt = ".txt";

            //Act
            bool result = Validator.IsTextFile(validExt);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
