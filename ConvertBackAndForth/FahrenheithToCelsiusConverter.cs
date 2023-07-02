using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBackAndForth
{
    internal class FahrenheithToCelsiusConverter
    {
        public double TempInFahrenheit { get; set; }
        public void Convert()
        {
            double result = (TempInFahrenheit - 32) / 1.8;
            Console.WriteLine($"{TempInFahrenheit} °F in Celsius is : {result} °C.");
        }
    }
}

