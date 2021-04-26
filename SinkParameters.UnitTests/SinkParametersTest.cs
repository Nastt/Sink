using System;
using NUnit.Framework;
using Sink;

namespace SinkParameters.UnitTests
{
    [TestFixture]
    public class SinkParametersTest
    {
        [Test(Description = "Позитивный тест для длины мойки")]
        public void SinkLength_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 1100.00;
            var expectedValue = sourceValue;

            //Act
            parameter.SinkLength = sourceValue;
            var actualValue = parameter.SinkLength;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test(Description = "Тест на проверку выхода за диапазон значений для длины мойки")]
        public void SinkLength_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 300.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkLength = sourceValue;
                }
            );
        }

        [Test(Description = "Тест на проверку условия - разница длины мойки и длины чаши мойки больше 55")]
        public void SinkLength_IncorrectValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter
            {
                SinkLength = 590.00,
                CupSinkLength = 530.00,
            };

            var sourceValue = 520.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkLength = sourceValue;
                }
            );
        }

        [Test(Description = "Позитивный тест для ширины мойки")]
        public void SinkWidth_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 650.00;
            var expectedValue = sourceValue;

            //Act
            parameter.SinkWidth = sourceValue;
            var actualValue = parameter.SinkWidth;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test(Description = "Тест на проверку выхода за диапазон значений для ширины мойки")]
        public void SinkWidth_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 800.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkWidth = sourceValue;
                }
            );
        }

        [Test(Description = "Тест на проверку условия - разница ширины мойки и ширины чаши мойки больше 55")]
        public void SinkWidth_IncorrectValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter
            {
                SinkWidth = 500.00,
                CupSinkWidth = 440.00,
            };

            var sourceValue = 420.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkWidth = sourceValue;
                }
            );
        }

        [Test(Description = "Позитивный тест для длины чаши мойки")]
        public void CupSinkLength_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameter()
            {
                SinkLength = 500
            };

            var sourceValue = 440.00;
            var expectedValue = sourceValue;

            //Act
            parameter.CupSinkLength = sourceValue;
            var actualValue = parameter.CupSinkLength;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test(Description = "Тест на проверку выхода за диапазон значений для длины чаши мойки")]
        public void CupSinkLength_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 100.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.CupSinkLength = sourceValue;
                }
            );
        }

        [Test(Description = "Тест на проверку условия - разница длины мойки и длины чаши мойки больше 55")]
        public void CupSinkLength_IncorrectValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter
            {
                SinkLength = 490.00,
                CupSinkLength = 430.00,
            };

            var sourceValue = 500.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.CupSinkLength = sourceValue;
                }
            );
        }

        [Test(Description = "Позитивный тест для ширины чаши мойки")]
        public void CupSinkWidth_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameter()
            {
                SinkWidth = 550
            };

            var sourceValue = 490.00;
            var expectedValue = sourceValue;

            //Act
            parameter.CupSinkWidth = sourceValue;
            var actualValue = parameter.CupSinkWidth;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test(Description = "Тест на проверку выхода за диапазон значений для ширины чаши мойки")]
        public void CupSinkWidth_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 200.00;

            //Act
            Assert.Throws<ArgumentException>

            (
                () =>
                {
                    //Act
                    parameter.CupSinkWidth = sourceValue;
                }
            );
        }

        [Test(Description = "Тест на проверку условия - разница ширины мойки и ширины чаши мойки больше 55")]
        public void CupSinkWidth_IncorrectValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter
            {
                SinkWidth = 490.00,
                CupSinkWidth = 430.00,
            };

            var sourceValue = 500.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.CupSinkWidth = sourceValue;
                }
            );
        }

        [Test(Description = "Позитивный тест для высоты мойки")]
        public void SinkHeight_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 200.00;
            var expectedValue = sourceValue;

            //Act
            parameter.SinkHeight = sourceValue;
            var actualValue = parameter.SinkHeight;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test(Description = "Тест на проверку выхода за диапазон значений для высоты мойки")]
        public void SinkHeight_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 300.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkHeight = sourceValue;
                }
            );
        }

        [Test(Description = "Позитивный тест для диаметра отверстия крана")]
        public void CraneHoleDiameter_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameter()
            {
                DrainHoleDiameter = 55
            };

            var sourceValue = 54.00;
            var expectedValue = sourceValue;

            //Act
            parameter.CraneHoleDiameter = sourceValue;
            var actualValue = parameter.CraneHoleDiameter;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test(Description = "Тест на проверку выхода за диапазон значений для диаметра отверстия крана")]
        public void CraneHoleDiameter_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 100.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.CraneHoleDiameter = sourceValue;
                }
            );
        }

        [Test(Description = "Тест на проверку условия - диаметр отверстия крана меньше диаметра отверстия слива")]
        public void CraneHoleDiameter_IncorrectValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter
            {
                DrainHoleDiameter = 50.00,
                CraneHoleDiameter = 40.00,
            };

            var sourceValue = 55.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.CraneHoleDiameter = sourceValue;
                }
            );
        }

        [Test(Description = "Позитивный тест для диаметра отверстия слива")]
        public void DrainHoleDiameter_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 50.00;
            var expectedValue = sourceValue;

            //Act
            parameter.DrainHoleDiameter = sourceValue;
            var actualValue = parameter.DrainHoleDiameter;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test(Description = "Тест на проверку выхода за диапазон значений для диаметра отверстия слива")]
        public void DrainHoleDiameter_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 100.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.DrainHoleDiameter = sourceValue;
                }
            );
        }

        [Test(Description = "Тест на проверку условия - диаметр отверстия слива больше диаметра отверстия крана")]
        public void DrainHoleDiameter_IncorrectValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter
            {
                DrainHoleDiameter = 60.00,
                CraneHoleDiameter = 54.00,
            };

            var sourceValue = 52.00;

            //Act
            Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.DrainHoleDiameter = sourceValue;
                }
            );
        }
    }
}