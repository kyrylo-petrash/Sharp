using MyPackage;

namespace ClassProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyProperties myProperties = new MyProperties()
            {
                Date = "01.01.2025",
                RecorderAt = DateTime.Now,
                Num = "1",
                To = "1",
                From = "1",
                Total = 1,
                strokeeeperSurname = "1",
                forwarderSurname = "1"
            };

            Console.WriteLine(myProperties.ToString);
        }
    }
}