using MyPackage;

namespace StructProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherObservation weatherObservation = new()
            {
                RecordedAt = DateTime.Now, // присвоить дату RecordedAt = DateTime.Parse("28/2/2028 8:30:52 AM")
                TemperatureInCelsius = 30,
                PressureInMillibars = 998.0m
            };

            // weatherObservation.TemperatureInCelsius = 20; // ошибка

            Console.WriteLine(weatherObservation.ToString());
        }
    }
}