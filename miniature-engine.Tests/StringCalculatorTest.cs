using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace miniature_engine.Tests
{
    public class StringCalculatorTest
    {
        private readonly StringCalculator _stringCalculator;

        public StringCalculatorTest()
        {
            //Arrange
            _stringCalculator = new StringCalculator();
        }

        [Fact]
        public void AddTest()
        {
            //Arrange
            string numbers = "1";

            //Act
            int add = _stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(add, 1);
        }
    }
}
