using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Conversion
{
    internal class Conversion
    {
        public double convertLength(double x, string unit)
        {
            var toBase = new Dictionary<string, double>
            {
                { "millimeter", 0.001 },
                { "centimeter", 0.01 },
                { "meter", 1 },
                { "kilometer", 1000 },
                { "inch", 0.0254 },
                { "foot", 0.3048 },
                { "yard", 0.9144 },
                { "mile", 1609.34 }
            };
            return x*toBase[unit];
        }
        public double convertTemperature(double x, string unit)
        {
            if (unit == "Celsius")
            {
                return x;
            }  
            else if (unit == "Fahrenheit")
            {
                return (x * 9 / 5) + 32;
            }    
            else
            {
                return x + 273.15;
            }
                
        }
        public double convertWeight(double x, string unit)
        {
            var toBase = new Dictionary<string, double>
            {
                { "milligram", 0.000001 },
                { "gram", 0.001 },
                { "kilogram", 1 },
                { "pound", 0.453592 },
                { "ounce", 0.0283495 }
            };
            return x * toBase[unit];
        }

        public double convertVolume(double x, string unit)
        {
            var toBase = new Dictionary<string, double>
            {
                { "milliliter", 0.001 },
                { "liter", 1 },
                { "gallon", 3.78541 },
                { "cup", 0.24 },
                { "pint", 0.473176 }
            };
            return x * toBase[unit];
        }

        public double convertTime(double x, string unit)
        {
            var toBase = new Dictionary<string, double>
            {
                { "second", 1 },
                { "minute", 60 },
                { "hour", 3600 },
                { "day", 86400 },
                { "week", 604800 }
            };
            return x * toBase[unit];
        }
        public double convertSpeed(double x, string unit)
        {
            var toBase = new Dictionary<string, double>
            {
                { "meters per second", 1 },
                { "kilometers per hour", 0.277778 },
                { "miles per hour", 0.44704 },
                { "knots", 0.514444 }
            };
            return x * toBase[unit];
        }
        public double convertArea(double x, string unit)
        {
            var toBase = new Dictionary<string, double>
            {
                { "square meter", 1 },
                { "square kilometer", 1_000_000 },
                { "square foot", 0.092903 },
                { "acre", 4046.86 },
                { "hectare", 10_000 }
            };
            return x * toBase[unit];
        }
        public double convertDataStorage(double x, string unit)
        {
            var toBase = new Dictionary<string, double>
            {
                { "bit", 0.125 },
                { "byte", 1 },
                { "kilobyte", 1024 },
                { "megabyte", 1_048_576 },
                { "gigabyte", 1_073_741_824 }
            };
            return x * toBase[unit];
        }
        public double convertCurrency(double x, string unit)
        {
            var toBase = new Dictionary<string, double>
            {
                { "USD", 1 },
                { "EUR", 0.92 },
                { "PHP", 58.5 },
                { "JPY", 143.2 },
                { "GBP", 0.79 }
            };
            return x / toBase[unit];
        }
    }
}
