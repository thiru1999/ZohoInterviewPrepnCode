using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;

namespace Demo.Test
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(4, 2, 6)]
        [InlineData(45,67,112)]
        public void Add_simpleValueShouldCalculate(double x,double y,double expected)
        {
            //Arrange

            //act
            double actual = Calculator.Add(x,y);

            Assert.Equal(expected, actual);

        }
        [Fact]

        public void Divide_simpleValueShouldCalculate()
        {
            double expected = 0;
            double actual = Calculator.Divide(15, 0);
            Assert.Equal(expected, actual);


        }


    }
}
