namespace ConvertBackAndForth
{
    internal class Program
    {
        
        
            static void Main(string[] args)
            {

                Console.WriteLine("Temperature Converter");
                Console.WriteLine("Insert 1 to convert from Celsius to Fahrenheit or 2 for vise versa");
                Console.WriteLine("Enter either 1 or 2");
                int chosenNumber = int.Parse(Console.ReadLine());
                if (chosenNumber == 1)
                {
                    Console.WriteLine("Enter temperature in celsius");
                    double tempInC = double.Parse(Console.ReadLine());
                    CelsiusToFahrenheitConverter convert2Fahrenheit = new CelsiusToFahrenheitConverter();
                    convert2Fahrenheit.TempInCelsius = tempInC;
                    convert2Fahrenheit.Convert();

                }
                else if (chosenNumber == 2)
                {
                    Console.WriteLine("Enter temperature in °F");
                    double tempInF = double.Parse(Console.ReadLine());
                    FahrenheithToCelsiusConverter convertToCelsius = new FahrenheithToCelsiusConverter();
                    convertToCelsius.TempInFahrenheit = tempInF;
                    convertToCelsius.Convert();
                }


            }
        }
    }
