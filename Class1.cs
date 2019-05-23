using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace AwesomeCalculator
{
    public class Class1
    {
        private double number1;

        [Test]
        public void Getsubtraction_Input20point0and10point0_Returns10point0()
        {//Arrange

            double number1 = 20;
            double number2 = 10;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act double actualResult = testCalc.Getsubtraction();
            //Assert Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

