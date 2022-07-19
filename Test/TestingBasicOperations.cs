using Xunit;

namespace Test
{
    public class TestingBasicOperations
    {
        [Fact]
        public void ValidateSum() {
            //Arrange
            var calculator = new Calculators.Calculator();
            float a = 10, b = 20;
            //Act
            float sumCheck = calculator.Add(a, b);
            //Assert
            Assert.Equal(30, sumCheck);
        }

        [Fact]
        public void ValidateSubstract()
        {
            //Arrange
            var calculator = new Calculators.Calculator();
            float a = 20, b = 10;
            //Act
            float substractCheck = calculator.Sub(a, b);
            //Assert
            Assert.Equal(10, substractCheck);
        }

        [Theory]
        [InlineData(2, 4, 8)]
        [InlineData(2, 2, 4)]
        [InlineData(5, 14, 70)]
        [InlineData(1, 4, 4)]
        [InlineData(10, 10, 100)]
        public void ValidateMultiplication(float a, float b, float expected) {
            //Arrange
            var calculator = new Calculators.Calculator();
            //Act
            float multiplicationCheck = calculator.Mul(a, b);
            //Assert
            Assert.Equal(expected, multiplicationCheck);
        }

        [Theory]
        [InlineData(2, 4, 0.5)]
        [InlineData(2, 2, 1)]
        [InlineData(28, 14, 2)]
        [InlineData(1, 4, 0.25)]
        [InlineData(10, 10, 1)]
        public void ValidateDiv(float a, float b, float expected)
        {
            //Arrange
            var calculator = new Calculators.Calculator();
            //Act
            float divCheck = calculator.Div(a, b);
            //Assert
            Assert.Equal(expected, divCheck);
        }
    }
}
