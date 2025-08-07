using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
