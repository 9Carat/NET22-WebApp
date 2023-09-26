using NET22_WebApp;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VariablesTest_Returns_Same_As_Expected()
        {
            // Arrange
            Numbers num = new Numbers();
            var actual = num.Add(10, 12);
            var expected = 22;
            // Act
            Assert.AreEqual(expected, actual);
            // Assert
        }
        [TestMethod]
        public void VariablesTest_Returns_Error()
        {
            // Arrange
            Numbers num = new Numbers();
            var actual = num.Add(10, 11);
            var expected = 22;
            // Act
            Assert.AreEqual(expected, actual);
            // Assert
        }
    }
}