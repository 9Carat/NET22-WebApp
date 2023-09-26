using FluentAssertions;
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
        public void VariablesTest_Returns_Equal()
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
        public void FluentAssertion_Test1()
        {
            string name = "Tobias";
            //name.Should().StartWith("T").And.EndWith("s");
            int number = 22;
            //number.Should().BeLessThan(50);
            List<string> list = new List<string>() { "Ante", "Reidar", "Harry"};
            list.Should().HaveCount(3);
        }
    }
}