namespace ConvertBackAndForth
{
    internal class CelsiusToFahrenheitConverter
    {
        public double TempInCelsius
        {
            get; set;
        }
        public string text = "Hello world";


        public void Convert()
        {
            double result = 1.8 * TempInCelsius + 32;
            Console.WriteLine($"{TempInCelsius} °C in Fahrenheit is : {result} °F.");

            Console.WriteLine();
        }
    }
}
