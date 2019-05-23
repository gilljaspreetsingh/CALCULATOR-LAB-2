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
        public void GetSubtraction_Input50point0and10point0_Returns40point0()
        {//Arrange

            double number1 = 50;
            double number2 = 10;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Getsubtraction_Input50point0and10point0_Returns40point0()
        {//Arrange

            double number1 = 50;
            double number2 = 10;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Getsubtraction_Input40point0and2point0_Returns38point0()
        {//Arrange

            double number1 = 40;
            double number2 = 2;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Getsubtraction_Input30point0and2point0_Returns28point0()
        {//Arrange

            double number1 = 30;
            double number2 = 2;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input30point0and2point0_Returns32point0()
        {//Arrange

            double number1 = 30;
            double number2 = 2;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input40point0and2point0_Returns42point0()
        {//Arrange

            double number1 = 40;
            double number2 = 2;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input10point0and10point0_Returns20point0()
        {//Arrange

            double number1 = 10;
            double number2 = 10;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input2point0and2point0_Returns4point0()
        {//Arrange

            double number1 = 2;
            double number2 = 2;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input4point0and2point0_Returns2point0()
        {//Arrange

            double number1 = 4;
            double number2 = 2;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input2point0and1point0_Returns2point0()
        {//Arrange

            double number1 = 2;
            double number2 = 1;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input2point0and2point0_Returns1point0()
        {//Arrange

            double number1 = 2.0;
            double number2 = 2.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input4point0and4point0_Returns1point0()
        {//Arrange

            double number1 = 4.0;
            double number2 = 4.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input5point0and5point0_Returns1point0()
        {//Arrange

            double number1 = 5.0;
            double number2 = 5.0;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

    


