using Xunit;
using Moq;

namespace Test
{
    public class TestingInterface
    {
        [Fact]
        public void FibonacciShould() {
            //Arrange
            int n = 6;
            Mock<Calculators.ICalculator> calculator=new Mock<Calculators.ICalculator>();
            calculator.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a + b);
            var series = new Calculators.Series(calculator.Object);
            //An1t
            float fibonacciCheck = series.Fibonacci(n);
            //Assert
            Assert.Equal(8, fibonacciCheck);
        }

        [Fact]
        public void FactorialShould()
        {
            //Arrange
            int n = 6;
            Mock<Calculators.ICalculator> calculator = new Mock<Calculators.ICalculator>();
            calculator.Setup(c => c.Mul(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a * b);
            var series = new Calculators.Series(calculator.Object);
            //An1t
            float factorialCheck = series.Factorial(n);
            //Assert
            Assert.Equal(720, factorialCheck);
        }
    }
}


/*
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
 */