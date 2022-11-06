using MyPackage;

namespace TypesProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyProperties myClass = new MyProperties();
            myClass.MyExpBodyProperty = 1;
            Console.WriteLine(myClass.MyExpBodyProperty);
        }
    }
}