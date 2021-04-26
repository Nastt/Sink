using System;

namespace Sink
{
    /// <summary>
    /// Класс с параметрами
    /// </summary>
    public class SinkParameter
    {
        /// <summary>
        /// Длина мойки
        /// </summary>
        private double _sinkLength;

        /// <summary>
        /// Ширина мойки
        /// </summary>
        private double _sinkWidth;

        /// <summary>
        /// Высота мойки
        /// </summary>
        private double _sinkHeight;

        /// <summary>
        /// Диаметр отверстия для слива
        /// </summary>
        private double _drainHoleDiameter;

        /// <summary>
        /// Диаметр отверстия для крана 
        /// </summary>
        private double _craneHoleDiameter;

        /// <summary>
        /// Длина чаши
        /// </summary>
        private double _cupSinkLength;

        /// <summary>
        /// Ширина чаши
        /// </summary>
        private double _cupSinkWidth;

        /// <summary>
        /// Длина мойки должна быть в диапазоне от 450 мм до 1200 мм
        /// </summary>
        public double SinkLength
        {
            get
            {
                return _sinkLength;
            }

            set
            {
                if (value < 450 || value > 1200)
                {
                    throw new ArgumentException("Некорректное значение!");
                }
                
                if (value - 55 < CupSinkLength)
                {
                    throw new ArgumentException("Некорректное значение!");
                }
                
                _sinkLength = value;
            }
        }

        /// <summary>
        /// Ширина мойки должна быть в диапазоне от 400 мм до 700 мм
        /// </summary>
        public double SinkWidth
        {
            get
            {
                return _sinkWidth;
            }
            set
            {
                if (value < 400 || value > 700)
                {
                    throw new ArgumentException("Некорректное значение!");
                }

                if (value - 55 < CupSinkWidth)
                {
                    throw new ArgumentException("Некорректное значение!");
                }

                _sinkWidth = value;
            }
        }

        /// <summary>
        /// Высота мойки должна быть в диапазоне от 150 мм до 250 мм
        /// </summary>
        public double SinkHeight
        {
            get
            {
                return _sinkHeight;
            }
            set
            {
                if (value < 150 || value > 250)
                {
                    throw new ArgumentException("Некорректное значение!");
                }

                _sinkHeight = value;
            }
        }

        /// <summary>
        /// Диаметр отверстия для крана должен быть в диапазоне от 25 мм до 55 мм
        /// </summary>
        public double CraneHoleDiameter
        {
            get
            {
                return _craneHoleDiameter;
            }
            set
            {
                if (value < 25 || value > 55)
                {
                    throw new ArgumentException("Некорректное значение!");
                }

                if (value > DrainHoleDiameter)
                {
                    throw new ArgumentException("Некорректное значение!");
                }

                _craneHoleDiameter = value;
            }
        }

        /// <summary>
        /// Диаметр отверстия для слива должен быть в диапазоне от 50 мм до 65 мм
        /// </summary>
        public double DrainHoleDiameter
        {
            get
            {
                return _drainHoleDiameter;
            }
            set
            {
                if (value < 50 || value > 65)
                {
                    throw new ArgumentException("Некорректное значение!");
                }

                if (value < CraneHoleDiameter)
                {
                    throw new ArgumentException("Некорректное значение!");
                }

                _drainHoleDiameter = value;
            }
        }

        /// <summary>
        /// Длина чаши мойки должна быть в диапазоне от 300 мм до 1000 мм
        /// </summary>
        public double CupSinkLength
        {
            get
            {
                return _cupSinkLength;
            }
            set
            {
                if (value < 300 || value > 1000)
                {
                    throw new ArgumentException("Некорректное значение!");
                }

                if (value + 55 > SinkLength)
                {
                    throw new ArgumentException("Некорректное значение!");
                }

                _cupSinkLength = value;
            }
        }

        /// <summary>
        /// Ширина чаши мойки должна быть в диапазоне от 300 мм до 600 мм
        /// </summary>
        public double CupSinkWidth
        {
            get
            {
                return _cupSinkWidth;
            }
            set
            {
                if (value < 300 || value > 600)
                {
                    throw new ArgumentException("Некорректное значение!");
                }

                if (value + 55 > SinkWidth)
                {
                    throw new ArgumentException("Некорректное значение!");
                }

                _cupSinkWidth = value;
            }
        }
    }
}