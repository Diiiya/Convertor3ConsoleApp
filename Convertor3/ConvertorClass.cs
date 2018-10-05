using System;
using System.Collections.Generic;
using System.Text;

namespace Convertor3
{
    public class ConvertorClass
    {
        private double _value;

        public double Value { get => _value; set => _value = value; }

        public double ConvertToOunces(double a)
        {
            return _value = a * 0.035274;
        }

        public double ConvertToGrams(double a)
        {
            return _value = a * 28.3495;
        }

        public override string ToString()
        {
            return $"The value is: " + _value;
        }
    }
}
