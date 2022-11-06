using MyPackage;

namespace Package // пакет
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyPackage.MyProperties myPackage = new MyPackage.MyProperties();
            myPackage.Name = "myPackage";
            myPackage.Display();

            double sqrt = Math.Sqrt(9); // корень из namespace System
            Console.WriteLine(sqrt);
        }
    }
}