﻿using System;
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
        public void AddTest()
        {
            //Arrange
            string numbers = "1";

            //Act
            int add = _stringCalculator.Add(numbers);

            //Assert
            Assert.Equal(add, 1);
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
        public void ConversionTest()
        {
            //Arrange
            string numbers = "1,2";

            //Act
            int add = _stringCalculator.Add(numbers);

            //Assert
            Assert.NotEqual(add, 3);
        }
    }
}
