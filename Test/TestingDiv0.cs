using Xunit;

namespace Test
{
    public class TestingDiv0
    {
        [Fact]
        public void RaiseErrorDiv0()
        {
            //Arrange
            var calculator = new Calculators.Calculator();
            float a = 1, b = 0;
            //Act dentro del Assert
            Assert.Throws<DivideByZeroException>(() => {
                calculator.Div(a, b);
            });
        }
    }
}
