using MyPackage;

namespace InitProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            MyClass myClass = new MyClass();
            myClass.Properties = "Hello";
            Console.WriteLine(myClass.Properties);

            // MyClass instance = new MyClass() { Properties = "Hello" };
            // MyClass instance = new MyClass { Properties = "Hello" };
            MyClass instance = new() { Properties = "Hello" }; // c 6.0 версии C#
            instance.Properties = "World";
            Console.WriteLine(instance.Properties);

            // 2
            InitClass initClass = new() { Properties = "Hello" }; // после инициализации значений подобных свойств их значения изменить нельзя - они доступны только для чтения
                                                                  // initClass.Properties = "World"; // ошибка

            // 3
            DualClass douClass = new()
            {
                AutoProperty = "Some value AutoProperty",
                SimpleProperty = "Some value SimpleProperty",
                ExpBodyProperty = "Some value ExpBodyProperty",
                OnlyInitSimpleProperty = "Some value OnlyInitSimpleProperty",
                OnlyInitExpBodyProperty = "Some value OnlyInitExpBodyProperty"
            };
            Console.WriteLine(douClass.AutoProperty); // Some value AutoProperty
            Console.WriteLine(douClass.SimpleProperty); // Some value OnlyInitExpBodyProperty
            Console.WriteLine(douClass.ExpBodyProperty); // Some value OnlyInitExpBodyProperty
                                                         // Console.WriteLine(douClass.OnlyInitSimpleProperty); // ошибка так как only init
        }
    }
}