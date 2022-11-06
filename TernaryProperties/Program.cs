using MyPackage;

namespace TernaryProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyProperties myClass = new MyProperties();
            myClass.PropertyFirst = 1;
            Console.WriteLine($"{myClass.PropertyFirst}");
        }
    }
}