using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace miniature_engine.Tests
{
    public class StringCalculatorTests
    {
        private readonly StringCalculator _stringCalculator;

        public StringCalculatorTests()
        {
            //Arrange
            _stringCalculator = new StringCalculator();
        }

        [Fact]
        public void EmptyStringTest()
        {
            //Arrange
            string numbers = "";

            //Act
            int add = _stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(add, 0);
        }

        [Fact]
        public void AddOneNumberTest()
        {
            //Arrange
            string numbers = "1";

            //Act
            int add = _stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(add, 1);
        }

        [Fact]
        public void AddTwoNumbersTest()
        {
            //Arrange
            string numbers = "1,2";

            //Act
            int add = _stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(add, 3);
        }

        [Fact]
        public void AddUnknownAmountNumbersTest()
        {
            //Arrange
            string numbers = "1,2,3,4,5";

            //Act
            int add = _stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(add, 15);
        }

        [Fact]
        public void AddNewLineCommaNumbersTest()
        {
            //Arrange
            string numbers = "1\n2,3";

            //Act
            int add = _stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(add, 6);
        }

        [Fact]
        public void AddOneNumberCommaNewLineNumbersTest()
        {
            //Arrange
            string numbers = "1,\n";

            //Act
            int add = _stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(add, 1);
        }

        [Fact]
        public void AddIdentifierDelimiterNewLineNumbersTest()
        {
            //Arrange
            string numbers = "//;\n1;2";

            //Act
            int add = _stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(add, 3);
        }

        [Fact]
        public void AddNegativeNumbersTest()
        {
            //Arrange
            string numbers = "//;\n1;2;3;-4;5;-6;7;-8;9;10";

            //Act
            Action action = () => _stringCalculator.Add(numbers);

            action.Should().ThrowExactly<InvalidOperationException>().WithMessage("Negatives not allowed, the following were found: -4,-6,-8.");
        }

        [Fact]
        public void AddBiggerNumbersTest()
        {
            //Arrange
            string numbers = "1,2,3,4,5,999,1000,1001,9,10";

            //Act
            int add = _stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(add, 2033);
        }
    }
}
