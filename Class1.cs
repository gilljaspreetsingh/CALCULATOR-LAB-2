﻿using System;
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
        public void GetAddition_Input10point0and20point0_Returns30point0()
        {//Arrange

            double number1 = 10;
            double number2 = 20;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act double actualResult = testCalc.GetAddition();
            //Assert Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

