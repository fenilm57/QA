using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;
using NUnit.Framework;

namespace Assigment2.Tests
{
    class ConversionTest
    {
        Conversion convert;
        [SetUp]
        public void Setup()
        {
            convert = new Conversion();
        }
        [Test]
        public void ConvertCelciusToFahrenheitTestInteger()
        {
            var expectedOutput = 46;
            var enteredValue = 8;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertCelciusToFahrenheit();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertCelciusToFahrenheitTestInteger2()
        {
            var expectedOutput = 104;
            var enteredValue = 40;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertCelciusToFahrenheit();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertCelciusToFahrenheitTestInteger3()
        {
            var expectedOutput = 33;
            var enteredValue = 1;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertCelciusToFahrenheit();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }

        [Test]
        public void ConvertCelciusToKelvinTestInteger()
        {
            var expectedOutput = 281.15;
            var enteredValue = 8;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertCelciusToKelvin();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertCelciusToKelvinTestInteger2()
        {
            var expectedOutput = 313.15;
            var enteredValue = 40;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertCelciusToKelvin();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertCelciusToKelvinTestInteger3()
        {
            var expectedOutput = 274.15;
            var enteredValue = 1;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertCelciusToKelvin();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTestInteger()
        {
            var expectedOutput = -445.27;
            var enteredValue = 8;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertKelvinToFahrenheit();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTestInteger2()
        {
            var expectedOutput = 260.33000000000004;
            var enteredValue = 400;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertKelvinToFahrenheit();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTestInteger3()
        {
            var expectedOutput = -457.87;
            var enteredValue = 1;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertKelvinToFahrenheit();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertKelvinToCelsiusTestInteger()
        {
            var expectedOutput = -265.15;
            var enteredValue = 8;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertKelvinToCelsius();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertKelvinToCelsiusTestInteger2()
        {
            var expectedOutput = 126.85000000000002;
            var enteredValue = 400;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertKelvinToCelsius();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertKelvinToCelsiusTestInteger3()
        {
            var expectedOutput = -272.15;
            var enteredValue = 1;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertKelvinToCelsius();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTestInteger()
        {
            var expectedOutput = 260.15;
            var enteredValue = 8;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertFahrenheitToKelvin();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTestInteger2()
        {
            var expectedOutput = 277.15;
            var enteredValue = 40;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertFahrenheitToKelvin();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTestInteger3()
        {
            var expectedOutput = 256.15;
            var enteredValue = 1;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertFahrenheitToKelvin();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTestInteger()
        {
            var expectedOutput = -13;
            var enteredValue = 8;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertFahrenheitToCelsius();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTestInteger2()
        {
            var expectedOutput = 4;
            var enteredValue = 40;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertFahrenheitToCelsius();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTestInteger3()
        {
            var expectedOutput = -17;
            var enteredValue = 1;

            convert = new Conversion(enteredValue);
            var outputRecieved = convert.ConvertFahrenheitToCelsius();
            Assert.AreEqual(expectedOutput, outputRecieved);
        }
    }
}