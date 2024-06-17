using MathService.Logic;

namespace MathService.Tests.UnitTests
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            // Arrange
            CalculatorService calculatorService = new CalculatorService();
            int a = 1;
            int b = 2;
            int expectedResult = 3;
            // Act
            int result = calculatorService.Add(a, b);
            // Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void MultiplyTest()
        {
            // Arrange
            CalculatorService calculatorService = new CalculatorService();
            int a = 1;
            int b = 2;
            int expectedResult = 2;
            // Act
            int result = calculatorService.Multiply(a, b);
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}